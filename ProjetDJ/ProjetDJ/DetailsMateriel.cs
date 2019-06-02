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
    public partial class DetailsMateriel : Form
    {
        public MySqlConnection connect = new MySqlConnection("server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8");
        Administration admin;
        AjoutMateriel aM;
        public DetailsMateriel()
        {
            InitializeComponent();
        }

        private void DetailsMateriel_Load(object sender, EventArgs e)
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
            this.dataMateriel();
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Hide();
        }

        private void dataMateriel()
        {
            foreach (Materiel mat in MaterielADO.readAll())
            {
                dGVMateriel.Rows.Add(mat.Id, mat.Nom, mat.Puissance, mat.Dimensions, mat.Masse, mat.Stock, mat.PrixAchat, mat.PrixLocation, mat.PrixVente); //, mat.Image

            }
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            aM = new AjoutMateriel();
            aM.Show();
            this.Hide();

        }
    }
}
