using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDJ
{
    class Administrateur
    {
        private string idA;
        private string nom;
        private string prenom;
        private string mail;
        private string mdp;

        public Administrateur(string nom, string prenom, string mail, string mdp)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.mdp = mdp;
        }


        public string Id { get => idA; set => idA = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Motdepasse { get => mdp; set => mdp = value; }


    }
}

