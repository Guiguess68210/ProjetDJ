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
        public MySqlConnection connect;
        private string idCl = "";
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
            bool logCl = false;
            bool mdpCl = false;
            bool logAd = false;
            bool mdpAd = false;
            bool check = chkAdmin.ThreeState;
            

            //Si admin
            if ( chkAdmin.Checked==true)
            {
                //Parcours des administrateurs
                foreach (Administrateur ad in AdministrateurADO.readAll())
                {

                    if (ad.Mail.Equals(txtLogin.Text) && ad.Motdepasse.Equals(txtMDP.Text))
                    {
                        logAd = true;
                        mdpAd = true;
                    }
                    else if (ad.Mail.Equals(txtLogin.Text) && !ad.Motdepasse.Equals(txtMDP.Text))
                    {
                        logAd = true;
                    }

                    else if (!ad.Mail.Equals(txtLogin.Text) && ad.Motdepasse.Equals(txtMDP.Text))
                    {
                        mdpAd = true;
                    }

                }

                if (logAd && !mdpAd)
                {
                    MessageBox.Show("mot de passe incorrect");
                }
                else if(!logAd && mdpAd)
                {
                    MessageBox.Show("login incorrect");
                }

                else if (logAd && mdpAd)
                {
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("mail ou mot de passe incorrect");
                }

            }

            //Si pas admin
            else
            {
                // Parcours des clients 
                foreach (Clients cl in ClientsADO.readAll())
                {
                    // Si les informations sont bonnes
                    if (cl.Mail.Equals(txtLogin.Text) && cl.Motdepasse.Equals(txtMDP.Text))
                    {
                        logCl = true;
                        mdpCl = true;
                        this.idCl = cl.Id;
                    }
                    else if (cl.Mail.Equals(txtLogin.Text) && !cl.Motdepasse.Equals(txtMDP.Text))
                    {
                        logCl = true;
                    }

                    else if (!cl.Mail.Equals(txtLogin.Text) && cl.Motdepasse.Equals(txtMDP.Text))
                    {
                        mdpCl = true;
                    }

                }

                if (logCl && !mdpCl)
                {
                    MessageBox.Show("mot de passe incorrect");
                }
                else if (!logCl && mdpCl)
                {
                    MessageBox.Show("login incorrect");
                }
                
                else if (logCl && mdpCl)
                {
                    locAchat = new LocAchat(this.idCl);
                    locAchat.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("mail ou mot de passe incorrect");
                }

            }

        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            admin = new Administration();
            inscription = new Inscription();
            oublieMdp = new MdpOublie();
            //MySqlConnection connect = new MySqlConnection("server=atoneoitszguiiss.mysql.db; sshPort=22; database=atoneoitszguiiss; username=atoneoitszguiiss password=Gui19iss; Pooling=true; charset=utf8");
            MySqlConnection connect = new MySqlConnection("server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8");
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
