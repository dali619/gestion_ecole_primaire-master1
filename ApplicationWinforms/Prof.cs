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
    public partial class Prof : Form
    {
        public Prof()
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
                Profs pro =ProfDAO.Get_client_ID(int.Parse(tbID_p.Text));
                tbnom.Text = pro.Nom;
                tbprenom.Text = pro.Prenom;
                tbadresse.Text = pro.adresse;
                tbmail.Text = pro.mail;
                List<Profs> L = new List<Profs>();
                L.Add(pro);
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
                ProfDAO.Insert_client(tbnom.Text, tbprenom.Text, tbadresse.Text, tbmail.Text );
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
                ProfDAO.Update_client(int.Parse(tbID_p.Text), tbnom.Text, tbprenom.Text, tbadresse.Text, tbmail.Text);
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
                List<Profs> ListClients = ProfDAO.Get_clients();
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
                ProfDAO.Delete_client(int.Parse(txt_ID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Prof_Load(object sender, EventArgs e)
        {

        }
    }
}
