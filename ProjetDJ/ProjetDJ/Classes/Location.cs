using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDJ
{
    class Location
    {
        private Commande idCo;
        private DateTime dateD;
        private DateTime dateF;
        private bool demandeInstall;
        private float prixTotal;
        private int effectifMTotal;
        private Clients idCl;

        public Location(Commande idCo, DateTime dateD, DateTime dateF, bool demandeInstall, float prixTotal, int eMTotal, Clients idCl)
        {
            this.idCo = idCo;
            this.dateD = dateD;
            this.dateF = dateF;
            this.demandeInstall = demandeInstall;
            this.prixTotal = prixTotal;
            this.effectifMTotal = eMTotal;
            this.idCl = idCl;
        }

        public Commande IdCo { get => idCo; }
        public DateTime DateD { get => dateD; set => dateD = value; }
        public DateTime DateF { get => dateF; set => dateF = value; }
        public bool DemandeI { get => demandeInstall; set => demandeInstall = value; }
        public int EffectifMT { get => effectifMTotal; set => effectifMTotal = value; }
        public float PrixTotal { get => prixTotal; set => prixTotal = value; }
        public Clients Client { get => idCl; }
    }
}
