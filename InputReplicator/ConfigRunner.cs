using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputReplicator
{
    public partial class ConfigRunner : Form
    {
        private Timer timer;
        private int seconds = 0;
        private bool isTimerRunning = false;
        private Point lastPoint;

        public ConfigRunner()
        {
            InitializeComponent();
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
            gbRunningMode?.Controls?.OfType<CheckBox>()?.Where(x => x != currentCheckboxSelected)?.ToList().ForEach(x => x.Checked= false);
        }

        private void btStart_Click(object sender, EventArgs e)
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
