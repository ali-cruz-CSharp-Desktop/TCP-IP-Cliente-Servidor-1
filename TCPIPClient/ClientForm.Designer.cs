
namespace TCPIPClient
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txbMsg = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.txbInfo = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.TxbServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TxbPuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensaje:";
            // 
            // txbMsg
            // 
            this.txbMsg.Location = new System.Drawing.Point(62, 316);
            this.txbMsg.Multiline = true;
            this.txbMsg.Name = "txbMsg";
            this.txbMsg.Size = new System.Drawing.Size(284, 39);
            this.txbMsg.TabIndex = 1;
            this.txbMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMsg_KeyDown);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(249, 371);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(96, 35);
            this.BtnConnect.TabIndex = 2;
            this.BtnConnect.Text = "Conectarme";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // txbInfo
            // 
            this.txbInfo.Location = new System.Drawing.Point(66, 66);
            this.txbInfo.Multiline = true;
            this.txbInfo.Name = "txbInfo";
            this.txbInfo.ReadOnly = true;
            this.txbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbInfo.Size = new System.Drawing.Size(279, 240);
            this.txbInfo.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(63, 370);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(96, 35);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // TxbServer
            // 
            this.TxbServer.Location = new System.Drawing.Point(111, 38);
            this.TxbServer.Name = "TxbServer";
            this.TxbServer.Size = new System.Drawing.Size(96, 20);
            this.TxbServer.TabIndex = 6;
            this.TxbServer.Text = "192.168.2.47";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP / Nombre PC";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // TxbPuerto
            // 
            this.TxbPuerto.Location = new System.Drawing.Point(258, 38);
            this.TxbPuerto.Name = "TxbPuerto";
            this.TxbPuerto.Size = new System.Drawing.Size(51, 20);
            this.TxbPuerto.TabIndex = 8;
            this.TxbPuerto.Text = "9001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Puerto";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.TxbPuerto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxbServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbInfo);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.txbMsg);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMsg;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox txbInfo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox TxbServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox TxbPuerto;
        private System.Windows.Forms.Label label3;
    }
}