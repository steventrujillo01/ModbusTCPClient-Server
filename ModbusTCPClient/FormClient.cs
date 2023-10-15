using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using ModbusTCPServer;

namespace ModbusTCPClient
{

    public partial class FormClient : Form
    {
        
        ModbusClient modbusClient;
        private FormServer formServer;
        bool isServerRunning;
        private string ip { get; set; }
        private int port { get; set; }


        public FormClient(FormServer server)
        {
            InitializeComponent();       
            modbusClient = new ModbusClient();
            SetDefaultIpAndPort(ip, port);
            modbusClient.ConnectionTimeout = 60000;
            formServer = server;
            isServerRunning = formServer.IsServerRunning; 
            
        }

        private void SetDefaultIpAndPort(string ip, int port)
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

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                int startAddress = int.Parse(txtDirezioneInizio.Text);
                int numRegisters = int.Parse(txtNumeroRegistri.Text);

                int[] registers = modbusClient.ReadHoldingRegisters(startAddress, numRegisters);

                // Vedere i registri nel txtResult
                txtResult.Text = string.Join(", ", registers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore al leggere registro del holding: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int registerAddress = int.Parse(txtDirezioneRegistro.Text);
                int valueToWrite = int.Parse(txtValoreRegistro.Text);

                modbusClient.WriteSingleRegister(registerAddress, valueToWrite);
                txtResult.Text = "Registro scritto esitosamente.Premi buttone Leggere registri";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore al scrivere registro: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modbusClient.Connected)
                modbusClient.Disconnect();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
          

            try
            {
                if (modbusClient.Connected || isServerRunning)
                {
                    modbusClient.Disconnect();
                    UpdateClientStatus(false);
                    CleanTextBoxes();
                    btnStart.Text = "START";
                }
                else
                {

                    modbusClient = new ModbusClient(ip, port);
                    modbusClient.Connect();
                    UpdateClientStatus(true);
                    btnStart.Text = "STOP";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore al collegarsi al server " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void CleanTextBoxes()
        {
            txtDirezioneInizio.Text = " ";
            txtDirezioneRegistro.Text = " ";
            txtNumeroRegistri.Text = " ";
            txtValoreRegistro.Text  = " ";
            txtResult.Text = " ";
            txtIP.Text = " ";
            txtPorta.Text = "0";
        }


        private void UpdateClientStatus(bool isConnected)
        {

            if (isConnected)
            {              
                lblStatusClient.Text = "Client connected";
                lblStatusClient.BackColor = Color.Green;
            }
            else
            {
                lblStatusClient.Text = "Client disconnected";
                lblStatusClient.BackColor = Color.LightGray;
            }
        }
    }
}
