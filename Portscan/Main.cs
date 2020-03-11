using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (Start)
            {
                if (string.IsNullOrEmpty(DOMAIN.Text) || string.IsNullOrWhiteSpace(DOMAIN.Text))
                    MessageBox.Show("IP Adresi - Domain Boş!");
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

        private void Times_Tick(object sender, EventArgs e)
        {
            Time += 0.1;
            TIMER.Text = "Geçen Süre: " + Math.Round(Time, 1) + "s";
        }

        private void FIX(bool State)
        {
            Start = State;
            DOMAIN.Enabled = State;
            PORT1T.Enabled = State;
            PORT2T.Enabled = State;
            TCP.Enabled = State;
            UDP.Enabled = State;
            if (State)
            {
                SCAN.Text = "BAŞLAT";
                Scanner.CancelAsync();
                Times.Stop();
            }
            else
            {
                SCAN.Text = "DURDUR";
                Times.Start();
                RO.Items.Clear();
                RC.Items.Clear();
                RESULT.Text = "";
                AOPC.Text = "0";
                KOPC.Text = "0";
                Time = 0.0;
                if (string.IsNullOrEmpty(PORT2T.Text))
                    EIS = 1;
                else
                    EIS = Int32.Parse(PORT2T.Text) - Int32.Parse(PORT1T.Text);
                Scanner.RunWorkerAsync();
            }
        }

        private void PRT()
        {
            int R = 0;
            if (!string.IsNullOrEmpty(PORT2T.Text))
                R = EIS - (RO.Items.Count + RC.Items.Count) + 1;
            if (R > 0)
                RESULT.Text = "KALAN: " + R;
            else
            {
                RESULT.Text = "";
                FIX(true);
            }
        }

        private ProtocolType GTU()
        {
            if (TCP.Checked)
                return ProtocolType.Tcp;
            else
                return ProtocolType.Udp;
        }

        private void SCN(int P, string IP)
        {
            if (!Start)
            {
                Socket Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, GTU());
                try
                {
                    Socket.Connect(IP, P);
                    RO.Items.Add(P);
                    Socket.Dispose();
                    AOPC.Text = RO.Items.Count.ToString();
                    if (RO.Items.Count > 0)
                        RO.SelectedIndex = RO.Items.Count - 1;
                }
                catch
                {
                    RC.Items.Add(P);
                    Socket.Dispose();
                    KOPC.Text = RC.Items.Count.ToString();
                    if (RC.Items.Count > 0)
                        RC.SelectedIndex = RC.Items.Count - 1;
                }
                PRT();
            }
        }

        private void Scanner_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int E;
            if (string.IsNullOrEmpty(PORT2T.Text))
                E = Int32.Parse(PORT1T.Text);
            else
                E = Int32.Parse(PORT2T.Text);
            for (int C = Int32.Parse(PORT1T.Text); C <= E; C++)
            {
                if (Start)
                    break;
                else
                {
                    int P = C;
                    Task TASK = new Task(delegate ()
                    {
                        SCN(P, DOMAIN.Text);
                    });
                    TASK.Start();
                }
            }
            Task.WaitAll();
        }
    }
}