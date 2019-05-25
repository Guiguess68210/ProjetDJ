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
    public partial class Accueil : Form
    {
        MdpOublie oublieMdp;
        Inscription inscription;
        Administration admin;
        LocAchat locAchat;
        Accueil accueil;
        public MySqlConnection connect;
        public Accueil()
        {
            InitializeComponent();

        }

        private void LkLblMdpOublie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            oublieMdp.Show();
            this.Hide();
        }

        private void BtnInscription_Click(object sender, EventArgs e)
        {
            
            inscription.Show();
            this.Hide();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            
            locAchat.Show();
            this.Hide();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            locAchat = new LocAchat();
            admin = new Administration();
            inscription = new Inscription();
            oublieMdp = new MdpOublie();
            MySqlConnection connect = new MySqlConnection("server=atoneoitszguiiss.mysql.db; sshPort=22; database=atoneoitszguiiss; username=atoneoitszguiiss password=Gui19iss; Pooling=true; charset=utf8");
            //MySqlConnection connect = new MySqlConnection("server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8");
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
        }
    }
}
