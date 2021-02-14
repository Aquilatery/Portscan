using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portscan
{
    public partial class LAST : Form
    {
        private bool Start = true;
        private int EIS = 0;
        private double Time = 0;

        public LAST()
        {
            InitializeComponent();
        }

        private void LAST_Load(object sender, EventArgs e)
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
                DOMAIN.Size = new Size(219, 20);
                MessageBox.Show("Selection Disabled Because UDP Is Not Supported!", "TCP/UDP Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TCP_CheckedChanged(object sender, EventArgs e)
        {
            if (Start)
            {
                UDP.Checked = !TCP.Checked;
            }
        }

        private void UDP_CheckedChanged(object sender, EventArgs e)
        {
            if (Start)
            {
                TCP.Checked = !UDP.Checked;
            }
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
                    {
                        MessageBox.Show("IP Address - Domain is Empty!");
                    }
                    else if (DOMAIN.Text.StartsWith("http"))
                    {
                        MessageBox.Show("Domain Address Does Not Start With 'http' or 'https'!");
                    }
                    else if (string.IsNullOrEmpty(PORT1T.Text))
                    {
                        MessageBox.Show("PORT 1 is Empty!");
                    }
                    else if (Convert.ToInt32(PORT1T.Text) == 0 || Convert.ToInt32(PORT1T.Text) > 65535)
                    {
                        MessageBox.Show("PORT 1 Must Be Greater Than 0, Less Than 65535!");
                    }
                    else if (!string.IsNullOrEmpty(PORT2T.Text) && Convert.ToInt32(PORT1T.Text) == 0 || Convert.ToInt32(PORT1T.Text) > 65535)
                    {
                        MessageBox.Show("PORT 2 Must Be Greater Than 0 and Less Than 65535!");
                    }
                    else if (!string.IsNullOrEmpty(PORT2T.Text) && (PORT1T.Text == PORT2T.Text || Convert.ToInt32(PORT1T.Text) == Convert.ToInt32(PORT2T.Text)))
                    {
                        MessageBox.Show("PORT 1 Cannot Be The Same As PORT 2!");
                    }
                    else if (!string.IsNullOrEmpty(PORT2T.Text) && Convert.ToInt32(PORT1T.Text) > Convert.ToInt32(PORT2T.Text))
                    {
                        MessageBox.Show("PORT 1 Must Be Less Than PORT 2!");
                    }
                    else if (PORT1T.Text.StartsWith("0"))
                    {
                        MessageBox.Show("PORT 1 Value Cannot Begin With 0!");
                    }
                    else if (PORT2T.Text.StartsWith("0"))
                    {
                        MessageBox.Show("PORT 2 Value Cannot Begin With 0!");
                    }
                    else
                    {
                        FIX(false);
                    }
                }
                else
                {
                    FIX(true);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\n\n" + Error.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Times_Tick(object sender, EventArgs e)
        {
            try
            {
                Time += 0.1;
                TIMER.Text = "The Passing Time: " + Math.Round(Time, 1) + "s";
                PRT();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\n\n" + Error.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    SCAN.Text = "START";
                    Scanner.CancelAsync();
                    Times.Stop();
                }
                else
                {
                    if (ROL.Items.Count > 1)
                    {
                        ROL.Items.Clear();
                    }

                    if (RCL.Items.Count > 1)
                    {
                        RCL.Items.Clear();
                    }

                    SCAN.Text = "STOP";
                    RESULT.Text = "";
                    AOPC.Text = "0";
                    KOPC.Text = "0";
                    Time = 0;
                    TIMER.Text = "The Passing Time: 0s";
                    if (string.IsNullOrEmpty(PORT2T.Text))
                    {
                        EIS = 1;
                    }
                    else
                    {
                        EIS = int.Parse(PORT2T.Text) - int.Parse(PORT1T.Text);
                    }

                    Times.Start();
                    Scanner.RunWorkerAsync();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\n\n" + Error.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void PRT()
        {
            try
            {
                int R = 0;
                if (!string.IsNullOrEmpty(PORT2T.Text))
                {
                    R = EIS - (ROL.Items.Count + RCL.Items.Count) + 1;
                }

                if (R > 0)
                {
                    RESULT.Text = "REMAINING: " + R;
                }
                else
                {
                    RESULT.Text = "";
                    FIX(true);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\n\n" + Error.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private ProtocolType GTU()
        {
            if (TCP.Checked)
            {
                return ProtocolType.Tcp;
            }
            else
            {
                return ProtocolType.Udp;
            }
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

        private void Scanner_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int E;
                if (string.IsNullOrEmpty(PORT2T.Text))
                {
                    E = int.Parse(PORT1T.Text);
                }
                else
                {
                    E = int.Parse(PORT2T.Text);
                }

                Parallel.For(int.Parse(PORT1T.Text), ++E, C =>
                {
                    if (!Start)
                    {
                        int P = C;
                        Task TASK = new Task(delegate ()
                        {
                            if (FST.Checked)
                            {
                                SCN2(P, DOMAIN.Text);
                            }
                            else
                            {
                                SCN1(P, DOMAIN.Text);
                            }
                        });
                        TASK.Start();
                    }
                });
                Task.WaitAll();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message + "\n\n" + Error.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}