using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DAL;

namespace ApplicationWinforms
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void beleve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eleve f = new Eleve();
            f.ShowDialog();
            this.Close();
        }

        private void bprof_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prof p = new Prof();
            p.ShowDialog();
            this.Close();
        }

        private void bgroupe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Groupe g = new Groupe();
            g.ShowDialog();
            this.Close();
        }

        private void bmatiere_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matiere m = new Matiere();
            m.ShowDialog();
            this.Close();
        }

        private void bseance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seance s = new Seance();
            s.ShowDialog();
            this.Close();
        }

        private void bniveau_Click(object sender, EventArgs e)
        {
            this.Hide();
            Niveau n = new Niveau();
            n.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emploi ep = new Emploi();
            ep.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
