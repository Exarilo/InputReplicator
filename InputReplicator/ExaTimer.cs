using System;
using System.Windows.Forms;

namespace InputReplicator
{
    public partial class ExaTimer : UserControl
    {
        private Timer timer;
        public bool isTimerRunning = false;
        private int seconds = 0;

        public ExaTimer()
        {
            InitializeComponent();
        }
        public void StartTimer()
        {
            timer = new Timer();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            isTimerRunning = true;
        }

        public void StopTimer()
        {
            timer.Stop();
            isTimerRunning = false;
        }

        public void Reset()
        {
            seconds = 0;
            label1.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            label1.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
        }
    }
}
