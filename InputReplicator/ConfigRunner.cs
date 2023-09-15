using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace InputReplicator
{
    public partial class ConfigRunner : Form
    {


        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const uint MOUSEEVENTF_WHEEL = 0x0800;
        private const uint MOUSEEVENTF_HWHEEL = 0x01000;

        private Timer timer;
        private int seconds = 0;
        private bool isTimerRunning = false;
        private Point lastPoint;
        private ObservableInput inputs = new ObservableInput();

        public ConfigRunner()
        {
            InitializeComponent();

            inputs.Load("config01");
            DateTime initialTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 15, 0);
            dtpRunningModeTime.Value = initialTime;

            btClose.Click += (sender, args) => this.Close();
            cbInfiniteMode.Click += RunningModeOnEdit;
            cbTimeMode.Click += RunningModeOnEdit;
            cbCycleMode.Click += RunningModeOnEdit;
        }

        private void RunningModeOnEdit(object sender, EventArgs e)
        {
            var currentCheckboxSelected = (sender as CheckBox);
            if (currentCheckboxSelected.Checked)
                return;
            currentCheckboxSelected.Checked = true;
            gbRunningMode?.Controls?.OfType<CheckBox>()?.Where(x => x != currentCheckboxSelected)?.ToList().ForEach(x => x.Checked= false);
        }

        private async void btStart_ClickAsync(object sender, EventArgs e)
        {
            if (isTimerRunning)
            {
                StopTimer();
            }
            else
            {
                StartTimer();
                await ProcessInputAsync(); 

            }
        }
        private async Task ProcessInputAsync()
        {
            foreach (UserInput userInput in inputs)
            {
                await Task.Delay(userInput.msDelay);

                // Déplace le curseur à la position spécifiée
                Win32.SetCursorPos(userInput.positionInScreen.X, userInput.positionInScreen.Y);

                // Émulation de l'événement de souris en fonction du type d'événement
                switch (userInput.mouseMessage)
                {
                    case MouseMessage.LeftButtonDown:
                        Win32.mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, UIntPtr.Zero);
                        break;
                    case MouseMessage.LeftButtonUp:
                        Win32.mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
                        break;
                    case MouseMessage.RightButtonDown:
                        Win32.mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, UIntPtr.Zero);
                        break;
                    case MouseMessage.RightButtonUp:
                        Win32.mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, UIntPtr.Zero);
                        break;
                        // Ajoutez d'autres cas pour les autres types d'événements de souris si nécessaire
                }
            }
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
