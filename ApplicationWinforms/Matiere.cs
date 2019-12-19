using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using DAL;

namespace ApplicationWinforms
{
    public partial class Matiere : Form
    {
        public Matiere()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil al = new Accueil();
            al.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Matieres clt = MatiereDAO.Get_client_ID(int.Parse(tbID.Text));
                tbnom.Text = clt.Nom;
                
                tbnniv.Text = clt.num_niv.ToString();
                List<Matieres> L = new List<Matieres>();
                L.Add(clt);
                grid_clients.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                MatiereDAO.Insert_client(tbnom.Text, int.Parse(tbnniv.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                MatiereDAO.Update_client(int.Parse(tbID.Text), tbnom.Text, int.Parse(tbnniv.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<Matieres> ListClients = MatiereDAO.Get_clients(int.Parse(tbnivlist.Text));
                grid_clients.DataSource = ListClients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                MatiereDAO.Delete_client(int.Parse(txt_ID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
