using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetDJ
{
    public partial class VosCommandes : Form
    {
        LocAchat lA;
        private string idCl = "";
        public MySqlConnection connect = new MySqlConnection("server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8");
        public VosCommandes(string idClient)
        {
            InitializeComponent();
            this.idCl = idClient;
        }

        private void VosCommandes_Load(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                MessageBox.Show("connecté");
            }
            catch (MySqlException co)
            {
                MessageBox.Show(" non connecté");
                MessageBox.Show(co.ToString());
            }

            foreach (Clients cl in ClientsADO.readAll())
            {
                if (cl.Id == this.idCl)
                {
                    lblNom.Text = cl.Nom;
                    lblPrenom.Text = cl.Prenom;
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            lA = new LocAchat(this.idCl);
            lA.Show();
            this.Hide();
        }
    }
}
