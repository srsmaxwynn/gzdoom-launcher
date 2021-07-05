namespace GZDoomLauncher
{
    partial class MainWindow
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.IWADlist = new System.Windows.Forms.ListView();
			this.Icolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.IWlabel = new System.Windows.Forms.Label();
			this.PWlabel = new System.Windows.Forms.Label();
			this.StartButton = new System.Windows.Forms.Button();
			this.ReloadButton = new System.Windows.Forms.Button();
			this.CloseOnStartButton = new System.Windows.Forms.CheckBox();
			this.AddIWADButton = new System.Windows.Forms.Button();
			this.groupBoxLaunchSettings = new System.Windows.Forms.GroupBox();
			this.AboutButton = new System.Windows.Forms.Button();
			this.SaveProfileButton = new System.Windows.Forms.Button();
			this.LoadProfileButton = new System.Windows.Forms.Button();
			this.groupBoxMultiplayer = new System.Windows.Forms.GroupBox();
			this.PacketServerButton = new System.Windows.Forms.CheckBox();
			this.DeathmatchButton = new System.Windows.Forms.CheckBox();
			this.labelConnect = new System.Windows.Forms.Label();
			this.ConnectBox = new System.Windows.Forms.TextBox();
			this.PortBox = new System.Windows.Forms.TextBox();
			this.labelPort = new System.Windows.Forms.Label();
			this.labelHost = new System.Windows.Forms.Label();
			this.HostNumber = new System.Windows.Forms.NumericUpDown();
			this.groupBoxConfig = new System.Windows.Forms.GroupBox();
			this.ConfigExplorerSelectButton = new System.Windows.Forms.Button();
			this.LabelConfigPath = new System.Windows.Forms.Label();
			this.ConfigPathBox = new System.Windows.Forms.TextBox();
			this.groupBoxGameplay = new System.Windows.Forms.GroupBox();
			this.MonstersRespawnButton = new System.Windows.Forms.CheckBox();
			this.FastMonstersButton = new System.Windows.Forms.CheckBox();
			this.NoMonstersButton = new System.Windows.Forms.CheckBox();
			this.BoxSkillLvL = new System.Windows.Forms.ComboBox();
			this.LabelSkillLvL = new System.Windows.Forms.Label();
			this.LabelStartFrom = new System.Windows.Forms.Label();
			this.StartFromBox = new System.Windows.Forms.TextBox();
			this.groupBoxAudio = new System.Windows.Forms.GroupBox();
			this.radioNoMusic = new System.Windows.Forms.RadioButton();
			this.radioNoSFX = new System.Windows.Forms.RadioButton();
			this.radioNoSounds = new System.Windows.Forms.RadioButton();
			this.radioAllSounds = new System.Windows.Forms.RadioButton();
			this.CustomParamBox = new System.Windows.Forms.TextBox();
			this.CustomParamLabel = new System.Windows.Forms.Label();
			this.SelectFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.AddPWADButton = new System.Windows.Forms.Button();
			this.ZDoomSelComboBox = new System.Windows.Forms.ComboBox();
			this.RemIWADButton = new System.Windows.Forms.Button();
			this.RemPWADsButton = new System.Windows.Forms.Button();
			this.PWADlist = new System.Windows.Forms.CheckedListBox();
			this.UpPWADsButton = new System.Windows.Forms.Button();
			this.DownPWADsButton = new System.Windows.Forms.Button();
			this.groupBoxLaunchSettings.SuspendLayout();
			this.groupBoxMultiplayer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.HostNumber)).BeginInit();
			this.groupBoxConfig.SuspendLayout();
			this.groupBoxGameplay.SuspendLayout();
			this.groupBoxAudio.SuspendLayout();
			this.SuspendLayout();
			// 
			// IWADlist
			// 
			this.IWADlist.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.IWADlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Icolumn});
			this.IWADlist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.IWADlist.HideSelection = false;
			this.IWADlist.Location = new System.Drawing.Point(12, 25);
			this.IWADlist.MultiSelect = false;
			this.IWADlist.Name = "IWADlist";
			this.IWADlist.Size = new System.Drawing.Size(532, 109);
			this.IWADlist.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.IWADlist.TabIndex = 1;
			this.IWADlist.UseCompatibleStateImageBehavior = false;
			this.IWADlist.View = System.Windows.Forms.View.Details;
			// 
			// Icolumn
			// 
			this.Icolumn.Text = "";
			this.Icolumn.Width = 528;
			// 
			// IWlabel
			// 
			this.IWlabel.AutoSize = true;
			this.IWlabel.Location = new System.Drawing.Point(9, 9);
			this.IWlabel.Name = "IWlabel";
			this.IWlabel.Size = new System.Drawing.Size(41, 13);
			this.IWlabel.TabIndex = 2;
			this.IWlabel.Text = "IWADs";
			// 
			// PWlabel
			// 
			this.PWlabel.AutoSize = true;
			this.PWlabel.Location = new System.Drawing.Point(12, 137);
			this.PWlabel.Name = "PWlabel";
			this.PWlabel.Size = new System.Drawing.Size(45, 13);
			this.PWlabel.TabIndex = 3;
			this.PWlabel.Text = "PWADs";
			// 
			// StartButton
			// 
			this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartButton.Location = new System.Drawing.Point(12, 298);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(96, 36);
			this.StartButton.TabIndex = 0;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartGZD);
			// 
			// ReloadButton
			// 
			this.ReloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReloadButton.Location = new System.Drawing.Point(524, 4);
			this.ReloadButton.Name = "ReloadButton";
			this.ReloadButton.Size = new System.Drawing.Size(20, 20);
			this.ReloadButton.TabIndex = 0;
			this.ReloadButton.Text = "⟳";
			this.ReloadButton.UseVisualStyleBackColor = true;
			this.ReloadButton.Click += new System.EventHandler(this.ReloadList);
			// 
			// CloseOnStartButton
			// 
			this.CloseOnStartButton.AutoSize = true;
			this.CloseOnStartButton.Location = new System.Drawing.Point(6, 19);
			this.CloseOnStartButton.Name = "CloseOnStartButton";
			this.CloseOnStartButton.Size = new System.Drawing.Size(134, 17);
			this.CloseOnStartButton.TabIndex = 0;
			this.CloseOnStartButton.Text = "Close launcher on start";
			this.CloseOnStartButton.UseVisualStyleBackColor = true;
			// 
			// AddIWADButton
			// 
			this.AddIWADButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddIWADButton.Location = new System.Drawing.Point(498, 4);
			this.AddIWADButton.Name = "AddIWADButton";
			this.AddIWADButton.Size = new System.Drawing.Size(20, 20);
			this.AddIWADButton.TabIndex = 0;
			this.AddIWADButton.Text = "+";
			this.AddIWADButton.UseVisualStyleBackColor = true;
			this.AddIWADButton.Click += new System.EventHandler(this.AddIWADButton_Click);
			// 
			// groupBoxLaunchSettings
			// 
			this.groupBoxLaunchSettings.Controls.Add(this.AboutButton);
			this.groupBoxLaunchSettings.Controls.Add(this.SaveProfileButton);
			this.groupBoxLaunchSettings.Controls.Add(this.LoadProfileButton);
			this.groupBoxLaunchSettings.Controls.Add(this.groupBoxMultiplayer);
			this.groupBoxLaunchSettings.Controls.Add(this.groupBoxConfig);
			this.groupBoxLaunchSettings.Controls.Add(this.groupBoxGameplay);
			this.groupBoxLaunchSettings.Controls.Add(this.groupBoxAudio);
			this.groupBoxLaunchSettings.Controls.Add(this.CloseOnStartButton);
			this.groupBoxLaunchSettings.Location = new System.Drawing.Point(550, 12);
			this.groupBoxLaunchSettings.Name = "groupBoxLaunchSettings";
			this.groupBoxLaunchSettings.Size = new System.Drawing.Size(397, 322);
			this.groupBoxLaunchSettings.TabIndex = 10;
			this.groupBoxLaunchSettings.TabStop = false;
			this.groupBoxLaunchSettings.Text = "Launch Settings";
			// 
			// AboutButton
			// 
			this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AboutButton.Location = new System.Drawing.Point(368, 15);
			this.AboutButton.Name = "AboutButton";
			this.AboutButton.Size = new System.Drawing.Size(23, 23);
			this.AboutButton.TabIndex = 13;
			this.AboutButton.Text = "?";
			this.AboutButton.UseVisualStyleBackColor = true;
			this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
			// 
			// SaveProfileButton
			// 
			this.SaveProfileButton.Location = new System.Drawing.Point(206, 15);
			this.SaveProfileButton.Name = "SaveProfileButton";
			this.SaveProfileButton.Size = new System.Drawing.Size(75, 23);
			this.SaveProfileButton.TabIndex = 14;
			this.SaveProfileButton.Text = "Save Profile";
			this.SaveProfileButton.UseVisualStyleBackColor = true;
			this.SaveProfileButton.Click += new System.EventHandler(this.SaveProfileButton_Click);
			// 
			// LoadProfileButton
			// 
			this.LoadProfileButton.Location = new System.Drawing.Point(287, 15);
			this.LoadProfileButton.Name = "LoadProfileButton";
			this.LoadProfileButton.Size = new System.Drawing.Size(75, 23);
			this.LoadProfileButton.TabIndex = 13;
			this.LoadProfileButton.Text = "Load Profile";
			this.LoadProfileButton.UseVisualStyleBackColor = true;
			this.LoadProfileButton.Click += new System.EventHandler(this.LoadProfileButton_Click);
			// 
			// groupBoxMultiplayer
			// 
			this.groupBoxMultiplayer.Controls.Add(this.PacketServerButton);
			this.groupBoxMultiplayer.Controls.Add(this.DeathmatchButton);
			this.groupBoxMultiplayer.Controls.Add(this.labelConnect);
			this.groupBoxMultiplayer.Controls.Add(this.ConnectBox);
			this.groupBoxMultiplayer.Controls.Add(this.PortBox);
			this.groupBoxMultiplayer.Controls.Add(this.labelPort);
			this.groupBoxMultiplayer.Controls.Add(this.labelHost);
			this.groupBoxMultiplayer.Controls.Add(this.HostNumber);
			this.groupBoxMultiplayer.Location = new System.Drawing.Point(252, 160);
			this.groupBoxMultiplayer.Name = "groupBoxMultiplayer";
			this.groupBoxMultiplayer.Size = new System.Drawing.Size(139, 156);
			this.groupBoxMultiplayer.TabIndex = 12;
			this.groupBoxMultiplayer.TabStop = false;
			this.groupBoxMultiplayer.Text = "Multiplayer";
			// 
			// PacketServerButton
			// 
			this.PacketServerButton.AutoSize = true;
			this.PacketServerButton.Enabled = false;
			this.PacketServerButton.Location = new System.Drawing.Point(9, 64);
			this.PacketServerButton.Name = "PacketServerButton";
			this.PacketServerButton.Size = new System.Drawing.Size(94, 17);
			this.PacketServerButton.TabIndex = 15;
			this.PacketServerButton.Text = "Packet Server";
			this.PacketServerButton.UseVisualStyleBackColor = true;
			// 
			// DeathmatchButton
			// 
			this.DeathmatchButton.AutoSize = true;
			this.DeathmatchButton.Enabled = false;
			this.DeathmatchButton.Location = new System.Drawing.Point(9, 45);
			this.DeathmatchButton.Name = "DeathmatchButton";
			this.DeathmatchButton.Size = new System.Drawing.Size(84, 17);
			this.DeathmatchButton.TabIndex = 14;
			this.DeathmatchButton.Text = "Deathmatch";
			this.DeathmatchButton.UseVisualStyleBackColor = true;
			// 
			// labelConnect
			// 
			this.labelConnect.AutoSize = true;
			this.labelConnect.Location = new System.Drawing.Point(6, 110);
			this.labelConnect.Name = "labelConnect";
			this.labelConnect.Size = new System.Drawing.Size(59, 13);
			this.labelConnect.TabIndex = 5;
			this.labelConnect.Text = "Connect to";
			// 
			// ConnectBox
			// 
			this.ConnectBox.Location = new System.Drawing.Point(6, 126);
			this.ConnectBox.Name = "ConnectBox";
			this.ConnectBox.Size = new System.Drawing.Size(127, 20);
			this.ConnectBox.TabIndex = 17;
			this.ConnectBox.TextChanged += new System.EventHandler(this.ConnectBox_TextChanged);
			// 
			// PortBox
			// 
			this.PortBox.Enabled = false;
			this.PortBox.Location = new System.Drawing.Point(46, 86);
			this.PortBox.Name = "PortBox";
			this.PortBox.Size = new System.Drawing.Size(42, 20);
			this.PortBox.TabIndex = 16;
			this.PortBox.Text = "5029";
			this.PortBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelPort
			// 
			this.labelPort.AutoSize = true;
			this.labelPort.Location = new System.Drawing.Point(6, 89);
			this.labelPort.Name = "labelPort";
			this.labelPort.Size = new System.Drawing.Size(26, 13);
			this.labelPort.TabIndex = 2;
			this.labelPort.Text = "Port";
			// 
			// labelHost
			// 
			this.labelHost.AutoSize = true;
			this.labelHost.Location = new System.Drawing.Point(6, 22);
			this.labelHost.Name = "labelHost";
			this.labelHost.Size = new System.Drawing.Size(29, 13);
			this.labelHost.TabIndex = 1;
			this.labelHost.Text = "Host";
			// 
			// HostNumber
			// 
			this.HostNumber.Location = new System.Drawing.Point(49, 19);
			this.HostNumber.Name = "HostNumber";
			this.HostNumber.Size = new System.Drawing.Size(35, 20);
			this.HostNumber.TabIndex = 13;
			this.HostNumber.ValueChanged += new System.EventHandler(this.HostNumber_ValueChanged);
			// 
			// groupBoxConfig
			// 
			this.groupBoxConfig.Controls.Add(this.ConfigExplorerSelectButton);
			this.groupBoxConfig.Controls.Add(this.LabelConfigPath);
			this.groupBoxConfig.Controls.Add(this.ConfigPathBox);
			this.groupBoxConfig.Location = new System.Drawing.Point(134, 42);
			this.groupBoxConfig.Name = "groupBoxConfig";
			this.groupBoxConfig.Size = new System.Drawing.Size(257, 112);
			this.groupBoxConfig.TabIndex = 11;
			this.groupBoxConfig.TabStop = false;
			this.groupBoxConfig.Text = "Configuration File";
			// 
			// ConfigExplorerSelectButton
			// 
			this.ConfigExplorerSelectButton.Location = new System.Drawing.Point(6, 73);
			this.ConfigExplorerSelectButton.Name = "ConfigExplorerSelectButton";
			this.ConfigExplorerSelectButton.Size = new System.Drawing.Size(245, 23);
			this.ConfigExplorerSelectButton.TabIndex = 0;
			this.ConfigExplorerSelectButton.Text = "Browse";
			this.ConfigExplorerSelectButton.UseVisualStyleBackColor = true;
			this.ConfigExplorerSelectButton.Click += new System.EventHandler(this.ConfigExplorerSelectButton_Click);
			// 
			// LabelConfigPath
			// 
			this.LabelConfigPath.AutoSize = true;
			this.LabelConfigPath.Location = new System.Drawing.Point(6, 26);
			this.LabelConfigPath.Name = "LabelConfigPath";
			this.LabelConfigPath.Size = new System.Drawing.Size(29, 13);
			this.LabelConfigPath.TabIndex = 1;
			this.LabelConfigPath.Text = "Path";
			// 
			// ConfigPathBox
			// 
			this.ConfigPathBox.Location = new System.Drawing.Point(6, 42);
			this.ConfigPathBox.Name = "ConfigPathBox";
			this.ConfigPathBox.Size = new System.Drawing.Size(245, 20);
			this.ConfigPathBox.TabIndex = 7;
			// 
			// groupBoxGameplay
			// 
			this.groupBoxGameplay.Controls.Add(this.MonstersRespawnButton);
			this.groupBoxGameplay.Controls.Add(this.FastMonstersButton);
			this.groupBoxGameplay.Controls.Add(this.NoMonstersButton);
			this.groupBoxGameplay.Controls.Add(this.BoxSkillLvL);
			this.groupBoxGameplay.Controls.Add(this.LabelSkillLvL);
			this.groupBoxGameplay.Controls.Add(this.LabelStartFrom);
			this.groupBoxGameplay.Controls.Add(this.StartFromBox);
			this.groupBoxGameplay.Location = new System.Drawing.Point(6, 160);
			this.groupBoxGameplay.Name = "groupBoxGameplay";
			this.groupBoxGameplay.Size = new System.Drawing.Size(240, 156);
			this.groupBoxGameplay.TabIndex = 10;
			this.groupBoxGameplay.TabStop = false;
			this.groupBoxGameplay.Text = "Gameplay";
			// 
			// MonstersRespawnButton
			// 
			this.MonstersRespawnButton.AutoSize = true;
			this.MonstersRespawnButton.Location = new System.Drawing.Point(9, 120);
			this.MonstersRespawnButton.Name = "MonstersRespawnButton";
			this.MonstersRespawnButton.Size = new System.Drawing.Size(133, 17);
			this.MonstersRespawnButton.TabIndex = 12;
			this.MonstersRespawnButton.Text = "Monsters can respawn";
			this.MonstersRespawnButton.UseVisualStyleBackColor = true;
			// 
			// FastMonstersButton
			// 
			this.FastMonstersButton.AutoSize = true;
			this.FastMonstersButton.Location = new System.Drawing.Point(9, 97);
			this.FastMonstersButton.Name = "FastMonstersButton";
			this.FastMonstersButton.Size = new System.Drawing.Size(91, 17);
			this.FastMonstersButton.TabIndex = 11;
			this.FastMonstersButton.Text = "Fast monsters";
			this.FastMonstersButton.UseVisualStyleBackColor = true;
			// 
			// NoMonstersButton
			// 
			this.NoMonstersButton.AutoSize = true;
			this.NoMonstersButton.Location = new System.Drawing.Point(9, 74);
			this.NoMonstersButton.Name = "NoMonstersButton";
			this.NoMonstersButton.Size = new System.Drawing.Size(85, 17);
			this.NoMonstersButton.TabIndex = 10;
			this.NoMonstersButton.Text = "No monsters";
			this.NoMonstersButton.UseVisualStyleBackColor = true;
			// 
			// BoxSkillLvL
			// 
			this.BoxSkillLvL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BoxSkillLvL.FormattingEnabled = true;
			this.BoxSkillLvL.Items.AddRange(new object[] {
            "I\'m too young to die",
            "Hey, not too rough",
            "Hurt me plenty",
            "Ultra-Violence",
            "Nightmare!"});
			this.BoxSkillLvL.Location = new System.Drawing.Point(108, 45);
			this.BoxSkillLvL.Name = "BoxSkillLvL";
			this.BoxSkillLvL.Size = new System.Drawing.Size(126, 21);
			this.BoxSkillLvL.TabIndex = 9;
			// 
			// LabelSkillLvL
			// 
			this.LabelSkillLvL.AutoSize = true;
			this.LabelSkillLvL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelSkillLvL.Location = new System.Drawing.Point(6, 47);
			this.LabelSkillLvL.Name = "LabelSkillLvL";
			this.LabelSkillLvL.Size = new System.Drawing.Size(65, 16);
			this.LabelSkillLvL.TabIndex = 3;
			this.LabelSkillLvL.Text = "Skill level";
			// 
			// LabelStartFrom
			// 
			this.LabelStartFrom.AutoSize = true;
			this.LabelStartFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelStartFrom.Location = new System.Drawing.Point(6, 21);
			this.LabelStartFrom.Name = "LabelStartFrom";
			this.LabelStartFrom.Size = new System.Drawing.Size(94, 16);
			this.LabelStartFrom.TabIndex = 1;
			this.LabelStartFrom.Text = "Start from map";
			// 
			// StartFromBox
			// 
			this.StartFromBox.Location = new System.Drawing.Point(108, 19);
			this.StartFromBox.Name = "StartFromBox";
			this.StartFromBox.Size = new System.Drawing.Size(126, 20);
			this.StartFromBox.TabIndex = 8;
			// 
			// groupBoxAudio
			// 
			this.groupBoxAudio.Controls.Add(this.radioNoMusic);
			this.groupBoxAudio.Controls.Add(this.radioNoSFX);
			this.groupBoxAudio.Controls.Add(this.radioNoSounds);
			this.groupBoxAudio.Controls.Add(this.radioAllSounds);
			this.groupBoxAudio.Location = new System.Drawing.Point(6, 42);
			this.groupBoxAudio.Name = "groupBoxAudio";
			this.groupBoxAudio.Size = new System.Drawing.Size(122, 112);
			this.groupBoxAudio.TabIndex = 9;
			this.groupBoxAudio.TabStop = false;
			this.groupBoxAudio.Text = "Audio";
			// 
			// radioNoMusic
			// 
			this.radioNoMusic.AutoSize = true;
			this.radioNoMusic.Location = new System.Drawing.Point(6, 88);
			this.radioNoMusic.Name = "radioNoMusic";
			this.radioNoMusic.Size = new System.Drawing.Size(91, 17);
			this.radioNoMusic.TabIndex = 6;
			this.radioNoMusic.Text = "Disable Music";
			this.radioNoMusic.UseVisualStyleBackColor = true;
			// 
			// radioNoSFX
			// 
			this.radioNoSFX.AutoSize = true;
			this.radioNoSFX.Location = new System.Drawing.Point(6, 65);
			this.radioNoSFX.Name = "radioNoSFX";
			this.radioNoSFX.Size = new System.Drawing.Size(83, 17);
			this.radioNoSFX.TabIndex = 5;
			this.radioNoSFX.Text = "Disable SFX";
			this.radioNoSFX.UseVisualStyleBackColor = true;
			// 
			// radioNoSounds
			// 
			this.radioNoSounds.AutoSize = true;
			this.radioNoSounds.Location = new System.Drawing.Point(6, 42);
			this.radioNoSounds.Name = "radioNoSounds";
			this.radioNoSounds.Size = new System.Drawing.Size(110, 17);
			this.radioNoSounds.TabIndex = 4;
			this.radioNoSounds.Text = "Disable all sounds";
			this.radioNoSounds.UseVisualStyleBackColor = true;
			// 
			// radioAllSounds
			// 
			this.radioAllSounds.AutoSize = true;
			this.radioAllSounds.Checked = true;
			this.radioAllSounds.Location = new System.Drawing.Point(6, 19);
			this.radioAllSounds.Name = "radioAllSounds";
			this.radioAllSounds.Size = new System.Drawing.Size(108, 17);
			this.radioAllSounds.TabIndex = 3;
			this.radioAllSounds.TabStop = true;
			this.radioAllSounds.Text = "Enable all sounds";
			this.radioAllSounds.UseVisualStyleBackColor = true;
			// 
			// CustomParamBox
			// 
			this.CustomParamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustomParamBox.Location = new System.Drawing.Point(241, 303);
			this.CustomParamBox.Name = "CustomParamBox";
			this.CustomParamBox.Size = new System.Drawing.Size(303, 26);
			this.CustomParamBox.TabIndex = 0;
			// 
			// CustomParamLabel
			// 
			this.CustomParamLabel.AutoSize = true;
			this.CustomParamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustomParamLabel.Location = new System.Drawing.Point(241, 284);
			this.CustomParamLabel.Name = "CustomParamLabel";
			this.CustomParamLabel.Size = new System.Drawing.Size(126, 16);
			this.CustomParamLabel.TabIndex = 12;
			this.CustomParamLabel.Text = "Custom Parameters";
			// 
			// AddPWADButton
			// 
			this.AddPWADButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddPWADButton.Location = new System.Drawing.Point(524, 134);
			this.AddPWADButton.Name = "AddPWADButton";
			this.AddPWADButton.Size = new System.Drawing.Size(20, 20);
			this.AddPWADButton.TabIndex = 1;
			this.AddPWADButton.Text = "+";
			this.AddPWADButton.UseVisualStyleBackColor = true;
			this.AddPWADButton.Click += new System.EventHandler(this.AddPWADButton_Click);
			// 
			// ZDoomSelComboBox
			// 
			this.ZDoomSelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZDoomSelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ZDoomSelComboBox.FormattingEnabled = true;
			this.ZDoomSelComboBox.Items.AddRange(new object[] {
            "GZDoom",
            "LZDoom",
            "ZDoom"});
			this.ZDoomSelComboBox.Location = new System.Drawing.Point(114, 304);
			this.ZDoomSelComboBox.Name = "ZDoomSelComboBox";
			this.ZDoomSelComboBox.Size = new System.Drawing.Size(121, 24);
			this.ZDoomSelComboBox.TabIndex = 13;
			// 
			// RemIWADButton
			// 
			this.RemIWADButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
			this.RemIWADButton.Location = new System.Drawing.Point(472, 4);
			this.RemIWADButton.Name = "RemIWADButton";
			this.RemIWADButton.Size = new System.Drawing.Size(20, 20);
			this.RemIWADButton.TabIndex = 15;
			this.RemIWADButton.Text = "−";
			this.RemIWADButton.UseVisualStyleBackColor = true;
			this.RemIWADButton.Click += new System.EventHandler(this.RemIWADButton_Click);
			// 
			// RemPWADsButton
			// 
			this.RemPWADsButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
			this.RemPWADsButton.Location = new System.Drawing.Point(498, 134);
			this.RemPWADsButton.Name = "RemPWADsButton";
			this.RemPWADsButton.Size = new System.Drawing.Size(20, 20);
			this.RemPWADsButton.TabIndex = 16;
			this.RemPWADsButton.Text = "−";
			this.RemPWADsButton.UseVisualStyleBackColor = true;
			this.RemPWADsButton.Click += new System.EventHandler(this.RemPWADsButton_Click);
			// 
			// PWADlist
			// 
			this.PWADlist.FormattingEnabled = true;
			this.PWADlist.Location = new System.Drawing.Point(12, 154);
			this.PWADlist.Name = "PWADlist";
			this.PWADlist.Size = new System.Drawing.Size(532, 124);
			this.PWADlist.TabIndex = 17;
			// 
			// UpPWADsButton
			// 
			this.UpPWADsButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
			this.UpPWADsButton.Location = new System.Drawing.Point(472, 134);
			this.UpPWADsButton.Name = "UpPWADsButton";
			this.UpPWADsButton.Size = new System.Drawing.Size(20, 20);
			this.UpPWADsButton.TabIndex = 18;
			this.UpPWADsButton.Text = "ᐱ";
			this.UpPWADsButton.UseVisualStyleBackColor = true;
			this.UpPWADsButton.Click += new System.EventHandler(this.UpPWADsButton_Click);
			// 
			// DownPWADsButton
			// 
			this.DownPWADsButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DownPWADsButton.Location = new System.Drawing.Point(446, 134);
			this.DownPWADsButton.Name = "DownPWADsButton";
			this.DownPWADsButton.Size = new System.Drawing.Size(20, 20);
			this.DownPWADsButton.TabIndex = 19;
			this.DownPWADsButton.Text = "ᐯ";
			this.DownPWADsButton.UseVisualStyleBackColor = true;
			this.DownPWADsButton.Click += new System.EventHandler(this.DownPWADsButton_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 346);
			this.Controls.Add(this.DownPWADsButton);
			this.Controls.Add(this.UpPWADsButton);
			this.Controls.Add(this.PWADlist);
			this.Controls.Add(this.RemPWADsButton);
			this.Controls.Add(this.RemIWADButton);
			this.Controls.Add(this.ZDoomSelComboBox);
			this.Controls.Add(this.AddPWADButton);
			this.Controls.Add(this.CustomParamLabel);
			this.Controls.Add(this.CustomParamBox);
			this.Controls.Add(this.groupBoxLaunchSettings);
			this.Controls.Add(this.AddIWADButton);
			this.Controls.Add(this.ReloadButton);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.PWlabel);
			this.Controls.Add(this.IWlabel);
			this.Controls.Add(this.IWADlist);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GZDoom Launcher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.groupBoxLaunchSettings.ResumeLayout(false);
			this.groupBoxLaunchSettings.PerformLayout();
			this.groupBoxMultiplayer.ResumeLayout(false);
			this.groupBoxMultiplayer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.HostNumber)).EndInit();
			this.groupBoxConfig.ResumeLayout(false);
			this.groupBoxConfig.PerformLayout();
			this.groupBoxGameplay.ResumeLayout(false);
			this.groupBoxGameplay.PerformLayout();
			this.groupBoxAudio.ResumeLayout(false);
			this.groupBoxAudio.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView IWADlist;
        private System.Windows.Forms.Label IWlabel;
        private System.Windows.Forms.Label PWlabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.CheckBox CloseOnStartButton;
        private System.Windows.Forms.Button AddIWADButton;
        private System.Windows.Forms.GroupBox groupBoxLaunchSettings;
        private System.Windows.Forms.GroupBox groupBoxAudio;
        private System.Windows.Forms.RadioButton radioNoMusic;
        private System.Windows.Forms.RadioButton radioNoSFX;
        private System.Windows.Forms.RadioButton radioNoSounds;
        private System.Windows.Forms.RadioButton radioAllSounds;
        private System.Windows.Forms.TextBox CustomParamBox;
        private System.Windows.Forms.Label CustomParamLabel;
        private System.Windows.Forms.GroupBox groupBoxGameplay;
        private System.Windows.Forms.Label LabelStartFrom;
        private System.Windows.Forms.TextBox StartFromBox;
        private System.Windows.Forms.ComboBox BoxSkillLvL;
        private System.Windows.Forms.Label LabelSkillLvL;
        private System.Windows.Forms.CheckBox MonstersRespawnButton;
        private System.Windows.Forms.CheckBox FastMonstersButton;
        private System.Windows.Forms.CheckBox NoMonstersButton;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Button ConfigExplorerSelectButton;
        private System.Windows.Forms.Label LabelConfigPath;
        private System.Windows.Forms.TextBox ConfigPathBox;
        private System.Windows.Forms.GroupBox groupBoxMultiplayer;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.NumericUpDown HostNumber;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.TextBox ConnectBox;
        private System.Windows.Forms.OpenFileDialog SelectFileDialog;
        private System.Windows.Forms.CheckBox DeathmatchButton;
        private System.Windows.Forms.CheckBox PacketServerButton;
        private System.Windows.Forms.ColumnHeader Icolumn;
        private System.Windows.Forms.Button AddPWADButton;
        private System.Windows.Forms.Button SaveProfileButton;
        private System.Windows.Forms.Button LoadProfileButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.ComboBox ZDoomSelComboBox;
        private System.Windows.Forms.Button RemIWADButton;
        private System.Windows.Forms.Button RemPWADsButton;
		private System.Windows.Forms.CheckedListBox PWADlist;
		private System.Windows.Forms.Button UpPWADsButton;
		private System.Windows.Forms.Button DownPWADsButton;
	}
}

