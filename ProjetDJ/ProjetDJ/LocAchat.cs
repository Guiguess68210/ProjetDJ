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
    public partial class LocAchat : Form
    {
        Listes lst;
        VosCommandes VC;
        Accueil accueil;
        public string locAchat = "";
        private string idCl;
        public LocAchat(string idCl)
        {
            InitializeComponent();
            this.idCl = idCl;
        }

        private void LocAchat_Load(object sender, EventArgs e)
        {
            accueil = new Accueil();
        }

        private void BtnAchat_Click(object sender, EventArgs e)
        {
            locAchat = "Achat";
            lst = new Listes(locAchat, this.idCl);
            lst.Show();         
            this.Hide();
        }

        private void BtnLocation_Click(object sender, EventArgs e)
        {
            locAchat = "Location";
            lst = new Listes(locAchat, this.idCl);
            lst.Show();
            this.Hide();
        }

        private void BtnCommande_Click(object sender, EventArgs e)
        {
            VC = new VosCommandes(this.idCl);
            VC.Show();
            this.Hide();
        }

        private void BtnDeco_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
