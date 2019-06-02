using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDJ
{
    class Contenir
    {
        private Materiel idM;
        private Commande idCo;
        private string nbMateriel;

        public Contenir(Materiel idM, Commande idCo, string nbMateriel)
        {
            this.idM = idM;
            this.idCo = idCo;
            this.nbMateriel = nbMateriel;
        }


        public Materiel IdM { get => idM; set => idM = value; }
        public Commande IdCo { get => idCo; set => idCo = value; }
        public string NbMateriel { get => nbMateriel; set => nbMateriel = value; }
    }
}
