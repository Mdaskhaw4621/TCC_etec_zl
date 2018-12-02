namespace WindowsFormsApplication1
{
    partial class frm_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Status));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCapacidade = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmperagem = new System.Windows.Forms.Label();
            this.lblVoltagem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNivelBat = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_temp_rest = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.metroProgressSpinner_Bateria_percent = new MetroFramework.Controls.MetroProgressSpinner();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip_btn_Conectar = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(18, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 246);
            this.panel3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(249, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Informações Complementares";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(225)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lblCapacidade);
            this.panel6.Location = new System.Drawing.Point(21, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(393, 169);
            this.panel6.TabIndex = 16;
            // 
            // lblCapacidade
            // 
            this.lblCapacidade.AutoSize = true;
            this.lblCapacidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidade.ForeColor = System.Drawing.Color.White;
            this.lblCapacidade.Location = new System.Drawing.Point(60, 49);
            this.lblCapacidade.Name = "lblCapacidade";
            this.lblCapacidade.Size = new System.Drawing.Size(133, 25);
            this.lblCapacidade.TabIndex = 4;
            this.lblCapacidade.Text = "Capacidade:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(225)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.lblAmperagem);
            this.panel7.Controls.Add(this.lblVoltagem);
            this.panel7.Location = new System.Drawing.Point(412, 54);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(398, 169);
            this.panel7.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // lblAmperagem
            // 
            this.lblAmperagem.AutoSize = true;
            this.lblAmperagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmperagem.ForeColor = System.Drawing.Color.White;
            this.lblAmperagem.Location = new System.Drawing.Point(52, 91);
            this.lblAmperagem.Name = "lblAmperagem";
            this.lblAmperagem.Size = new System.Drawing.Size(133, 25);
            this.lblAmperagem.TabIndex = 5;
            this.lblAmperagem.Text = "Âmperagem:";
            // 
            // lblVoltagem
            // 
            this.lblVoltagem.AutoSize = true;
            this.lblVoltagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltagem.ForeColor = System.Drawing.Color.White;
            this.lblVoltagem.Location = new System.Drawing.Point(52, 49);
            this.lblVoltagem.Name = "lblVoltagem";
            this.lblVoltagem.Size = new System.Drawing.Size(152, 25);
            this.lblVoltagem.TabIndex = 4;
            this.lblVoltagem.Text = "Voltagem: 12V";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(175)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 560);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblNivelBat);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.metroProgressSpinner_Bateria_percent);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(18, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(831, 254);
            this.panel4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(614, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conexão com BD";
            // 
            // lblNivelBat
            // 
            this.lblNivelBat.AutoSize = true;
            this.lblNivelBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelBat.ForeColor = System.Drawing.Color.Black;
            this.lblNivelBat.Location = new System.Drawing.Point(133, 129);
            this.lblNivelBat.Name = "lblNivelBat";
            this.lblNivelBat.Size = new System.Drawing.Size(40, 24);
            this.lblNivelBat.TabIndex = 6;
            this.lblNivelBat.Text = "0 %";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(225)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lbl_temp_rest);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(309, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 90);
            this.panel5.TabIndex = 15;
            // 
            // lbl_temp_rest
            // 
            this.lbl_temp_rest.AutoSize = true;
            this.lbl_temp_rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp_rest.ForeColor = System.Drawing.Color.White;
            this.lbl_temp_rest.Location = new System.Drawing.Point(65, 51);
            this.lbl_temp_rest.Name = "lbl_temp_rest";
            this.lbl_temp_rest.Size = new System.Drawing.Size(80, 24);
            this.lbl_temp_rest.TabIndex = 5;
            this.lbl_temp_rest.Text = "00:00:00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(37, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 25);
            this.label16.TabIndex = 4;
            this.label16.Text = "Uso em Horas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(82, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nível Bateria";
            // 
            // metroProgressSpinner_Bateria_percent
            // 
            this.metroProgressSpinner_Bateria_percent.EnsureVisible = false;
            this.metroProgressSpinner_Bateria_percent.Location = new System.Drawing.Point(75, 64);
            this.metroProgressSpinner_Bateria_percent.Maximum = 100;
            this.metroProgressSpinner_Bateria_percent.Name = "metroProgressSpinner_Bateria_percent";
            this.metroProgressSpinner_Bateria_percent.Size = new System.Drawing.Size(155, 155);
            this.metroProgressSpinner_Bateria_percent.Spinning = false;
            this.metroProgressSpinner_Bateria_percent.Style = MetroFramework.MetroColorStyle.Green;
            this.metroProgressSpinner_Bateria_percent.TabIndex = 7;
            this.metroProgressSpinner_Bateria_percent.UseSelectable = true;
            this.metroProgressSpinner_Bateria_percent.Value = 100;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(601, 114);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(184, 50);
            this.panel9.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(44, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Conectado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.dgvDados);
            this.panel1.Controls.Add(this.btn_Conectar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1511, 92);
            this.panel1.TabIndex = 11;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(501, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(221, 86);
            this.dgvDados.TabIndex = 15;
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(160)))), ((int)(((byte)(225)))));
            this.btn_Conectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Conectar.Image = global::WindowsFormsApplication1.Properties.Resources.link__1_;
            this.btn_Conectar.Location = new System.Drawing.Point(779, 24);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(58, 52);
            this.btn_Conectar.TabIndex = 2;
            this.btn_Conectar.Tag = "";
            this.toolTip_btn_Conectar.SetToolTip(this.btn_Conectar, "Conectar");
            this.btn_Conectar.UseVisualStyleBackColor = false;
            this.btn_Conectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status do Volta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.chart;
            this.pictureBox1.Location = new System.Drawing.Point(18, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "label8";
            // 
            // frm_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Status";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.frm_Status_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCapacidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblVoltagem;
        private System.Windows.Forms.Label lblAmperagem;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.ToolTip toolTip_btn_Conectar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNivelBat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_temp_rest;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner_Bateria_percent;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}