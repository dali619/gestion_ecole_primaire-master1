using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ApplicationWinforms
{
    public partial class Emploi : Form
    {
        public Emploi()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Emploi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                utils.Connect();
                string[] heure = { "08:00", "09:00", "10:00", "11:00", "14:00", "15:00", "16:00", "17:00" };         
                foreach (string h in heure)
                {
                        OleDbDataAdapter req = new OleDbDataAdapter("select n_salle, nom_prof, nom_matiere, h_fin from seance where jour='lundi' and h_debut='"+h+"' and num_grp=" + tbgrp.Text + ";", utils.cn);
                        DataTable dt = new DataTable();
                        req.Fill(dt);
                        string a = dt.Rows[0][0].ToString();
                        string b = dt.Rows[0][1].ToString();
                    string da = dt.Rows[0][2].ToString();
                    string g = dt.Rows[0][3].ToString();
                    OleDbDataAdapter re = new OleDbDataAdapter("select n_salle, nom_prof, nom_matiere from seance where jour='mardi' and h_debut='" + h + "' and num_grp=" + tbgrp.Text + ";", utils.cn);
                    DataTable t = new DataTable();
                    re.Fill(t);
                    string c = t.Rows[0][0].ToString();
                    string d = t.Rows[0][1].ToString();
                    string dm = t.Rows[0][2].ToString();
                    OleDbDataAdapter reqt = new OleDbDataAdapter("select n_salle, nom_prof, nom_matiere from seance where jour='mercredi' and h_debut='" + h + "' and num_grp=" + tbgrp.Text + ";", utils.cn);
                    DataTable T = new DataTable();
                    reqt.Fill(T);
                    string m = T.Rows[0][0].ToString();
                    string k = T.Rows[0][1].ToString();
                    string dk = T.Rows[0][2].ToString();
                    OleDbDataAdapter ret = new OleDbDataAdapter("select n_salle, nom_prof, nom_matiere from seance where jour='jeudi' and h_debut='" + h + "' and num_grp=" + tbgrp.Text + ";", utils.cn);
                    DataTable tab = new DataTable();
                    ret.Fill(tab);
                    string cd = tab.Rows[0][0].ToString();
                    string dc = tab.Rows[0][1].ToString();
                    string de = tab.Rows[0][2].ToString();
                    OleDbDataAdapter ree = new OleDbDataAdapter("select n_salle, nom_prof, nom_matiere from seance where jour='vendredi' and h_debut='" + h + "' and num_grp=" + tbgrp.Text + ";", utils.cn);
                    DataTable ta = new DataTable();
                    ree.Fill(ta);
                    string ca = ta.Rows[0][0].ToString();
                    string ds = ta.Rows[0][1].ToString();
                    string dl = ta.Rows[0][2].ToString();
                    OleDbDataAdapter rqqe = new OleDbDataAdapter("select n_salle, nom_prof, nom_matiere from seance where jour='samedi' and h_debut='" + h + "' and num_grp=" + tbgrp.Text + ";", utils.cn);
                    DataTable tq = new DataTable();
                    rqqe.Fill(tq);
                    string cq = tq.Rows[0][0].ToString();
                    string dq = tq.Rows[0][1].ToString();
                    string dqq = tq.Rows[0][2].ToString();

                    string[] row0 = { h+" - "+g, a + "," + b + "," + da, c + "," + d + "," + dm, m + "," + k + "," + dk, cd + "," + dc + "," + de, ca + "," + ds + "," + dl, cq + "," + dq + "," + dqq };
                    dataGridView1.Rows.Add(row0);
                }
                
           
            }
            catch (Exception )
            {if(tbgrp.Text=="")
                { MessageBox.Show("saisir un numéro de groupe"); }
            else
                MessageBox.Show("Ce groupe n'existe pas ou ses séances ne sont pas complétes");
            }

        }
    }
}
