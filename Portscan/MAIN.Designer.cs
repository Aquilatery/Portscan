namespace Portscan
{
    partial class MAIN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.hopeForm1 = new ReaLTaiizor.HopeForm();
            this.IP = new ReaLTaiizor.LabelEdit();
            this.DOMAIN = new ReaLTaiizor.ForeverTextBox();
            this.TCP = new ReaLTaiizor.HopeCheckBox();
            this.UDP = new ReaLTaiizor.HopeCheckBox();
            this.PORT1L = new ReaLTaiizor.LabelEdit();
            this.PORT2L = new ReaLTaiizor.LabelEdit();
            this.PORT2T = new System.Windows.Forms.MaskedTextBox();
            this.PORT1T = new System.Windows.Forms.MaskedTextBox();
            this.SCAN = new ReaLTaiizor.HopeButton();
            this.PTIME = new ReaLTaiizor.LabelEdit();
            this.Scanner = new System.ComponentModel.BackgroundWorker();
            this.Times = new System.Windows.Forms.Timer(this.components);
            this.SFAST = new ReaLTaiizor.ForeverCheckBox();
            this.RESULT = new ReaLTaiizor.LabelEdit();
            this.AOPC = new ReaLTaiizor.LabelEdit();
            this.AOPL = new ReaLTaiizor.LabelEdit();
            this.KOPC = new ReaLTaiizor.LabelEdit();
            this.KOPL = new ReaLTaiizor.LabelEdit();
            this.airSeparator1 = new ReaLTaiizor.AirSeparator();
            this.RCL = new System.Windows.Forms.ListBox();
            this.ROL = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // hopeForm1
            // 
            this.hopeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.hopeForm1.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            this.hopeForm1.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm1.ControlBoxColorN = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.hopeForm1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hopeForm1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hopeForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.hopeForm1.Image = global::Portscan.Properties.Resources.Scan;
            this.hopeForm1.Location = new System.Drawing.Point(0, 355);
            this.hopeForm1.MaximizeBox = false;
            this.hopeForm1.Name = "hopeForm1";
            this.hopeForm1.Size = new System.Drawing.Size(435, 40);
            this.hopeForm1.TabIndex = 0;
            this.hopeForm1.Text = "Portscan v1.3";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            // 
            // IP
            // 
            this.IP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IP.AutoSize = true;
            this.IP.BackColor = System.Drawing.Color.Transparent;
            this.IP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.IP.Location = new System.Drawing.Point(12, 16);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(155, 21);
            this.IP.TabIndex = 1;
            this.IP.Text = "IP Address - Domain:";
            // 
            // DOMAIN
            // 
            this.DOMAIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DOMAIN.BackColor = System.Drawing.Color.Transparent;
            this.DOMAIN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            this.DOMAIN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.DOMAIN.FocusOnHover = false;
            this.DOMAIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.DOMAIN.Location = new System.Drawing.Point(173, 12);
            this.DOMAIN.MaxLength = 50;
            this.DOMAIN.Multiline = false;
            this.DOMAIN.Name = "DOMAIN";
            this.DOMAIN.ReadOnly = false;
            this.DOMAIN.Size = new System.Drawing.Size(111, 29);
            this.DOMAIN.TabIndex = 8;
            this.DOMAIN.Text = "localhost";
            this.DOMAIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DOMAIN.UseSystemPasswordChar = false;
            // 
            // TCP
            // 
            this.TCP.AutoSize = true;
            this.TCP.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TCP.Checked = true;
            this.TCP.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.TCP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TCP.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.TCP.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.TCP.Enable = true;
            this.TCP.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.TCP.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.TCP.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.TCP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.TCP.Location = new System.Drawing.Point(290, 16);
            this.TCP.Name = "TCP";
            this.TCP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TCP.Size = new System.Drawing.Size(61, 20);
            this.TCP.TabIndex = 9;
            this.TCP.Text = "TCP";
            this.TCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TCP.UseVisualStyleBackColor = true;
            this.TCP.CheckedChanged += new System.EventHandler(this.TCP_CheckedChanged);
            // 
            // UDP
            // 
            this.UDP.AutoSize = true;
            this.UDP.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UDP.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.UDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UDP.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.UDP.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.UDP.Enable = true;
            this.UDP.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.UDP.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.UDP.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.UDP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.UDP.Location = new System.Drawing.Point(357, 16);
            this.UDP.Name = "UDP";
            this.UDP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UDP.Size = new System.Drawing.Size(66, 20);
            this.UDP.TabIndex = 10;
            this.UDP.Text = "UDP";
            this.UDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UDP.UseVisualStyleBackColor = true;
            this.UDP.CheckedChanged += new System.EventHandler(this.UDP_CheckedChanged);
            // 
            // PORT1L
            // 
            this.PORT1L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PORT1L.AutoSize = true;
            this.PORT1L.BackColor = System.Drawing.Color.Transparent;
            this.PORT1L.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PORT1L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.PORT1L.Location = new System.Drawing.Point(12, 51);
            this.PORT1L.Name = "PORT1L";
            this.PORT1L.Size = new System.Drawing.Size(64, 21);
            this.PORT1L.TabIndex = 11;
            this.PORT1L.Text = "PORT 1:";
            // 
            // PORT2L
            // 
            this.PORT2L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PORT2L.AutoSize = true;
            this.PORT2L.BackColor = System.Drawing.Color.Transparent;
            this.PORT2L.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PORT2L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.PORT2L.Location = new System.Drawing.Point(12, 86);
            this.PORT2L.Name = "PORT2L";
            this.PORT2L.Size = new System.Drawing.Size(64, 21);
            this.PORT2L.TabIndex = 13;
            this.PORT2L.Text = "PORT 2:";
            // 
            // PORT2T
            // 
            this.PORT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PORT2T.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            this.PORT2T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PORT2T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PORT2T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.PORT2T.HidePromptOnLeave = true;
            this.PORT2T.Location = new System.Drawing.Point(82, 82);
            this.PORT2T.Mask = "00000";
            this.PORT2T.Name = "PORT2T";
            this.PORT2T.Size = new System.Drawing.Size(85, 29);
            this.PORT2T.TabIndex = 15;
            this.PORT2T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PORT2T.ValidatingType = typeof(int);
            this.PORT2T.TextChanged += new System.EventHandler(this.PORT2T_TextChanged);
            // 
            // PORT1T
            // 
            this.PORT1T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PORT1T.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            this.PORT1T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PORT1T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PORT1T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.PORT1T.HidePromptOnLeave = true;
            this.PORT1T.Location = new System.Drawing.Point(82, 47);
            this.PORT1T.Mask = "00000";
            this.PORT1T.Name = "PORT1T";
            this.PORT1T.Size = new System.Drawing.Size(85, 29);
            this.PORT1T.TabIndex = 16;
            this.PORT1T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PORT1T.ValidatingType = typeof(int);
            this.PORT1T.TextChanged += new System.EventHandler(this.PORT1T_TextChanged);
            // 
            // SCAN
            // 
            this.SCAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SCAN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.SCAN.ButtonType = ReaLTaiizor.HopeButtonType.Primary;
            this.SCAN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SCAN.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.SCAN.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SCAN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SCAN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.SCAN.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.SCAN.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.SCAN.Location = new System.Drawing.Point(173, 47);
            this.SCAN.Name = "SCAN";
            this.SCAN.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.SCAN.Size = new System.Drawing.Size(250, 40);
            this.SCAN.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.SCAN.TabIndex = 0;
            this.SCAN.Text = "START SCAN";
            this.SCAN.TextColor = System.Drawing.Color.Black;
            this.SCAN.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.SCAN.Click += new System.EventHandler(this.SCAN_Click);
            // 
            // PTIME
            // 
            this.PTIME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PTIME.BackColor = System.Drawing.Color.Transparent;
            this.PTIME.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PTIME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.PTIME.Location = new System.Drawing.Point(173, 90);
            this.PTIME.Name = "PTIME";
            this.PTIME.Size = new System.Drawing.Size(250, 21);
            this.PTIME.TabIndex = 17;
            this.PTIME.Text = "The Passing Time: 0s";
            this.PTIME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Scanner
            // 
            this.Scanner.WorkerSupportsCancellation = true;
            this.Scanner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Scanner_DoWork);
            // 
            // Times
            // 
            this.Times.Tick += new System.EventHandler(this.Times_Tick);
            // 
            // SFAST
            // 
            this.SFAST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SFAST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.SFAST.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.SFAST.BorderColor = System.Drawing.Color.Crimson;
            this.SFAST.Checked = true;
            this.SFAST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SFAST.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SFAST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.SFAST.Location = new System.Drawing.Point(24, 117);
            this.SFAST.Name = "SFAST";
            this.SFAST.Options = ReaLTaiizor.ForeverCheckBox._Options.Style1;
            this.SFAST.Size = new System.Drawing.Size(131, 22);
            this.SFAST.TabIndex = 21;
            this.SFAST.Text = "Super Fast Scan";
            this.SFAST.CheckedChanged += new ReaLTaiizor.ForeverCheckBox.CheckedChangedEventHandler(this.SFAST_CheckedChanged);
            // 
            // RESULT
            // 
            this.RESULT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RESULT.BackColor = System.Drawing.Color.Transparent;
            this.RESULT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RESULT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.RESULT.Location = new System.Drawing.Point(173, 118);
            this.RESULT.Name = "RESULT";
            this.RESULT.Size = new System.Drawing.Size(250, 21);
            this.RESULT.TabIndex = 26;
            this.RESULT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AOPC
            // 
            this.AOPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AOPC.BackColor = System.Drawing.Color.Transparent;
            this.AOPC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AOPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.AOPC.Location = new System.Drawing.Point(12, 149);
            this.AOPC.Name = "AOPC";
            this.AOPC.Size = new System.Drawing.Size(170, 21);
            this.AOPC.TabIndex = 27;
            this.AOPC.Text = "0";
            this.AOPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AOPL
            // 
            this.AOPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AOPL.BackColor = System.Drawing.Color.Transparent;
            this.AOPL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AOPL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.AOPL.Location = new System.Drawing.Point(12, 170);
            this.AOPL.Name = "AOPL";
            this.AOPL.Size = new System.Drawing.Size(170, 21);
            this.AOPL.TabIndex = 28;
            this.AOPL.Text = "Opened Port List";
            this.AOPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KOPC
            // 
            this.KOPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KOPC.BackColor = System.Drawing.Color.Transparent;
            this.KOPC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.KOPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.KOPC.Location = new System.Drawing.Point(253, 149);
            this.KOPC.Name = "KOPC";
            this.KOPC.Size = new System.Drawing.Size(170, 21);
            this.KOPC.TabIndex = 29;
            this.KOPC.Text = "0";
            this.KOPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KOPL
            // 
            this.KOPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KOPL.BackColor = System.Drawing.Color.Transparent;
            this.KOPL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.KOPL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.KOPL.Location = new System.Drawing.Point(253, 170);
            this.KOPL.Name = "KOPL";
            this.KOPL.Size = new System.Drawing.Size(170, 21);
            this.KOPL.TabIndex = 30;
            this.KOPL.Text = "Closed Port List";
            this.KOPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airSeparator1
            // 
            this.airSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.airSeparator1.BackColor = System.Drawing.Color.Yellow;
            this.airSeparator1.Colors = new ReaLTaiizor.BloomAir[0];
            this.airSeparator1.Customization = "";
            this.airSeparator1.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator1.Image = null;
            this.airSeparator1.Location = new System.Drawing.Point(0, 145);
            this.airSeparator1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.airSeparator1.Name = "airSeparator1";
            this.airSeparator1.NoRounding = false;
            this.airSeparator1.Size = new System.Drawing.Size(435, 1);
            this.airSeparator1.TabIndex = 39;
            this.airSeparator1.Text = "airSeparator1";
            this.airSeparator1.Transparent = false;
            // 
            // RCL
            // 
            this.RCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RCL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(69)))));
            this.RCL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RCL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.RCL.FormatString = "N0";
            this.RCL.FormattingEnabled = true;
            this.RCL.Location = new System.Drawing.Point(253, 199);
            this.RCL.Name = "RCL";
            this.RCL.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.RCL.Size = new System.Drawing.Size(170, 145);
            this.RCL.TabIndex = 40;
            // 
            // ROL
            // 
            this.ROL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ROL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(69)))));
            this.ROL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ROL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.ROL.FormatString = "N0";
            this.ROL.FormattingEnabled = true;
            this.ROL.Location = new System.Drawing.Point(12, 199);
            this.ROL.Name = "ROL";
            this.ROL.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ROL.Size = new System.Drawing.Size(170, 145);
            this.ROL.TabIndex = 41;
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(435, 395);
            this.Controls.Add(this.ROL);
            this.Controls.Add(this.RCL);
            this.Controls.Add(this.airSeparator1);
            this.Controls.Add(this.KOPL);
            this.Controls.Add(this.KOPC);
            this.Controls.Add(this.AOPL);
            this.Controls.Add(this.AOPC);
            this.Controls.Add(this.RESULT);
            this.Controls.Add(this.SFAST);
            this.Controls.Add(this.PTIME);
            this.Controls.Add(this.SCAN);
            this.Controls.Add(this.PORT1T);
            this.Controls.Add(this.PORT2T);
            this.Controls.Add(this.PORT2L);
            this.Controls.Add(this.PORT1L);
            this.Controls.Add(this.UDP);
            this.Controls.Add(this.TCP);
            this.Controls.Add(this.DOMAIN);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.hopeForm1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "MAIN";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portscan v1.3";
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.HopeForm hopeForm1;
        private ReaLTaiizor.LabelEdit IP;
        private ReaLTaiizor.ForeverTextBox DOMAIN;
        private ReaLTaiizor.HopeCheckBox TCP;
        private ReaLTaiizor.HopeCheckBox UDP;
        private ReaLTaiizor.LabelEdit PORT1L;
        private ReaLTaiizor.LabelEdit PORT2L;
        private System.Windows.Forms.MaskedTextBox PORT2T;
        private System.Windows.Forms.MaskedTextBox PORT1T;
        private ReaLTaiizor.HopeButton SCAN;
        private ReaLTaiizor.LabelEdit PTIME;
        private System.ComponentModel.BackgroundWorker Scanner;
        private System.Windows.Forms.Timer Times;
        private ReaLTaiizor.ForeverCheckBox SFAST;
        private ReaLTaiizor.LabelEdit RESULT;
        private ReaLTaiizor.LabelEdit AOPC;
        private ReaLTaiizor.LabelEdit AOPL;
        private ReaLTaiizor.LabelEdit KOPC;
        private ReaLTaiizor.LabelEdit KOPL;
        private ReaLTaiizor.AirSeparator airSeparator1;
        public System.Windows.Forms.ListBox RCL;
        public System.Windows.Forms.ListBox ROL;
    }
}