using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_sistema_info_Click(object sender, EventArgs e)
        {
            /*frm_Aguarde frm_aguarde = new frm_Aguarde();
            frm_aguarde.Show();*/

            frmInfo_Sistema frm_sis_inf = new frmInfo_Sistema();
            frm_sis_inf.Show();

            
        }

        private void btn_status_Click(object sender, EventArgs e)
        {           
            frm_Status frm_status = new frm_Status();
            frm_status.Show();
        }       
    }
}
