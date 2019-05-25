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
    public partial class Inscription : Form
    {
        Accueil accueil;
        public MySqlConnection connect;
        public Inscription()
        {
            InitializeComponent();


        }
        private void Inscription_Load(object sender, EventArgs e)
        {
            accueil = new Accueil();
            connect = new MySqlConnection("server=atoneoitszguiiss.mysql.db; sshPort=22; database=atoneoitszguiiss; username=atoneoitszguiiss password=Gui19iss; Pooling=true; charset=utf8");
            //connect = new MySqlConnection("server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8");
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
        private void BtnInscription_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != null || txtPrenom.Text != null || txtAdresse.Text != null || txtVille.Text != null || txtCP.Text != null || txtNumFixe.Text != null || txtNumPort.Text != null
                || txtMail.Text != null || txtMDP.Text != null || txtCMDP.Text != null)
            { 
                if (txtMDP.Text == txtCMDP.Text)
                {
                    MySqlCommand cmd = new MySqlCommand("insert into clients(nom,prenom,adresse,ville,codePostal,numFixe,numPortable,mail,mdp) VALUES('" + txtNom.Text + "', '" + txtPrenom.Text + "', '" + txtAdresse.Text + "','" + txtVille.Text + "', '" + txtCP.Text + "'" +
                   ", '" + txtNumFixe.Text + "', '" + txtNumPort.Text + "', '" + txtMail.Text + "', '" + txtMDP.Text + "')", connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vos données ont été enregistrées avec succès");
                    this.Hide();
                    accueil.Show();
                }
                else
                {
                    MessageBox.Show("Confirmation du mot de passe incorrecte");
                }
            }
            else
            {
                MessageBox.Show("Formulaire incomplet");
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            accueil.Show();
            this.Hide();
        }


    }
}
