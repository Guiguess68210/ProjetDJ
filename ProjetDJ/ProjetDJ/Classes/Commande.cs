using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDJ
{
    class Commande
    {
        private string idCo;
        private float prixTotal;
        private int effectifMaterielTotal;
        private string typeCommande;
        private Clients client;

        public Commande(float prixT, int eMT, string typeC, Clients client)
        {
            this.prixTotal = prixT;
            this.effectifMaterielTotal = eMT;
            this.typeCommande = typeC;
            this.client = client;
        }

        public string Id { get => idCo; set => idCo = value; }
        public float PrixTotal { get => prixTotal; set => prixTotal = value; }
        public int EffectifMT  { get => effectifMaterielTotal; set => effectifMaterielTotal = value; }
        public string TypeCommande { get => typeCommande; set => typeCommande = value; }
        public Clients Client { get => client; }
    }
}
