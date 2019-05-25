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
    public partial class MdpOublie : Form
    {
        Accueil accueil;
        public MdpOublie()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void MdpOublie_Load(object sender, EventArgs e)
        {
            accueil = new Accueil();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            accueil.Show();
            this.Hide();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            accueil.Show();
            this.Hide();
        }
    }
}
