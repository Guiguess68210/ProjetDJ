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
    public partial class VosCommandes : Form
    {
        LocAchat lA;
        public VosCommandes()
        {
            InitializeComponent();
        }

        private void VosCommandes_Load(object sender, EventArgs e)
        {
            lA = new LocAchat();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            lA.Show();
            this.Hide();
        }
    }
}
