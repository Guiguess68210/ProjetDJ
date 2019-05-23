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
        public Dates()
        {
            InitializeComponent();
        }

        private void Dates_Load(object sender, EventArgs e)
        {
            lst = new Listes();
            lA = new LocAchat();
            dC = new DétailsCommande();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            lst.Show();
            this.Hide();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            lA.Show();
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            dC.Show();
            this.Hide();
        }
    }
}
