﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDJ
{
    class Administrateur
    {
        private string id;
        private string nom;
        private string prenom;
        private string username;
        private string email;
        private string photo;
        private string motdepasse;
        private DateTime date;

        public Administrateur(string nom, string prenom, string username, string email, string motdepasse, string photo, DateTime date)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.username = username;
            this.email = email;
            this.photo = photo;
            this.motdepasse = motdepasse;
            this.date = date;

        }

        public Administrateur(string id, string nom, string prenom, string username, string email, string motdepasse, string photo, DateTime date)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.username = username;
            this.email = email;
            this.photo = photo;
            this.motdepasse = motdepasse;
            this.date = date;

        }

        public string Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Photo { get => photo; set => photo = value; }
        public string Motdepasse { get => motdepasse; set => motdepasse = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Username { get => username; set => username = value; }


    }
}
}
