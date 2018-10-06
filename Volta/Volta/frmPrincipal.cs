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
            frmInfo_Sistema frm_info_sist = new frmInfo_Sistema();
            frm_info_sist.Show();
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            frmStatus frm_status = new frmStatus();
            frm_status.Show();
        }       
    }
}
