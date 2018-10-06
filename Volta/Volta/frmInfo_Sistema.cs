using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System.IO;
using System.Management;

namespace WindowsFormsApplication1
{
    public partial class frmInfo_Sistema : Form
    {
        public frmInfo_Sistema()
        {
            InitializeComponent();
           
        }

        private void frmInfo_Sistema_Load(object sender, EventArgs e)
        {
            
            //TabPane Visão Geral
            Computer computer = new Computer();

            lbl_SO_view.Text = "Sistema Operacional: " + computer.Info.OSFullName;

            lbl_CPU_view.Text = "Processador: " + Info_Processador.getNome_CPU();

            lbl_NomeUsuario_view.Text = "Nome do Usuário: " + Environment.UserName.ToString();

            lbl_Mem_Total.Text = "Memória Total (RAM): " + Info_Memoria_Armazenamento.getTotal_RAM() + " GB";

            lbl_Mem_Livre.Text = "Memória Livre (RAM): " + Info_Memoria_Armazenamento.getLivre_RAM() + " GB";


            lbl_Livre_Disc_Rig.Text = "Livre no Disco Rígido(C:): " + Info_Memoria_Armazenamento.getLivreEsp_HD() + " GB";

            lbl_Tot_Disc_Rig.Text = "Total no Disco Rígido(C:): " + Info_Memoria_Armazenamento.getTotalEsp_HD() + " GB";
            
            
            //TabPane Placa Mãe

           
                    lbl_MB_modelo.Text = "Modelo: " + Info_PlacaMae.getModelo_MB();
                    lbl_MB_fabricante.Text = "Fabricante: " + Info_PlacaMae.getFabricante_MB();
                    lbl_MB_numSerie.Text = "Número de Série: " + Info_PlacaMae.getSerialNum_MB();

                    lbl_MB_fornBIOS.Text = "Fornecedor da BIOS: " + Info_BIOS.getFornecedorBIOS();
                    lbl_MB_nomeBIOS.Text = "Nome da BIOS: " + Info_BIOS.getNomeBIOS();
                    lbl_MB_verBIOS.Text = "Versão da BIOS: " + Info_BIOS.getVersaoBIOS();
                    lbl_MB_dtBIOS.Text = "Data da BIOS: " + Info_BIOS.getDataBIOS();

            //TabPane Processador

                   //lbl_arqui_CPU.Text = "Arquitetura: " + Info_Processador.getArqui_CPU();
                    lbl_Fabri_CPU.Text = "Fabricante: " + Info_Processador.getFabri_CPU();
                    lbl_CPU_view_TabProc.Text = "Processador: " + Info_Processador.getNome_CPU();
                   //lbl_tensao_CPU.Text = "Tensão: " + Info_Processador.getVolt_CPU();
                    lbl_speedMaxClock_CPU.Text = "Velocidade Máxima do Clock: " + Info_Processador.getMaxSpeedClock_CPU() + " GHz";
                    lbl_speedNowClock_CPU.Text = "Velocidade Atual do Clock: " + Info_Processador.getAtualSpeedClock_CPU() + " GHz";
                    lbl_Num_PL_CPU.Text = "Processadores Lógicos: " + Info_Processador.getNumberLP_CPU();
                    lbl_numSerie_CPU.Text = "Número de Série: " + Info_Processador.getNumSerial_CPU();
                    lbl_l2Cache_CPU.Text = "Cache L2: " + Info_Processador.getCacheSizeL2_CPU() + " MB";
                    lbl_l3Cache_CPU.Text = "Cache L3: " + Info_Processador.getCacheSizeL3_CPU() + " MB";
                    
       
            
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Computer computer = new Computer();
            
            double RAM_Used = ((computer.Info.TotalPhysicalMemory) - (computer.Info.AvailablePhysicalMemory));
            int percent_RAM = Convert.ToInt32(RAM_Used * 100 / computer.Info.TotalPhysicalMemory);


            metroProgressSpinner_RAM.Value = percent_RAM;
            lblRAM_use_view.Text = "RAM: " + percent_RAM + " %";

            int CPU_Use = metroProgressSpinner_CPU.Value;
            metroProgressSpinner_CPU.Value = (int)CPU.NextValue();
            lblCPU_use_view.Text = "CPU: " + CPU_Use.ToString() + " %";

            if (percent_RAM >= 80)
            {
                metroProgressSpinner_RAM.Style = MetroFramework.MetroColorStyle.Red;
            }
            else
            {
                metroProgressSpinner_RAM.Style = MetroFramework.MetroColorStyle.Default;
            }

            if(CPU_Use >= 90)
            {
                metroProgressSpinner_RAM.Style = MetroFramework.MetroColorStyle.Red;
            }
            else
            {
                metroProgressSpinner_RAM.Style = MetroFramework.MetroColorStyle.Default;
            }
        } 
    }
}
