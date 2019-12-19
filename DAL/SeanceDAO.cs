using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class SeanceDAO
    {
        public static bool Insert_client(string h_debut,string h_fin,string nom_prof,int num_grp,string nom_matiere, string jour, string n_salle)
        {
            string requete = String.Format("insert into seance(h_debut, h_fin, num_prof, num_grp, num_matiere, jour)" +
                " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", h_debut,h_fin,nom_prof,num_grp,nom_matiere,jour,n_salle);
            return utils.miseajour(requete);
        }

        public static bool Update_client(int id, string h_debut, string h_fin, string nom_prof, int num_grp, string nom_matiere, string jour, string n_salle)
        {
            string requete = String.Format("update seance set h_debut='{0}', h_fin='{1}', num_prof='{2}'," +
                " num_grp='{3}', num_matiere='{4}', jour='{5}', n_salle='{6}' where id={7};", h_debut, h_fin, nom_prof, num_grp, nom_matiere, jour, n_salle, id);
            return utils.miseajour(requete);
        }

        public static bool Delete_client(int id)
        {
            string requete = String.Format("delete from seance where id={0};", id);
            return utils.miseajour(requete);
        }

        public static Seances Get_client_ID(int id)
        {
            string requete = String.Format("select * from seance where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            Seances c = new Seances();
            while (rd.Read())
            {
                c.id = rd.GetInt32(0);
                c.h_debut = rd.GetString(1);
                c.h_fin = rd.GetString(2);
                c.nom_prof = rd.GetString(3);
                c.num_grp = rd.GetInt32(4);
                c.nom_matiere = rd.GetString(5);
                c.jour = rd.GetString(6);
                c.n_salle = rd.GetString(7);

            }
            utils.Disconnect();
            return c;
        }

       
    }
}
