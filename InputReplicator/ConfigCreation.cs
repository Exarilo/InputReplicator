using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InputReplicator
{
    public enum MouseMessage
    {
        WH_MOUSE_LL = 14,
        LeftButtonDown = 0x0201,
        LeftButtonUp = 0x0202,
        LeftDoubleClick = 0x0203,
        RightButtonDown = 0x0204,
        RightButtonUp = 0x0205,
        RightDoubleClick = 0x0206,
        MiddleButtonDown = 0x0207,
        MiddleButtonUp = 0x0208,
        MiddleDoubleClick = 0x0209,
        MouseWheel = 0x020A,
        XButtonDown = 0x020B,
        XButtonUp = 0x020C,
        MouseHWheel = 0x020E,
    }



    public partial class ConfigCreation : Form
    {
        private ObservableInput inputs = new ObservableInput();

        private Timer timer;
        private int seconds = 0;
        private bool isTimerRunning = false;
        private Point lastPoint;

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr hookId = IntPtr.Zero;
        public ConfigCreation()
        {
            InitializeComponent();
            hookId = SetHook();
            btClose.Click += (sender, args) => this.Close();
            this.FormClosed+=(sender, args) => UnhookWindowsHookEx(hookId);
    
            tbEvents.ScrollBars = ScrollBars.Vertical;
            tbEvents.WordWrap = false;

        }
        private IntPtr SetHook()
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx((int)MouseMessage.WH_MOUSE_LL, MouseHookProc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }
        private IntPtr MouseHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {

            if (nCode >= 0 && Enum.IsDefined(typeof(MouseMessage), (int)wParam))
            {
                Point clickPoint = Cursor.Position;

                Point formPoint = this.PointToClient(clickPoint);
                if (!this.ClientRectangle.Contains(formPoint)&&isTimerRunning)
                {
                    tbEvents.AppendText($"{(MouseMessage)wParam} ({clickPoint.X},{clickPoint.Y})\r\n");
                    tbEvents.SelectionStart = tbEvents.Text.Length;
                    tbEvents.ScrollToCaret();
                    inputs.Add(new UserInput((MouseMessage)wParam, clickPoint));
                }
            }
            return CallNextHookEx(hookId, nCode, wParam, lParam);
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
    }
}
