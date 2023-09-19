namespace InputReplicator
{
    partial class DagableBorder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DagableBorder));
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopBar.Controls.Add(this.btClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(208, 25);
            this.panelTopBar.TabIndex = 12;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            this.panelTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseUp);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClose.BackgroundImage")));
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(186, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(20, 23);
            this.btClose.TabIndex = 12;
            this.btClose.UseVisualStyleBackColor = false;
            // 
            // DagableBorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTopBar);
            this.Name = "DagableBorder";
            this.Size = new System.Drawing.Size(208, 25);
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btClose;
    }
}
