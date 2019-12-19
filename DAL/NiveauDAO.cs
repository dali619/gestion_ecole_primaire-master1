using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class NiveauDAO
    {
       
        public static bool Update_client(int id, string nom, int nbre)
        {
            string requete = String.Format("update niveau set nom='{0}'," +
                " nbre_gr='{1}' where id={2};", nom, nbre, id);
            return utils.miseajour(requete);
        }

        public static Niveaus Get_client_ID(int id)
        {
            string requete = String.Format("select * from niveau;");
            OleDbDataReader rd = utils.lire(requete);
            Niveaus c = new Niveaus();
            while (rd.Read())
            {
                c.id = rd.GetInt32(0);
                c.nom = rd.GetString(1);
                c.nbre_gr = rd.GetInt32(2);
            }
            utils.Disconnect();
            return c;
        }

    

    }
}
