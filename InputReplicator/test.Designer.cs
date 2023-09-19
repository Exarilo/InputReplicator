namespace InputReplicator
{
    partial class test
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
            this.exaTimer1 = new InputReplicator.ExaTimer();
            this.dagableBorder1 = new InputReplicator.DagableBorder();
            this.button1 = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exaTimer1
            // 
            this.exaTimer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exaTimer1.Location = new System.Drawing.Point(0, 437);
            this.exaTimer1.Name = "exaTimer1";
            this.exaTimer1.Size = new System.Drawing.Size(800, 13);
            this.exaTimer1.TabIndex = 1;
            this.exaTimer1.Load += new System.EventHandler(this.exaTimer1_Load);
            // 
            // dagableBorder1
            // 
            this.dagableBorder1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dagableBorder1.Location = new System.Drawing.Point(0, 0);
            this.dagableBorder1.Name = "dagableBorder1";
            this.dagableBorder1.Size = new System.Drawing.Size(800, 25);
            this.dagableBorder1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btSave.BackgroundImage = global::InputReplicator.Properties.Resources.save;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(0, 25);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(24, 412);
            this.btSave.TabIndex = 16;
            this.btSave.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.BackgroundImage = global::InputReplicator.Properties.Resources.save;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(24, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 412);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dagableBorder1);
            this.Controls.Add(this.exaTimer1);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion
        private ExaTimer exaTimer1;
        private DagableBorder dagableBorder1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button button2;
    }
}