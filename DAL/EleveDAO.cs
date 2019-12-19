using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class EleveDAO
    {
        public static bool Insert_client(string nom, string prenom, string adresse, int num_gr)
        {
            string requete = String.Format("insert into eleve(nom, prenom, adresse, num_gr)" +
                " values ('{0}','{1}','{2}','{3}');", nom, prenom, adresse, num_gr);
            return utils.miseajour(requete);
        }

        public static bool Update_client(int id, string nom, string prenom, string adresse, int num_gr)
        {
            string requete = String.Format("update eleve set nom='{0}', prenom='{1}', adresse='{2}'," +
                " num_gr='{3}' where Id={4};", nom, prenom, adresse, num_gr, id);
            return utils.miseajour(requete);
        }

        public static bool Delete_client(int id)
        {
            string requete = String.Format("delete from eleve where Id={0};", id);
            return utils.miseajour(requete);
        }

        public static Eleve Get_client_ID(int id)
        {
            string requete = String.Format("select * from eleve where Id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            BEL.Eleve c = new BEL.Eleve();
            while (rd.Read())
            {
                c.Id = rd.GetInt32(0);
                c.Nom = rd.GetString(1);
                c.Prenom = rd.GetString(2);
                c.adresse = rd.GetString(3);
                c.num_gr = rd.GetInt32(4);
            }
            utils.Disconnect();
            return c;
        }

        public static List<Eleve> Get_clients(int gr)
        {
            string requete = String.Format("select * from eleve where num_gr={0};", gr);
            OleDbDataReader rd = utils.lire(requete);
            List<Eleve> L = new List<Eleve>();
            Eleve c;
            while (rd.Read())
            {
                c = new Eleve
                {
                    Id = rd.GetInt32(0),
                    Nom = rd.GetString(1),
                    Prenom = rd.GetString(2),
                    adresse = rd.GetString(3),
                    num_gr = rd.GetInt32(4)
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }

    }
}
