using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputReplicator
{
    public partial class Runner : Form
    {
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const uint MOUSEEVENTF_WHEEL = 0x0800;
        private const uint MOUSEEVENTF_HWHEEL = 0x01000;

        private ObservableInput inputs = new ObservableInput();

        public Runner()
        {
            InitializeComponent();

            inputs.Load("config01");
            DateTime initialTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 15, 0);
            dtpRunningModeTime.Value = initialTime;

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
            gbRunningMode?.Controls?.OfType<CheckBox>()?.Where(x => x != currentCheckboxSelected)?.ToList().ForEach(x => x.Checked = false);
        }

        private async void btStart_ClickAsync(object sender, EventArgs e)
        {
            if (exaTimer.isTimerRunning)
            {
                exaTimer.StopTimer();
            }
            else
            {
                exaTimer.StartTimer();
                await ProcessInputAsync();

            }
        }
        private async Task ProcessInputAsync()
        {
            foreach (UserInput userInput in inputs)
            {
                await Task.Delay(userInput.msDelay);
                Win32.SetCursorPos(userInput.positionInScreen.X, userInput.positionInScreen.Y);

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
                }
            }
        }
    }
}
