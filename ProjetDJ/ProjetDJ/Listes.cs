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
    public partial class Listes : Form
    {
        LocAchat lA;
        Dates dates;
        public MySqlDataReader reader;
        public MySqlCommand command;
        public MySqlConnection connect = new MySqlConnection("server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8");
        private string locAchat;
        private string idCl;

        public Listes(string locAchat, string idClient)
        {
            InitializeComponent();
            this.locAchat = locAchat;
            this.idCl = idClient;
        }

  

        private void Listes_Load(object sender, EventArgs e)
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

            this.loadgrid();
        }

        private void loadgrid()
        {
            if ( this.locAchat == "Location")
            {
                gBAchat.Visible = false;
                gBLocation.Visible = true;
                foreach (Materiel mat in MaterielADO.readAll())
                {

                    if (mat.PrixVente.Equals(0))
                    {
                        dGVLocation.Rows.Add(mat.Nom, mat.Puissance, mat.Dimensions, mat.Masse, mat.PrixLocation); //, mat.Image
                    }
 
                }
            }

            else if (this.locAchat == "Achat")
            {
                gBLocation.Visible = false;
                gBAchat.Visible = true;
                foreach (Materiel mat2 in MaterielADO.readAll())
                {

                    if (!mat2.PrixVente.Equals(0))
                    {
                        dGVAchat.Rows.Add(mat2.Nom, mat2.Puissance, mat2.Dimensions, mat2.Masse, mat2.PrixVente); //, mat.Image
                    }

                }
            }


        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            lA = new LocAchat(this.idCl);
            lA.Show();
            this.Hide();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            dates = new Dates(locAchat, this.idCl);
            dates.Show();
            this.Hide();
        }
    }
}
