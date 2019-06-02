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
    public partial class Administration : Form
    {
        Accueil accueil;
        DetailsClient dC;
        DetailsMateriel dM;
        public MySqlConnection connect = new MySqlConnection("server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8");
        public Administration()
        {
            InitializeComponent();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            accueil = new Accueil();
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

            this.dataFactures();
        }

        private void dataFactures()
        {
            foreach (Commande com in CommandeADO.readAll())
            {
                dGVFactures.Rows.Add(com.Id, com.PrixTotal, com.EffectifMT, com.TypeCommande, com.Client);

            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            accueil.Show();
            this.Hide();
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            dC = new DetailsClient();
            dC.Show();
            this.Hide();
        }

        private void BtnMateriel_Click(object sender, EventArgs e)
        {
            dM = new DetailsMateriel();
            dM.Show();
            this.Hide();
        }
    }
}
