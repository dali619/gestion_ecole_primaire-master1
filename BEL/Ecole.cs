using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Eleve
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string adresse { get; set; }
        public int num_gr { get; set; }
    }
    public class Profs
    {
        public int id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string adresse { get; set; }
        public string mail { get; set; }
    }
    public class Groupes
    {
        public int id { get; set; }
        public string nom { get; set; }
        public int nbre { get; set; }
        public int num_niv { get; set; }
       
    }
    public class Matieres
    {
        public int id { get; set; }
        public string Nom { get; set; }
        public int num_niv { get; set; }
    }
    public class Seances
    {
        public int id { get; set; }
        public string h_debut { get; set; }
        public string h_fin { get; set; }
        public string jour { get; set; }
        public string nom_prof { get; set; }
        public int num_grp { get; set; }
        public string nom_matiere { get; set; }
        public string n_salle { get; set; }
    }
    public class Niveaus
    {
        public int id { get; set; }
        public string nom { get; set; }
        public int nbre_gr { get; set; }
    }
   
}
