using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetDJ
{
    class CommandeADO
    {
        public static void create(Commande commande)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO commandes (prixTotal, effectifMaterielTotal, typeCommande, idCl) " +
                    "VALUES(@prixTotal, @effectifMaterielTotal, @typeCommande, @idCl)";
            cmd.Parameters.AddWithValue("@prixTotal", commande.PrixTotal);
            cmd.Parameters.AddWithValue("@effectifMaterielTotal", commande.EffectifMT);
            cmd.Parameters.AddWithValue("@typeCommande", commande.TypeCommande);
            cmd.Parameters.AddWithValue("@idCl", commande.Client);

            cmd.Connection = Connexion.getInstance();

            try
            {
                cmd.ExecuteNonQuery();
                cmd = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de ExecuteNonQuery : " + ex.Message);
            }
        }

        public static bool update(Commande commande)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE commandes SET prixTotal = @prixTotal, effectifMaterielTotal = @effectifMaterielTotal, typeCommande = @typeCommande, idCl = @idCl WHERE idCo = @idCo";
            cmd.Parameters.AddWithValue("@prixTotal", commande.PrixTotal);
            cmd.Parameters.AddWithValue("@effectifMaterielTotal", commande.EffectifMT);
            cmd.Parameters.AddWithValue("@typeCommande", commande.TypeCommande);
            cmd.Parameters.AddWithValue("@idCl", commande.Client);

            cmd.Connection = Connexion.getInstance();

            try
            {
                cmd.ExecuteNonQuery();
                cmd = null;
                res = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de ExecuteNonQuery : " + ex.Message);
            }

            return res;
        }

        public static bool delete(Commande commande)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM commandes WHERE idCo = @idCo";
            cmd.Parameters.AddWithValue("@idCo", commande.Id);
            cmd.Connection = Connexion.getInstance();

            try
            {
                cmd.ExecuteNonQuery();
                cmd = null;
                res = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de ExecuteNonQuery : " + ex.Message);
            }

            return res;
        }

        public static Commande findById(string id)
        {
            Commande mat = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM commandes WHERE idCo = @idCo";
            cmd.Parameters.AddWithValue("@idCo", id);

            //Connexion temporaire !
            string chaineDeConnexion = "server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8";
            MySqlConnection connexion = null;
            try
            {
                connexion = new MySqlConnection(chaineDeConnexion);
                connexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de connexion : " + ex.Message);
            }
            cmd.Connection = connexion;

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    float prixTotal = float.Parse(reader["prixTotal"].ToString());
                    int effectifMT = Int32.Parse(reader["effectifMaterielTotal"].ToString());
                    string typeCommande = reader["typeCommande"].ToString();
                    Clients idCl = ClientsADO.findById(reader["idCl"].ToString());
                    mat = new Commande(prixTotal, effectifMT, typeCommande, idCl);
                }
                cmd = null;
                reader.Close();
                reader = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de dataReader : " + ex.Message);
            }

            connexion.Close();
            connexion = null;
            return mat;
        }

        public static List<Commande> readAll()
        {
            List<Commande> res = new List<Commande>();
            Commande commande = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM materiels";
            cmd.Connection = Connexion.getInstance();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    float prixTotal = float.Parse(reader["prixTotal"].ToString());
                    int effectifMT = Int32.Parse(reader["effectifMaterielTotal"].ToString());
                    string typeCommande = reader["typeCommande"].ToString();
                    Clients idCl = ClientsADO.findById(reader["idCl"].ToString());
                    commande = new Commande(prixTotal, effectifMT, typeCommande, idCl);
                    res.Add(commande);
                }
                cmd = null;
                reader.Close();
                reader = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de dataReader : " + ex.Message);
            }
            return res;
        }


        // **************************************** RECHERCHE **************************************
        public static List<Commande> findByRecherche(string recherche)
        {
            List<Commande> res = new List<Commande>();
            Commande commande = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM commandes WHERE idCo LIKE '" + recherche + "%'";

            //Connexion temporaire !
            string chaineDeConnexion = "server=localhost; database=projet dj; username=root; Pooling=true; charset=utf8";
            MySqlConnection connexion = null;
            try
            {
                connexion = new MySqlConnection(chaineDeConnexion);
                connexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de connexion : " + ex.Message);
            }
            cmd.Connection = connexion;

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    float prixTotal = float.Parse(reader["prixTotal"].ToString());
                    int effectifMT = Int32.Parse(reader["effectifMaterielTotal"].ToString());
                    string typeCommande = reader["typeCommande"].ToString();
                    Clients idCl = ClientsADO.findById(reader["idCl"].ToString());
                    commande = new Commande(prixTotal, effectifMT, typeCommande, idCl);
                    res.Add(commande);
                }
                cmd = null;
                reader.Close();
                reader = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de dataReader : " + ex.Message);
            }
            connexion.Close();
            connexion = null;
            return res;

        }
    }
}
