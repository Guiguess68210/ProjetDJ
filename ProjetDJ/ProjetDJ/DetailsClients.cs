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
    public partial class DetailsClient : Form
    {
        public MySqlConnection connect = new MySqlConnection("server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8");
        Administration admin;
        public DetailsClient()
        {
            InitializeComponent();
        }

        private void DetailsClient_Load(object sender, EventArgs e)
        {
            admin = new Administration();
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
            this.dataClients();
        }

        private void dataClients()
        {
            foreach (Clients cl in ClientsADO.readAll())
            {
                dGVClients.Rows.Add(cl.Nom, cl.Prenom, cl.Adresse, cl.Ville, cl.CodePostal, cl.NumFixe, cl.NumPortable, cl.Mail); 

            }
        }
            private void BtnRetour_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Hide();
        }
    }
}
