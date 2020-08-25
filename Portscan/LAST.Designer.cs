namespace Portscan
{
    partial class LAST
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAST));
            IP = new System.Windows.Forms.Label();
            DOMAIN = new System.Windows.Forms.TextBox();
            TCP = new System.Windows.Forms.CheckBox();
            UDP = new System.Windows.Forms.CheckBox();
            ROL = new System.Windows.Forms.ListBox();
            PORT1L = new System.Windows.Forms.Label();
            PORT1T = new System.Windows.Forms.MaskedTextBox();
            PORT2T = new System.Windows.Forms.MaskedTextBox();
            PORT2L = new System.Windows.Forms.Label();
            SCAN = new System.Windows.Forms.Button();
            RCL = new System.Windows.Forms.ListBox();
            Scanner = new System.ComponentModel.BackgroundWorker();
            AOPL = new System.Windows.Forms.Label();
            KOPL = new System.Windows.Forms.Label();
            AOPC = new System.Windows.Forms.Label();
            KOPC = new System.Windows.Forms.Label();
            RESULT = new System.Windows.Forms.Label();
            Times = new System.Windows.Forms.Timer(components);
            TIMER = new System.Windows.Forms.Label();
            FST = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // IP
            // 
            IP.AutoSize = true;
            IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            IP.Location = new System.Drawing.Point(12, 9);
            IP.Name = "IP";
            IP.Size = new System.Drawing.Size(141, 17);
            IP.TabIndex = 0;
            IP.Text = "IP Address - Domain:";
            // 
            // DOMAIN
            // 
            DOMAIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            DOMAIN.Location = new System.Drawing.Point(159, 8);
            DOMAIN.MaxLength = 50;
            DOMAIN.Name = "DOMAIN";
            DOMAIN.Size = new System.Drawing.Size(111, 20);
            DOMAIN.TabIndex = 1;
            DOMAIN.Text = "localhost";
            DOMAIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TCP
            // 
            TCP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            TCP.AutoSize = true;
            TCP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            TCP.Checked = true;
            TCP.CheckState = System.Windows.Forms.CheckState.Checked;
            TCP.Cursor = System.Windows.Forms.Cursors.Hand;
            TCP.Location = new System.Drawing.Point(276, 10);
            TCP.Name = "TCP";
            TCP.Size = new System.Drawing.Size(47, 17);
            TCP.TabIndex = 2;
            TCP.Text = "TCP";
            TCP.UseVisualStyleBackColor = true;
            TCP.CheckedChanged += new System.EventHandler(TCP_CheckedChanged);
            // 
            // UDP
            // 
            UDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            UDP.AutoSize = true;
            UDP.Cursor = System.Windows.Forms.Cursors.Hand;
            UDP.Location = new System.Drawing.Point(329, 10);
            UDP.Name = "UDP";
            UDP.Size = new System.Drawing.Size(49, 17);
            UDP.TabIndex = 3;
            UDP.Text = "UDP";
            UDP.UseVisualStyleBackColor = true;
            UDP.CheckedChanged += new System.EventHandler(UDP_CheckedChanged);
            // 
            // ROL
            // 
            ROL.AllowDrop = true;
            ROL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            ROL.IntegralHeight = false;
            ROL.Location = new System.Drawing.Point(15, 151);
            ROL.Name = "ROL";
            ROL.ScrollAlwaysVisible = true;
            ROL.SelectionMode = System.Windows.Forms.SelectionMode.None;
            ROL.Size = new System.Drawing.Size(170, 82);
            ROL.TabIndex = 4;
            // 
            // PORT1L
            // 
            PORT1L.AutoSize = true;
            PORT1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            PORT1L.Location = new System.Drawing.Point(12, 38);
            PORT1L.Name = "PORT1L";
            PORT1L.Size = new System.Drawing.Size(63, 17);
            PORT1L.TabIndex = 5;
            PORT1L.Text = "PORT 1:";
            // 
            // PORT1T
            // 
            PORT1T.HidePromptOnLeave = true;
            PORT1T.Location = new System.Drawing.Point(81, 37);
            PORT1T.Mask = "00000";
            PORT1T.Name = "PORT1T";
            PORT1T.Size = new System.Drawing.Size(52, 20);
            PORT1T.TabIndex = 6;
            PORT1T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            PORT1T.ValidatingType = typeof(int);
            PORT1T.TextChanged += new System.EventHandler(PORT1T_TextChanged);
            // 
            // PORT2T
            // 
            PORT2T.HidePromptOnLeave = true;
            PORT2T.Location = new System.Drawing.Point(208, 37);
            PORT2T.Mask = "00000";
            PORT2T.Name = "PORT2T";
            PORT2T.Size = new System.Drawing.Size(52, 20);
            PORT2T.TabIndex = 8;
            PORT2T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            PORT2T.ValidatingType = typeof(int);
            PORT2T.TextChanged += new System.EventHandler(PORT2T_TextChanged);
            // 
            // PORT2L
            // 
            PORT2L.AutoSize = true;
            PORT2L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            PORT2L.Location = new System.Drawing.Point(139, 38);
            PORT2L.Name = "PORT2L";
            PORT2L.Size = new System.Drawing.Size(63, 17);
            PORT2L.TabIndex = 7;
            PORT2L.Text = "PORT 2:";
            // 
            // SCAN
            // 
            SCAN.Cursor = System.Windows.Forms.Cursors.Hand;
            SCAN.Location = new System.Drawing.Point(276, 35);
            SCAN.Name = "SCAN";
            SCAN.Size = new System.Drawing.Size(102, 23);
            SCAN.TabIndex = 9;
            SCAN.Text = "START";
            SCAN.UseVisualStyleBackColor = true;
            SCAN.Click += new System.EventHandler(SCAN_Click);
            // 
            // RCL
            // 
            RCL.AllowDrop = true;
            RCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            RCL.IntegralHeight = false;
            RCL.Location = new System.Drawing.Point(208, 151);
            RCL.Name = "RCL";
            RCL.ScrollAlwaysVisible = true;
            RCL.SelectionMode = System.Windows.Forms.SelectionMode.None;
            RCL.Size = new System.Drawing.Size(170, 82);
            RCL.TabIndex = 10;
            // 
            // Scanner
            // 
            Scanner.WorkerSupportsCancellation = true;
            Scanner.DoWork += new System.ComponentModel.DoWorkEventHandler(Scanner_DoWork);
            // 
            // AOPL
            // 
            AOPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            AOPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            AOPL.Location = new System.Drawing.Point(12, 131);
            AOPL.Name = "AOPL";
            AOPL.Size = new System.Drawing.Size(173, 17);
            AOPL.TabIndex = 11;
            AOPL.Text = "Opened Port List";
            AOPL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // KOPL
            // 
            KOPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            KOPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            KOPL.Location = new System.Drawing.Point(205, 131);
            KOPL.Name = "KOPL";
            KOPL.Size = new System.Drawing.Size(173, 17);
            KOPL.TabIndex = 12;
            KOPL.Text = "Closed Port List";
            KOPL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AOPC
            // 
            AOPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            AOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            AOPC.Location = new System.Drawing.Point(12, 114);
            AOPC.Name = "AOPC";
            AOPC.Size = new System.Drawing.Size(173, 17);
            AOPC.TabIndex = 13;
            AOPC.Text = "0";
            AOPC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // KOPC
            // 
            KOPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            KOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            KOPC.Location = new System.Drawing.Point(205, 114);
            KOPC.Name = "KOPC";
            KOPC.Size = new System.Drawing.Size(173, 17);
            KOPC.TabIndex = 14;
            KOPC.Text = "0";
            KOPC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // RESULT
            // 
            RESULT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            RESULT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            RESULT.Location = new System.Drawing.Point(15, 60);
            RESULT.Name = "RESULT";
            RESULT.Size = new System.Drawing.Size(363, 54);
            RESULT.TabIndex = 15;
            RESULT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Times
            // 
            Times.Tick += new System.EventHandler(Times_Tick);
            // 
            // TIMER
            // 
            TIMER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            TIMER.Location = new System.Drawing.Point(15, 61);
            TIMER.Name = "TIMER";
            TIMER.Size = new System.Drawing.Size(363, 13);
            TIMER.TabIndex = 16;
            TIMER.Text = "The Passing Time: 0s";
            TIMER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FST
            // 
            FST.AutoSize = true;
            FST.Checked = true;
            FST.CheckState = System.Windows.Forms.CheckState.Checked;
            FST.Cursor = System.Windows.Forms.Cursors.Hand;
            FST.Location = new System.Drawing.Point(15, 60);
            FST.Name = "FST";
            FST.Size = new System.Drawing.Size(105, 17);
            FST.TabIndex = 18;
            FST.Text = "Super Fast Scan";
            FST.UseVisualStyleBackColor = true;
            // 
            // LAST
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(392, 245);
            Controls.Add(FST);
            Controls.Add(TIMER);
            Controls.Add(RESULT);
            Controls.Add(KOPC);
            Controls.Add(AOPC);
            Controls.Add(KOPL);
            Controls.Add(AOPL);
            Controls.Add(RCL);
            Controls.Add(SCAN);
            Controls.Add(PORT2T);
            Controls.Add(PORT2L);
            Controls.Add(PORT1T);
            Controls.Add(PORT1L);
            Controls.Add(TCP);
            Controls.Add(UDP);
            Controls.Add(ROL);
            Controls.Add(DOMAIN);
            Controls.Add(IP);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            Name = "LAST";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Portscan v1.2";
            Load += new System.EventHandler(LAST_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.TextBox DOMAIN;
        private System.Windows.Forms.CheckBox TCP;
        private System.Windows.Forms.CheckBox UDP;
        private System.Windows.Forms.ListBox ROL;
        private System.Windows.Forms.Label PORT1L;
        private System.Windows.Forms.MaskedTextBox PORT1T;
        private System.Windows.Forms.MaskedTextBox PORT2T;
        private System.Windows.Forms.Label PORT2L;
        private System.Windows.Forms.Button SCAN;
        private System.Windows.Forms.ListBox RCL;
        private System.ComponentModel.BackgroundWorker Scanner;
        private System.Windows.Forms.Label AOPL;
        private System.Windows.Forms.Label KOPL;
        private System.Windows.Forms.Label AOPC;
        private System.Windows.Forms.Label KOPC;
        private System.Windows.Forms.Label RESULT;
        private System.Windows.Forms.Timer Times;
        private System.Windows.Forms.Label TIMER;
        private System.Windows.Forms.CheckBox FST;
    }
}