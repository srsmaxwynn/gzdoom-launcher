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

        private void GitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/PGgamer2/gzdoom-launcher");
        }

        private void ModDBLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.moddb.com/mods/gzdoom-launcher");
        }
    }
}
