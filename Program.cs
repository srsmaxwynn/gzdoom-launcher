using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace GZDoomLauncher
{
    static class Program
    {
        // GZLauncher made by PG.
        // ZDoom, GZDoom, LZDoom and Doom aren't mine.
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            String thisprocessname = Process.GetCurrentProcess().ProcessName;

            if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
            {
                return;
            }
            else
            {
                MainWindow gzlmain = new MainWindow();
                gzlmain.EXECArgs = args;
                Application.Run(gzlmain);
            }
        }
    }
}
