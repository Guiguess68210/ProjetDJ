using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetDJ
{
    class Connexion
    {
        private static MySqlConnection connexion;

        private Connexion() { }

        public static MySqlConnection getInstance()
        {
            //MySqlConnection connect = new MySqlConnection("server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8");
            if (connexion == null)
            {
                string chaineDeConnexion = "server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8";
                try
                {
                    connexion = new MySqlConnection(chaineDeConnexion);
                    connexion.Open();
                    Console.WriteLine("Connection à " + connexion.Database + " reussi !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur de connexion : " + ex.Message);
                }
            }
            return connexion;
        }
    }
}
