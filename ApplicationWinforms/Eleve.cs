using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;

namespace ApplicationWinforms
{

    public partial class Eleve : Form
    {
        public Eleve()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EleveDAO.Delete_client(int.Parse(txt_ID.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<BEL.Eleve> ListClients = EleveDAO.Get_clients(int.Parse(tbgrlist.Text));
                grid_clients.DataSource = ListClients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BEL.Eleve clt = EleveDAO.Get_client_ID(int.Parse(tbID.Text));
                tbnom.Text = clt.Nom;
                tbprenom.Text = clt.Prenom;
                tbadresse.Text = clt.adresse;
                tbgr.Text = clt.num_gr.ToString();
                List<BEL.Eleve> L = new List<BEL.Eleve>();
                L.Add(clt);
                grid_clients.DataSource = L;
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
                EleveDAO.Update_client(int.Parse(tbID.Text), tbnom.Text, tbprenom.Text, tbadresse.Text, int.Parse(tbgr.Text));
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
                EleveDAO.Insert_client(tbnom.Text, tbprenom.Text, tbadresse.Text, int.Parse(tbgr.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil al = new Accueil();
            al.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                List<BEL.Eleve> ListClients = EleveDAO.Get_clients(int.Parse(tbgrlist.Text));
                grid_clients.DataSource = ListClients;
            }
            catch (Exception)
            {
                if (tbgrlist.Text == "")
                { MessageBox.Show("saisir un numéro de groupe"); }
                else
                    MessageBox.Show("Ce groupe n'existe pas");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                BEL.Eleve clt = EleveDAO.Get_client_ID(int.Parse(tbID.Text));
                tbnom.Text = clt.Nom;
                tbprenom.Text = clt.Prenom.ToString();
                tbadresse.Text = clt.adresse;
                tbgr.Text = clt.num_gr.ToString();
                List<BEL.Eleve> L = new List<BEL.Eleve>();
                L.Add(clt);
                grid_clients.DataSource = L;
            }
            catch (Exception)
            {
                if (tbID.Text == "")
                { MessageBox.Show("saisir l'id d'éleve"); }
                else
                    MessageBox.Show("Ce éleve n'existe pas");
            }
        }

        private void Ajouter_Click_1(object sender, EventArgs e)
        {
            try
            {
                EleveDAO.Insert_client(tbnom.Text, tbprenom.Text, tbadresse.Text, int.Parse(tbgr.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("remplir les cases vides");
            }      
        }

        private void modifier_Click_1(object sender, EventArgs e)
        {
            try
            {
                EleveDAO.Update_client(int.Parse(tbID.Text), tbnom.Text, tbprenom.Text, tbadresse.Text, int.Parse(tbgr.Text));
            }
            catch (Exception )
            {
                MessageBox.Show("remplir les cases vides");
            }
        }

        private void grid_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
