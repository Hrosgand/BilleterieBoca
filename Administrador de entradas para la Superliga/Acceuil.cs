using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administrador_de_entradas_para_la_Superliga.GlobalSvc;

namespace Administrador_de_entradas_para_la_Superliga
{
    public partial class Acceuil : Form
    {
        BaseSvc bS = BaseSvc.Instance;
        string idSocio; 
        public Acceuil(string id)
        {
            InitializeComponent();
            idSocio = id; 
            /* Alimentation des ComboBox */
            foreach (Match m in bS.getListMatchs())
            {
                cbxMatch.Items.Add(m.intitule);
            }

            foreach (Tribunes t in bS.getListTribunes())
            {
                cbxTribunes.Items.Add(t.nom);
            }
        }

        private void btnAcheter_Click(object sender, EventArgs e)
        {
            bS.achatBillet(cbxTribunes.Text,cbxMatch.Text, idSocio);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbxTribunes_SelectedValueChanged(object sender, EventArgs e)
        {
            lblNbPlaces.Text = bS.getTribunesWithNom(cbxTribunes.Text).capacite.ToString();
            lblTotalPrix.Text = bS.calculPrix(cbxTribunes.Text, cbxMatch.Text).ToString() + ' $';
        }
    }
}
