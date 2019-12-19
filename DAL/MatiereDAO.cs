using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class MatiereDAO
    {
        public static bool Insert_client(string nom, int num_niv)
        {
            string requete = String.Format("insert into matiere(nom, num_niv)" +
                " values ('{0}','{1}');", nom, num_niv);
            return utils.miseajour(requete);
        }

        public static bool Update_client(int id, string nom, int num_niv)
        {
            string requete = String.Format("update matiere set nom='{0}', num_niv='{1}' where id={2};", nom, num_niv, id);
            return utils.miseajour(requete);
        }

        public static bool Delete_client(int id)
        {
            string requete = String.Format("delete from matiere where id={0};", id);
            return utils.miseajour(requete);
        }

        public static Matieres Get_client_ID(int id)
        {
            string requete = String.Format("select * from matiere where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);

            Matieres c = new Matieres();
            while (rd.Read())
            {
                c.id = rd.GetInt32(0);
                c.Nom = rd.GetString(1);              
                c.num_niv = rd.GetInt32(2);
            }
            utils.Disconnect();
            return c;
        }

        public static List<Matieres> Get_clients(int num_niv)
        {
            string requete = String.Format("select * from matiere where num_niv={0};", num_niv);
            OleDbDataReader rd = utils.lire(requete);
            List<Matieres> L = new List<Matieres>();
            Matieres c;
            while (rd.Read())
            {
                c = new Matieres
                {
                    id = rd.GetInt32(0),
                    Nom = rd.GetString(1),                    
                    num_niv = rd.GetInt32(2)
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }

    }
}
