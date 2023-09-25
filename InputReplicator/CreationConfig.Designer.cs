namespace InputReplicator
{
    partial class CreationConfig
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
            this.dagableBorder = new InputReplicator.DagableBorder();
            this.exaTimer = new InputReplicator.ExaTimer();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.btRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbEvents = new System.Windows.Forms.TextBox();
            this.btRecord = new System.Windows.Forms.Button();
            this.tbConfigName = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.panelCenter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dagableBorder
            // 
            this.dagableBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dagableBorder.Location = new System.Drawing.Point(0, 0);
            this.dagableBorder.Name = "dagableBorder";
            this.dagableBorder.Size = new System.Drawing.Size(210, 25);
            this.dagableBorder.TabIndex = 0;
            // 
            // exaTimer
            // 
            this.exaTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exaTimer.Location = new System.Drawing.Point(0, 131);
            this.exaTimer.Name = "exaTimer";
            this.exaTimer.Size = new System.Drawing.Size(210, 13);
            this.exaTimer.TabIndex = 1;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.btRefresh);
            this.panelCenter.Controls.Add(this.panel1);
            this.panelCenter.Controls.Add(this.btRecord);
            this.panelCenter.Controls.Add(this.tbConfigName);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 25);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(210, 106);
            this.panelCenter.TabIndex = 2;
            // 
            // btRefresh
            // 
            this.btRefresh.BackgroundImage = global::InputReplicator.Properties.Resources.refresh1;
            this.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRefresh.Location = new System.Drawing.Point(6, 65);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(38, 32);
            this.btRefresh.TabIndex = 21;
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(50, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 86);
            this.panel1.TabIndex = 20;
            // 
            // tbEvents
            // 
            this.tbEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEvents.Location = new System.Drawing.Point(0, 0);
            this.tbEvents.Multiline = true;
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.Size = new System.Drawing.Size(160, 86);
            this.tbEvents.TabIndex = 18;
            // 
            // btRecord
            // 
            this.btRecord.BackgroundImage = global::InputReplicator.Properties.Resources.record;
            this.btRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRecord.Location = new System.Drawing.Point(6, 23);
            this.btRecord.Name = "btRecord";
            this.btRecord.Size = new System.Drawing.Size(38, 37);
            this.btRecord.TabIndex = 19;
            this.btRecord.UseVisualStyleBackColor = true;
            this.btRecord.Click += new System.EventHandler(this.btRecord_Click);
            // 
            // tbConfigName
            // 
            this.tbConfigName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfigName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbConfigName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfigName.Location = new System.Drawing.Point(0, 0);
            this.tbConfigName.Name = "tbConfigName";
            this.tbConfigName.Size = new System.Drawing.Size(210, 20);
            this.tbConfigName.TabIndex = 18;
            this.tbConfigName.Text = "Config1";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btSave.BackgroundImage = global::InputReplicator.Properties.Resources.save;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(3, 0);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(24, 25);
            this.btSave.TabIndex = 18;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // CreationConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 144);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.exaTimer);
            this.Controls.Add(this.dagableBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreationConfig";
            this.ShowInTaskbar = false;
            this.Text = "CreationConfig";
            this.TopMost = true;
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DagableBorder dagableBorder;
        private ExaTimer exaTimer;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Button btRecord;
        private System.Windows.Forms.TextBox tbConfigName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbEvents;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRefresh;
    }
}