namespace InputReplicator
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btRunConfig = new System.Windows.Forms.Button();
            this.btEditConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Run";
            // 
            // btRunConfig
            // 
            this.btRunConfig.BackgroundImage = global::InputReplicator.Properties.Resources.runer;
            this.btRunConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRunConfig.Location = new System.Drawing.Point(12, 88);
            this.btRunConfig.Name = "btRunConfig";
            this.btRunConfig.Size = new System.Drawing.Size(100, 77);
            this.btRunConfig.TabIndex = 7;
            this.btRunConfig.UseVisualStyleBackColor = true;
            this.btRunConfig.Click += new System.EventHandler(this.btRunConfig_Click);
            // 
            // btEditConfig
            // 
            this.btEditConfig.BackgroundImage = global::InputReplicator.Properties.Resources.editor;
            this.btEditConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEditConfig.Location = new System.Drawing.Point(12, 12);
            this.btEditConfig.Name = "btEditConfig";
            this.btEditConfig.Size = new System.Drawing.Size(100, 70);
            this.btEditConfig.TabIndex = 6;
            this.btEditConfig.UseVisualStyleBackColor = true;
            this.btEditConfig.Click += new System.EventHandler(this.btEditConfig_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRunConfig);
            this.Controls.Add(this.btEditConfig);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRunConfig;
        private System.Windows.Forms.Button btEditConfig;
    }
}