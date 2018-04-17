using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administrador_de_entradas_para_la_Superliga.GlobalSvc;

namespace Administrador_de_entradas_para_la_Superliga
{
    public partial class Connection : Form
    {
        BaseSvc bSvc = BaseSvc.Instance;
        public Connection()
        {
            InitializeComponent();
           
           
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (bSvc.getSociosByNumeroEtMdp(txbLogin.Text, txbMdp.Text))
            {
                Acceuil a = new Acceuil();
                a.Show();
            }
            else
            {
                MessageBox.Show("Indentifiants incorrects");
            }
        }
    }
}
