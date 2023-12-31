﻿using System;
using System.Windows.Forms;

namespace InputReplicator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btEditConfig_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            CreationConfig creationConfig = new CreationConfig();
            creationConfig.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void btRunConfig_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Runner runner = new Runner();
            runner.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
