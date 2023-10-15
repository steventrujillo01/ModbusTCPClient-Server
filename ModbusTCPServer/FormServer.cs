using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;


namespace ModbusTCPServer
{
    public partial class FormServer : Form
    {

        public bool IsServerRunning { get; private set; }
        ModbusServer ModServer;
        private string ip { get; set; }
        private int port {  get;  set; }


        public FormServer()
        {
            InitializeComponent();
            SetDefaultIpAndPort(ip,port);
        }
        
        private void SetDefaultIpAndPort(string ip ,int port)
        {
            if (!string.IsNullOrWhiteSpace(ip) && port > 300) 
            {
                this.ip = txtIP.Text;
                this.port = int.Parse(txtPorta.Text);

            }
            else
            {
                this.ip = "127.0.0.1";
                this.port = 502;
                txtIP.Text = this.ip;
                txtPorta.Text = this.port.ToString();
            }

        }


        private void btnStart_Click(object sender, EventArgs e)
        {

            try
            {
                if (btnStart.Text == "START")
                {
                    ModServer = new ModbusServer();                  
                    ModServer.Listen();
                    this.IsServerRunning = true;
                    UpdateClientStatus(true);
                    btnStart.Text = "STOP";
                }
                else if (btnStart.Text == "STOP")
                {
                    ModServer.StopListening();
                    ModServer = null;
                    this.IsServerRunning = false;
                    UpdateClientStatus(false);
                    btnStart.Text = "START";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void UpdateClientStatus(bool isConnected)
        {

            if (isConnected && (!string.IsNullOrWhiteSpace(ip) && port > 300))
            {
                lblStatus.Text = "Server connected";
                lblStatus.BackColor = Color.Green;
            }
            else
            {
                txtIP.Text = this.ip;
                txtPorta.Text = this.port.ToString();
                lblStatus.Text = "Server disconnected";
                lblStatus.BackColor = Color.LightGray;
            }
        }



    }
}
