using SuperSimpleTcp;
using System;
using System.Linq;
using System.Net;
using System.Text;

using System.Windows.Forms;

namespace TCPIPClient
{
    public partial class ClientForm : Form
    {
        SimpleTcpClient client;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txbInfo.Text += $"Servidor Desconectado. {Environment.NewLine}";
            });            
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txbInfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data.ToArray())} {Environment.NewLine}";
                MostrarNotificacion(Encoding.UTF8.GetString(e.Data.ToArray()));
                System.Diagnostics.Debug.WriteLine("Events_DataReceived");
            });
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txbInfo.Text += $"Servidor Conectado. {Environment.NewLine}";
            });
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //IPAddress ipAddress = Dns.GetHostEntry(TxbServer.Text).AddressList[0];
                //string ipp = ipAddress.MapToIPv4().ToString();
                string ip4 = string.Empty;

                IPAddress[] ipAddress = Dns.GetHostAddresses(TxbServer.Text);
                foreach (IPAddress adress in ipAddress)
                {
                    if (adress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        ip4 = adress.ToString();
                    }
                }

                client = new SimpleTcpClient(ip4, Convert.ToInt32(TxbPuerto.Text));
                client.Connect();

                client.Events.Connected += Events_Connected;
                client.Events.DataReceived += Events_DataReceived;
                client.Events.Disconnected += Events_Disconnected;
                

                btnSend.Enabled = true;
                BtnConnect.Enabled = false;

                txbInfo.Text += $"Iniciando conexión con el servidor {TxbServer.Text} con puerto " +
                    $"{TxbPuerto.Text} {Environment.NewLine}";

                if (client.IsConnected)
                {
                    txbInfo.Text += $"Conectado correctamente al servidor {TxbServer.Text} " +
                        $"con puerto {TxbPuerto.Text} {Environment.NewLine}";
                } else
                {
                    txbInfo.Text += $"Hubo un error al intentar conectarte al servidor " +
                        $"{TxbServer.Text} con puerto {TxbPuerto.Text} {Environment.NewLine}";
                }

            } catch (Exception ex)
            {
                txbInfo.Text += $"Error al intentar conectar al servidor {TxbServer.Text} " +
                    $"con puerto {TxbPuerto.Text}. {ex} {Environment.NewLine}";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            EnviarMensaje();
        }

        private void EnviarMensaje()
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txbMsg.Text))
                {
                    client.Send(txbMsg.Text);
                    txbInfo.Text += $"Yo: {txbMsg.Text}{Environment.NewLine}";
                    txbMsg.Text = string.Empty;
                }
            }
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



        private void txbMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnviarMensaje();
            }
        }
    }
}
