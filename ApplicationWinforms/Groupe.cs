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
    public partial class Groupe : Form
    {
        public Groupe()
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
                Groupes clt = GroupeDAO.Get_client_ID(int.Parse(tbID.Text));
                tbnom.Text = clt.nom;
                tbnbre.Text = clt.nbre.ToString();
         
                tbniv.Text = clt.num_niv.ToString();
                List<Groupes> L = new List<Groupes>();
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
                GroupeDAO.Insert_client(tbnom.Text, int.Parse(tbnbre.Text), int.Parse(tbniv.Text));
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
                GroupeDAO.Update_client(int.Parse(tbID.Text), tbnom.Text, int.Parse(tbnbre.Text), int.Parse(tbniv.Text));
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
                List<Groupes> ListClients = GroupeDAO.Get_clients(int.Parse(tbnivlist.Text));
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
                GroupeDAO.Delete_client(int.Parse(txt_ID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
