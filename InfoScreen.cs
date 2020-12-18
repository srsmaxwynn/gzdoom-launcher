using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GZDoomLauncher
{
    public partial class InfoScreen : Form
    {
        public InfoScreen()
        {
            InitializeComponent();
        }

        private void GoToSiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://pggamer2.github.io/GZL/");
        }
    }
}
