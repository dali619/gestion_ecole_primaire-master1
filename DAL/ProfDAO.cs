using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class ProfDAO
    {
        public static bool Insert_client(string nom, string prenom, string adresse, string mail)
        {
            string requete = String.Format("insert into prof(nom, prenom, adresse, mail)" +
                " values ('{0}','{1}','{2}','{3}');", nom, prenom, adresse, mail);
            return utils.miseajour(requete);
        }

        public static bool Update_client(int id, string nom, string prenom, string adresse, string mail)
        {
            string requete = String.Format("update prof set nom='{0}', prenom='{1}', adresse='{2}'," +
                " mail='{3}' where Id={4};", nom, prenom, adresse, mail, id);
            return utils.miseajour(requete);
        }

        public static bool Delete_client(int id)
        {
            string requete = String.Format("delete from prof where id={0};", id);
            return utils.miseajour(requete);
        }

        public static Profs Get_client_ID(int id)
        {
            string requete = String.Format("select * from prof where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            Profs c = new Profs();
            while (rd.Read())
            {
                c.id = rd.GetInt32(0);
                c.Nom = rd.GetString(1);
                c.Prenom = rd.GetString(2);
                c.adresse = rd.GetString(3);
                c.mail = rd.GetString(4);
            }
            utils.Disconnect();
            return c;
        }

        public static List<Profs> Get_clients()
        {
            string requete = String.Format("select * from prof;");
            OleDbDataReader rd = utils.lire(requete);
            List<Profs> L = new List<Profs>();
            Profs c;
            while (rd.Read())
            {
                c = new Profs
                {
                    id = rd.GetInt32(0),
                    Nom = rd.GetString(1),
                    Prenom = rd.GetString(2),
                    adresse = rd.GetString(3),
                    mail = rd.GetString(4)
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }
       

    }
}
