using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class frm_Conexao : Form
    {
        public frm_Conexao()
        {
            InitializeComponent();
            atualizaListaCOMs();

            data = DateTime.Now;
            carregar_grid();
        }

        OleDbConnection conn = Conexao.obterConexao();
        BindingSource bs_dados = new BindingSource();
        OleDbDataReader dr_dados;
        String _query;
        DateTime data;
        String RxString;
        /*String[] dados; //voltagem, amperagem, capacidade, tempo*/
        float amp_ent, amp_sai = 0, amp_tot = 0, nivel;
        //amp_sai - monitorar com arduino (ta no caderno)
        //amp_tot - ver na bateria

        double[] dados_bd = new double[4];

        float hora;

        public void inserir()
        {
            //QUANDO CODIFICAR O NIVEL E CAPACIDADE ALTERAR O BANCO
            _query = "Insert into propriedades (uso_horas, voltagem, nivel_bateria , data, amperagem, capacidade) Values ";
            _query += "('" + hora + "','" + dados_bd[0] + "','" + nivel + "','" + data + "','" + dados_bd[1] + "','" + amp_tot+ "')";
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_grid();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com a Inclusão !!!!" + _query, "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void calc_nivel(){

            amp_ent = (float) (dados_bd[1]);
            nivel = (((amp_ent * hora) - (amp_sai * hora)) * 100) / amp_tot;
        }
        private void carregar_grid()
        {
            _query = "Select * from propriedades";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_dados = _dataCommand.ExecuteReader();

            if (dr_dados.HasRows == true)
            {
                bs_dados.DataSource = dr_dados;
                dgvDados.DataSource = bs_dados;
            }
            else
            {
                MessageBox.Show("Não temos Dados cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }




        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;	//flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (cmbCOM.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cmbCOM.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                cmbCOM.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            cmbCOM.SelectedIndex = 0;
        }

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
            data = DateTime.Now;
            data.ToString("dd/mm/yy");
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            
            if (serialPort2.IsOpen == false)
            {
                try
                {
                    serialPort2.PortName = cmbCOM.Items[cmbCOM.SelectedIndex].ToString();
                    serialPort2.Open();
                }
                catch
                {
                    return;

                }
                if (serialPort2.IsOpen)
                {
                    btnConectar.Text = "Desconectar";
                    cmbCOM.Enabled = false;
                }
            }
            else
            {
                try
                {
                    serialPort2.Close();
                    cmbCOM.Enabled = true;
                    btnConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }

        private void frm_Conexao_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort2.IsOpen == true)  // se porta aberta 
                serialPort2.Close();            //fecha a porta
        
        }
        /*public void carregarVetorBD()
        {
            dados_bd[0] = Double.Parse(dados[0]);
            dados_bd[0] /= 10000;
            dados_bd[1] = Double.Parse(dados[1]);
            dados_bd[1] /= 10000;
            inserir();
            carregar_grid();
        }*/

      /*  private void trataDadoRecebido(object sender, EventArgs e)
        {
            txbReceber.AppendText(RxString);
            txbReceber.Text = RxString;
            dados = RxString.Substring(0).Split(' ');
            hora = float.Parse(dados[3]) / 3600;
            carregarVetorBD();
        }

        private void serialPort2_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort2.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen == true)  //porta está aberta
                serialPort2.WriteLine("" + txtEnviar.Text);  //envia o texto presente no textbox Enviar
       
        }*/
    }
}
