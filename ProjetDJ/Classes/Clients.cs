using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDJ
{
    class Clients
    {
        private string idCl;
        private string nom;
        private string prenom;
        private string adresse;
        private string ville;
        private string codePostal;
        private string numFixe;
        private string numPortable;
        private string mail;
        private string mdp;


        public Clients(string nom, string prenom, string adresse, string ville, string codePostal, string numFixe, string numPortable, string mail, string mdp)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.ville = ville;
            this.codePostal = codePostal;
            this.numFixe = numFixe;
            this.numPortable = numPortable;
            this.mail = mail;
            this.mdp = mdp;

        }


        public string Id { get => idCl; set => idCl = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public string NumFixe{ get => numFixe; set => numFixe = value; }
        public string NumPortable { get => numPortable; set => numPortable = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Motdepasse { get => mdp; set => mdp = value; }
        



    }
}

