namespace QConverter {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.decimal_Label = new MetroFramework.Controls.MetroLabel();
            this.decimal_TextBox = new System.Windows.Forms.TextBox();
            this.octal_Label = new MetroFramework.Controls.MetroLabel();
            this.hexLabel = new MetroFramework.Controls.MetroLabel();
            this.binaryLabel = new MetroFramework.Controls.MetroLabel();
            this.octal_TextBox = new System.Windows.Forms.TextBox();
            this.hex_TextBox = new System.Windows.Forms.TextBox();
            this.binary_TextBox = new System.Windows.Forms.TextBox();
            this.main_TabControl = new MetroFramework.Controls.MetroTabControl();
            this.patternScan_Tab = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.scanInput1Box = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.scanSelect1Btn = new MetroFramework.Controls.MetroButton();
            this.scanArchBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scanRangeBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.scanSizeBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.findPatternBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.scanPatternBox = new MetroFramework.Controls.MetroTextBox();
            this.createPatternBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.scanOffsetBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataConverter_Tab = new System.Windows.Forms.TabPage();
            this.dataConverter_Panel = new System.Windows.Forms.Panel();
            this.loadBinaryFile_Button = new MetroFramework.Controls.MetroButton();
            this.dataConvertStatus_Label = new MetroFramework.Controls.MetroLabel();
            this.float_TextBox = new System.Windows.Forms.TextBox();
            this.float_Label = new MetroFramework.Controls.MetroLabel();
            this.base64_TextBox = new System.Windows.Forms.TextBox();
            this.rawBytes_Label = new MetroFramework.Controls.MetroLabel();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.string_Label = new MetroFramework.Controls.MetroLabel();
            this.bytesTextBox = new System.Windows.Forms.TextBox();
            this.base64_Label = new MetroFramework.Controls.MetroLabel();
            this.stringEncoding_ComboBox = new System.Windows.Forms.ComboBox();
            this.asmDisasm_Tab = new System.Windows.Forms.TabPage();
            this.asmStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.asmAction_ComboBox = new System.Windows.Forms.ComboBox();
            this.asmArch_ComboBox = new System.Windows.Forms.ComboBox();
            this.asmInput_ComboBox = new System.Windows.Forms.RichTextBox();
            this.asmCodeLabel = new MetroFramework.Controls.MetroLabel();
            this.hexDataLabel = new MetroFramework.Controls.MetroLabel();
            this.asmResult_ComboBox = new System.Windows.Forms.RichTextBox();
            this.codeConverter_Tab = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.codeRealTime_CheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.codeInput_TextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.convertCodeButton = new MetroFramework.Controls.MetroButton();
            this.scrCodeLabel = new MetroFramework.Controls.MetroLabel();
            this.convertMode_ComboBox = new System.Windows.Forms.ComboBox();
            this.codeResult_TextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.codeResult_Label = new MetroFramework.Controls.MetroLabel();
            this.IlExplorer_Tab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ilRealTime_CheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.sourceCodeBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.loadCodeButton = new MetroFramework.Controls.MetroButton();
            this.ilDasmButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.langBox = new System.Windows.Forms.ComboBox();
            this.stackTabs_CheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.ilCodeBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.loadBinary_Button = new MetroFramework.Controls.MetroButton();
            this.about_Tab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_PictureBox = new System.Windows.Forms.PictureBox();
            this.market_Link = new MetroFramework.Controls.MetroLink();
            this.about_Label = new MetroFramework.Controls.MetroLabel();
            this.github_Link = new MetroFramework.Controls.MetroLink();
            this.contact_Label = new MetroFramework.Controls.MetroLabel();
            this.telegram_Link = new MetroFramework.Controls.MetroLink();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.typingTimer = new System.Windows.Forms.Timer(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayWindow_Button = new System.Windows.Forms.PictureBox();
            this.pinWindow_Button = new System.Windows.Forms.PictureBox();
            this.opacity_TrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.main_TabControl.SuspendLayout();
            this.patternScan_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.dataConverter_Tab.SuspendLayout();
            this.dataConverter_Panel.SuspendLayout();
            this.asmDisasm_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.codeConverter_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeInput_TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeResult_TextBox)).BeginInit();
            this.IlExplorer_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCodeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilCodeBox)).BeginInit();
            this.about_Tab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayWindow_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinWindow_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // decimal_Label
            // 
            this.decimal_Label.AutoSize = true;
            this.decimal_Label.Location = new System.Drawing.Point(12, 10);
            this.decimal_Label.Name = "decimal_Label";
            this.decimal_Label.Size = new System.Drawing.Size(96, 19);
            this.decimal_Label.TabIndex = 0;
            this.decimal_Label.Text = "Int32 (Decimal)";
            this.decimal_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.decimal_Label.UseCustomBackColor = true;
            // 
            // decimal_TextBox
            // 
            this.decimal_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decimal_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.decimal_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decimal_TextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.decimal_TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.decimal_TextBox.Location = new System.Drawing.Point(151, 10);
            this.decimal_TextBox.Name = "decimal_TextBox";
            this.decimal_TextBox.Size = new System.Drawing.Size(124, 21);
            this.decimal_TextBox.TabIndex = 1;
            this.decimal_TextBox.Tag = "Decimal";
            this.decimal_TextBox.TextChanged += new System.EventHandler(this.decimalTextBox_TextChanged);
            // 
            // octal_Label
            // 
            this.octal_Label.AutoSize = true;
            this.octal_Label.Location = new System.Drawing.Point(12, 38);
            this.octal_Label.Name = "octal_Label";
            this.octal_Label.Size = new System.Drawing.Size(80, 19);
            this.octal_Label.TabIndex = 2;
            this.octal_Label.Text = "Int32 (Octal)";
            this.octal_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.octal_Label.UseCustomBackColor = true;
            // 
            // hexLabel
            // 
            this.hexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(291, 10);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(124, 19);
            this.hexLabel.TabIndex = 3;
            this.hexLabel.Text = "Int32 (Hexadecimal)";
            this.hexLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hexLabel.UseCustomBackColor = true;
            // 
            // binaryLabel
            // 
            this.binaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.binaryLabel.AutoSize = true;
            this.binaryLabel.Location = new System.Drawing.Point(291, 38);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.Size = new System.Drawing.Size(86, 19);
            this.binaryLabel.TabIndex = 4;
            this.binaryLabel.Text = "Int32 (Binary)";
            this.binaryLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.binaryLabel.UseCustomBackColor = true;
            // 
            // octal_TextBox
            // 
            this.octal_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.octal_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.octal_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.octal_TextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.octal_TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.octal_TextBox.Location = new System.Drawing.Point(151, 38);
            this.octal_TextBox.Name = "octal_TextBox";
            this.octal_TextBox.Size = new System.Drawing.Size(124, 21);
            this.octal_TextBox.TabIndex = 5;
            this.octal_TextBox.Tag = "Octal";
            this.octal_TextBox.TextChanged += new System.EventHandler(this.decimalTextBox_TextChanged);
            // 
            // hex_TextBox
            // 
            this.hex_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hex_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.hex_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hex_TextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.hex_TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.hex_TextBox.Location = new System.Drawing.Point(430, 10);
            this.hex_TextBox.Name = "hex_TextBox";
            this.hex_TextBox.Size = new System.Drawing.Size(124, 21);
            this.hex_TextBox.TabIndex = 6;
            this.hex_TextBox.Tag = "Hexademical";
            this.hex_TextBox.TextChanged += new System.EventHandler(this.decimalTextBox_TextChanged);
            // 
            // binary_TextBox
            // 
            this.binary_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.binary_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.binary_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.binary_TextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.binary_TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.binary_TextBox.Location = new System.Drawing.Point(430, 38);
            this.binary_TextBox.Name = "binary_TextBox";
            this.binary_TextBox.Size = new System.Drawing.Size(124, 21);
            this.binary_TextBox.TabIndex = 7;
            this.binary_TextBox.Tag = "Binary";
            this.binary_TextBox.TextChanged += new System.EventHandler(this.decimalTextBox_TextChanged);
            // 
            // main_TabControl
            // 
            this.main_TabControl.AllowDrop = true;
            this.main_TabControl.Controls.Add(this.dataConverter_Tab);
            this.main_TabControl.Controls.Add(this.asmDisasm_Tab);
            this.main_TabControl.Controls.Add(this.IlExplorer_Tab);
            this.main_TabControl.Controls.Add(this.codeConverter_Tab);
            this.main_TabControl.Controls.Add(this.patternScan_Tab);
            this.main_TabControl.Controls.Add(this.about_Tab);
            this.main_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_TabControl.Location = new System.Drawing.Point(20, 60);
            this.main_TabControl.Name = "main_TabControl";
            this.main_TabControl.SelectedIndex = 0;
            this.main_TabControl.Size = new System.Drawing.Size(592, 324);
            this.main_TabControl.Style = MetroFramework.MetroColorStyle.White;
            this.main_TabControl.TabIndex = 8;
            this.main_TabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.main_TabControl.UseSelectable = true;
            // 
            // patternScan_Tab
            // 
            this.patternScan_Tab.BackColor = System.Drawing.Color.Black;
            this.patternScan_Tab.Controls.Add(this.splitContainer3);
            this.patternScan_Tab.ForeColor = System.Drawing.Color.DarkGray;
            this.patternScan_Tab.Location = new System.Drawing.Point(4, 38);
            this.patternScan_Tab.Name = "patternScan_Tab";
            this.patternScan_Tab.Size = new System.Drawing.Size(584, 282);
            this.patternScan_Tab.TabIndex = 5;
            this.patternScan_Tab.Text = "Pattern scanner";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer3.Size = new System.Drawing.Size(584, 282);
            this.splitContainer3.SplitterDistance = 161;
            this.splitContainer3.TabIndex = 23;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.metroLabel8);
            this.splitContainer4.Panel1.Controls.Add(this.scanInput1Box);
            this.splitContainer4.Panel1.Controls.Add(this.metroLabel9);
            this.splitContainer4.Panel1.Controls.Add(this.scanSelect1Btn);
            this.splitContainer4.Panel1.Controls.Add(this.scanArchBox);
            this.splitContainer4.Panel1.Font = new System.Drawing.Font("Consolas", 9F);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer4.Size = new System.Drawing.Size(584, 161);
            this.splitContainer4.SplitterDistance = 41;
            this.splitContainer4.TabIndex = 65;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Location = new System.Drawing.Point(3, 9);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(83, 23);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 67;
            this.metroLabel8.Text = "Input binary";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // scanInput1Box
            // 
            this.scanInput1Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scanInput1Box.Lines = new string[0];
            this.scanInput1Box.Location = new System.Drawing.Point(92, 9);
            this.scanInput1Box.MaxLength = 32767;
            this.scanInput1Box.Name = "scanInput1Box";
            this.scanInput1Box.PasswordChar = '\0';
            this.scanInput1Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scanInput1Box.SelectedText = "";
            this.scanInput1Box.Size = new System.Drawing.Size(205, 23);
            this.scanInput1Box.TabIndex = 68;
            this.scanInput1Box.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.scanInput1Box.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.Location = new System.Drawing.Point(386, 9);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(83, 23);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel9.TabIndex = 70;
            this.metroLabel9.Text = "Architecture";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // scanSelect1Btn
            // 
            this.scanSelect1Btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.scanSelect1Btn.Location = new System.Drawing.Point(303, 9);
            this.scanSelect1Btn.Name = "scanSelect1Btn";
            this.scanSelect1Btn.Size = new System.Drawing.Size(77, 23);
            this.scanSelect1Btn.Style = MetroFramework.MetroColorStyle.Black;
            this.scanSelect1Btn.TabIndex = 66;
            this.scanSelect1Btn.Text = "Select file";
            this.scanSelect1Btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.scanSelect1Btn.UseSelectable = true;
            this.scanSelect1Btn.Click += new System.EventHandler(this.scanInput1Button_Click);
            // 
            // scanArchBox
            // 
            this.scanArchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scanArchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.scanArchBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanArchBox.ForeColor = System.Drawing.Color.LightGray;
            this.scanArchBox.Items.AddRange(new object[] {
            "ARM",
            "ARM64",
            "X86",
            "X86_64"});
            this.scanArchBox.Location = new System.Drawing.Point(475, 11);
            this.scanArchBox.Name = "scanArchBox";
            this.scanArchBox.Size = new System.Drawing.Size(93, 22);
            this.scanArchBox.TabIndex = 69;
            this.scanArchBox.Text = "X86";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scanRangeBox);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.scanSizeBox);
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.findPatternBtn);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.scanPatternBox);
            this.groupBox1.Controls.Add(this.createPatternBtn);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.scanOffsetBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 116);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pattern maker";
            // 
            // scanRangeBox
            // 
            this.scanRangeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scanRangeBox.Lines = new string[] {
        "1024"};
            this.scanRangeBox.Location = new System.Drawing.Point(475, 46);
            this.scanRangeBox.MaxLength = 32767;
            this.scanRangeBox.Name = "scanRangeBox";
            this.scanRangeBox.PasswordChar = '\0';
            this.scanRangeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scanRangeBox.SelectedText = "";
            this.scanRangeBox.Size = new System.Drawing.Size(93, 23);
            this.scanRangeBox.TabIndex = 72;
            this.scanRangeBox.Text = "1024";
            this.scanRangeBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.scanRangeBox.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.Location = new System.Drawing.Point(407, 46);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 23);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 71;
            this.metroLabel3.Text = "Range";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(215, 16);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(124, 23);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 61;
            this.metroLabel7.Text = " Pattern size (bytes)";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // scanSizeBox
            // 
            this.scanSizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanSizeBox.Lines = new string[] {
        "64"};
            this.scanSizeBox.Location = new System.Drawing.Point(346, 16);
            this.scanSizeBox.MaxLength = 32767;
            this.scanSizeBox.Name = "scanSizeBox";
            this.scanSizeBox.PasswordChar = '\0';
            this.scanSizeBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scanSizeBox.SelectedText = "";
            this.scanSizeBox.Size = new System.Drawing.Size(55, 23);
            this.scanSizeBox.TabIndex = 63;
            this.scanSizeBox.Text = "64";
            this.scanSizeBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.scanSizeBox.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextBox1.Lines = new string[] {
        "256"};
            this.metroTextBox1.Location = new System.Drawing.Point(475, 16);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(93, 23);
            this.metroTextBox1.TabIndex = 70;
            this.metroTextBox1.Text = "256";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel12.Location = new System.Drawing.Point(407, 16);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(62, 23);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel12.TabIndex = 69;
            this.metroLabel12.Text = "Filter";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // findPatternBtn
            // 
            this.findPatternBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.findPatternBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.findPatternBtn.Location = new System.Drawing.Point(291, 76);
            this.findPatternBtn.Name = "findPatternBtn";
            this.findPatternBtn.Size = new System.Drawing.Size(118, 26);
            this.findPatternBtn.Style = MetroFramework.MetroColorStyle.Black;
            this.findPatternBtn.TabIndex = 68;
            this.findPatternBtn.Text = "Find pattern";
            this.findPatternBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.findPatternBtn.UseSelectable = true;
            this.findPatternBtn.Click += new System.EventHandler(this.findPatternButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(11, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 23);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 67;
            this.metroLabel2.Text = "Pattern";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // scanPatternBox
            // 
            this.scanPatternBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scanPatternBox.Lines = new string[0];
            this.scanPatternBox.Location = new System.Drawing.Point(116, 46);
            this.scanPatternBox.MaxLength = 32767;
            this.scanPatternBox.Name = "scanPatternBox";
            this.scanPatternBox.PasswordChar = '\0';
            this.scanPatternBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scanPatternBox.SelectedText = "";
            this.scanPatternBox.Size = new System.Drawing.Size(285, 23);
            this.scanPatternBox.TabIndex = 66;
            this.scanPatternBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.scanPatternBox.UseSelectable = true;
            // 
            // createPatternBtn
            // 
            this.createPatternBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createPatternBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.createPatternBtn.Location = new System.Drawing.Point(170, 76);
            this.createPatternBtn.Name = "createPatternBtn";
            this.createPatternBtn.Size = new System.Drawing.Size(115, 26);
            this.createPatternBtn.Style = MetroFramework.MetroColorStyle.Black;
            this.createPatternBtn.TabIndex = 64;
            this.createPatternBtn.Text = "Create pattern";
            this.createPatternBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.createPatternBtn.UseSelectable = true;
            this.createPatternBtn.Click += new System.EventHandler(this.createPatternButton_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(11, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 23);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel6.TabIndex = 62;
            this.metroLabel6.Text = "Offset (HEX)";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // scanOffsetBox
            // 
            this.scanOffsetBox.Lines = new string[] {
        "0xFF"};
            this.scanOffsetBox.Location = new System.Drawing.Point(116, 16);
            this.scanOffsetBox.MaxLength = 32767;
            this.scanOffsetBox.Name = "scanOffsetBox";
            this.scanOffsetBox.PasswordChar = '\0';
            this.scanOffsetBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scanOffsetBox.SelectedText = "";
            this.scanOffsetBox.Size = new System.Drawing.Size(92, 23);
            this.scanOffsetBox.TabIndex = 60;
            this.scanOffsetBox.Text = "0xFF";
            this.scanOffsetBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.scanOffsetBox.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 117);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pattern scanner";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel1.Location = new System.Drawing.Point(3, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(578, 96);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 71;
            this.metroLabel1.Text = "Comming soon";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // dataConverter_Tab
            // 
            this.dataConverter_Tab.BackColor = System.Drawing.Color.Black;
            this.dataConverter_Tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataConverter_Tab.Controls.Add(this.dataConverter_Panel);
            this.dataConverter_Tab.Location = new System.Drawing.Point(4, 38);
            this.dataConverter_Tab.Name = "dataConverter_Tab";
            this.dataConverter_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.dataConverter_Tab.Size = new System.Drawing.Size(584, 282);
            this.dataConverter_Tab.TabIndex = 0;
            this.dataConverter_Tab.Text = "Data converter";
            // 
            // dataConverter_Panel
            // 
            this.dataConverter_Panel.AllowDrop = true;
            this.dataConverter_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataConverter_Panel.Controls.Add(this.loadBinaryFile_Button);
            this.dataConverter_Panel.Controls.Add(this.dataConvertStatus_Label);
            this.dataConverter_Panel.Controls.Add(this.float_TextBox);
            this.dataConverter_Panel.Controls.Add(this.float_Label);
            this.dataConverter_Panel.Controls.Add(this.decimal_Label);
            this.dataConverter_Panel.Controls.Add(this.hex_TextBox);
            this.dataConverter_Panel.Controls.Add(this.base64_TextBox);
            this.dataConverter_Panel.Controls.Add(this.binaryLabel);
            this.dataConverter_Panel.Controls.Add(this.rawBytes_Label);
            this.dataConverter_Panel.Controls.Add(this.stringTextBox);
            this.dataConverter_Panel.Controls.Add(this.octal_Label);
            this.dataConverter_Panel.Controls.Add(this.decimal_TextBox);
            this.dataConverter_Panel.Controls.Add(this.string_Label);
            this.dataConverter_Panel.Controls.Add(this.bytesTextBox);
            this.dataConverter_Panel.Controls.Add(this.hexLabel);
            this.dataConverter_Panel.Controls.Add(this.base64_Label);
            this.dataConverter_Panel.Controls.Add(this.stringEncoding_ComboBox);
            this.dataConverter_Panel.Controls.Add(this.octal_TextBox);
            this.dataConverter_Panel.Controls.Add(this.binary_TextBox);
            this.dataConverter_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataConverter_Panel.Location = new System.Drawing.Point(3, 3);
            this.dataConverter_Panel.Name = "dataConverter_Panel";
            this.dataConverter_Panel.Size = new System.Drawing.Size(576, 274);
            this.dataConverter_Panel.TabIndex = 20;
            this.dataConverter_Panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataConverter_Panel_DragDrop);
            this.dataConverter_Panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataConverter_Panel_DragEnter);
            // 
            // loadBinaryFile_Button
            // 
            this.loadBinaryFile_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadBinaryFile_Button.Location = new System.Drawing.Point(465, 150);
            this.loadBinaryFile_Button.Name = "loadBinaryFile_Button";
            this.loadBinaryFile_Button.Size = new System.Drawing.Size(89, 20);
            this.loadBinaryFile_Button.Style = MetroFramework.MetroColorStyle.Black;
            this.loadBinaryFile_Button.TabIndex = 67;
            this.loadBinaryFile_Button.Text = "Load file";
            this.loadBinaryFile_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadBinaryFile_Button.UseSelectable = true;
            // 
            // dataConvertStatus_Label
            // 
            this.dataConvertStatus_Label.BackColor = System.Drawing.Color.Transparent;
            this.dataConvertStatus_Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataConvertStatus_Label.Location = new System.Drawing.Point(0, 252);
            this.dataConvertStatus_Label.Name = "dataConvertStatus_Label";
            this.dataConvertStatus_Label.Size = new System.Drawing.Size(574, 20);
            this.dataConvertStatus_Label.TabIndex = 22;
            this.dataConvertStatus_Label.Text = "Status: None";
            this.dataConvertStatus_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dataConvertStatus_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // float_TextBox
            // 
            this.float_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.float_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.float_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.float_TextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.float_TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.float_TextBox.Location = new System.Drawing.Point(151, 68);
            this.float_TextBox.Name = "float_TextBox";
            this.float_TextBox.Size = new System.Drawing.Size(124, 21);
            this.float_TextBox.TabIndex = 21;
            this.float_TextBox.Tag = "Float";
            this.float_TextBox.TextChanged += new System.EventHandler(this.decimalTextBox_TextChanged);
            // 
            // float_Label
            // 
            this.float_Label.AutoSize = true;
            this.float_Label.Location = new System.Drawing.Point(12, 66);
            this.float_Label.Name = "float_Label";
            this.float_Label.Size = new System.Drawing.Size(38, 19);
            this.float_Label.TabIndex = 20;
            this.float_Label.Text = "Float";
            this.float_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.float_Label.UseCustomBackColor = true;
            // 
            // base64_TextBox
            // 
            this.base64_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.base64_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.base64_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.base64_TextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.base64_TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.base64_TextBox.Location = new System.Drawing.Point(151, 123);
            this.base64_TextBox.MaxLength = 512000;
            this.base64_TextBox.Name = "base64_TextBox";
            this.base64_TextBox.Size = new System.Drawing.Size(403, 21);
            this.base64_TextBox.TabIndex = 15;
            this.base64_TextBox.Tag = "Base64";
            this.base64_TextBox.TextChanged += new System.EventHandler(this.decimalTextBox_TextChanged);
            // 
            // rawBytes_Label
            // 
            this.rawBytes_Label.AutoSize = true;
            this.rawBytes_Label.Location = new System.Drawing.Point(12, 150);
            this.rawBytes_Label.Name = "rawBytes_Label";
            this.rawBytes_Label.Size = new System.Drawing.Size(67, 19);
            this.rawBytes_Label.TabIndex = 12;
            this.rawBytes_Label.Text = "Raw bytes";
            this.rawBytes_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rawBytes_Label.UseCustomBackColor = true;
            // 
            // stringTextBox
            // 
            this.stringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stringTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.stringTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stringTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.stringTextBox.Location = new System.Drawing.Point(151, 97);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(308, 20);
            this.stringTextBox.TabIndex = 9;
            this.stringTextBox.Tag = "String";
            this.stringTextBox.TextChanged += new System.EventHandler(this.decimalTextBox_TextChanged);
            // 
            // string_Label
            // 
            this.string_Label.AutoSize = true;
            this.string_Label.Location = new System.Drawing.Point(12, 97);
            this.string_Label.Name = "string_Label";
            this.string_Label.Size = new System.Drawing.Size(43, 19);
            this.string_Label.TabIndex = 8;
            this.string_Label.Text = "String";
            this.string_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.string_Label.UseCustomBackColor = true;
            // 
            // bytesTextBox
            // 
            this.bytesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bytesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bytesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bytesTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.bytesTextBox.Location = new System.Drawing.Point(151, 150);
            this.bytesTextBox.MaxLength = 512000;
            this.bytesTextBox.Name = "bytesTextBox";
            this.bytesTextBox.Size = new System.Drawing.Size(308, 20);
            this.bytesTextBox.TabIndex = 16;
            this.bytesTextBox.Tag = "Bytes";
            this.bytesTextBox.TextChanged += new System.EventHandler(this.decimalTextBox_TextChanged);
            // 
            // base64_Label
            // 
            this.base64_Label.AutoSize = true;
            this.base64_Label.Location = new System.Drawing.Point(12, 123);
            this.base64_Label.Name = "base64_Label";
            this.base64_Label.Size = new System.Drawing.Size(50, 19);
            this.base64_Label.TabIndex = 11;
            this.base64_Label.Text = "Base64";
            this.base64_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.base64_Label.UseCustomBackColor = true;
            // 
            // stringEncoding_ComboBox
            // 
            this.stringEncoding_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stringEncoding_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.stringEncoding_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stringEncoding_ComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.stringEncoding_ComboBox.FormattingEnabled = true;
            this.stringEncoding_ComboBox.Location = new System.Drawing.Point(465, 96);
            this.stringEncoding_ComboBox.Name = "stringEncoding_ComboBox";
            this.stringEncoding_ComboBox.Size = new System.Drawing.Size(89, 21);
            this.stringEncoding_ComboBox.TabIndex = 10;
            this.stringEncoding_ComboBox.Text = "ascii";
            this.stringEncoding_ComboBox.SelectedIndexChanged += new System.EventHandler(this.encodingComboBox_SelectedIndexChanged);
            // 
            // asmDisasm_Tab
            // 
            this.asmDisasm_Tab.BackColor = System.Drawing.Color.Black;
            this.asmDisasm_Tab.Controls.Add(this.asmStatusLabel);
            this.asmDisasm_Tab.Controls.Add(this.splitContainer1);
            this.asmDisasm_Tab.Location = new System.Drawing.Point(4, 38);
            this.asmDisasm_Tab.Name = "asmDisasm_Tab";
            this.asmDisasm_Tab.Size = new System.Drawing.Size(584, 282);
            this.asmDisasm_Tab.TabIndex = 2;
            this.asmDisasm_Tab.Text = "Asm/Disasm";
            // 
            // asmStatusLabel
            // 
            this.asmStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.asmStatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.asmStatusLabel.Location = new System.Drawing.Point(0, 263);
            this.asmStatusLabel.Name = "asmStatusLabel";
            this.asmStatusLabel.Size = new System.Drawing.Size(584, 19);
            this.asmStatusLabel.TabIndex = 17;
            this.asmStatusLabel.Text = "Status: None";
            this.asmStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.asmStatusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.asmAction_ComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.asmArch_ComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.asmInput_ComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.asmCodeLabel);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Consolas", 9F);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.hexDataLabel);
            this.splitContainer1.Panel2.Controls.Add(this.asmResult_ComboBox);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Consolas", 9F);
            this.splitContainer1.Size = new System.Drawing.Size(584, 282);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 19;
            // 
            // asmAction_ComboBox
            // 
            this.asmAction_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.asmAction_ComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ARM",
            "ARM64",
            "X86",
            "X86_64"});
            this.asmAction_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.asmAction_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asmAction_ComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.asmAction_ComboBox.FormattingEnabled = true;
            this.asmAction_ComboBox.Items.AddRange(new object[] {
            "Assemble",
            "Disassemble"});
            this.asmAction_ComboBox.Location = new System.Drawing.Point(110, 8);
            this.asmAction_ComboBox.Name = "asmAction_ComboBox";
            this.asmAction_ComboBox.Size = new System.Drawing.Size(82, 22);
            this.asmAction_ComboBox.TabIndex = 17;
            this.asmAction_ComboBox.Text = "Assemble";
            // 
            // asmArch_ComboBox
            // 
            this.asmArch_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.asmArch_ComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ARM",
            "ARM64",
            "X86",
            "X86_64"});
            this.asmArch_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.asmArch_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.asmArch_ComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.asmArch_ComboBox.FormattingEnabled = true;
            this.asmArch_ComboBox.Location = new System.Drawing.Point(198, 8);
            this.asmArch_ComboBox.Name = "asmArch_ComboBox";
            this.asmArch_ComboBox.Size = new System.Drawing.Size(82, 22);
            this.asmArch_ComboBox.TabIndex = 16;
            this.asmArch_ComboBox.Text = "X86";
            this.asmArch_ComboBox.SelectedIndexChanged += new System.EventHandler(this.archComboBox_SelectedIndexChanged);
            // 
            // asmInput_ComboBox
            // 
            this.asmInput_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asmInput_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.asmInput_ComboBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asmInput_ComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.asmInput_ComboBox.Location = new System.Drawing.Point(15, 35);
            this.asmInput_ComboBox.Name = "asmInput_ComboBox";
            this.asmInput_ComboBox.Size = new System.Drawing.Size(265, 216);
            this.asmInput_ComboBox.TabIndex = 12;
            this.asmInput_ComboBox.Text = "";
            this.asmInput_ComboBox.TextChanged += new System.EventHandler(this.asmCodeBox_TextChanged);
            // 
            // asmCodeLabel
            // 
            this.asmCodeLabel.AutoSize = true;
            this.asmCodeLabel.Location = new System.Drawing.Point(12, 10);
            this.asmCodeLabel.Name = "asmCodeLabel";
            this.asmCodeLabel.Size = new System.Drawing.Size(38, 19);
            this.asmCodeLabel.TabIndex = 13;
            this.asmCodeLabel.Text = "Input";
            this.asmCodeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.asmCodeLabel.UseCustomBackColor = true;
            // 
            // hexDataLabel
            // 
            this.hexDataLabel.AutoSize = true;
            this.hexDataLabel.Location = new System.Drawing.Point(10, 10);
            this.hexDataLabel.Name = "hexDataLabel";
            this.hexDataLabel.Size = new System.Drawing.Size(43, 19);
            this.hexDataLabel.TabIndex = 2;
            this.hexDataLabel.Text = "Result";
            this.hexDataLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hexDataLabel.UseCustomBackColor = true;
            // 
            // asmResult_ComboBox
            // 
            this.asmResult_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asmResult_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.asmResult_ComboBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.asmResult_ComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.asmResult_ComboBox.Location = new System.Drawing.Point(10, 35);
            this.asmResult_ComboBox.Name = "asmResult_ComboBox";
            this.asmResult_ComboBox.ReadOnly = true;
            this.asmResult_ComboBox.Size = new System.Drawing.Size(268, 216);
            this.asmResult_ComboBox.TabIndex = 14;
            this.asmResult_ComboBox.Text = "";
            // 
            // codeConverter_Tab
            // 
            this.codeConverter_Tab.BackColor = System.Drawing.Color.Black;
            this.codeConverter_Tab.Controls.Add(this.splitContainer5);
            this.codeConverter_Tab.Location = new System.Drawing.Point(4, 38);
            this.codeConverter_Tab.Name = "codeConverter_Tab";
            this.codeConverter_Tab.Size = new System.Drawing.Size(584, 282);
            this.codeConverter_Tab.TabIndex = 6;
            this.codeConverter_Tab.Text = "C#/VB.NET Converter";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.codeRealTime_CheckBox);
            this.splitContainer5.Panel1.Controls.Add(this.codeInput_TextBox);
            this.splitContainer5.Panel1.Controls.Add(this.metroButton4);
            this.splitContainer5.Panel1.Controls.Add(this.convertCodeButton);
            this.splitContainer5.Panel1.Controls.Add(this.scrCodeLabel);
            this.splitContainer5.Panel1.Controls.Add(this.convertMode_ComboBox);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.codeResult_TextBox);
            this.splitContainer5.Panel2.Controls.Add(this.codeResult_Label);
            this.splitContainer5.Size = new System.Drawing.Size(584, 282);
            this.splitContainer5.SplitterDistance = 294;
            this.splitContainer5.TabIndex = 23;
            // 
            // codeRealTime_CheckBox
            // 
            this.codeRealTime_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.codeRealTime_CheckBox.AutoSize = true;
            this.codeRealTime_CheckBox.BackColor = System.Drawing.Color.Transparent;
            this.codeRealTime_CheckBox.ForeColor = System.Drawing.Color.LightGray;
            this.codeRealTime_CheckBox.Location = new System.Drawing.Point(111, 256);
            this.codeRealTime_CheckBox.Name = "codeRealTime_CheckBox";
            this.codeRealTime_CheckBox.Size = new System.Drawing.Size(74, 15);
            this.codeRealTime_CheckBox.TabIndex = 75;
            this.codeRealTime_CheckBox.Text = "Real-time";
            this.codeRealTime_CheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.codeRealTime_CheckBox.UseSelectable = true;
            this.codeRealTime_CheckBox.CheckedChanged += new System.EventHandler(this.onRealTimeEnabled_Checked);
            // 
            // codeInput_TextBox
            // 
            this.codeInput_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeInput_TextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeInput_TextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.codeInput_TextBox.AutoScrollMinSize = new System.Drawing.Size(226, 98);
            this.codeInput_TextBox.BackBrush = null;
            this.codeInput_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.codeInput_TextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.codeInput_TextBox.CharHeight = 14;
            this.codeInput_TextBox.CharWidth = 8;
            this.codeInput_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeInput_TextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeInput_TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.codeInput_TextBox.IndentBackColor = System.Drawing.Color.DimGray;
            this.codeInput_TextBox.IsReplaceMode = false;
            this.codeInput_TextBox.Language = FastColoredTextBoxNS.Language.CSharp;
            this.codeInput_TextBox.LeftBracket = '(';
            this.codeInput_TextBox.LeftBracket2 = '{';
            this.codeInput_TextBox.LineNumberColor = System.Drawing.Color.LightGray;
            this.codeInput_TextBox.Location = new System.Drawing.Point(15, 40);
            this.codeInput_TextBox.Name = "codeInput_TextBox";
            this.codeInput_TextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeInput_TextBox.RightBracket = ')';
            this.codeInput_TextBox.RightBracket2 = '}';
            this.codeInput_TextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.codeInput_TextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeInput_TextBox.ServiceColors")));
            this.codeInput_TextBox.Size = new System.Drawing.Size(266, 206);
            this.codeInput_TextBox.TabIndex = 71;
            this.codeInput_TextBox.Text = "using System;\r\n\r\nclass Program {\r\n public static void Main() {\r\n\r\n }\r\n}";
            this.codeInput_TextBox.Zoom = 100;
            this.codeInput_TextBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.sourceCodeInputBox_TextChanged);
            // 
            // metroButton4
            // 
            this.metroButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.Location = new System.Drawing.Point(15, 252);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(86, 21);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton4.TabIndex = 72;
            this.metroButton4.Text = "Load code";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            // 
            // convertCodeButton
            // 
            this.convertCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.convertCodeButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.convertCodeButton.Location = new System.Drawing.Point(195, 252);
            this.convertCodeButton.Name = "convertCodeButton";
            this.convertCodeButton.Size = new System.Drawing.Size(86, 21);
            this.convertCodeButton.Style = MetroFramework.MetroColorStyle.Black;
            this.convertCodeButton.TabIndex = 71;
            this.convertCodeButton.Text = "Convert";
            this.convertCodeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.convertCodeButton.UseSelectable = true;
            this.convertCodeButton.Click += new System.EventHandler(this.convertCodeButton_Click);
            // 
            // scrCodeLabel
            // 
            this.scrCodeLabel.Location = new System.Drawing.Point(12, 10);
            this.scrCodeLabel.Name = "scrCodeLabel";
            this.scrCodeLabel.Size = new System.Drawing.Size(85, 23);
            this.scrCodeLabel.TabIndex = 2;
            this.scrCodeLabel.Text = "Source Code";
            this.scrCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scrCodeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.scrCodeLabel.UseCustomBackColor = true;
            // 
            // convertMode_ComboBox
            // 
            this.convertMode_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.convertMode_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.convertMode_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertMode_ComboBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertMode_ComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.convertMode_ComboBox.Items.AddRange(new object[] {
            "C# -> VB.NET",
            "VB.NET -> C#"});
            this.convertMode_ComboBox.Location = new System.Drawing.Point(131, 10);
            this.convertMode_ComboBox.Name = "convertMode_ComboBox";
            this.convertMode_ComboBox.Size = new System.Drawing.Size(149, 22);
            this.convertMode_ComboBox.TabIndex = 18;
            this.convertMode_ComboBox.Text = "C# -> VB.NET";
            this.convertMode_ComboBox.SelectedValueChanged += new System.EventHandler(this.convertModeBox_SelectedValueChanged);
            // 
            // codeResult_TextBox
            // 
            this.codeResult_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeResult_TextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeResult_TextBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.\\(\\)]+\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.codeResult_TextBox.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.codeResult_TextBox.BackBrush = null;
            this.codeResult_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.codeResult_TextBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.codeResult_TextBox.CharHeight = 14;
            this.codeResult_TextBox.CharWidth = 8;
            this.codeResult_TextBox.CommentPrefix = "\'";
            this.codeResult_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeResult_TextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeResult_TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.codeResult_TextBox.IndentBackColor = System.Drawing.Color.DimGray;
            this.codeResult_TextBox.IsReplaceMode = false;
            this.codeResult_TextBox.Language = FastColoredTextBoxNS.Language.VB;
            this.codeResult_TextBox.LeftBracket = '(';
            this.codeResult_TextBox.LineNumberColor = System.Drawing.Color.LightGray;
            this.codeResult_TextBox.Location = new System.Drawing.Point(10, 40);
            this.codeResult_TextBox.Name = "codeResult_TextBox";
            this.codeResult_TextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.codeResult_TextBox.ReadOnly = true;
            this.codeResult_TextBox.RightBracket = ')';
            this.codeResult_TextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.codeResult_TextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeResult_TextBox.ServiceColors")));
            this.codeResult_TextBox.Size = new System.Drawing.Size(266, 206);
            this.codeResult_TextBox.TabIndex = 72;
            this.codeResult_TextBox.Zoom = 100;
            // 
            // codeResult_Label
            // 
            this.codeResult_Label.Location = new System.Drawing.Point(10, 10);
            this.codeResult_Label.Name = "codeResult_Label";
            this.codeResult_Label.Size = new System.Drawing.Size(54, 19);
            this.codeResult_Label.TabIndex = 13;
            this.codeResult_Label.Text = "Result";
            this.codeResult_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.codeResult_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.codeResult_Label.UseCustomBackColor = true;
            // 
            // IlExplorer_Tab
            // 
            this.IlExplorer_Tab.BackColor = System.Drawing.Color.Black;
            this.IlExplorer_Tab.Controls.Add(this.splitContainer2);
            this.IlExplorer_Tab.Location = new System.Drawing.Point(4, 38);
            this.IlExplorer_Tab.Name = "IlExplorer_Tab";
            this.IlExplorer_Tab.Size = new System.Drawing.Size(584, 282);
            this.IlExplorer_Tab.TabIndex = 4;
            this.IlExplorer_Tab.Text = "IL Explorer";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ilRealTime_CheckBox);
            this.splitContainer2.Panel1.Controls.Add(this.sourceCodeBox);
            this.splitContainer2.Panel1.Controls.Add(this.loadCodeButton);
            this.splitContainer2.Panel1.Controls.Add(this.ilDasmButton);
            this.splitContainer2.Panel1.Controls.Add(this.metroLabel4);
            this.splitContainer2.Panel1.Controls.Add(this.langBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.stackTabs_CheckBox);
            this.splitContainer2.Panel2.Controls.Add(this.ilCodeBox);
            this.splitContainer2.Panel2.Controls.Add(this.metroLabel5);
            this.splitContainer2.Panel2.Controls.Add(this.loadBinary_Button);
            this.splitContainer2.Size = new System.Drawing.Size(584, 282);
            this.splitContainer2.SplitterDistance = 294;
            this.splitContainer2.TabIndex = 22;
            // 
            // ilRealTime_CheckBox
            // 
            this.ilRealTime_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ilRealTime_CheckBox.AutoSize = true;
            this.ilRealTime_CheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ilRealTime_CheckBox.ForeColor = System.Drawing.Color.LightGray;
            this.ilRealTime_CheckBox.Location = new System.Drawing.Point(111, 256);
            this.ilRealTime_CheckBox.Name = "ilRealTime_CheckBox";
            this.ilRealTime_CheckBox.Size = new System.Drawing.Size(74, 15);
            this.ilRealTime_CheckBox.TabIndex = 75;
            this.ilRealTime_CheckBox.Text = "Real-time";
            this.ilRealTime_CheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ilRealTime_CheckBox.UseSelectable = true;
            this.ilRealTime_CheckBox.CheckedChanged += new System.EventHandler(this.onRealTimeEnabled_Checked);
            // 
            // sourceCodeBox
            // 
            this.sourceCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceCodeBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.sourceCodeBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.sourceCodeBox.AutoScrollMinSize = new System.Drawing.Size(226, 98);
            this.sourceCodeBox.BackBrush = null;
            this.sourceCodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sourceCodeBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.sourceCodeBox.CharHeight = 14;
            this.sourceCodeBox.CharWidth = 8;
            this.sourceCodeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sourceCodeBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.sourceCodeBox.ForeColor = System.Drawing.Color.LightGray;
            this.sourceCodeBox.IndentBackColor = System.Drawing.Color.DimGray;
            this.sourceCodeBox.IsReplaceMode = false;
            this.sourceCodeBox.Language = FastColoredTextBoxNS.Language.CSharp;
            this.sourceCodeBox.LeftBracket = '(';
            this.sourceCodeBox.LeftBracket2 = '{';
            this.sourceCodeBox.LineNumberColor = System.Drawing.Color.LightGray;
            this.sourceCodeBox.Location = new System.Drawing.Point(15, 40);
            this.sourceCodeBox.Name = "sourceCodeBox";
            this.sourceCodeBox.Paddings = new System.Windows.Forms.Padding(0);
            this.sourceCodeBox.RightBracket = ')';
            this.sourceCodeBox.RightBracket2 = '}';
            this.sourceCodeBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.sourceCodeBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("sourceCodeBox.ServiceColors")));
            this.sourceCodeBox.Size = new System.Drawing.Size(266, 206);
            this.sourceCodeBox.TabIndex = 71;
            this.sourceCodeBox.Text = "using System;\r\n\r\nclass Program {\r\n public static void Main() {\r\n\r\n }\r\n}";
            this.sourceCodeBox.Zoom = 100;
            this.sourceCodeBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.sourceCodeBox_TextChanged);
            // 
            // loadCodeButton
            // 
            this.loadCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadCodeButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.loadCodeButton.Location = new System.Drawing.Point(15, 252);
            this.loadCodeButton.Name = "loadCodeButton";
            this.loadCodeButton.Size = new System.Drawing.Size(86, 21);
            this.loadCodeButton.Style = MetroFramework.MetroColorStyle.Black;
            this.loadCodeButton.TabIndex = 72;
            this.loadCodeButton.Text = "Load code";
            this.loadCodeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadCodeButton.UseSelectable = true;
            this.loadCodeButton.Click += new System.EventHandler(this.loadCodeButton_Click);
            // 
            // ilDasmButton
            // 
            this.ilDasmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ilDasmButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ilDasmButton.Location = new System.Drawing.Point(195, 252);
            this.ilDasmButton.Name = "ilDasmButton";
            this.ilDasmButton.Size = new System.Drawing.Size(86, 21);
            this.ilDasmButton.Style = MetroFramework.MetroColorStyle.Black;
            this.ilDasmButton.TabIndex = 71;
            this.ilDasmButton.Text = "Compile";
            this.ilDasmButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ilDasmButton.UseSelectable = true;
            this.ilDasmButton.Click += new System.EventHandler(this.ilDasmButton_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(12, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 23);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Source Code";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // langBox
            // 
            this.langBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.langBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.langBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.langBox.ForeColor = System.Drawing.Color.LightGray;
            this.langBox.Items.AddRange(new object[] {
            "C#",
            "VB.NET"});
            this.langBox.Location = new System.Drawing.Point(175, 10);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(105, 21);
            this.langBox.TabIndex = 18;
            this.langBox.Text = "C#";
            this.langBox.SelectedIndexChanged += new System.EventHandler(this.langBox_SelectedIndexChanged);
            // 
            // stackTabs_CheckBox
            // 
            this.stackTabs_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stackTabs_CheckBox.AutoSize = true;
            this.stackTabs_CheckBox.BackColor = System.Drawing.Color.Transparent;
            this.stackTabs_CheckBox.ForeColor = System.Drawing.Color.LightGray;
            this.stackTabs_CheckBox.Location = new System.Drawing.Point(199, 14);
            this.stackTabs_CheckBox.Name = "stackTabs_CheckBox";
            this.stackTabs_CheckBox.Size = new System.Drawing.Size(76, 15);
            this.stackTabs_CheckBox.TabIndex = 76;
            this.stackTabs_CheckBox.Text = "Stack tabs";
            this.stackTabs_CheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stackTabs_CheckBox.UseSelectable = true;
            // 
            // ilCodeBox
            // 
            this.ilCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ilCodeBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ilCodeBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.ilCodeBox.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.ilCodeBox.BackBrush = null;
            this.ilCodeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ilCodeBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ilCodeBox.CharHeight = 14;
            this.ilCodeBox.CharWidth = 8;
            this.ilCodeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ilCodeBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ilCodeBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ilCodeBox.ForeColor = System.Drawing.Color.LightGray;
            this.ilCodeBox.IndentBackColor = System.Drawing.Color.DimGray;
            this.ilCodeBox.IsReplaceMode = false;
            this.ilCodeBox.Language = FastColoredTextBoxNS.Language.CSharp;
            this.ilCodeBox.LeftBracket = '(';
            this.ilCodeBox.LeftBracket2 = '{';
            this.ilCodeBox.LineNumberColor = System.Drawing.Color.LightGray;
            this.ilCodeBox.Location = new System.Drawing.Point(10, 40);
            this.ilCodeBox.Name = "ilCodeBox";
            this.ilCodeBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ilCodeBox.ReadOnly = true;
            this.ilCodeBox.RightBracket = ')';
            this.ilCodeBox.RightBracket2 = '}';
            this.ilCodeBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ilCodeBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ilCodeBox.ServiceColors")));
            this.ilCodeBox.Size = new System.Drawing.Size(266, 206);
            this.ilCodeBox.TabIndex = 72;
            this.ilCodeBox.Zoom = 100;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(10, 10);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "IL Code";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // loadBinary_Button
            // 
            this.loadBinary_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadBinary_Button.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.loadBinary_Button.Location = new System.Drawing.Point(10, 252);
            this.loadBinary_Button.Name = "loadBinary_Button";
            this.loadBinary_Button.Size = new System.Drawing.Size(86, 21);
            this.loadBinary_Button.Style = MetroFramework.MetroColorStyle.Black;
            this.loadBinary_Button.TabIndex = 71;
            this.loadBinary_Button.Text = "Load binary";
            this.loadBinary_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadBinary_Button.UseSelectable = true;
            this.loadBinary_Button.Click += new System.EventHandler(this.loadBinaryButton_Click);
            // 
            // about_Tab
            // 
            this.about_Tab.BackColor = System.Drawing.Color.Black;
            this.about_Tab.Controls.Add(this.panel1);
            this.about_Tab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.about_Tab.Location = new System.Drawing.Point(4, 38);
            this.about_Tab.Name = "about_Tab";
            this.about_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.about_Tab.Size = new System.Drawing.Size(584, 282);
            this.about_Tab.TabIndex = 1;
            this.about_Tab.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logo_PictureBox);
            this.panel1.Controls.Add(this.market_Link);
            this.panel1.Controls.Add(this.about_Label);
            this.panel1.Controls.Add(this.github_Link);
            this.panel1.Controls.Add(this.contact_Label);
            this.panel1.Controls.Add(this.telegram_Link);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 276);
            this.panel1.TabIndex = 10;
            // 
            // logo_PictureBox
            // 
            this.logo_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logo_PictureBox.Image")));
            this.logo_PictureBox.Location = new System.Drawing.Point(210, 71);
            this.logo_PictureBox.Name = "logo_PictureBox";
            this.logo_PictureBox.Size = new System.Drawing.Size(151, 148);
            this.logo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_PictureBox.TabIndex = 2;
            this.logo_PictureBox.TabStop = false;
            // 
            // market_Link
            // 
            this.market_Link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.market_Link.Location = new System.Drawing.Point(225, 249);
            this.market_Link.Name = "market_Link";
            this.market_Link.Size = new System.Drawing.Size(68, 20);
            this.market_Link.Style = MetroFramework.MetroColorStyle.Black;
            this.market_Link.TabIndex = 9;
            this.market_Link.Text = "Market";
            this.market_Link.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.market_Link.UseSelectable = true;
            this.market_Link.Click += new System.EventHandler(this.marketBtn_Click);
            // 
            // about_Label
            // 
            this.about_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.about_Label.Location = new System.Drawing.Point(3, 0);
            this.about_Label.Name = "about_Label";
            this.about_Label.Size = new System.Drawing.Size(572, 68);
            this.about_Label.Style = MetroFramework.MetroColorStyle.Black;
            this.about_Label.TabIndex = 1;
            this.about_Label.Text = "QConverter is a software that can be used to convert different types of data from" +
    " one format to another. This program is designed mostly for for low-level develo" +
    "pers and reverse-engineers.";
            this.about_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.about_Label.UseCustomBackColor = true;
            this.about_Label.WrapToLine = true;
            // 
            // github_Link
            // 
            this.github_Link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.github_Link.Location = new System.Drawing.Point(151, 249);
            this.github_Link.Name = "github_Link";
            this.github_Link.Size = new System.Drawing.Size(68, 20);
            this.github_Link.Style = MetroFramework.MetroColorStyle.Black;
            this.github_Link.TabIndex = 8;
            this.github_Link.Text = "Github";
            this.github_Link.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.github_Link.UseSelectable = true;
            this.github_Link.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // contact_Label
            // 
            this.contact_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.contact_Label.AutoSize = true;
            this.contact_Label.Location = new System.Drawing.Point(10, 248);
            this.contact_Label.Name = "contact_Label";
            this.contact_Label.Size = new System.Drawing.Size(61, 19);
            this.contact_Label.Style = MetroFramework.MetroColorStyle.Black;
            this.contact_Label.TabIndex = 6;
            this.contact_Label.Text = "Contact: ";
            this.contact_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // telegram_Link
            // 
            this.telegram_Link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.telegram_Link.Location = new System.Drawing.Point(77, 249);
            this.telegram_Link.Name = "telegram_Link";
            this.telegram_Link.Size = new System.Drawing.Size(68, 19);
            this.telegram_Link.Style = MetroFramework.MetroColorStyle.Black;
            this.telegram_Link.TabIndex = 5;
            this.telegram_Link.Text = "Telegram";
            this.telegram_Link.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.telegram_Link.UseSelectable = true;
            this.telegram_Link.Click += new System.EventHandler(this.telegramLink_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // typingTimer
            // 
            this.typingTimer.Enabled = true;
            this.typingTimer.Interval = 500;
            this.typingTimer.Tick += new System.EventHandler(this.typingTimer_Tick);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "notifyIcon1";
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // trayWindow_Button
            // 
            this.trayWindow_Button.BackColor = System.Drawing.Color.Transparent;
            this.trayWindow_Button.Image = global::QConverter.Properties.Resources.minimize_icon;
            this.trayWindow_Button.Location = new System.Drawing.Point(199, 21);
            this.trayWindow_Button.Name = "trayWindow_Button";
            this.trayWindow_Button.Size = new System.Drawing.Size(33, 33);
            this.trayWindow_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trayWindow_Button.TabIndex = 10;
            this.trayWindow_Button.TabStop = false;
            this.trayWindow_Button.Click += new System.EventHandler(this.toTrayBtn_Click);
            // 
            // pinWindow_Button
            // 
            this.pinWindow_Button.BackColor = System.Drawing.Color.Transparent;
            this.pinWindow_Button.Image = global::QConverter.Properties.Resources.pin_icon;
            this.pinWindow_Button.Location = new System.Drawing.Point(155, 21);
            this.pinWindow_Button.Name = "pinWindow_Button";
            this.pinWindow_Button.Size = new System.Drawing.Size(33, 33);
            this.pinWindow_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinWindow_Button.TabIndex = 9;
            this.pinWindow_Button.TabStop = false;
            this.pinWindow_Button.Click += new System.EventHandler(this.pinWindowBtn_Click);
            // 
            // opacity_TrackBar
            // 
            this.opacity_TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.opacity_TrackBar.Location = new System.Drawing.Point(250, 21);
            this.opacity_TrackBar.Minimum = 5;
            this.opacity_TrackBar.Name = "opacity_TrackBar";
            this.opacity_TrackBar.Size = new System.Drawing.Size(160, 33);
            this.opacity_TrackBar.Style = MetroFramework.MetroColorStyle.Silver;
            this.opacity_TrackBar.TabIndex = 11;
            this.opacity_TrackBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.opacity_TrackBar.Value = 100;
            this.opacity_TrackBar.ValueChanged += new System.EventHandler(this.metroTrackBar1_ValueChanged);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 404);
            this.Controls.Add(this.opacity_TrackBar);
            this.Controls.Add(this.trayWindow_Button);
            this.Controls.Add(this.pinWindow_Button);
            this.Controls.Add(this.main_TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(632, 404);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "QConverter";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.main_TabControl.ResumeLayout(false);
            this.patternScan_Tab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.dataConverter_Tab.ResumeLayout(false);
            this.dataConverter_Panel.ResumeLayout(false);
            this.dataConverter_Panel.PerformLayout();
            this.asmDisasm_Tab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.codeConverter_Tab.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codeInput_TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeResult_TextBox)).EndInit();
            this.IlExplorer_Tab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourceCodeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilCodeBox)).EndInit();
            this.about_Tab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trayWindow_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinWindow_Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel decimal_Label;
        private System.Windows.Forms.TextBox decimal_TextBox;
        private MetroFramework.Controls.MetroLabel octal_Label;
        private MetroFramework.Controls.MetroLabel hexLabel;
        private MetroFramework.Controls.MetroLabel binaryLabel;
        private System.Windows.Forms.TextBox octal_TextBox;
        private System.Windows.Forms.TextBox hex_TextBox;
        private System.Windows.Forms.TextBox binary_TextBox;
        private MetroFramework.Controls.MetroTabControl main_TabControl;
        private System.Windows.Forms.TabPage dataConverter_Tab;
        private System.Windows.Forms.TabPage about_Tab;
        private System.Windows.Forms.TextBox stringTextBox;
        private MetroFramework.Controls.MetroLabel string_Label;
        private System.Windows.Forms.ComboBox stringEncoding_ComboBox;
        private MetroFramework.Controls.MetroLabel base64_Label;
        private MetroFramework.Controls.MetroLabel rawBytes_Label;
        private System.Windows.Forms.TextBox base64_TextBox;
        private System.Windows.Forms.TextBox bytesTextBox;
        private MetroFramework.Controls.MetroLabel about_Label;
        private System.Windows.Forms.TabPage asmDisasm_Tab;
        private MetroFramework.Controls.MetroLabel hexDataLabel;
        private System.Windows.Forms.ComboBox asmArch_ComboBox;
        private System.Windows.Forms.RichTextBox asmResult_ComboBox;
        private MetroFramework.Controls.MetroLabel asmCodeLabel;
        private System.Windows.Forms.RichTextBox asmInput_ComboBox;
        private System.Windows.Forms.PictureBox logo_PictureBox;
        private MetroFramework.Controls.MetroLabel contact_Label;
        private MetroFramework.Controls.MetroLink telegram_Link;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private MetroFramework.Controls.MetroLink github_Link;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel dataConverter_Panel;
        private System.Windows.Forms.TextBox float_TextBox;
        private MetroFramework.Controls.MetroLabel float_Label;
        private System.Windows.Forms.TabPage IlExplorer_Tab;
        private System.Windows.Forms.Timer typingTimer;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox langBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton loadBinary_Button;
        private MetroFramework.Controls.MetroLabel dataConvertStatus_Label;
        private MetroFramework.Controls.MetroLink market_Link;
        private System.Windows.Forms.TabPage patternScan_Tab;
        private MetroFramework.Controls.MetroButton ilDasmButton;
        private MetroFramework.Controls.MetroButton loadCodeButton;
        private System.Windows.Forms.PictureBox pinWindow_Button;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.PictureBox trayWindow_Button;
        private FastColoredTextBoxNS.FastColoredTextBox sourceCodeBox;
        private FastColoredTextBoxNS.FastColoredTextBox ilCodeBox;
        private MetroFramework.Controls.MetroCheckBox ilRealTime_CheckBox;
        private System.Windows.Forms.TabPage codeConverter_Tab;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private MetroFramework.Controls.MetroCheckBox codeRealTime_CheckBox;
        private FastColoredTextBoxNS.FastColoredTextBox codeInput_TextBox;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton convertCodeButton;
        private MetroFramework.Controls.MetroLabel scrCodeLabel;
        private System.Windows.Forms.ComboBox convertMode_ComboBox;
        private FastColoredTextBoxNS.FastColoredTextBox codeResult_TextBox;
        private MetroFramework.Controls.MetroLabel codeResult_Label;
        private System.Windows.Forms.ComboBox asmAction_ComboBox;
        private MetroFramework.Controls.MetroCheckBox stackTabs_CheckBox;
        private MetroFramework.Controls.MetroLabel asmStatusLabel;
        private MetroFramework.Controls.MetroTrackBar opacity_TrackBar;
        private MetroFramework.Controls.MetroButton loadBinaryFile_Button;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox scanInput1Box;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton scanSelect1Btn;
        private System.Windows.Forms.ComboBox scanArchBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox scanRangeBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox scanSizeBox;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton findPatternBtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox scanPatternBox;
        private MetroFramework.Controls.MetroButton createPatternBtn;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox scanOffsetBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}