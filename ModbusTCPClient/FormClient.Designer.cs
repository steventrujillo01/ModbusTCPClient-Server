namespace ModbusTCPClient
{
    partial class FormClient
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtDirezioneInizio = new System.Windows.Forms.TextBox();
            this.txtNumeroRegistri = new System.Windows.Forms.TextBox();
            this.txtDirezioneRegistro = new System.Windows.Forms.TextBox();
            this.txtValoreRegistro = new System.Windows.Forms.TextBox();
            this.lblStatusClient = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modbus TCP Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP del Server:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Read registers of Holding:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Posizione di inizio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero di registri:";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(113, 224);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(113, 23);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Leggere registri";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(390, 224);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(113, 23);
            this.btnWrite.TabIndex = 7;
            this.btnWrite.Text = "Scrivere registro";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Write register:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Posizione di registro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Valore di registro:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(138, 287);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(338, 20);
            this.txtResult.TabIndex = 11;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(257, 46);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(126, 20);
            this.txtIP.TabIndex = 12;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(257, 82);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(126, 20);
            this.txtPorta.TabIndex = 13;
            // 
            // txtDirezioneInizio
            // 
            this.txtDirezioneInizio.Location = new System.Drawing.Point(147, 159);
            this.txtDirezioneInizio.Name = "txtDirezioneInizio";
            this.txtDirezioneInizio.Size = new System.Drawing.Size(103, 20);
            this.txtDirezioneInizio.TabIndex = 14;
            // 
            // txtNumeroRegistri
            // 
            this.txtNumeroRegistri.Location = new System.Drawing.Point(147, 187);
            this.txtNumeroRegistri.Name = "txtNumeroRegistri";
            this.txtNumeroRegistri.Size = new System.Drawing.Size(103, 20);
            this.txtNumeroRegistri.TabIndex = 15;
            // 
            // txtDirezioneRegistro
            // 
            this.txtDirezioneRegistro.Location = new System.Drawing.Point(445, 159);
            this.txtDirezioneRegistro.Name = "txtDirezioneRegistro";
            this.txtDirezioneRegistro.Size = new System.Drawing.Size(104, 20);
            this.txtDirezioneRegistro.TabIndex = 16;
            // 
            // txtValoreRegistro
            // 
            this.txtValoreRegistro.Location = new System.Drawing.Point(446, 188);
            this.txtValoreRegistro.Name = "txtValoreRegistro";
            this.txtValoreRegistro.Size = new System.Drawing.Size(103, 20);
            this.txtValoreRegistro.TabIndex = 17;
            // 
            // lblStatusClient
            // 
            this.lblStatusClient.AutoSize = true;
            this.lblStatusClient.Location = new System.Drawing.Point(460, 85);
            this.lblStatusClient.Name = "lblStatusClient";
            this.lblStatusClient.Size = new System.Drawing.Size(43, 13);
            this.lblStatusClient.TabIndex = 18;
            this.lblStatusClient.Text = "Status :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(463, 46);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(279, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Risultato";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 335);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStatusClient);
            this.Controls.Add(this.txtValoreRegistro);
            this.Controls.Add(this.txtDirezioneRegistro);
            this.Controls.Add(this.txtNumeroRegistri);
            this.Controls.Add(this.txtDirezioneInizio);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormClient";
            this.Text = "Modbus TCP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtDirezioneInizio;
        private System.Windows.Forms.TextBox txtNumeroRegistri;
        private System.Windows.Forms.TextBox txtDirezioneRegistro;
        private System.Windows.Forms.TextBox txtValoreRegistro;
        private System.Windows.Forms.Label lblStatusClient;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label10;
    }
}

