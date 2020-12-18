namespace GZDoomLauncher
{
    partial class InfoScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoScreen));
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.TextBox = new System.Windows.Forms.Label();
            this.GoToSiteLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImageBox.Image = global::GZDoomLauncher.Properties.Resources.GZL;
            this.ImageBox.Location = new System.Drawing.Point(12, 12);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(160, 160);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // TextBox
            // 
            this.TextBox.AutoSize = true;
            this.TextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(178, 12);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(306, 95);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "GZDoom Launcher 1.4.1.1 \r\nMade by PGgamer\r\n\r\nThanks to ID Software for this aweso" +
    "me game.\r\nThanks to the ZDoom Team for this source port.";
            // 
            // GoToSiteLink
            // 
            this.GoToSiteLink.AutoSize = true;
            this.GoToSiteLink.Location = new System.Drawing.Point(179, 122);
            this.GoToSiteLink.Name = "GoToSiteLink";
            this.GoToSiteLink.Size = new System.Drawing.Size(60, 13);
            this.GoToSiteLink.TabIndex = 2;
            this.GoToSiteLink.TabStop = true;
            this.GoToSiteLink.Text = "Official Site";
            this.GoToSiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoToSiteLink_LinkClicked);
            // 
            // InfoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 184);
            this.Controls.Add(this.GoToSiteLink);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ImageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label TextBox;
        private System.Windows.Forms.LinkLabel GoToSiteLink;
    }
}