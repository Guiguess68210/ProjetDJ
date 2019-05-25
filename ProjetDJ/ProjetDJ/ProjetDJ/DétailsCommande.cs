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
        public DétailsCommande()
        {
            InitializeComponent();
        }

        private void DétailsCommande_Load(object sender, EventArgs e)
        {
            lst = new Listes();
            lA = new LocAchat();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
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
            date.Show();
            this.Hide();
        }
    }
}
