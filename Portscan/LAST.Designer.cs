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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAST));
            this.IP = new System.Windows.Forms.Label();
            this.DOMAIN = new System.Windows.Forms.TextBox();
            this.TCP = new System.Windows.Forms.CheckBox();
            this.UDP = new System.Windows.Forms.CheckBox();
            this.ROL = new System.Windows.Forms.ListBox();
            this.PORT1L = new System.Windows.Forms.Label();
            this.PORT1T = new System.Windows.Forms.MaskedTextBox();
            this.PORT2T = new System.Windows.Forms.MaskedTextBox();
            this.PORT2L = new System.Windows.Forms.Label();
            this.SCAN = new System.Windows.Forms.Button();
            this.RCL = new System.Windows.Forms.ListBox();
            this.Scanner = new System.ComponentModel.BackgroundWorker();
            this.AOPL = new System.Windows.Forms.Label();
            this.KOPL = new System.Windows.Forms.Label();
            this.AOPC = new System.Windows.Forms.Label();
            this.KOPC = new System.Windows.Forms.Label();
            this.RESULT = new System.Windows.Forms.Label();
            this.Times = new System.Windows.Forms.Timer(this.components);
            this.TIMER = new System.Windows.Forms.Label();
            this.FST = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IP.Location = new System.Drawing.Point(12, 9);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(141, 17);
            this.IP.TabIndex = 0;
            this.IP.Text = "IP Address - Domain:";
            // 
            // DOMAIN
            // 
            this.DOMAIN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DOMAIN.Location = new System.Drawing.Point(159, 8);
            this.DOMAIN.MaxLength = 50;
            this.DOMAIN.Name = "DOMAIN";
            this.DOMAIN.Size = new System.Drawing.Size(111, 20);
            this.DOMAIN.TabIndex = 1;
            this.DOMAIN.Text = "localhost";
            this.DOMAIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TCP
            // 
            this.TCP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCP.AutoSize = true;
            this.TCP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TCP.Checked = true;
            this.TCP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TCP.Location = new System.Drawing.Point(276, 10);
            this.TCP.Name = "TCP";
            this.TCP.Size = new System.Drawing.Size(47, 17);
            this.TCP.TabIndex = 2;
            this.TCP.Text = "TCP";
            this.TCP.UseVisualStyleBackColor = true;
            this.TCP.CheckedChanged += new System.EventHandler(this.TCP_CheckedChanged);
            // 
            // UDP
            // 
            this.UDP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UDP.AutoSize = true;
            this.UDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UDP.Location = new System.Drawing.Point(329, 10);
            this.UDP.Name = "UDP";
            this.UDP.Size = new System.Drawing.Size(49, 17);
            this.UDP.TabIndex = 3;
            this.UDP.Text = "UDP";
            this.UDP.UseVisualStyleBackColor = true;
            this.UDP.CheckedChanged += new System.EventHandler(this.UDP_CheckedChanged);
            // 
            // ROL
            // 
            this.ROL.AllowDrop = true;
            this.ROL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ROL.IntegralHeight = false;
            this.ROL.Location = new System.Drawing.Point(15, 151);
            this.ROL.Name = "ROL";
            this.ROL.ScrollAlwaysVisible = true;
            this.ROL.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ROL.Size = new System.Drawing.Size(170, 82);
            this.ROL.TabIndex = 4;
            // 
            // PORT1L
            // 
            this.PORT1L.AutoSize = true;
            this.PORT1L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PORT1L.Location = new System.Drawing.Point(12, 38);
            this.PORT1L.Name = "PORT1L";
            this.PORT1L.Size = new System.Drawing.Size(63, 17);
            this.PORT1L.TabIndex = 5;
            this.PORT1L.Text = "PORT 1:";
            // 
            // PORT1T
            // 
            this.PORT1T.HidePromptOnLeave = true;
            this.PORT1T.Location = new System.Drawing.Point(81, 37);
            this.PORT1T.Mask = "00000";
            this.PORT1T.Name = "PORT1T";
            this.PORT1T.Size = new System.Drawing.Size(52, 20);
            this.PORT1T.TabIndex = 6;
            this.PORT1T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PORT1T.ValidatingType = typeof(int);
            this.PORT1T.TextChanged += new System.EventHandler(this.PORT1T_TextChanged);
            // 
            // PORT2T
            // 
            this.PORT2T.HidePromptOnLeave = true;
            this.PORT2T.Location = new System.Drawing.Point(208, 37);
            this.PORT2T.Mask = "00000";
            this.PORT2T.Name = "PORT2T";
            this.PORT2T.Size = new System.Drawing.Size(52, 20);
            this.PORT2T.TabIndex = 8;
            this.PORT2T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PORT2T.ValidatingType = typeof(int);
            this.PORT2T.TextChanged += new System.EventHandler(this.PORT2T_TextChanged);
            // 
            // PORT2L
            // 
            this.PORT2L.AutoSize = true;
            this.PORT2L.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PORT2L.Location = new System.Drawing.Point(139, 38);
            this.PORT2L.Name = "PORT2L";
            this.PORT2L.Size = new System.Drawing.Size(63, 17);
            this.PORT2L.TabIndex = 7;
            this.PORT2L.Text = "PORT 2:";
            // 
            // SCAN
            // 
            this.SCAN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SCAN.Location = new System.Drawing.Point(276, 35);
            this.SCAN.Name = "SCAN";
            this.SCAN.Size = new System.Drawing.Size(102, 23);
            this.SCAN.TabIndex = 9;
            this.SCAN.Text = "START";
            this.SCAN.UseVisualStyleBackColor = true;
            this.SCAN.Click += new System.EventHandler(this.SCAN_Click);
            // 
            // RCL
            // 
            this.RCL.AllowDrop = true;
            this.RCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RCL.IntegralHeight = false;
            this.RCL.Location = new System.Drawing.Point(208, 151);
            this.RCL.Name = "RCL";
            this.RCL.ScrollAlwaysVisible = true;
            this.RCL.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.RCL.Size = new System.Drawing.Size(170, 82);
            this.RCL.TabIndex = 10;
            // 
            // Scanner
            // 
            this.Scanner.WorkerSupportsCancellation = true;
            this.Scanner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Scanner_DoWork);
            // 
            // AOPL
            // 
            this.AOPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AOPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AOPL.Location = new System.Drawing.Point(12, 131);
            this.AOPL.Name = "AOPL";
            this.AOPL.Size = new System.Drawing.Size(173, 17);
            this.AOPL.TabIndex = 11;
            this.AOPL.Text = "Opened Port List";
            this.AOPL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // KOPL
            // 
            this.KOPL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.KOPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KOPL.Location = new System.Drawing.Point(205, 131);
            this.KOPL.Name = "KOPL";
            this.KOPL.Size = new System.Drawing.Size(173, 17);
            this.KOPL.TabIndex = 12;
            this.KOPL.Text = "Closed Port List";
            this.KOPL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AOPC
            // 
            this.AOPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AOPC.Location = new System.Drawing.Point(12, 114);
            this.AOPC.Name = "AOPC";
            this.AOPC.Size = new System.Drawing.Size(173, 17);
            this.AOPC.TabIndex = 13;
            this.AOPC.Text = "0";
            this.AOPC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // KOPC
            // 
            this.KOPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KOPC.Location = new System.Drawing.Point(205, 114);
            this.KOPC.Name = "KOPC";
            this.KOPC.Size = new System.Drawing.Size(173, 17);
            this.KOPC.TabIndex = 14;
            this.KOPC.Text = "0";
            this.KOPC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // RESULT
            // 
            this.RESULT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RESULT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RESULT.Location = new System.Drawing.Point(15, 60);
            this.RESULT.Name = "RESULT";
            this.RESULT.Size = new System.Drawing.Size(363, 54);
            this.RESULT.TabIndex = 15;
            this.RESULT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Times
            // 
            this.Times.Tick += new System.EventHandler(this.Times_Tick);
            // 
            // TIMER
            // 
            this.TIMER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TIMER.Location = new System.Drawing.Point(15, 61);
            this.TIMER.Name = "TIMER";
            this.TIMER.Size = new System.Drawing.Size(363, 13);
            this.TIMER.TabIndex = 16;
            this.TIMER.Text = "The Passing Time: 0s";
            this.TIMER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FST
            // 
            this.FST.AutoSize = true;
            this.FST.Checked = true;
            this.FST.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FST.Location = new System.Drawing.Point(15, 60);
            this.FST.Name = "FST";
            this.FST.Size = new System.Drawing.Size(105, 17);
            this.FST.TabIndex = 18;
            this.FST.Text = "Super Fast Scan";
            this.FST.UseVisualStyleBackColor = true;
            // 
            // LAST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 245);
            this.Controls.Add(this.FST);
            this.Controls.Add(this.TIMER);
            this.Controls.Add(this.RESULT);
            this.Controls.Add(this.KOPC);
            this.Controls.Add(this.AOPC);
            this.Controls.Add(this.KOPL);
            this.Controls.Add(this.AOPL);
            this.Controls.Add(this.RCL);
            this.Controls.Add(this.SCAN);
            this.Controls.Add(this.PORT2T);
            this.Controls.Add(this.PORT2L);
            this.Controls.Add(this.PORT1T);
            this.Controls.Add(this.PORT1L);
            this.Controls.Add(this.TCP);
            this.Controls.Add(this.UDP);
            this.Controls.Add(this.ROL);
            this.Controls.Add(this.DOMAIN);
            this.Controls.Add(this.IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LAST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portscan v1.2";
            this.Load += new System.EventHandler(this.LAST_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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