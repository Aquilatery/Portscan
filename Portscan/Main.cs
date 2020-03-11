using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Portscan
{
    public partial class Main : Form
    {
        bool Start = true;
        int EIS = 0;
        double Time = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                Socket UDPC = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Udp);
                UDPC.Dispose();
            }
            catch
            {
                UDP.Visible = false;
                TCP.Visible = false;
                DOMAIN.Size = new System.Drawing.Size(231, 20);
                MessageBox.Show("UDP Desteklenmediğinden Seçim Devre Dışı Bırakıldı!", "TCP/UDP Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TCP_CheckedChanged(object sender, EventArgs e)
        {
            if (Start)
                UDP.Checked = !TCP.Checked;
        }

        private void UDP_CheckedChanged(object sender, EventArgs e)
        {
            if (Start)
                TCP.Checked = !UDP.Checked;
        }

        private void PORT1T_TextChanged(object sender, EventArgs e)
        {
            PORT1T.Text = PORT1T.Text.Replace(" ", "");
        }

        private void PORT2T_TextChanged(object sender, EventArgs e)
        {
            PORT2T.Text = PORT2T.Text.Replace(" ", "");
        }

        private void SCAN_Click(object sender, EventArgs e)
        {
            try
            {
                if (Start)
                {
                    if (string.IsNullOrEmpty(DOMAIN.Text) || string.IsNullOrWhiteSpace(DOMAIN.Text))
                        MessageBox.Show("IP Adresi - Domain Boş!");
                    else if (DOMAIN.Text.StartsWith("http"))
                        MessageBox.Show("Domain Adresi 'http' veya 'https' İle Başlamaz!");
                    else if (string.IsNullOrEmpty(PORT1T.Text))
                        MessageBox.Show("PORT 1 Boş!");
                    else if (Convert.ToInt32(PORT1T.Text) == 0 || Convert.ToInt32(PORT1T.Text) > 65535)
                        MessageBox.Show("PORT 1 0'dan Büyük, 65535'ten Küçük Olmalı!");
                    else if (!string.IsNullOrEmpty(PORT2T.Text) && Convert.ToInt32(PORT1T.Text) == 0 || Convert.ToInt32(PORT1T.Text) > 65535)
                        MessageBox.Show("PORT 2 0'dan Büyük, 65535'ten Küçük Olmalı!");
                    else if (!string.IsNullOrEmpty(PORT2T.Text) && (PORT1T.Text == PORT2T.Text || Convert.ToInt32(PORT1T.Text) == Convert.ToInt32(PORT2T.Text)))
                        MessageBox.Show("PORT 1, PORT 2 İle Aynı Olamaz!");
                    else if (!string.IsNullOrEmpty(PORT2T.Text) && Convert.ToInt32(PORT1T.Text) > Convert.ToInt32(PORT2T.Text))
                        MessageBox.Show("PORT 1, PORT 2'den Küçük Olmalı!");
                    else if (PORT1T.Text.StartsWith("0"))
                        MessageBox.Show("PORT 1 Değeri 0 İle Başlayamaz!");
                    else if (PORT2T.Text.StartsWith("0"))
                        MessageBox.Show("PORT 2 Değeri 0 İle Başlayamaz!");
                    else
                        FIX(false);
                }
                else
                    FIX(true);
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message + "\n\n" + Hata.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void CLS_Click(object sender, EventArgs e)
        {
            try
            {
                if (ROL.Items.Count > 1)
                    ROL.Items.Clear();
                if (RCL.Items.Count > 1)
                    RCL.Items.Clear();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message + "\n\n" + Hata.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Application.Exit();
            }
        }

        private void Times_Tick(object sender, EventArgs e)
        {
            try
            {
                Time += 0.1;
                TIMER.Text = "Geçen Süre: " + Math.Round(Time, 1) + "s";
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message + "\n\n" + Hata.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void FIX(bool State)
        {
            try
            {
                Start = State;
                DOMAIN.Enabled = State;
                PORT1T.Enabled = State;
                PORT2T.Enabled = State;
                TCP.Enabled = State;
                UDP.Enabled = State;
                FST.Enabled = State;
                if (State)
                {
                    SCAN.Text = "BAŞLAT";
                    Scanner.CancelAsync();
                    Times.Stop();
                    CLS.Enabled = true;
                }
                else
                {
                    SCAN.Text = "DURDUR";
                    RESULT.Text = "";
                    AOPC.Text = "0";
                    KOPC.Text = "0";
                    Time = 0;
                    TIMER.Text = "Geçen Süre: 0s";
                    if (string.IsNullOrEmpty(PORT2T.Text))
                        EIS = 1;
                    else
                        EIS = Int32.Parse(PORT2T.Text) - Int32.Parse(PORT1T.Text);
                    Times.Start();
                    Scanner.RunWorkerAsync();
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message + "\n\n" + Hata.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void PRT()
        {
            try
            {
                int R = 0;
                if (!string.IsNullOrEmpty(PORT2T.Text))
                    R = EIS - (ROL.Items.Count + RCL.Items.Count) + 1;
                if (R > 0)
                    RESULT.Text = "KALAN: " + R;
                else
                {
                    RESULT.Text = "";
                    FIX(true);
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message + "\n\n" + Hata.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private ProtocolType GTU()
        {
            if (TCP.Checked)
                return ProtocolType.Tcp;
            else
                return ProtocolType.Udp;
        }

        private void SCN1(int P, string IP)
        {
            if (!Start)
            {
                Socket Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, GTU());
                try
                {
                    Socket.Connect(IP, P);
                    ROL.Items.Add(P);
                    AOPC.Text = ROL.Items.Count.ToString();
                    Socket.Dispose();
                }
                catch
                {
                    RCL.Items.Add(P);
                    KOPC.Text = RCL.Items.Count.ToString();
                    Socket.Dispose();
                }
            }
            PRT();
        }

        private async void SCN2(int P, string IP)
        {
            if (!Start)
            {
                Socket Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, GTU());
                try
                {
                    await Socket.ConnectAsync(IP, P);
                    ROL.Items.Add(P);
                    AOPC.Text = ROL.Items.Count.ToString();
                    Socket.Dispose();
                }
                catch
                {
                    RCL.Items.Add(P);
                    KOPC.Text = RCL.Items.Count.ToString();
                    Socket.Dispose();
                }
            }
            PRT();
        }

        private void Scanner_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                int E;
                if (string.IsNullOrEmpty(PORT2T.Text))
                    E = Int32.Parse(PORT1T.Text);
                else
                    E = Int32.Parse(PORT2T.Text);
                Parallel.For(Int32.Parse(PORT1T.Text), ++E, C =>
                {
                    if (!Start)
                    {
                        int P = C;
                        Task TASK = new Task(delegate ()
                        {
                            if (FST.Checked)
                                SCN2(P, DOMAIN.Text);
                            else
                                SCN1(P, DOMAIN.Text);
                        });
                        TASK.Start();
                    }
                });
                Task.WaitAll();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message + "\n\n" + Hata.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}