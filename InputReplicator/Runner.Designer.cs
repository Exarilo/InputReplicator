namespace InputReplicator
{
    partial class Runner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cbConfigs = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbRunningMode = new System.Windows.Forms.GroupBox();
            this.dtpRunningModeTime = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbCycleMode = new System.Windows.Forms.CheckBox();
            this.cbTimeMode = new System.Windows.Forms.CheckBox();
            this.cbInfiniteMode = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.exaTimer = new InputReplicator.ExaTimer();
            this.dagableBorder1 = new InputReplicator.DagableBorder();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbRunningMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.BackgroundImage = global::InputReplicator.Properties.Resources.open;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbConfigs
            // 
            this.cbConfigs.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbConfigs.FormattingEnabled = true;
            this.cbConfigs.Location = new System.Drawing.Point(0, 25);
            this.cbConfigs.Name = "cbConfigs";
            this.cbConfigs.Size = new System.Drawing.Size(251, 21);
            this.cbConfigs.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 128);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbRunningMode);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(52, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 128);
            this.panel3.TabIndex = 17;
            // 
            // gbRunningMode
            // 
            this.gbRunningMode.Controls.Add(this.dtpRunningModeTime);
            this.gbRunningMode.Controls.Add(this.numericUpDown1);
            this.gbRunningMode.Controls.Add(this.cbCycleMode);
            this.gbRunningMode.Controls.Add(this.cbTimeMode);
            this.gbRunningMode.Controls.Add(this.cbInfiniteMode);
            this.gbRunningMode.Location = new System.Drawing.Point(10, 3);
            this.gbRunningMode.Name = "gbRunningMode";
            this.gbRunningMode.Size = new System.Drawing.Size(169, 94);
            this.gbRunningMode.TabIndex = 1;
            this.gbRunningMode.TabStop = false;
            this.gbRunningMode.Text = "Running mode";
            // 
            // dtpRunningModeTime
            // 
            this.dtpRunningModeTime.Checked = false;
            this.dtpRunningModeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRunningModeTime.Location = new System.Drawing.Point(70, 42);
            this.dtpRunningModeTime.Name = "dtpRunningModeTime";
            this.dtpRunningModeTime.ShowUpDown = true;
            this.dtpRunningModeTime.Size = new System.Drawing.Size(83, 20);
            this.dtpRunningModeTime.TabIndex = 2;
            this.dtpRunningModeTime.Value = new System.DateTime(2023, 9, 14, 0, 15, 0, 0);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(70, 64);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbCycleMode
            // 
            this.cbCycleMode.AutoCheck = false;
            this.cbCycleMode.AutoSize = true;
            this.cbCycleMode.Location = new System.Drawing.Point(7, 65);
            this.cbCycleMode.Name = "cbCycleMode";
            this.cbCycleMode.Size = new System.Drawing.Size(57, 17);
            this.cbCycleMode.TabIndex = 2;
            this.cbCycleMode.Text = "Cycles";
            this.cbCycleMode.UseVisualStyleBackColor = true;
            // 
            // cbTimeMode
            // 
            this.cbTimeMode.AutoCheck = false;
            this.cbTimeMode.AutoSize = true;
            this.cbTimeMode.Location = new System.Drawing.Point(7, 42);
            this.cbTimeMode.Name = "cbTimeMode";
            this.cbTimeMode.Size = new System.Drawing.Size(49, 17);
            this.cbTimeMode.TabIndex = 1;
            this.cbTimeMode.Text = "Time";
            this.cbTimeMode.UseVisualStyleBackColor = true;
            // 
            // cbInfiniteMode
            // 
            this.cbInfiniteMode.AutoCheck = false;
            this.cbInfiniteMode.AutoSize = true;
            this.cbInfiniteMode.Checked = true;
            this.cbInfiniteMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInfiniteMode.Location = new System.Drawing.Point(7, 19);
            this.cbInfiniteMode.Name = "cbInfiniteMode";
            this.cbInfiniteMode.Size = new System.Drawing.Size(57, 17);
            this.cbInfiniteMode.TabIndex = 0;
            this.cbInfiniteMode.Text = "Infinite";
            this.cbInfiniteMode.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nb loops : 0";
            // 
            // btStart
            // 
            this.btStart.BackgroundImage = global::InputReplicator.Properties.Resources.play;
            this.btStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btStart.Location = new System.Drawing.Point(8, 11);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(38, 37);
            this.btStart.TabIndex = 16;
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_ClickAsync);
            // 
            // exaTimer
            // 
            this.exaTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exaTimer.Location = new System.Drawing.Point(0, 174);
            this.exaTimer.Name = "exaTimer";
            this.exaTimer.Size = new System.Drawing.Size(251, 13);
            this.exaTimer.TabIndex = 1;
            // 
            // dagableBorder1
            // 
            this.dagableBorder1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dagableBorder1.Location = new System.Drawing.Point(0, 0);
            this.dagableBorder1.Name = "dagableBorder1";
            this.dagableBorder1.Size = new System.Drawing.Size(251, 25);
            this.dagableBorder1.TabIndex = 0;
            // 
            // Runner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 187);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbConfigs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exaTimer);
            this.Controls.Add(this.dagableBorder1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Runner";
            this.ShowInTaskbar = false;
            this.Text = "Runner";
            this.TopMost = true;
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbRunningMode.ResumeLayout(false);
            this.gbRunningMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DagableBorder dagableBorder1;
        private ExaTimer exaTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbConfigs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbRunningMode;
        private System.Windows.Forms.DateTimePicker dtpRunningModeTime;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox cbCycleMode;
        private System.Windows.Forms.CheckBox cbTimeMode;
        private System.Windows.Forms.CheckBox cbInfiniteMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btStart;
    }
}