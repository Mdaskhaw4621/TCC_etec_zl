namespace WindowsFormsApplication1
{
    partial class frmInfo_Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfo_Sistema));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblRAM_use_view = new System.Windows.Forms.Label();
            this.lblCPU_use_view = new System.Windows.Forms.Label();
            this.metroProgressSpinner_CPU = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner_RAM = new MetroFramework.Controls.MetroProgressSpinner();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Tot_Disc_Rig = new System.Windows.Forms.Label();
            this.lbl_Livre_Disc_Rig = new System.Windows.Forms.Label();
            this.lbl_Mem_Total = new System.Windows.Forms.Label();
            this.lbl_Mem_Livre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_NomeUsuario_view = new System.Windows.Forms.Label();
            this.lbl_CPU_view = new System.Windows.Forms.Label();
            this.lbl_SO_view = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_l3Cache_CPU = new System.Windows.Forms.Label();
            this.lbl_l2Cache_CPU = new System.Windows.Forms.Label();
            this.lbl_numSerie_CPU = new System.Windows.Forms.Label();
            this.lbl_speedNowClock_CPU = new System.Windows.Forms.Label();
            this.lbl_speedMaxClock_CPU = new System.Windows.Forms.Label();
            this.lbl_Fabri_CPU = new System.Windows.Forms.Label();
            this.lbl_CPU_view_TabProc = new System.Windows.Forms.Label();
            this.lbl_Num_PL_CPU = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_MB_dtBIOS = new System.Windows.Forms.Label();
            this.lbl_MB_verBIOS = new System.Windows.Forms.Label();
            this.lbl_MB_nomeBIOS = new System.Windows.Forms.Label();
            this.lbl_MB_fornBIOS = new System.Windows.Forms.Label();
            this.lbl_MB_numSerie = new System.Windows.Forms.Label();
            this.lbl_MB_fabricante = new System.Windows.Forms.Label();
            this.lbl_MB_modelo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(658, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visão Geral";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.metroProgressSpinner3);
            this.groupBox7.Controls.Add(this.metroProgressSpinner2);
            this.groupBox7.Controls.Add(this.lblRAM_use_view);
            this.groupBox7.Controls.Add(this.lblCPU_use_view);
            this.groupBox7.Controls.Add(this.metroProgressSpinner_CPU);
            this.groupBox7.Controls.Add(this.metroProgressSpinner_RAM);
            this.groupBox7.Location = new System.Drawing.Point(6, 283);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(629, 191);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Desempenho";
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.EnsureVisible = false;
            this.metroProgressSpinner3.Location = new System.Drawing.Point(476, 37);
            this.metroProgressSpinner3.Maximum = 100;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(135, 135);
            this.metroProgressSpinner3.Spinning = false;
            this.metroProgressSpinner3.TabIndex = 14;
            this.metroProgressSpinner3.UseSelectable = true;
            this.metroProgressSpinner3.Value = 100;
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.EnsureVisible = false;
            this.metroProgressSpinner2.Location = new System.Drawing.Point(326, 37);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(135, 135);
            this.metroProgressSpinner2.Spinning = false;
            this.metroProgressSpinner2.TabIndex = 13;
            this.metroProgressSpinner2.UseSelectable = true;
            this.metroProgressSpinner2.Value = 100;
            // 
            // lblRAM_use_view
            // 
            this.lblRAM_use_view.AutoSize = true;
            this.lblRAM_use_view.Location = new System.Drawing.Point(219, 99);
            this.lblRAM_use_view.Name = "lblRAM_use_view";
            this.lblRAM_use_view.Size = new System.Drawing.Size(31, 13);
            this.lblRAM_use_view.TabIndex = 9;
            this.lblRAM_use_view.Text = "RAM";
            // 
            // lblCPU_use_view
            // 
            this.lblCPU_use_view.AutoSize = true;
            this.lblCPU_use_view.Location = new System.Drawing.Point(65, 99);
            this.lblCPU_use_view.Name = "lblCPU_use_view";
            this.lblCPU_use_view.Size = new System.Drawing.Size(29, 13);
            this.lblCPU_use_view.TabIndex = 8;
            this.lblCPU_use_view.Text = "CPU";
            // 
            // metroProgressSpinner_CPU
            // 
            this.metroProgressSpinner_CPU.EnsureVisible = false;
            this.metroProgressSpinner_CPU.Location = new System.Drawing.Point(24, 37);
            this.metroProgressSpinner_CPU.Maximum = 100;
            this.metroProgressSpinner_CPU.Name = "metroProgressSpinner_CPU";
            this.metroProgressSpinner_CPU.Size = new System.Drawing.Size(135, 135);
            this.metroProgressSpinner_CPU.Spinning = false;
            this.metroProgressSpinner_CPU.TabIndex = 11;
            this.metroProgressSpinner_CPU.UseSelectable = true;
            this.metroProgressSpinner_CPU.Value = 100;
            // 
            // metroProgressSpinner_RAM
            // 
            this.metroProgressSpinner_RAM.EnsureVisible = false;
            this.metroProgressSpinner_RAM.Location = new System.Drawing.Point(176, 37);
            this.metroProgressSpinner_RAM.Maximum = 100;
            this.metroProgressSpinner_RAM.Name = "metroProgressSpinner_RAM";
            this.metroProgressSpinner_RAM.Size = new System.Drawing.Size(135, 135);
            this.metroProgressSpinner_RAM.Spinning = false;
            this.metroProgressSpinner_RAM.TabIndex = 12;
            this.metroProgressSpinner_RAM.UseSelectable = true;
            this.metroProgressSpinner_RAM.Value = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Tot_Disc_Rig);
            this.groupBox2.Controls.Add(this.lbl_Livre_Disc_Rig);
            this.groupBox2.Controls.Add(this.lbl_Mem_Total);
            this.groupBox2.Controls.Add(this.lbl_Mem_Livre);
            this.groupBox2.Location = new System.Drawing.Point(6, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 144);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memória e Armazenamento";
            // 
            // lbl_Tot_Disc_Rig
            // 
            this.lbl_Tot_Disc_Rig.AutoSize = true;
            this.lbl_Tot_Disc_Rig.Location = new System.Drawing.Point(35, 99);
            this.lbl_Tot_Disc_Rig.Name = "lbl_Tot_Disc_Rig";
            this.lbl_Tot_Disc_Rig.Size = new System.Drawing.Size(114, 13);
            this.lbl_Tot_Disc_Rig.TabIndex = 3;
            this.lbl_Tot_Disc_Rig.Text = "Total no Disco Rígido:";
            // 
            // lbl_Livre_Disc_Rig
            // 
            this.lbl_Livre_Disc_Rig.AutoSize = true;
            this.lbl_Livre_Disc_Rig.Location = new System.Drawing.Point(35, 77);
            this.lbl_Livre_Disc_Rig.Name = "lbl_Livre_Disc_Rig";
            this.lbl_Livre_Disc_Rig.Size = new System.Drawing.Size(113, 13);
            this.lbl_Livre_Disc_Rig.TabIndex = 2;
            this.lbl_Livre_Disc_Rig.Text = "Livre no Disco Rígido:";
            // 
            // lbl_Mem_Total
            // 
            this.lbl_Mem_Total.AutoSize = true;
            this.lbl_Mem_Total.Location = new System.Drawing.Point(35, 55);
            this.lbl_Mem_Total.Name = "lbl_Mem_Total";
            this.lbl_Mem_Total.Size = new System.Drawing.Size(77, 13);
            this.lbl_Mem_Total.TabIndex = 1;
            this.lbl_Mem_Total.Text = "Memória Total:";
            // 
            // lbl_Mem_Livre
            // 
            this.lbl_Mem_Livre.AutoSize = true;
            this.lbl_Mem_Livre.Location = new System.Drawing.Point(35, 33);
            this.lbl_Mem_Livre.Name = "lbl_Mem_Livre";
            this.lbl_Mem_Livre.Size = new System.Drawing.Size(76, 13);
            this.lbl_Mem_Livre.TabIndex = 0;
            this.lbl_Mem_Livre.Text = "Memória Livre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_NomeUsuario_view);
            this.groupBox1.Controls.Add(this.lbl_CPU_view);
            this.groupBox1.Controls.Add(this.lbl_SO_view);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geral";
            // 
            // lbl_NomeUsuario_view
            // 
            this.lbl_NomeUsuario_view.AutoSize = true;
            this.lbl_NomeUsuario_view.Location = new System.Drawing.Point(35, 77);
            this.lbl_NomeUsuario_view.Name = "lbl_NomeUsuario_view";
            this.lbl_NomeUsuario_view.Size = new System.Drawing.Size(92, 13);
            this.lbl_NomeUsuario_view.TabIndex = 2;
            this.lbl_NomeUsuario_view.Text = "Nome do Usuário:";
            // 
            // lbl_CPU_view
            // 
            this.lbl_CPU_view.AutoSize = true;
            this.lbl_CPU_view.Location = new System.Drawing.Point(35, 55);
            this.lbl_CPU_view.Name = "lbl_CPU_view";
            this.lbl_CPU_view.Size = new System.Drawing.Size(69, 13);
            this.lbl_CPU_view.TabIndex = 1;
            this.lbl_CPU_view.Text = "Processador:";
            // 
            // lbl_SO_view
            // 
            this.lbl_SO_view.AutoSize = true;
            this.lbl_SO_view.Location = new System.Drawing.Point(35, 33);
            this.lbl_SO_view.Name = "lbl_SO_view";
            this.lbl_SO_view.Size = new System.Drawing.Size(107, 13);
            this.lbl_SO_view.TabIndex = 0;
            this.lbl_SO_view.Text = "Sistema Operacional:";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(658, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Processador & Memória";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(6, 277);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(629, 265);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Memória";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "L3 Cache:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "L2 Cache:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número de Série:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Velocidade Atual do Clock:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Velocidade Máxima  do Clock:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Fabricante:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Processador:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Processadores Lógicos:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_l3Cache_CPU);
            this.groupBox5.Controls.Add(this.lbl_l2Cache_CPU);
            this.groupBox5.Controls.Add(this.lbl_numSerie_CPU);
            this.groupBox5.Controls.Add(this.lbl_speedNowClock_CPU);
            this.groupBox5.Controls.Add(this.lbl_speedMaxClock_CPU);
            this.groupBox5.Controls.Add(this.lbl_Fabri_CPU);
            this.groupBox5.Controls.Add(this.lbl_CPU_view_TabProc);
            this.groupBox5.Controls.Add(this.lbl_Num_PL_CPU);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(629, 265);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Processador";
            // 
            // lbl_l3Cache_CPU
            // 
            this.lbl_l3Cache_CPU.AutoSize = true;
            this.lbl_l3Cache_CPU.Location = new System.Drawing.Point(35, 196);
            this.lbl_l3Cache_CPU.Name = "lbl_l3Cache_CPU";
            this.lbl_l3Cache_CPU.Size = new System.Drawing.Size(56, 13);
            this.lbl_l3Cache_CPU.TabIndex = 9;
            this.lbl_l3Cache_CPU.Text = "L3 Cache:";
            // 
            // lbl_l2Cache_CPU
            // 
            this.lbl_l2Cache_CPU.AutoSize = true;
            this.lbl_l2Cache_CPU.Location = new System.Drawing.Point(35, 172);
            this.lbl_l2Cache_CPU.Name = "lbl_l2Cache_CPU";
            this.lbl_l2Cache_CPU.Size = new System.Drawing.Size(56, 13);
            this.lbl_l2Cache_CPU.TabIndex = 8;
            this.lbl_l2Cache_CPU.Text = "L2 Cache:";
            // 
            // lbl_numSerie_CPU
            // 
            this.lbl_numSerie_CPU.AutoSize = true;
            this.lbl_numSerie_CPU.Location = new System.Drawing.Point(35, 103);
            this.lbl_numSerie_CPU.Name = "lbl_numSerie_CPU";
            this.lbl_numSerie_CPU.Size = new System.Drawing.Size(89, 13);
            this.lbl_numSerie_CPU.TabIndex = 6;
            this.lbl_numSerie_CPU.Text = "Número de Série:";
            // 
            // lbl_speedNowClock_CPU
            // 
            this.lbl_speedNowClock_CPU.AutoSize = true;
            this.lbl_speedNowClock_CPU.Location = new System.Drawing.Point(35, 148);
            this.lbl_speedNowClock_CPU.Name = "lbl_speedNowClock_CPU";
            this.lbl_speedNowClock_CPU.Size = new System.Drawing.Size(135, 13);
            this.lbl_speedNowClock_CPU.TabIndex = 4;
            this.lbl_speedNowClock_CPU.Text = "Velocidade Atual do Clock:";
            // 
            // lbl_speedMaxClock_CPU
            // 
            this.lbl_speedMaxClock_CPU.AutoSize = true;
            this.lbl_speedMaxClock_CPU.Location = new System.Drawing.Point(35, 125);
            this.lbl_speedMaxClock_CPU.Name = "lbl_speedMaxClock_CPU";
            this.lbl_speedMaxClock_CPU.Size = new System.Drawing.Size(150, 13);
            this.lbl_speedMaxClock_CPU.TabIndex = 3;
            this.lbl_speedMaxClock_CPU.Text = "Velocidade Máxima  do Clock:";
            // 
            // lbl_Fabri_CPU
            // 
            this.lbl_Fabri_CPU.AutoSize = true;
            this.lbl_Fabri_CPU.Location = new System.Drawing.Point(35, 80);
            this.lbl_Fabri_CPU.Name = "lbl_Fabri_CPU";
            this.lbl_Fabri_CPU.Size = new System.Drawing.Size(60, 13);
            this.lbl_Fabri_CPU.TabIndex = 2;
            this.lbl_Fabri_CPU.Text = "Fabricante:";
            // 
            // lbl_CPU_view_TabProc
            // 
            this.lbl_CPU_view_TabProc.AutoSize = true;
            this.lbl_CPU_view_TabProc.Location = new System.Drawing.Point(35, 33);
            this.lbl_CPU_view_TabProc.Name = "lbl_CPU_view_TabProc";
            this.lbl_CPU_view_TabProc.Size = new System.Drawing.Size(69, 13);
            this.lbl_CPU_view_TabProc.TabIndex = 1;
            this.lbl_CPU_view_TabProc.Text = "Processador:";
            // 
            // lbl_Num_PL_CPU
            // 
            this.lbl_Num_PL_CPU.AutoSize = true;
            this.lbl_Num_PL_CPU.Location = new System.Drawing.Point(35, 56);
            this.lbl_Num_PL_CPU.Name = "lbl_Num_PL_CPU";
            this.lbl_Num_PL_CPU.Size = new System.Drawing.Size(120, 13);
            this.lbl_Num_PL_CPU.TabIndex = 0;
            this.lbl_Num_PL_CPU.Text = "Processadores Lógicos:";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tabPage2.Size = new System.Drawing.Size(658, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "S.O & Placa Mãe";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(6, 238);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(629, 142);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sistema Operacional";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID do Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Versão do SO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome do Computador:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nome do SO: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_MB_dtBIOS);
            this.groupBox3.Controls.Add(this.lbl_MB_verBIOS);
            this.groupBox3.Controls.Add(this.lbl_MB_nomeBIOS);
            this.groupBox3.Controls.Add(this.lbl_MB_fornBIOS);
            this.groupBox3.Controls.Add(this.lbl_MB_numSerie);
            this.groupBox3.Controls.Add(this.lbl_MB_fabricante);
            this.groupBox3.Controls.Add(this.lbl_MB_modelo);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 226);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Placa Mãe";
            // 
            // lbl_MB_dtBIOS
            // 
            this.lbl_MB_dtBIOS.AutoSize = true;
            this.lbl_MB_dtBIOS.Location = new System.Drawing.Point(35, 177);
            this.lbl_MB_dtBIOS.Name = "lbl_MB_dtBIOS";
            this.lbl_MB_dtBIOS.Size = new System.Drawing.Size(76, 13);
            this.lbl_MB_dtBIOS.TabIndex = 6;
            this.lbl_MB_dtBIOS.Text = "Data da BIOS:";
            // 
            // lbl_MB_verBIOS
            // 
            this.lbl_MB_verBIOS.AutoSize = true;
            this.lbl_MB_verBIOS.Location = new System.Drawing.Point(35, 151);
            this.lbl_MB_verBIOS.Name = "lbl_MB_verBIOS";
            this.lbl_MB_verBIOS.Size = new System.Drawing.Size(86, 13);
            this.lbl_MB_verBIOS.TabIndex = 5;
            this.lbl_MB_verBIOS.Text = "Versão da BIOS:";
            // 
            // lbl_MB_nomeBIOS
            // 
            this.lbl_MB_nomeBIOS.AutoSize = true;
            this.lbl_MB_nomeBIOS.Location = new System.Drawing.Point(35, 127);
            this.lbl_MB_nomeBIOS.Name = "lbl_MB_nomeBIOS";
            this.lbl_MB_nomeBIOS.Size = new System.Drawing.Size(81, 13);
            this.lbl_MB_nomeBIOS.TabIndex = 4;
            this.lbl_MB_nomeBIOS.Text = "Nome da BIOS:";
            // 
            // lbl_MB_fornBIOS
            // 
            this.lbl_MB_fornBIOS.AutoSize = true;
            this.lbl_MB_fornBIOS.Location = new System.Drawing.Point(35, 104);
            this.lbl_MB_fornBIOS.Name = "lbl_MB_fornBIOS";
            this.lbl_MB_fornBIOS.Size = new System.Drawing.Size(104, 13);
            this.lbl_MB_fornBIOS.TabIndex = 3;
            this.lbl_MB_fornBIOS.Text = "Fonecedor da BIOS:";
            // 
            // lbl_MB_numSerie
            // 
            this.lbl_MB_numSerie.AutoSize = true;
            this.lbl_MB_numSerie.Location = new System.Drawing.Point(35, 79);
            this.lbl_MB_numSerie.Name = "lbl_MB_numSerie";
            this.lbl_MB_numSerie.Size = new System.Drawing.Size(89, 13);
            this.lbl_MB_numSerie.TabIndex = 2;
            this.lbl_MB_numSerie.Text = "Número de Série:";
            // 
            // lbl_MB_fabricante
            // 
            this.lbl_MB_fabricante.AutoSize = true;
            this.lbl_MB_fabricante.Location = new System.Drawing.Point(35, 33);
            this.lbl_MB_fabricante.Name = "lbl_MB_fabricante";
            this.lbl_MB_fabricante.Size = new System.Drawing.Size(63, 13);
            this.lbl_MB_fabricante.TabIndex = 1;
            this.lbl_MB_fabricante.Text = "Fabricante: ";
            // 
            // lbl_MB_modelo
            // 
            this.lbl_MB_modelo.AutoSize = true;
            this.lbl_MB_modelo.Location = new System.Drawing.Point(35, 55);
            this.lbl_MB_modelo.Name = "lbl_MB_modelo";
            this.lbl_MB_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_MB_modelo.TabIndex = 0;
            this.lbl_MB_modelo.Text = "Modelo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(18, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inforções sobre seu Sistema";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 92);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 985;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor Information";
            this.CPU.CounterName = "% Processor Utility";
            this.CPU.InstanceName = "_Total";
            // 
            // frmInfo_Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 473);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInfo_Sistema";
            this.Text = "Informções do Sistema";
            this.Load += new System.EventHandler(this.frmInfo_Sistema_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Tot_Disc_Rig;
        private System.Windows.Forms.Label lbl_Livre_Disc_Rig;
        private System.Windows.Forms.Label lbl_Mem_Total;
        private System.Windows.Forms.Label lbl_Mem_Livre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_NomeUsuario_view;
        private System.Windows.Forms.Label lbl_CPU_view;
        private System.Windows.Forms.Label lbl_SO_view;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_MB_numSerie;
        private System.Windows.Forms.Label lbl_MB_fabricante;
        private System.Windows.Forms.Label lbl_MB_modelo;
        private System.Windows.Forms.Label lbl_MB_fornBIOS;
        private System.Windows.Forms.Label lbl_MB_verBIOS;
        private System.Windows.Forms.Label lbl_MB_nomeBIOS;
        private System.Windows.Forms.Label lbl_MB_dtBIOS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_numSerie_CPU;
        private System.Windows.Forms.Label lbl_speedNowClock_CPU;
        private System.Windows.Forms.Label lbl_speedMaxClock_CPU;
        private System.Windows.Forms.Label lbl_Fabri_CPU;
        private System.Windows.Forms.Label lbl_CPU_view_TabProc;
        private System.Windows.Forms.Label lbl_Num_PL_CPU;
        private System.Windows.Forms.Label lbl_l3Cache_CPU;
        private System.Windows.Forms.Label lbl_l2Cache_CPU;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRAM_use_view;
        private System.Windows.Forms.Label lblCPU_use_view;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner_CPU;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner_RAM;
        private System.Diagnostics.PerformanceCounter CPU;


    }
}