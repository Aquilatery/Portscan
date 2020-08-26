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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            IP = new ReaLTaiizor.Controls.LabelEdit();
            DOMAIN = new ReaLTaiizor.Controls.ForeverTextBox();
            TCP = new ReaLTaiizor.Controls.HopeCheckBox();
            UDP = new ReaLTaiizor.Controls.HopeCheckBox();
            PORT1L = new ReaLTaiizor.Controls.LabelEdit();
            PORT2L = new ReaLTaiizor.Controls.LabelEdit();
            PORT2T = new System.Windows.Forms.MaskedTextBox();
            PORT1T = new System.Windows.Forms.MaskedTextBox();
            SCAN = new ReaLTaiizor.Controls.HopeButton();
            PTIME = new ReaLTaiizor.Controls.LabelEdit();
            Scanner = new System.ComponentModel.BackgroundWorker();
            Times = new System.Windows.Forms.Timer(components);
            SFAST = new ReaLTaiizor.Controls.ForeverCheckBox();
            RESULT = new ReaLTaiizor.Controls.LabelEdit();
            AOPC = new ReaLTaiizor.Controls.LabelEdit();
            AOPL = new ReaLTaiizor.Controls.LabelEdit();
            KOPC = new ReaLTaiizor.Controls.LabelEdit();
            KOPL = new ReaLTaiizor.Controls.LabelEdit();
            airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            RCL = new System.Windows.Forms.ListBox();
            ROL = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // hopeForm1
            // 
            hopeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            hopeForm1.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(135)))));
            hopeForm1.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            hopeForm1.ControlBoxColorN = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            hopeForm1.Cursor = System.Windows.Forms.Cursors.Default;
            hopeForm1.Dock = System.Windows.Forms.DockStyle.Bottom;
            hopeForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            hopeForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            hopeForm1.Image = global::Portscan.Properties.Resources.Scan;
            hopeForm1.Location = new System.Drawing.Point(0, 355);
            hopeForm1.MaximizeBox = false;
            hopeForm1.Name = "hopeForm1";
            hopeForm1.Size = new System.Drawing.Size(435, 40);
            hopeForm1.TabIndex = 0;
            hopeForm1.Text = "Portscan v1.4";
            hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            // 
            // IP
            // 
            IP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            IP.AutoSize = true;
            IP.BackColor = System.Drawing.Color.Transparent;
            IP.Font = new System.Drawing.Font("Segoe UI", 12F);
            IP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            IP.Location = new System.Drawing.Point(12, 16);
            IP.Name = "IP";
            IP.Size = new System.Drawing.Size(155, 21);
            IP.TabIndex = 1;
            IP.Text = "IP Address - Domain:";
            // 
            // DOMAIN
            // 
            DOMAIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            DOMAIN.BackColor = System.Drawing.Color.Transparent;
            DOMAIN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            DOMAIN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            DOMAIN.FocusOnHover = false;
            DOMAIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            DOMAIN.Location = new System.Drawing.Point(173, 12);
            DOMAIN.MaxLength = 50;
            DOMAIN.Multiline = false;
            DOMAIN.Name = "DOMAIN";
            DOMAIN.ReadOnly = false;
            DOMAIN.Size = new System.Drawing.Size(111, 29);
            DOMAIN.TabIndex = 8;
            DOMAIN.Text = "localhost";
            DOMAIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            DOMAIN.UseSystemPasswordChar = false;
            // 
            // TCP
            // 
            TCP.AutoSize = true;
            TCP.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TCP.Checked = true;
            TCP.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            TCP.CheckState = System.Windows.Forms.CheckState.Checked;
            TCP.Cursor = System.Windows.Forms.Cursors.Hand;
            TCP.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            TCP.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            TCP.Enable = true;
            TCP.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            TCP.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            TCP.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            TCP.Font = new System.Drawing.Font("Segoe UI", 12F);
            TCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            TCP.Location = new System.Drawing.Point(290, 16);
            TCP.Name = "TCP";
            TCP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TCP.Size = new System.Drawing.Size(61, 20);
            TCP.TabIndex = 9;
            TCP.Text = "TCP";
            TCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TCP.UseVisualStyleBackColor = true;
            TCP.CheckedChanged += new System.EventHandler(TCP_CheckedChanged);
            // 
            // UDP
            // 
            UDP.AutoSize = true;
            UDP.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            UDP.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            UDP.Cursor = System.Windows.Forms.Cursors.Hand;
            UDP.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            UDP.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            UDP.Enable = true;
            UDP.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            UDP.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            UDP.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            UDP.Font = new System.Drawing.Font("Segoe UI", 12F);
            UDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            UDP.Location = new System.Drawing.Point(357, 16);
            UDP.Name = "UDP";
            UDP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            UDP.Size = new System.Drawing.Size(66, 20);
            UDP.TabIndex = 10;
            UDP.Text = "UDP";
            UDP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            UDP.UseVisualStyleBackColor = true;
            UDP.CheckedChanged += new System.EventHandler(UDP_CheckedChanged);
            // 
            // PORT1L
            // 
            PORT1L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            PORT1L.AutoSize = true;
            PORT1L.BackColor = System.Drawing.Color.Transparent;
            PORT1L.Font = new System.Drawing.Font("Segoe UI", 12F);
            PORT1L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            PORT1L.Location = new System.Drawing.Point(12, 51);
            PORT1L.Name = "PORT1L";
            PORT1L.Size = new System.Drawing.Size(64, 21);
            PORT1L.TabIndex = 11;
            PORT1L.Text = "PORT 1:";
            // 
            // PORT2L
            // 
            PORT2L.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            PORT2L.AutoSize = true;
            PORT2L.BackColor = System.Drawing.Color.Transparent;
            PORT2L.Font = new System.Drawing.Font("Segoe UI", 12F);
            PORT2L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            PORT2L.Location = new System.Drawing.Point(12, 86);
            PORT2L.Name = "PORT2L";
            PORT2L.Size = new System.Drawing.Size(64, 21);
            PORT2L.TabIndex = 13;
            PORT2L.Text = "PORT 2:";
            // 
            // PORT2T
            // 
            PORT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            PORT2T.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            PORT2T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PORT2T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            PORT2T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            PORT2T.HidePromptOnLeave = true;
            PORT2T.Location = new System.Drawing.Point(82, 82);
            PORT2T.Mask = "00000";
            PORT2T.Name = "PORT2T";
            PORT2T.Size = new System.Drawing.Size(85, 29);
            PORT2T.TabIndex = 15;
            PORT2T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            PORT2T.ValidatingType = typeof(int);
            PORT2T.TextChanged += new System.EventHandler(PORT2T_TextChanged);
            // 
            // PORT1T
            // 
            PORT1T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            PORT1T.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(29)))));
            PORT1T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PORT1T.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            PORT1T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            PORT1T.HidePromptOnLeave = true;
            PORT1T.Location = new System.Drawing.Point(82, 47);
            PORT1T.Mask = "00000";
            PORT1T.Name = "PORT1T";
            PORT1T.Size = new System.Drawing.Size(85, 29);
            PORT1T.TabIndex = 16;
            PORT1T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            PORT1T.ValidatingType = typeof(int);
            PORT1T.TextChanged += new System.EventHandler(PORT1T_TextChanged);
            // 
            // SCAN
            // 
            SCAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            SCAN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            SCAN.ButtonType = ReaLTaiizor.Utils.HopeButtonType.Primary;
            SCAN.Cursor = System.Windows.Forms.Cursors.Hand;
            SCAN.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            SCAN.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            SCAN.Font = new System.Drawing.Font("Segoe UI", 12F);
            SCAN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            SCAN.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            SCAN.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            SCAN.Location = new System.Drawing.Point(173, 47);
            SCAN.Name = "SCAN";
            SCAN.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            SCAN.Size = new System.Drawing.Size(250, 40);
            SCAN.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            SCAN.TabIndex = 0;
            SCAN.Text = "START SCAN";
            SCAN.TextColor = System.Drawing.Color.Black;
            SCAN.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            SCAN.Click += new System.EventHandler(SCAN_Click);
            // 
            // PTIME
            // 
            PTIME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            PTIME.BackColor = System.Drawing.Color.Transparent;
            PTIME.Font = new System.Drawing.Font("Segoe UI", 12F);
            PTIME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            PTIME.Location = new System.Drawing.Point(173, 90);
            PTIME.Name = "PTIME";
            PTIME.Size = new System.Drawing.Size(250, 21);
            PTIME.TabIndex = 17;
            PTIME.Text = "The Passing Time: 0s";
            PTIME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Scanner
            // 
            Scanner.WorkerSupportsCancellation = true;
            Scanner.DoWork += new System.ComponentModel.DoWorkEventHandler(Scanner_DoWork);
            // 
            // Times
            // 
            Times.Tick += new System.EventHandler(Times_Tick);
            // 
            // SFAST
            // 
            SFAST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            SFAST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            SFAST.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            SFAST.BorderColor = System.Drawing.Color.Crimson;
            SFAST.Checked = true;
            SFAST.Cursor = System.Windows.Forms.Cursors.Hand;
            SFAST.Font = new System.Drawing.Font("Segoe UI", 11F);
            SFAST.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            SFAST.Location = new System.Drawing.Point(24, 117);
            SFAST.Name = "SFAST";
            SFAST.Options = ReaLTaiizor.Controls.ForeverCheckBox._Options.Style1;
            SFAST.Size = new System.Drawing.Size(131, 22);
            SFAST.TabIndex = 21;
            SFAST.Text = "Super Fast Scan";
            SFAST.CheckedChanged += new ReaLTaiizor.Controls.ForeverCheckBox.CheckedChangedEventHandler(SFAST_CheckedChanged);
            // 
            // RESULT
            // 
            RESULT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            RESULT.BackColor = System.Drawing.Color.Transparent;
            RESULT.Font = new System.Drawing.Font("Segoe UI", 12F);
            RESULT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            RESULT.Location = new System.Drawing.Point(173, 118);
            RESULT.Name = "RESULT";
            RESULT.Size = new System.Drawing.Size(250, 21);
            RESULT.TabIndex = 26;
            RESULT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AOPC
            // 
            AOPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            AOPC.BackColor = System.Drawing.Color.Transparent;
            AOPC.Font = new System.Drawing.Font("Segoe UI", 12F);
            AOPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            AOPC.Location = new System.Drawing.Point(12, 149);
            AOPC.Name = "AOPC";
            AOPC.Size = new System.Drawing.Size(170, 21);
            AOPC.TabIndex = 27;
            AOPC.Text = "0";
            AOPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AOPL
            // 
            AOPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            AOPL.BackColor = System.Drawing.Color.Transparent;
            AOPL.Font = new System.Drawing.Font("Segoe UI", 12F);
            AOPL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            AOPL.Location = new System.Drawing.Point(12, 170);
            AOPL.Name = "AOPL";
            AOPL.Size = new System.Drawing.Size(170, 21);
            AOPL.TabIndex = 28;
            AOPL.Text = "Opened Port List";
            AOPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KOPC
            // 
            KOPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            KOPC.BackColor = System.Drawing.Color.Transparent;
            KOPC.Font = new System.Drawing.Font("Segoe UI", 12F);
            KOPC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            KOPC.Location = new System.Drawing.Point(253, 149);
            KOPC.Name = "KOPC";
            KOPC.Size = new System.Drawing.Size(170, 21);
            KOPC.TabIndex = 29;
            KOPC.Text = "0";
            KOPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KOPL
            // 
            KOPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            KOPL.BackColor = System.Drawing.Color.Transparent;
            KOPL.Font = new System.Drawing.Font("Segoe UI", 12F);
            KOPL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            KOPL.Location = new System.Drawing.Point(253, 170);
            KOPL.Name = "KOPL";
            KOPL.Size = new System.Drawing.Size(170, 21);
            KOPL.TabIndex = 30;
            KOPL.Text = "Closed Port List";
            KOPL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airSeparator1
            // 
            airSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            airSeparator1.BackColor = System.Drawing.Color.Yellow;
            airSeparator1.Colors = new ReaLTaiizor.Utils.BloomAir[0];
            airSeparator1.Customization = "";
            airSeparator1.Font = new System.Drawing.Font("Verdana", 8F);
            airSeparator1.Image = null;
            airSeparator1.Location = new System.Drawing.Point(0, 145);
            airSeparator1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            airSeparator1.Name = "airSeparator1";
            airSeparator1.NoRounding = false;
            airSeparator1.Size = new System.Drawing.Size(435, 1);
            airSeparator1.TabIndex = 39;
            airSeparator1.Text = "airSeparator1";
            airSeparator1.Transparent = false;
            // 
            // RCL
            // 
            RCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            RCL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(69)))));
            RCL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RCL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            RCL.FormatString = "N0";
            RCL.FormattingEnabled = true;
            RCL.Location = new System.Drawing.Point(253, 199);
            RCL.Name = "RCL";
            RCL.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            RCL.Size = new System.Drawing.Size(170, 145);
            RCL.TabIndex = 40;
            // 
            // ROL
            // 
            ROL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            ROL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(69)))));
            ROL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ROL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            ROL.FormatString = "N0";
            ROL.FormattingEnabled = true;
            ROL.Location = new System.Drawing.Point(12, 199);
            ROL.Name = "ROL";
            ROL.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            ROL.Size = new System.Drawing.Size(170, 145);
            ROL.TabIndex = 41;
            // 
            // MAIN
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            ClientSize = new System.Drawing.Size(435, 395);
            Controls.Add(ROL);
            Controls.Add(RCL);
            Controls.Add(airSeparator1);
            Controls.Add(KOPL);
            Controls.Add(KOPC);
            Controls.Add(AOPL);
            Controls.Add(AOPC);
            Controls.Add(RESULT);
            Controls.Add(SFAST);
            Controls.Add(PTIME);
            Controls.Add(SCAN);
            Controls.Add(PORT1T);
            Controls.Add(PORT2T);
            Controls.Add(PORT2L);
            Controls.Add(PORT1L);
            Controls.Add(UDP);
            Controls.Add(TCP);
            Controls.Add(DOMAIN);
            Controls.Add(IP);
            Controls.Add(hopeForm1);
            ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(155)))));
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1366, 768);
            MinimumSize = new System.Drawing.Size(190, 40);
            Name = "MAIN";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Portscan v1.4";
            Load += new System.EventHandler(MAIN_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.LabelEdit IP;
        private ReaLTaiizor.Controls.ForeverTextBox DOMAIN;
        private ReaLTaiizor.Controls.HopeCheckBox TCP;
        private ReaLTaiizor.Controls.HopeCheckBox UDP;
        private ReaLTaiizor.Controls.LabelEdit PORT1L;
        private ReaLTaiizor.Controls.LabelEdit PORT2L;
        private System.Windows.Forms.MaskedTextBox PORT2T;
        private System.Windows.Forms.MaskedTextBox PORT1T;
        private ReaLTaiizor.Controls.HopeButton SCAN;
        private ReaLTaiizor.Controls.LabelEdit PTIME;
        private System.ComponentModel.BackgroundWorker Scanner;
        private System.Windows.Forms.Timer Times;
        private ReaLTaiizor.Controls.ForeverCheckBox SFAST;
        private ReaLTaiizor.Controls.LabelEdit RESULT;
        private ReaLTaiizor.Controls.LabelEdit AOPC;
        private ReaLTaiizor.Controls.LabelEdit AOPL;
        private ReaLTaiizor.Controls.LabelEdit KOPC;
        private ReaLTaiizor.Controls.LabelEdit KOPL;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        public System.Windows.Forms.ListBox RCL;
        public System.Windows.Forms.ListBox ROL;
    }
}