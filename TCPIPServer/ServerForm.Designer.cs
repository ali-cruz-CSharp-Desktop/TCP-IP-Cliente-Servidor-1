
namespace TCPIPServer
{
    partial class ServerForm
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
            this.TxbServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbInfo = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.txbMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LstClient = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTotalIps = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxbServer
            // 
            this.TxbServer.Location = new System.Drawing.Point(113, 46);
            this.TxbServer.Name = "TxbServer";
            this.TxbServer.Size = new System.Drawing.Size(97, 20);
            this.TxbServer.TabIndex = 13;
            this.TxbServer.Text = "192.168.2.47";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "IP / Nombre PC";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(71, 392);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(96, 35);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbInfo
            // 
            this.txbInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbInfo.Location = new System.Drawing.Point(73, 83);
            this.txbInfo.Multiline = true;
            this.txbInfo.Name = "txbInfo";
            this.txbInfo.ReadOnly = true;
            this.txbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbInfo.Size = new System.Drawing.Size(370, 233);
            this.txbInfo.TabIndex = 10;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(346, 392);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(96, 35);
            this.BtnStart.TabIndex = 9;
            this.BtnStart.Text = "Iniciar Server";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // txbMsg
            // 
            this.txbMsg.Location = new System.Drawing.Point(72, 329);
            this.txbMsg.Multiline = true;
            this.txbMsg.Name = "txbMsg";
            this.txbMsg.Size = new System.Drawing.Size(371, 47);
            this.txbMsg.TabIndex = 8;
            this.txbMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMsg_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mensaje:";
            // 
            // LstClient
            // 
            this.LstClient.FormattingEnabled = true;
            this.LstClient.Location = new System.Drawing.Point(474, 82);
            this.LstClient.Name = "LstClient";
            this.LstClient.Size = new System.Drawing.Size(233, 290);
            this.LstClient.TabIndex = 14;
            this.LstClient.SelectedIndexChanged += new System.EventHandler(this.LstClient_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Listado Clientes IP:";
            // 
            // TxbPort
            // 
            this.TxbPort.Location = new System.Drawing.Point(378, 46);
            this.TxbPort.Name = "TxbPort";
            this.TxbPort.Size = new System.Drawing.Size(61, 20);
            this.TxbPort.TabIndex = 17;
            this.TxbPort.Text = "9001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Puerto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // LblTotalIps
            // 
            this.LblTotalIps.AutoSize = true;
            this.LblTotalIps.Location = new System.Drawing.Point(576, 379);
            this.LblTotalIps.Name = "LblTotalIps";
            this.LblTotalIps.Size = new System.Drawing.Size(103, 13);
            this.LblTotalIps.TabIndex = 19;
            this.LblTotalIps.Text = "Total de elementos: ";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 449);
            this.Controls.Add(this.LblTotalIps);
            this.Controls.Add(this.TxbPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LstClient);
            this.Controls.Add(this.TxbServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbInfo);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.txbMsg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txbInfo;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox txbMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LstClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label LblTotalIps;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}