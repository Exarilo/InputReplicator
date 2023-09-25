using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace InputReplicator
{
    public partial class CreationConfig : Form
    {
        private ObservableInput inputs = new ObservableInput();
        private IntPtr hookId = IntPtr.Zero;

        public CreationConfig()
        {
            InitializeComponent();
            hookId = SetHook();
            this.FormClosed += (sender, args) => Win32.UnhookWindowsHookEx(hookId);

            tbEvents.ScrollBars = ScrollBars.Vertical;
            tbEvents.WordWrap = false;
        }

        private IntPtr SetHook()
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return Win32.SetWindowsHookEx((int)MouseMessage.WH_MOUSE_LL, MouseHookProc, Win32.GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private IntPtr MouseHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && Enum.IsDefined(typeof(MouseMessage), (int)wParam))
            {
                Point clickPoint = Cursor.Position;

                Point formPoint = this.PointToClient(clickPoint);
                if (!this.ClientRectangle.Contains(formPoint) && exaTimer.isTimerRunning)
                {
                    tbEvents.AppendText($"{(MouseMessage)wParam} ({clickPoint.X},{clickPoint.Y})\r\n");
                    tbEvents.SelectionStart = tbEvents.Text.Length;
                    tbEvents.ScrollToCaret();
                    inputs.Add(new UserInput((MouseMessage)wParam, clickPoint));
                }
            }
            return Win32.CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        private void btRecord_Click(object sender, EventArgs e)
        {
            if (exaTimer.isTimerRunning)
                exaTimer.StopTimer();
            else
                exaTimer.StartTimer();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (inputs.GetAllConfigNames().Contains(tbConfigName.Text))
            {
                MessageBox.Show("This config name already exist");
                return;
            }
            inputs.Save(tbConfigName.Text);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            tbEvents.Text = "";
            inputs.Clear();
            exaTimer.StopTimer();
            exaTimer.Reset();
        }
    }
}
