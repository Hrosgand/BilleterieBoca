using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Diagnostics;
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
            Bitmap bmp = new Bitmap(720, 618);
            Graphics g = Graphics.FromImage(bmp);
            g.FillEllipse(new SolidBrush(Color.FromArgb(255, 255, 0)), new Rectangle(20, 10, 100, 30));
            g.DrawLine(Pens.Blue, new Point(5, 5), new Point(100, 100));
            pictureBox1.Image = bmp;
        }

        private void cbxTribunes_SelectedValueChanged(object sender, EventArgs e)
        {
            lblNbPlaces.Text = bS.getTribunesWithNom(cbxTribunes.Text).capacite.ToString();
            lblTotalPrix.Text = bS.calculPrix(cbxTribunes.Text, cbxMatch.Text).ToString() + " $";

            /* remise à zero des zones */
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox5.BackColor = Color.White;
            pictureBox6.BackColor = Color.White;
            pictureBox7.BackColor = Color.White;
            pictureBox8.BackColor = Color.White;
            pictureBox9.BackColor = Color.White;
            pictureBox10.BackColor = Color.White;
            pictureBox11.BackColor = Color.White;
            pictureBox12.BackColor = Color.White;
            pictureBox13.BackColor = Color.White;
            pictureBox14.BackColor = Color.White;
            pictureBox15.BackColor = Color.White;
            pictureBox16.BackColor = Color.White;
            pictureBox17.BackColor = Color.White;
            pictureBox18.BackColor = Color.White;
            pictureBox19.BackColor = Color.White;
            pictureBox20.BackColor = Color.White;
            



            /* */

            switch (bS.getTribunesWithNom(cbxTribunes.Text).id)
            {
                case 1: 
                    pictureBox11.BackColor = Color.Red;
                    break;
                case 2:
                    pictureBox14.BackColor = Color.Red;
                    break;
                case 3:
                    pictureBox9.BackColor = Color.Red;
                    break;
                case 4: 
                    pictureBox19.BackColor = Color.Red;
                    break;
                case 5:
                    pictureBox6.BackColor = Color.Red;
                    break;
                case 6:
                    pictureBox12.BackColor = Color.Red;
                    break;
                case 7: 
                    pictureBox13.BackColor = Color.Red;
                    break;
                case 8:
                    pictureBox10.BackColor = Color.Red;
                    break;
                case 9:
                    pictureBox7.BackColor = Color.Red;
                    break;
                case 10:
                    pictureBox17.BackColor = Color.Red;
                    break;
                case 11:
                    pictureBox18.BackColor = Color.Red;
                    break;
                case 12:
                    pictureBox8.BackColor = Color.Red;
                    break;
                case 13:
                    pictureBox20.BackColor = Color.Red;
                    break;
                case 14:
                    pictureBox20.BackColor = Color.Red;
                    break;
                case 15:
                    pictureBox20.BackColor = Color.Red;
                    break;
                case 16:
                    pictureBox20.BackColor = Color.Red;
                    break;
                case 17:
                    pictureBox15.BackColor = Color.Red;
                    break;
                case 18:
                    pictureBox16.BackColor = Color.Red;
                    break;
                case 19:
                    pictureBox3.BackColor = Color.Red;
                    break;
                case 20:
                    pictureBox4.BackColor = Color.Red;
                    break;
                case 21:
                    pictureBox5.BackColor = Color.Red;
                    break;
            }

        }
    }
}
