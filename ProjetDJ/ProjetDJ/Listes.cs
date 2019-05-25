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
    public partial class Listes : Form
    {
        LocAchat lA;
        Dates dates;
        public Listes()
        {
            InitializeComponent();
        }

  

        private void Listes_Load(object sender, EventArgs e)
        {
            lA = new LocAchat();
            dates = new Dates();
        }
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            lA.Show();
            this.Hide();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            dates.Show();
            this.Hide();
        }
    }
}
