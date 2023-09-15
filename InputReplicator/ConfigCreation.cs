using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace InputReplicator
{
    public partial class ConfigCreation : Form
    {
        private ObservableInput inputs = new ObservableInput();

        private Timer timer;
        private int seconds = 0;
        private bool isTimerRunning = false;
        private Point lastPoint;

        private IntPtr hookId = IntPtr.Zero;
        public ConfigCreation()
        {
            InitializeComponent();
            hookId = SetHook();
            btClose.Click += (sender, args) => this.Close();
            this.FormClosed+=(sender, args) => Win32.UnhookWindowsHookEx(hookId);
    
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
                if (!this.ClientRectangle.Contains(formPoint) && isTimerRunning)
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
            if (isTimerRunning)
                StopTimer();
            else
                StartTimer();
          
        }

        private void StartTimer()
        {
            timer = new Timer();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            isTimerRunning = true; 
        }

        private void StopTimer()
        {
            timer.Stop();
            isTimerRunning = false; 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            label1.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
        }
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = Point.Empty;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            inputs.Save(tbConfigName.Text);
            var a = 0;
            //inputs.ForEach()
        }
    }
}
