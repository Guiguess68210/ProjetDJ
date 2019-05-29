using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDJ
{
    class Materiel
    {
        private string idM;
        private string nom;
        private int puissance;
        private string dimensions;
        private float masse;
        private int stock;
        private float prixAchat;
        private float prixLocation;
        private float prixVente;
        private string image;


        public Materiel(string nom, int puissance, string dimensions, float masse, int stock, float prixAchat, float prixLocation, float prixVente, string image)
        {
            this.nom = nom;
            this.puissance = puissance;
            this.dimensions = dimensions;
            this.masse = masse;
            this.stock = stock;
            this.prixAchat = prixAchat;
            this.prixLocation = prixLocation;
            this.prixVente = prixVente;
            this.image = image;

        }


        public string Id { get => idM; set => idM = value; }
        public string Nom { get => nom; set => nom = value; }
        public int Puissance { get => puissance; set => puissance = value; }
        public string Dimensions { get => dimensions; set => dimensions = value; }
        public float Masse { get => masse; set => masse = value; }
        public int Stock { get => stock; set => stock = value; }
        public float PrixAchat { get => prixAchat; set => prixAchat = value; }
        public float PrixLocation { get => prixLocation; set => prixLocation = value; }
        public float PrixVente { get => prixVente; set => prixVente = value; }
        public string Image { get => image; set => image = value; }
     
    }
}
