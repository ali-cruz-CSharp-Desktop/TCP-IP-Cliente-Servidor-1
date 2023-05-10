using SuperSimpleTcp;
using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace TCPIPServer
{
    public partial class ServerForm : Form
    {
        SimpleTcpServer server;


        public ServerForm()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //IPAddress ipAddress = Dns.GetHostEntry(TxbServer.Text).AddressList[0];
                //string ipp = ipAddress.MapToIPv4().ToString();
                string ip4 = string.Empty;

                // Replace with the name of the adapter you want to retrieve the IPv4 address for
                string adapterName = "Ethernet";

                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

                foreach (NetworkInterface adapter in interfaces)
                {
                    if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet && adapter.Name == adapterName)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();

                        foreach (UnicastIPAddressInformation address in properties.UnicastAddresses)
                        {
                            if (address.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                ip4 = address.Address.ToString();
                            }
                        }
                    }
                }

                //IPAddress[] ipAddress = Dns.GetHostAddresses(TxbServer.Text);
                //foreach (IPAddress address in ipAddress)
                //{
                //    if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                //    {
                //        ip4 = address.ToString();
                //    }
                //}

                server = new SimpleTcpServer(ip4, Convert.ToInt32(TxbPort.Text.Trim()));
                server.Start();

                server.Events.ClientConnected += Events_ClientConnected;
                server.Events.ClientDisconnected += Events_ClientDisconnected;
                server.Events.DataReceived += Events_DataReceived;


                txbInfo.Text = $"{Environment.NewLine} {DateTime.Now} Iniciando servidor... {txbInfo.Text} {Environment.NewLine}";
                BtnStart.Enabled = false;
                btnSend.Enabled = true;

                if (server.IsListening)
                {
                    txbInfo.Text = $"{Environment.NewLine} {DateTime.Now} Servidor iniciado correctamente. {txbInfo.Text} {Environment.NewLine}";
                }
                else
                {
                    txbInfo.Text = $"{Environment.NewLine} {DateTime.Now} Hubo un error al intentar iniciar el servidor. {txbInfo.Text} {Environment.NewLine}";
                }
            } catch (Exception ex)
            {
                txbInfo.Text = $"{Environment.NewLine} {DateTime.Now} {ex}. {txbInfo.Text} {Environment.NewLine}";
            }
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;            
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                System.Diagnostics.Debug.WriteLine("Events_DataReceived");
                byte[] byteData = e.Data.ToArray();
                txbInfo.Text = $"{Environment.NewLine} {DateTime.Now} - {e.IpPort} : {Encoding.UTF8.GetString(byteData)} {txbInfo.Text} {Environment.NewLine}";
                MostrarNotificacion(Encoding.UTF8.GetString(e.Data.ToArray()));
            });            
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txbInfo.Text = $"{Environment.NewLine} {DateTime.Now} - {e.IpPort} Desconectado. {txbInfo.Text} {Environment.NewLine}";
                LstClient.Items.Remove(e.IpPort);
                LblTotalIps.Text = $"Total de elementos: {LstClient.Items.Count}";
            });            
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txbInfo.Text = $"{Environment.NewLine} {DateTime.Now} - {e.IpPort} Conectado. {txbInfo.Text} {Environment.NewLine}";
                LstClient.Items.Insert(0, e.IpPort);
                LblTotalIps.Text = $"Total de elementos: {LstClient.Items.Count}";                
            });            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            EnviarMensaje();
        }

        private void EnviarMensaje()
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txbMsg.Text) && LstClient.SelectedItem != null)
                {
                    server.Send(LstClient.SelectedItem.ToString(), txbMsg.Text.Trim());
                    txbInfo.Text = $"{Environment.NewLine} {DateTime.Now} Server: {txbMsg.Text} {txbInfo.Text} {Environment.NewLine}";
                    txbMsg.Text = string.Empty;
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnviarMensaje();
            }
        }

        private void LstClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblTotalIps.Text = $"Total de elementos: {LstClient.Items.Count}";
        }

        private void MostrarNotificacion(string msg)
        {
            //notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@""));
            notifyIcon1.Text = msg;
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = msg;
            notifyIcon1.BalloonTipText = "Detalles de la notificación";
            notifyIcon1.ShowBalloonTip(1000);
        }
    }
}
