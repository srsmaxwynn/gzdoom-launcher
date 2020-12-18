namespace GZDoomLauncher
{
    partial class GZDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GZDL));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.DownloadTextLabel = new System.Windows.Forms.Label();
            this.DTextProgressStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 28);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(292, 23);
            this.progressBar.TabIndex = 0;
            // 
            // DownloadTextLabel
            // 
            this.DownloadTextLabel.AutoSize = true;
            this.DownloadTextLabel.Location = new System.Drawing.Point(12, 9);
            this.DownloadTextLabel.Name = "DownloadTextLabel";
            this.DownloadTextLabel.Size = new System.Drawing.Size(124, 13);
            this.DownloadTextLabel.TabIndex = 1;
            this.DownloadTextLabel.Text = "Downloading GZDoom...";
            // 
            // DTextProgressStatus
            // 
            this.DTextProgressStatus.AutoSize = true;
            this.DTextProgressStatus.Location = new System.Drawing.Point(113, 57);
            this.DTextProgressStatus.Name = "DTextProgressStatus";
            this.DTextProgressStatus.Size = new System.Drawing.Size(84, 13);
            this.DTextProgressStatus.TabIndex = 2;
            this.DTextProgressStatus.Text = "Downloaded 0%";
            // 
            // GZDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 79);
            this.Controls.Add(this.DTextProgressStatus);
            this.Controls.Add(this.DownloadTextLabel);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GZDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GZDoom Launcher";
            this.Load += new System.EventHandler(this.GZDL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label DownloadTextLabel;
        private System.Windows.Forms.Label DTextProgressStatus;
    }
}