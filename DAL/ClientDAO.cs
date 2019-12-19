using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class ClientDAO
    {
        public static bool Insert_client(string nom, string prenom, string mail)
        {
            string requete = String.Format("insert into client(nom, prenom, mail)" +
                " values ('{0}','{1}','{2}');", nom, prenom, mail);
            return utils.miseajour(requete);
        }

        public static bool Update_client(int id, string nom, string prenom, string mail)
        {
            string requete = String.Format("update client set nom='{0}', prenom={1}," +
                " mail='{2}' where id={3};", nom, prenom, mail, id);
            return utils.miseajour(requete);
        }

        public static bool Delete_client(int id)
        {
            string requete = String.Format("delete from client where id={0};", id);
            return utils.miseajour(requete);
        }

        public static Client Get_client_ID(int id)
        {
            string requete = String.Format("select * from client where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            Client c = new Client();
            while (rd.Read())
            {
                c.Id = rd.GetInt32(0);
                c.Nom = rd.GetString(1);
                c.Prenom = rd.GetString(2);
                c.Mail = rd.GetString(3);
            }
            utils.Disconnect();
            return c;
        }

        public static List<Client> Get_clients()
        {
            string requete = String.Format("select * from client;");
            OleDbDataReader rd = utils.lire(requete);
            List<Client> L = new List<Client>();
            Client c;
            while (rd.Read())
            {
                c = new Client
                {
                    Id = rd.GetInt32(0),
                    Nom = rd.GetString(1),
                    Prenom = rd.GetString(2),
                    Mail = rd.GetString(3)
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }

    }
}
