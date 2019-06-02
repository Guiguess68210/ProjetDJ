using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDJ
{
    public partial class DétailsCommande : Form
    {
        Listes lst;
        LocAchat lA;
        Dates date;
        public string locAchat = "";
        private string idCl = "";
        public DétailsCommande(string locAchat, string idClient)
        {
            InitializeComponent();
            this.locAchat = locAchat;

        }

        private void DétailsCommande_Load(object sender, EventArgs e)
        {
            if (this.locAchat == "Location")
            {
                gBAchat.Visible = false;
                foreach (Materiel mat in MaterielADO.readAll())
                {

                     dGVLocation.Rows.Add(mat.Nom); 

                }

                foreach (Location loc in LocationADO.readAll())
                {
                     dGVLocation.Rows.Add(loc.DateD, loc.DateF, loc.DemandeI, loc.EffectifMT, loc.PrixTotal); 
                    
                }

            }

            else
            {
                gBLocation.Visible = false;
                foreach (Materiel mat in MaterielADO.readAll())
                {

                    dGVLocation.Rows.Add(mat.Nom);

                }
                foreach (Achat achat in AchatADO.readAll())
                {
                    dGVLocation.Rows.Add(achat.DateAchat, achat.DemandeL, achat.EffectifMT, achat.PrixTotal);

                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            lA = new LocAchat(this.idCl);
            lA.Show();
            this.Hide();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            lA.Show();
            this.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            date = new Dates(this.locAchat, this.idCl);
            date.Show();
            this.Hide();
        }

    }
}
