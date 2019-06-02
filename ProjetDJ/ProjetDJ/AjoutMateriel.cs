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
    public partial class AjoutMateriel : Form
    {
        DetailsMateriel dM;
        public MySqlConnection connect = new MySqlConnection("server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8");
        Materiel mat;
        public AjoutMateriel()
        {
            InitializeComponent();
        }

        private void AjoutMateriel_Load(object sender, EventArgs e)
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
        }

        private void LblRetour_Click(object sender, EventArgs e)
        {
            dM = new DetailsMateriel();
            dM.Show();
            this.Hide();
        }

        private void LblValider_Click(object sender, EventArgs e)
        {
            int i = 0;
            string idM;
            string nom = txtBoxNom.Text;
            int puissance = Int32.Parse(txtBoxPuissance.Text);
            string dimensions = txtBoxDimensions.Text;
            float masse = float.Parse(txtBoxMasse.Text);
            int stock = Int32.Parse(txtBoxStock.Text);
            float prixAchat = float.Parse(txtBoxPA.Text);
            float prixLocation = float.Parse(txtBoxPL.Text);
            float prixVente = float.Parse(txtBoxPV.Text);
            string image = txtBoxImage.Text;

            foreach (Materiel mat in MaterielADO.readAll())
            {
                idM = i.ToString();
                if (mat.Nom!= nom && mat.Id!= idM)
                {
                    Materiel mat2 = new Materiel(idM ,nom, puissance, dimensions, masse, stock, prixAchat, prixLocation, prixVente, image);
                    MaterielADO.create(mat2);
                    MessageBox.Show("Enregistré");

                }
                i++;
            }
        }
    }
}
