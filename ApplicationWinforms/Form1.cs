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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClientDAO.Delete_client(int.Parse(txt_ID.Text));
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
                List<Client> ListClients = ClientDAO.Get_clients();
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
                Client clt = ClientDAO.Get_client_ID(int.Parse(tbID.Text));
                tbnom.Text = clt.Nom;
                tbprenom.Text = clt.Prenom;
                tbmail.Text = clt.Mail;
                List<Client> L = new List<Client>();
                L.Add(clt);
                grid_clients.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
    }
}
