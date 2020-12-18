using ICSharpCode.SharpZipLib.Zip;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace GZDoomLauncher
{
    public partial class GZDL : Form
    {
        public GZDL()
        {
            InitializeComponent();
        }

        WebClient client;
        public int ZDTypeDL = 0;

        private void tryDelUselessFiles()
        {
            try
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "zdoom.zip"))
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "zdoom.zip");
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ZDGitInfo.txt"))
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "ZDGitInfo.txt");
            }
            catch { Console.WriteLine("Can't delete useless files..."); }
        }

        private void GZDL_Load(object sender, EventArgs e)
        {
            client = new WebClient();

            try { client.OpenRead("http://google.com/generate_204"); }
            catch
            {
                MessageBox.Show("You need internet connection to download this.\nRestart the launcher to continue.", "GZDoom Launcher");
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        Environment.Exit(1);
                    }));
                }
                else Environment.Exit(1);
            }

            client.Headers.Add("user-agent", "Anything"); // Use this to avoid GitHub API problems.
            string url = "";
            switch (ZDTypeDL)
            {
                case 0:
                    DownloadTextLabel.Text = "Downloading GZDoom...";
                    client.DownloadFile("https://api.github.com/repos/coelckers/gzdoom/releases/latest", AppDomain.CurrentDomain.BaseDirectory + "ZDGitInfo.txt");
                    StreamReader gzreader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "ZDGitInfo.txt");
                    string GZDGitAPI = gzreader.ReadToEnd();
                    JObject gzobj = JObject.Parse(GZDGitAPI);
                    JArray gzgitAssets = (JArray)gzobj["assets"];
                    string gzassetSwitchingUrl = "";
                    for (int i = 0; i < gzgitAssets.Count; i++)
                    {
                        gzassetSwitchingUrl = (string)gzobj["assets"][i]["browser_download_url"];
                        if (gzassetSwitchingUrl.Contains("Windows"))
                        {
                            if ((Environment.Is64BitOperatingSystem && gzassetSwitchingUrl.Contains("64bit"))
                                || (!Environment.Is64BitOperatingSystem && gzassetSwitchingUrl.Contains("32bit")))
                                url = gzassetSwitchingUrl;
                        }
                    }
                    break;
                case 1:
                    DownloadTextLabel.Text = "Downloading LZDoom...";
                    client.DownloadFile("https://api.github.com/repos/drfrag666/gzdoom/releases/latest", AppDomain.CurrentDomain.BaseDirectory + "ZDGitInfo.txt");
                    StreamReader lzreader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "ZDGitInfo.txt");
                    string LZGitAPI = lzreader.ReadToEnd();
                    JObject lzobj = JObject.Parse(LZGitAPI);
                    JArray lzgitAssets = (JArray)lzobj["assets"];
                    string lzassetSwitchingUrl = "";
                    for (int i = 0; i < lzgitAssets.Count; i++)
                    {
                        lzassetSwitchingUrl = (string)lzobj["assets"][i]["browser_download_url"];
                        if ((Environment.Is64BitOperatingSystem && lzassetSwitchingUrl.Contains("x64"))
                            || (!Environment.Is64BitOperatingSystem && lzassetSwitchingUrl.Contains("x86")))
                            url = lzassetSwitchingUrl;
                    }
                    break;
                case 2:
                    DownloadTextLabel.Text = "Downloading ZDoom...";
                    // ZDoom is discontinued and has no Git repository.
                    url = "https://zdoom.org/files/zdoom/2.8/zdoom-2.8.1.zip";
                    break;
            }

            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;

            Thread thread = new Thread(() =>
            {
                Uri uri = new Uri(url);
                client.DownloadFileAsync(uri, AppDomain.CurrentDomain.BaseDirectory + "zdoom.zip");
            });
            thread.Start();
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try { client.OpenRead("http://google.com/generate_204"); }
            catch
            {
                MessageBox.Show("You need internet connection to download this.\nRestart the launcher to continue.", "GZDoom Launcher");
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        Environment.Exit(1);
                    }));
                }
                else Environment.Exit(1);
            }

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "zdoom.zip"))
            {
                var zipFileName = AppDomain.CurrentDomain.BaseDirectory + "zdoom.zip";
                var targetDir = "";
                switch (ZDTypeDL)
                {
                    case 0:
                        targetDir = AppDomain.CurrentDomain.BaseDirectory + "GZDoom";
                        break;
                    case 1:
                        targetDir = AppDomain.CurrentDomain.BaseDirectory + "LZDoom";
                        break;
                    case 2:
                        targetDir = AppDomain.CurrentDomain.BaseDirectory + "ZDoom";
                        break;
                }
                FastZip fastZip = new FastZip();
                fastZip.ExtractZip(zipFileName, targetDir, null);
                MessageBox.Show("Program successfully downloaded.\nRestart the launcher to complete the installation.", "GZDoom Launcher");
            }
            else
            {
                MessageBox.Show("An error has occurred.\nRestart the launcher to continue.", "GZDoom Launcher");
            }
            tryDelUselessFiles();
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    Environment.Exit(0);
                }));
            }
            else Environment.Exit(0);
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    progressBar.Minimum = 0;
                    double receive = double.Parse(e.BytesReceived.ToString());
                    double total = double.Parse(e.TotalBytesToReceive.ToString());
                    double percentage = receive / total * 100;
                    DTextProgressStatus.Text = $"Downloaded {string.Format("{0:0.##}", percentage)}%";
                    progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
                }));
            }
            catch
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        Environment.Exit(1);
                    }));
                }
                else
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}
