

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApplication1
{
    public partial class frm_Status : Form
    {
        public frm_Status()
        {
            InitializeComponent();
        }

        OleDbConnection conn = Conexao.obterConexao();
        BindingSource bs_dados = new BindingSource();
        OleDbDataReader dr_dados;
        String _query;
        int cont = 0, id = 1;

        private void carregar_dados()
        {
            _query = "Select * from propriedades";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_dados = _dataCommand.ExecuteReader();

            if (dr_dados.HasRows == true)
            {
                bs_dados.DataSource = dr_dados;
                dgvDados.DataSource = bs_dados;
            }
        }

        public void excluir_dados()
        {

           _query = "DELETE from propriedades where id = " + Convert.ToString(id) ;
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_dados();
            }
            catch (Exception)
            {
            }
            cont++;
      
        }
       
        private int getNivel_Bateria()
        {
            //Essa label 2 está atras do Panel pq ela recebe o dado
            //A que está exibindo é pra fazer tipo um mascara pra essa label2
            //Os outro vou fazer a mesma coisa
            label2.DataBindings.Clear();
            label2.DataBindings.Add("Text", bs_dados, "nivelBateria");
            string n_bateria = label2.Text;
            int n_bat = Convert.ToInt32(n_bateria);
            return n_bat;
        }

        private void getVoltagem()
        {
            label4.DataBindings.Clear();
            label4.DataBindings.Add("Text", bs_dados, "Voltagem");
            lblVoltagem.Text = label4.Text + " V"; 
            
                
        }

        private void getAmperagem()
        {   
            label6.DataBindings.Clear();
            label6.DataBindings.Add("Text", bs_dados, "amperagem");

            //Aqui é mhA ou A?
            lblAmperagem.Text = label6.Text + " A";

        }

        private void getCapacidade()
        {
            label8.DataBindings.Clear();
            label8.DataBindings.Add("Text", bs_dados, "capacidade");
           
            //Aqui é mhA ou A?

            lblCapacidade.Text = label8.Text + " A";
        }
        
        

        private void frm_Status_Load(object sender, EventArgs e)
        {
            carregar_dados();

            /*metroProgressSpinner_Bateria_percent.Value = getNivel_Bateria();
            lblNivelBat.Text = metroProgressSpinner_Bateria_percent.Value.ToString() + "%";*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Conexao frmCx = new frm_Conexao();
            frmCx.Show();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //avança e atualiza informações
            metroProgressSpinner_Bateria_percent.Value = getNivel_Bateria();
            lblNivelBat.Text = metroProgressSpinner_Bateria_percent.Value.ToString() + "%";

            getVoltagem();
            getAmperagem();
            getCapacidade();

            bs_dados.MoveNext();

            id = 1;

            excluir_dados();


        }

    }
}
