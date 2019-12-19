using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class GroupeDAO
    {
        public static bool Insert_client(string nom, int nbre, int num_niv)
        {
            string requete = String.Format("insert into groupe(nom, nbre, num_niv)" +
                " values ('{0}','{1}','{2}');", nom, nbre, num_niv);
            return utils.miseajour(requete);
        }

        public static bool Update_client(int id, string nom, int nbre, int num_niv)
        {
            string requete = String.Format("update groupe set nom='{0}', nbre='{1}'," +
                " num_niv='{2}' where id={3};", nom, nbre, num_niv, id);
            return utils.miseajour(requete);
        }

        public static bool Delete_client(int id)
        {
            string requete = String.Format("delete from groupe where id={0};", id);
            return utils.miseajour(requete);
        }

        public static Groupes Get_client_ID(int id)
        {
            string requete = String.Format("select * from groupe where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            Groupes c = new Groupes();
            while (rd.Read())
            {
                c.id = rd.GetInt32(0);
                c.nom = rd.GetString(1);
                c.nbre = rd.GetInt32(2);
                c.num_niv = rd.GetInt32(3);
            }
            utils.Disconnect();
            return c;
        }

        public static List<Groupes> Get_clients(int num_niv)
        {
            string requete = String.Format("select * from groupe where num_niv={0};", num_niv);
            OleDbDataReader rd = utils.lire(requete);
            List<Groupes> L = new List<Groupes>();
            Groupes c;
            while (rd.Read())
            {
                c = new Groupes
                {
                    id = rd.GetInt32(0),
                    nom = rd.GetString(1),
                    nbre = rd.GetInt32(2),
                    num_niv = rd.GetInt32(3)
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }

    }
}
