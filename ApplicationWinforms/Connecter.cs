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
    public partial class Connecter : Form
    {
        public Connecter()
        {
            InitializeComponent();
        }

      

        private void tblogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbpass_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            utils.Connect();
            OleDbDataAdapter req = new OleDbDataAdapter("select COUNT(*) from users where login='" + tblogin.Text + "'and pass='" + tbpass.Text + "'", utils.cn);
            DataTable dt = new DataTable();
            req.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Accueil ac = new Accueil();
                ac.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("incorrect");
        }

        private void Connecter_Load(object sender, EventArgs e)
        {

        }
    }
}
