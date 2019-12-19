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
    public partial class Seance : Form
    {
        public Seance()
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
                Seances clt = SeanceDAO.Get_client_ID(int.Parse(tbID.Text));
                tbhdb.Text = clt.h_debut;
                tbhfin.Text = clt.h_fin;
                tbpf.Text = clt.nom_prof;
                tbgr.Text = clt.num_grp.ToString();
                tb_id_m.Text = clt.nom_matiere;
                tbjour.Text = clt.jour;
                tbsalle.Text = clt.n_salle;
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
                SeanceDAO.Insert_client(tbhdb.Text, tbhfin.Text, tbpf.Text, int.Parse(tbgr.Text), tb_id_m.Text, tbjour.Text, tbsalle.Text);
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
                SeanceDAO.Update_client(int.Parse(tbID.Text), tbhdb.Text, tbhfin.Text, tbpf.Text, int.Parse(tbgr.Text), tb_id_m.Text, tbjour.Text, tbsalle.Text);
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
                SeanceDAO.Delete_client(int.Parse(txt_ID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbprenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seance_Load(object sender, EventArgs e)
        {

        }
    }
}
