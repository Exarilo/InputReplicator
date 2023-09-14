namespace InputReplicator
{
    partial class ConfigRunner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigRunner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbRunningMode = new System.Windows.Forms.GroupBox();
            this.cbInfiniteMode = new System.Windows.Forms.CheckBox();
            this.cbTimeMode = new System.Windows.Forms.CheckBox();
            this.cbCycleMode = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dtpRunningModeTime = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.gbRunningMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelTopBar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 187);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btStart);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 147);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbRunningMode);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(50, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 127);
            this.panel3.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Config1";
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopBar.Controls.Add(this.button1);
            this.panelTopBar.Controls.Add(this.btClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(249, 25);
            this.panelTopBar.TabIndex = 11;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            this.panelTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btStart
            // 
            this.btStart.BackgroundImage = global::InputReplicator.Properties.Resources.play;
            this.btStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btStart.Location = new System.Drawing.Point(6, 23);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(38, 37);
            this.btStart.TabIndex = 16;
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.BackgroundImage = global::InputReplicator.Properties.Resources.open;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClose.BackgroundImage")));
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(227, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(20, 23);
            this.btClose.TabIndex = 12;
            this.btClose.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nb loops : 0";
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
            // ConfigRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 187);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigRunner";
            this.Text = "ConfigRunner";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.gbRunningMode.ResumeLayout(false);
            this.gbRunningMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRunningModeTime;
        private System.Windows.Forms.GroupBox gbRunningMode;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox cbCycleMode;
        private System.Windows.Forms.CheckBox cbTimeMode;
        private System.Windows.Forms.CheckBox cbInfiniteMode;
        private System.Windows.Forms.Label label2;
    }
}