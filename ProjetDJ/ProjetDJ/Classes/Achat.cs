using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDJ
{
    class Achat
    {
        private Commande idCo;
        private DateTime dateAchat;
        private bool demandeLivraison;
        private float prixTotal;
        private int effectifMTotal;
        private Clients idCl;

        public Achat(Commande idCo, DateTime dateA, bool demandeL, float prixTotal, int eMTotal, Clients idCl)
        {
            this.idCo = idCo;
            this.dateAchat = dateA;
            this.demandeLivraison = demandeL;
            this.prixTotal = prixTotal;
            this.effectifMTotal = eMTotal;
            this.idCl = idCl;
        }

        public Commande IdCo { get => idCo; }
        public DateTime DateAchat { get => dateAchat; set => dateAchat = value; }
        public int EffectifMT { get => effectifMTotal; set => effectifMTotal = value; }
        public bool DemandeL { get => demandeLivraison; set => demandeLivraison = value; }
        public float PrixTotal { get => prixTotal; set => prixTotal = value; }
        public Clients Client { get => idCl; }
    }
}
