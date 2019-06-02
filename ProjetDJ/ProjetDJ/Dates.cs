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
    public partial class Dates : Form
    {
        Listes lst;
        LocAchat lA;
        DétailsCommande dC;
        public string locAchat="";
        private string idCl = "";
        public Dates(string locAchat, string idClient)
        {
            InitializeComponent();
            this.locAchat = locAchat;
            this.idCl = idClient;
        }

        private void Dates_Load(object sender, EventArgs e)
        {
           
            if (this.locAchat == "Location")
            {
                gBAchat.Visible = false;

            }

            else
            {
                gBLocation.Visible = false;
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            lst = new Listes(this.locAchat, this.idCl);
            lst.Show();
            this.Hide();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            lA = new LocAchat(this.idCl);
            lA.Show();
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            dC = new DétailsCommande(this.locAchat, this.idCl);
            dC.Show();
            this.Hide();
        }
    }
}
