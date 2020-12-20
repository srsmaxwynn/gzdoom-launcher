using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GZDoomLauncher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string[] EXECArgs;
        string GZpath   = AppDomain.CurrentDomain.BaseDirectory + "GZDoom";
        string ZDpath   = AppDomain.CurrentDomain.BaseDirectory + "ZDoom";
        string LZpath   = AppDomain.CurrentDomain.BaseDirectory + "LZDoom";
        string iwadpath = AppDomain.CurrentDomain.BaseDirectory + "IWADS";
        string pwadpath = AppDomain.CurrentDomain.BaseDirectory + "PWADS";

        private void Main_Load(object sender, EventArgs e)
        {
            this.BoxSkillLvL.SelectedIndex = 2;
            this.ZDoomSelComboBox.SelectedIndex = 0;
            ReloadList();

            // EXE Parameters
            bool startGZonFinish = false;
            for (int i = 0; i < EXECArgs.Length; i++)
            {
                if (EXECArgs[i] == "-loadprofile" && !String.IsNullOrWhiteSpace(EXECArgs[i+1]))
                {
                    if (File.Exists(EXECArgs[i + 1]))
                        LoadProfile(EXECArgs[i + 1]);
                }
                if (EXECArgs[i] == "-autostart") startGZonFinish = true;
                if (EXECArgs[i] == "-closeonstart") CloseOnStartButton.Checked = true;
            }
            if (startGZonFinish) StartGZD();

            try
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "zdoom.zip"))
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "zdoom.zip");
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ZDGitInfo.txt"))
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "ZDGitInfo.txt");
            }
            catch { Console.WriteLine("Can't delete useless files..."); }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Funny messages before leaving.
            string[] ExitMessages = {
                "Please don't leave, there's more demons to toast!",
                "Let's beat it -- This is turning into a bloodbath!",
                "I wouldn't leave if I were you. Work is much worse.",
                "Don't leave yet -- There's a demon around that corner!",
                "Ya know, next time you come in here I'm gonna toast ya.",
                "Go ahead and leave. See if I care.",
                "Are you sure you want to quit this great game?",
                "You want to quit? Then, thou hast lost an eighth!",
                "Don't go now, there's a dimensional shambler waiting in the Explorer!",
                "Get outta here and go back to your boring programs.",
                "If I were your boss, I'd deathmatch ya in a minute!",
                "Look, bud. You leave now and you forfeit your body count!",
                "Just leave. When you come back, I'll be waiting with a bat.",
                "You're lucky I don't smack you for thinking about leaving.",
                "Are you sure you want to quit this great game?"
            };
            Random randMsg = new Random();
            int index = randMsg.Next(ExitMessages.Length);
            DialogResult exitDialog = MessageBox.Show($"{ExitMessages[index]}", "Do you want to exit?", MessageBoxButtons.YesNo);

            if (exitDialog == DialogResult.Yes)
                Application.ExitThread();
            else e.Cancel = true;
        }

        private void ReloadList([Optional] object sender, [Optional] EventArgs e)
        {
            Directory.CreateDirectory(iwadpath);
            Directory.CreateDirectory(pwadpath);

            // Reload list of IWADs
            string[] gwad = Directory.GetFiles(iwadpath, "*.wad");
            string[] gpk3 = Directory.GetFiles(iwadpath, "*.pk3");
            string[] gzip = Directory.GetFiles(iwadpath, "*.zip");
            string[] gpak = Directory.GetFiles(iwadpath, "*.pak");
            string[] gpk7 = Directory.GetFiles(iwadpath, "*.pk7");
            string[] ggrp = Directory.GetFiles(iwadpath, "*.grp");
            string[] grff = Directory.GetFiles(iwadpath, "*.rff");
            string[] totalIWADS = gwad.Union(gpk3).Union(gzip).Union(gpak).Union(gpk7).Union(ggrp).Union(grff).ToArray();
            List<string> IWADStrList = new List<string>(totalIWADS);
            for (int i = 0; i < IWADlist.Items.Count; i++)
            {
                if (IWADlist.Items[i].Text == $"{iwadpath}\\{Path.GetFileName(IWADlist.Items[i].Text)}")
                    IWADlist.Items[i].Remove();
            }
            foreach (string IWelem in IWADStrList)
            {
                if (IWADlist.FindItemWithText(IWelem) == null)
                    IWADlist.Items.Add(IWelem);
            }
            ResizeListViewColumns(IWADlist);

            // Reload list of PWADs
            string[] fwad = Directory.GetFiles(pwadpath, "*.wad");
            string[] fpk3 = Directory.GetFiles(pwadpath, "*.pk3");
            string[] fzip = Directory.GetFiles(pwadpath, "*.zip");
            string[] fpak = Directory.GetFiles(pwadpath, "*.pak");
            string[] fpk7 = Directory.GetFiles(pwadpath, "*.pk7");
            string[] fgrp = Directory.GetFiles(pwadpath, "*.grp");
            string[] frff = Directory.GetFiles(pwadpath, "*.rff");
            string[] fdeh = Directory.GetFiles(pwadpath, "*.deh");
            string[] fbex = Directory.GetFiles(pwadpath, "*.bex");
            string[] totalPWADS = fwad.Union(fpk3).Union(fzip).Union(fpak).Union(fpk7).Union(fgrp).Union(frff).Union(fdeh).Union(fbex).ToArray();
            List<string> PWADStrList = new List<string>(totalPWADS);
            for (int i = 0; i < PWADlist.Items.Count; i++)
            {
                if (PWADlist.Items[i].Text == $"{pwadpath}\\{Path.GetFileName(PWADlist.Items[i].Text)}")
                    PWADlist.Items[i].Remove();
            }
            foreach (string PWelem in PWADStrList)
            {
                if (PWADlist.FindItemWithText(PWelem) == null)
                    PWADlist.Items.Add(PWelem);
            }
            ResizeListViewColumns(PWADlist);
        }
        
        private void StartGZD([Optional] object sender, [Optional] EventArgs e)
        {
            string ZDName = "GZDoom";
            string ZDDir = GZpath;
            string ZDEXEPath = GZpath + "\\gzdoom.exe";
            switch (ZDoomSelComboBox.SelectedIndex)
            {
                case 1:
                    ZDName = "LZDoom";
                    ZDDir = LZpath;
                    ZDEXEPath = LZpath + "\\lzdoom.exe";
                    break;
                case 2:
                    ZDName = "ZDoom";
                    ZDDir = ZDpath;
                    ZDEXEPath = ZDpath + "\\zdoom.exe";
                    break;
            }

            string totalArguments;
            Directory.CreateDirectory(ZDDir);
            if (File.Exists(ZDEXEPath))
            {
                if (IWADlist.SelectedItems.Count > 0)
                {
                    // Set Parameters
                    totalArguments = " -iwad \"" + IWADlist.SelectedItems[0].Text + "\"";

                    if (PWADlist.SelectedItems.Count > 0)
                    {
                        string selectedPWADS = String.Empty;
                        for (int i = 0; i < PWADlist.Items.Count; i++)
                        {
                            if (PWADlist.Items[i].Selected)
                            {
                                selectedPWADS += " \"" + PWADlist.Items[i].Text + "\"";
                            }
                        }
                        totalArguments += " -file" + selectedPWADS;
                    }

                    if (radioNoSounds.Checked)
                    {
                        totalArguments += " -nosound";
                    }
                    if (radioNoSFX.Checked)
                    {
                        totalArguments += " -nosfx";
                    }
                    if (radioNoMusic.Checked)
                    {
                        totalArguments += " -nomusic";
                    }

                    if (StartFromBox.TextLength > 0 && StartFromBox.Text != " ")
                    {
                        totalArguments += " +map " + StartFromBox.Text;
                    }

                    if (BoxSkillLvL.Text != "Hurt me plenty")
                    {
                        string CurrentSkillLvL = "3";
                        switch (BoxSkillLvL.Text)
                        {
                            case "I'm too young to die":
                                CurrentSkillLvL = "1";
                                break;
                            case "Hey, not too rough":
                                CurrentSkillLvL = "2";
                                break;
                            case "Ultra-Violence":
                                CurrentSkillLvL = "4";
                                break;
                            case "Nightmare!":
                                CurrentSkillLvL = "5";
                                break;
                        }
                        totalArguments += " -skill " + CurrentSkillLvL;
                    }

                    if (NoMonstersButton.Checked)
                    {
                        totalArguments += " -nomonsters";
                    }

                    if (FastMonstersButton.Checked)
                    {
                        totalArguments += " -fast";
                    }

                    if (MonstersRespawnButton.Checked)
                    {
                        totalArguments += " -respawn";
                    }

                    if (ConfigPathBox.TextLength > 0 && ConfigPathBox.Text != " ")
                    {
                        totalArguments += " -config \"" + ConfigPathBox.Text + "\"";
                    }

                    if (HostNumber.Value > 0 && HostNumber.Enabled)
                    {
                        totalArguments += " -host " + HostNumber.Value;
                    }

                    string JoinPort = String.Empty;
                    if (PortBox.Text != "5029" && PortBox.TextLength > 0 && PortBox.Text != " " && PortBox.Enabled)
                    {
                        if (ConnectBox.TextLength > 0)
                        {
                            JoinPort = PortBox.Text;
                        }
                        else
                        {
                            totalArguments += " -port " + PortBox.Text;
                        }
                    }

                    if (ConnectBox.TextLength > 0 && ConnectBox.Enabled)
                    {
                        if (PortBox.Text != "5029" && PortBox.TextLength > 0 && PortBox.Text != " ")
                        {
                            totalArguments += " -join " + ConnectBox.Text + ":" + JoinPort;
                        }
                        else
                        {
                            totalArguments += " -join " + ConnectBox.Text;
                        }
                    }

                    if (DeathmatchButton.Checked && DeathmatchButton.Enabled)
                    {
                        totalArguments += " -deathmatch";
                    }

                    if (PacketServerButton.Checked && PacketServerButton.Enabled)
                    {
                        totalArguments += " -netmode 1";
                    }

                    if (CustomParamBox.TextLength > 0 && CustomParamBox.Text != " ")
                    {
                        totalArguments += $" {CustomParamBox.Text}";
                    }

                    // Start GZDoom
                    Process GZInfo = new Process();
                    GZInfo.StartInfo.FileName = ZDEXEPath;
                    GZInfo.StartInfo.Arguments = totalArguments;
                    GZInfo.StartInfo.UseShellExecute = false;
                    GZInfo.Start();
                    if (CloseOnStartButton.Checked)
                    {
                        Application.ExitThread();
                    }
                }
                else   // If something is missing then...
                {
                    MessageBox.Show("Select an IWAD first!", "GZDoom Launcher");
                }
            }
            else
            {
                DialogResult MissGZMsg = MessageBox.Show($"{ZDName} is missing.\nWould you like to download it?", "Some files are missing...", MessageBoxButtons.YesNo);
                if (MissGZMsg == DialogResult.Yes)
                {
                    GZDL Downloader = new GZDL();
                    Downloader.ZDTypeDL = ZDoomSelComboBox.SelectedIndex;
                    Downloader.ShowDialog();
                }
            }
        }

        private void ConfigExplorerSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelectConfigFileDialog = new OpenFileDialog();
            SelectConfigFileDialog.DefaultExt = "ini";
            SelectConfigFileDialog.Filter = "Configuration files (*.ini)|*.ini|All files (*.*)|*.*";
            SelectConfigFileDialog.ShowDialog();
            ConfigPathBox.Text = SelectConfigFileDialog.FileName;
        }

        private void HostNumber_ValueChanged(object sender, EventArgs e)
        {
            if (HostNumber.Value > 0)
            {
                PortBox.Enabled = true;
                DeathmatchButton.Enabled = true;
                PacketServerButton.Enabled = true;
                ConnectBox.Enabled = false;
            }
            else
            {
                PortBox.Enabled = false;
                DeathmatchButton.Enabled = false;
                PacketServerButton.Enabled = false;
                ConnectBox.Enabled = true;
            }
        }

        private void ConnectBox_TextChanged(object sender, EventArgs e)
        {
            if (ConnectBox.TextLength > 0)
            {
                PortBox.Enabled = true;
                HostNumber.Enabled = false;
            }
            else
            {
                PortBox.Enabled = false;
                HostNumber.Enabled = true;
            }
        }

        private void AddIWADButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog AddIWADialog = new OpenFileDialog();
            AddIWADialog.DefaultExt = "wad";
            AddIWADialog.Filter = "Where's All the Data? (*.wad)|*.wad|PK3 Files (*.pk3)|*.pk3|Zipped Files (*.zip)|*.zip|PAK Files (*.pak)|*.pak|PK7 Files (*.pk7)|*.pk7|GRP Files (*.grp)|*.grp|RFF Files (*.rff)|*.rff|All files (*.*)|*.*";
            AddIWADialog.Multiselect = true;
            AddIWADialog.ShowDialog();
            foreach (string file in AddIWADialog.FileNames)
            {
                if (!String.IsNullOrWhiteSpace(file) && IWADlist.FindItemWithText(file) == null)
                {
                    IWADlist.Items.Add(file);
                }
            }
            ResizeListViewColumns(IWADlist);
        }

        private void AddPWADButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog AddPWADialog = new OpenFileDialog();
            AddPWADialog.DefaultExt = "pk3";
            AddPWADialog.Filter = "PK3 Files (*.pk3)|*.pk3|Where's All the Data? (*.wad)|*.wad|Zipped Files (*.zip)|*.zip|PAK Files (*.pak)|*.pak|PK7 Files (*.pk7)|*.pk7|GRP Files (*.grp)|*.grp|RFF Files (*.rff)|*.rff|DeHackEd Files (*.deh)|*.deh|BOOM Extension Files (*.bex)|*.bex|All files (*.*)|*.*";
            AddPWADialog.Multiselect = true;
            AddPWADialog.ShowDialog();
            foreach (string file in AddPWADialog.FileNames)
            {
                if (!String.IsNullOrWhiteSpace(file) && PWADlist.FindItemWithText(file) == null)
                    PWADlist.Items.Add(file);
            }
            ResizeListViewColumns(PWADlist);
        }

        private void SaveProfileButton_Click(object sender, EventArgs e)
        {
            string FinalJSON = "{\n";
            if (IWADlist.SelectedItems.Count > 0) FinalJSON += "\"SelectedIWAD\": \"" + IWADlist.SelectedItems[0].Text + "\",\n";
            if (PWADlist.SelectedItems.Count > 0)
            {
                FinalJSON += "\"SelectedPWADs\": [";
                for (int i = 0; i < PWADlist.Items.Count; i++)
                {
                    if (PWADlist.Items[i].Selected)
                        FinalJSON += " \"" + PWADlist.Items[i].Text + "\",";
                }
                FinalJSON = FinalJSON.Remove(FinalJSON.Length - 1);
                FinalJSON += " ],\n";
            }

            string JAudioSetting = "enabled";
            if (radioNoSounds.Checked)
                JAudioSetting = "nosound";

            if (radioNoSFX.Checked)
                JAudioSetting = "nosfx";

            if (radioNoMusic.Checked)
                JAudioSetting = "nomusic";

            FinalJSON += "\"Audio\": \"" + JAudioSetting + "\",\n";

            if (StartFromBox.TextLength > 0 && StartFromBox.Text != " ")
                FinalJSON += "\"StartMap\": \"" + StartFromBox.Text + "\",\n";

            if (BoxSkillLvL.Text != "Hurt me plenty")
            {
                string JCurrentSkillLvL = "3";
                switch (BoxSkillLvL.Text)
                {
                    case "I'm too young to die":
                        JCurrentSkillLvL = "1";
                        break;
                    case "Hey, not too rough":
                        JCurrentSkillLvL = "2";
                        break;
                    case "Ultra-Violence":
                        JCurrentSkillLvL = "4";
                        break;
                    case "Nightmare!":
                        JCurrentSkillLvL = "5";
                        break;
                }

                FinalJSON += "\"Skill\": " + JCurrentSkillLvL + ",\n";
            }

            if (NoMonstersButton.Checked)
                FinalJSON += "\"NoMonsters\": \"True\",\n";

            if (FastMonstersButton.Checked)
                FinalJSON += "\"FastMonsters\": \"True\",\n";

            if (MonstersRespawnButton.Checked)
                FinalJSON += "\"MonstersCanRespawn\": \"True\",\n";

            if (ConfigPathBox.TextLength > 0 && ConfigPathBox.Text != " ")
                FinalJSON += "\"ConfigFilePath\": \"" + ConfigPathBox.Text + "\",\n";

            if (HostNumber.Value > 0 && HostNumber.Enabled)
                FinalJSON += "\"Host\": " + HostNumber.Value + ",\n";

            if (PortBox.Text != "5029" && PortBox.TextLength > 0 && PortBox.Text != " " && PortBox.Enabled)
                FinalJSON += "\"Port\": \"" + PortBox.Text + "\",\n";

            if (ConnectBox.TextLength > 0 && ConnectBox.Enabled)
                FinalJSON += "\"ConnectTo\": \"" + ConnectBox.Text + "\",\n";

            if (DeathmatchButton.Checked && DeathmatchButton.Enabled)
                FinalJSON += "\"Deathmatch\": \"True\",\n";

            if (PacketServerButton.Checked && PacketServerButton.Enabled)
                FinalJSON += "\"PacketServer\": \"True\",\n";

            if (CustomParamBox.TextLength > 0 && CustomParamBox.Text != " ")
                FinalJSON += "\"OtherParameters\": \"" + CustomParamBox.Text + "\",\n";

            if (FinalJSON != "{\n") FinalJSON = FinalJSON.Remove(FinalJSON.Length - 2);
            FinalJSON += "\n}";
            SaveFileDialog JSONPath = new SaveFileDialog();
            JSONPath.FileName = "profile.gzlp";
            JSONPath.DefaultExt = "gzlp";
            JSONPath.Filter = "GZLauncher Profile (*.gzlp)|*.gzlp|JavaScript Object Notation (*.json)|*.json";
            if (!String.IsNullOrWhiteSpace(JSONPath.FileName) && JSONPath.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(JSONPath.FileName, FinalJSON);
                }
                catch(Exception err)
                {
                    MessageBox.Show("An error occurred:\n" + err.Message, "GZDoom Launcher");
                }
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            InfoScreen AboutScreen = new InfoScreen();
            AboutScreen.ShowDialog();
        }

        private void LoadProfileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ProfilePath = new OpenFileDialog();
            ProfilePath.DefaultExt = "gzlp";
            ProfilePath.Filter = "GZLauncher Profile (*.gzlp)|*.gzlp|JavaScript Object Notation (*.json)|*.json|All files (*.*)|*.*";
            ProfilePath.ShowDialog();
            if (ProfilePath.FileName.Length > 0)
                LoadProfile(ProfilePath.FileName);
        }

        public void LoadProfile(string ArgProfilePath)
        {
            if (File.Exists(ArgProfilePath))
            {
                try
                {
                    StreamReader reader = new StreamReader(ArgProfilePath);
                    string PFJson = reader.ReadToEnd();
                    PFJson = PFJson.Replace("\\", "\\\\");
                    JObject Jobj = JObject.Parse(PFJson);

                    if ((string)Jobj["Host"] != null && (string)Jobj["ConnectTo"] != null)
                    {
                        MessageBox.Show("This file has both \"Host\" and \"ConnectTo\" values", "An error has occurred");
                    }
                    else
                    {
                        if ((string)Jobj["SelectedIWAD"] != null)
                        {
                            foreach (ListViewItem selIWAD in IWADlist.SelectedItems) selIWAD.Selected = false;
                            if (IWADlist.FindItemWithText((string)Jobj["SelectedIWAD"]) == null)
                                IWADlist.Items.Add((string)Jobj["SelectedIWAD"]);
                            IWADlist.FindItemWithText((string)Jobj["SelectedIWAD"]).Selected = true;
                            ResizeListViewColumns(IWADlist);
                        }

                        if ((JArray)Jobj["SelectedPWADs"] != null)
                        {
                            JArray JSelPWADsItems = (JArray)Jobj["SelectedPWADs"];
                            for (int i = 0; i < PWADlist.Items.Count; i++)
                                PWADlist.Items[i].Selected = false;
                            for (int i = 0; i < JSelPWADsItems.Count; i++)
                            {
                                if (PWADlist.FindItemWithText((string)Jobj["SelectedPWADs"][i]) == null)
                                    PWADlist.Items.Add((string)Jobj["SelectedPWADs"][i]);
                                PWADlist.FindItemWithText((string)Jobj["SelectedPWADs"][i]).Selected = true;
                            }
                            ResizeListViewColumns(PWADlist);
                        }

                        if ((string)Jobj["Audio"] != null)
                        {
                            if ((string)Jobj["Audio"] == "nosound")
                            {
                                radioNoSounds.Checked = true;
                            }
                            else if ((string)Jobj["Audio"] == "nosfx")
                            {
                                radioNoSFX.Checked = true;
                            }
                            else if ((string)Jobj["Audio"] == "nomusic")
                            {
                                radioNoMusic.Checked = true;
                            }
                            else
                            {
                                radioAllSounds.Checked = true;
                            }
                        }

                        if ((string)Jobj["StartMap"] != null)
                        {
                            StartFromBox.Text = (string)Jobj["StartMap"];
                        }

                        if ((string)Jobj["Skill"] != null)
                        {
                            BoxSkillLvL.SelectedIndex = 2;
                            switch ((string)Jobj["Skill"])
                            {
                                case "1":
                                    BoxSkillLvL.SelectedIndex = 0;
                                    break;
                                case "2":
                                    BoxSkillLvL.SelectedIndex = 1;
                                    break;
                                case "4":
                                    BoxSkillLvL.SelectedIndex = 3;
                                    break;
                                case "5":
                                    BoxSkillLvL.SelectedIndex = 4;
                                    break;
                            }
                        }

                        if ((string)Jobj["NoMonsters"] != null)
                        {
                            if ((string)Jobj["NoMonsters"] == "True")
                                NoMonstersButton.Checked = true;
                            else
                                NoMonstersButton.Checked = false;
                        }

                        if ((string)Jobj["FastMonsters"] != null)
                        {
                            if ((string)Jobj["FastMonsters"] == "True")
                                FastMonstersButton.Checked = true;
                            else
                                FastMonstersButton.Checked = false;
                        }

                        if ((string)Jobj["MonstersCanRespawn"] != null)
                        {
                            if ((string)Jobj["MonstersCanRespawn"] == "True")
                                MonstersRespawnButton.Checked = true;
                            else
                                MonstersRespawnButton.Checked = false;
                        }

                        if ((string)Jobj["ConfigFilePath"] != null)
                        {
                            ConfigPathBox.Text = (string)Jobj["ConfigFilePath"];
                        }

                        if ((string)Jobj["Host"] != null)
                        {
                            PortBox.Enabled = true;
                            DeathmatchButton.Enabled = true;
                            PacketServerButton.Enabled = true;
                            ConnectBox.Enabled = false;
                            HostNumber.Enabled = true;
                            HostNumber.Value = (decimal)Jobj["Host"];
                        }
                        else if ((string)Jobj["ConnectTo"] != null)
                        {
                            PortBox.Enabled = true;
                            HostNumber.Enabled = false;
                            ConnectBox.Enabled = true;
                            DeathmatchButton.Enabled = false;
                            PacketServerButton.Enabled = false;
                            ConnectBox.Text = (string)Jobj["ConnectTo"];
                        }

                        if ((string)Jobj["Port"] != null)
                        {
                            PortBox.Text = (string)Jobj["Port"];
                        }

                        if ((string)Jobj["Deathmatch"] != null)
                        {
                            if ((string)Jobj["Deathmatch"] == "True")
                            {
                                DeathmatchButton.Checked = true;
                            }
                            else
                            {
                                DeathmatchButton.Checked = false;
                            }
                        }

                        if ((string)Jobj["PacketServer"] != null)
                        {
                            if ((string)Jobj["PacketServer"] == "True")
                            {
                                PacketServerButton.Checked = true;
                            }
                            else
                            {
                                PacketServerButton.Checked = false;
                            }
                        }

                        if ((string)Jobj["OtherParameters"] != null)
                        {
                            CustomParamBox.Text = (string)Jobj["OtherParameters"];
                        }
                    }
                }
                catch(Newtonsoft.Json.JsonReaderException err)
                {
                    Console.WriteLine(err.Message);
                    MessageBox.Show("An error occurred: the syntax of the JSON is incorrect.\nProbably this isn't a profile file", "GZDoom Launcher");
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                    MessageBox.Show("An error occurred:\n" + err.Message, "GZDoom Launcher");
                }
            }
        }

        private void RemIWADButton_Click(object sender, EventArgs e)
        {
            if (IWADlist.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an IWAD from the list first.", "GZDoom Launcher");
            }
            else
            {
                if (File.Exists($"{iwadpath}\\{Path.GetFileName(IWADlist.SelectedItems[0].Text)}"))
                {
                    DialogResult RemIWADAsk = MessageBox.Show("Are you sure you want to remove the selected IWAD?\nATTENTION: it will be deleted from the IWADs folder.", "GZDoom Launcher", MessageBoxButtons.YesNo);
                    if (RemIWADAsk == DialogResult.Yes)
                    {
                        try
                        {
                            File.Delete(IWADlist.SelectedItems[0].Text);
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err.Message);
                        }
                        IWADlist.SelectedItems[0].Remove();
                    }
                }
                else
                {
                    DialogResult RemIWADAsk = MessageBox.Show("Are you sure you want to remove the selected IWAD from the list?", "GZDoom Launcher", MessageBoxButtons.YesNo);
                    if (RemIWADAsk == DialogResult.Yes)
                        IWADlist.SelectedItems[0].Remove();
                }
                ResizeListViewColumns(IWADlist);
            }
        }

        private void RemPWADsButton_Click(object sender, EventArgs e)
        {
            if (PWADlist.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select some PWADs from the list first.", "GZDoom Launcher");
            }
            else
            {
                string alertboxmsg = "Are you sure to remove these PWADs from the list?";
                foreach (ListViewItem selPWAD in PWADlist.SelectedItems)
                {
                    if (File.Exists($"{pwadpath}\\{Path.GetFileName(selPWAD.Text)}"))
                        alertboxmsg += "\nEvery file you wanted to remove that is in the PWADs folder will reappear after you click the reload button.";
                }
                DialogResult RemPWADsAsk = MessageBox.Show(alertboxmsg, "GZDoom Launcher", MessageBoxButtons.YesNo);
                if (RemPWADsAsk == DialogResult.Yes)
                {
                    foreach (ListViewItem selPWAD in PWADlist.SelectedItems) selPWAD.Remove();
                }
                ResizeListViewColumns(PWADlist);
            }
        }

        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -1;
            }
        }
    }
}
