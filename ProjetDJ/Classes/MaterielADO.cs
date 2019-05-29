using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetDJ
{
    class MaterielADO
    {
        public static void create(Materiel mat)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO materiels (nom, puissance, dimensions, masse, stock, prixAchat, prixLocation, prixVente, image) " +
                "VALUES(@nom, @puissance, @dimensions, @masse, @stock, @prixAchat, @prixLocation, @prixVente, @image)";
            cmd.Parameters.AddWithValue("@nom", mat.Nom);
            cmd.Parameters.AddWithValue("@puissance", mat.Puissance);
            cmd.Parameters.AddWithValue("@dimensions", mat.Dimensions);
            cmd.Parameters.AddWithValue("@masse", mat.Masse);
            cmd.Parameters.AddWithValue("@stock", mat.Stock);
            cmd.Parameters.AddWithValue("@prixAchat", mat.PrixAchat);
            cmd.Parameters.AddWithValue("@prixLocation", mat.PrixLocation);
            cmd.Parameters.AddWithValue("@prixVente", mat.PrixVente);
            cmd.Parameters.AddWithValue("@image", mat.Image);

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

        public static bool update(Materiel mat)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE materiels SET nom = @nom, puissance = @puissance, dimensions = @dimensions, masse = @masse, stock = @stock, prixAchat = @prixAchat, prixLocation = @prixLocation, image = @image WHERE idM = @idM";
            cmd.Parameters.AddWithValue("@nom", mat.Nom);
            cmd.Parameters.AddWithValue("@puissance", mat.Puissance);
            cmd.Parameters.AddWithValue("@dimensions", mat.Dimensions);
            cmd.Parameters.AddWithValue("@masse", mat.Masse);
            cmd.Parameters.AddWithValue("@stock", mat.Stock);
            cmd.Parameters.AddWithValue("@prixAchat", mat.PrixAchat);
            cmd.Parameters.AddWithValue("@prixLocation", mat.PrixLocation);
            cmd.Parameters.AddWithValue("@prixVente", mat.PrixVente);
            cmd.Parameters.AddWithValue("@image", mat.Image);
            cmd.Parameters.AddWithValue("@idM", mat.Id);
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

        public static bool delete(Materiel mat)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM materiels WHERE idM = @idM";
            cmd.Parameters.AddWithValue("@idM", mat.Id);
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

        public static Materiel findById(string id)
        {
            Materiel mat = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM materiels WHERE idM = @idM";
            cmd.Parameters.AddWithValue("@idM", id);

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
                    string nom = reader["nom"].ToString();
                    int puissance = Int32.Parse( reader["puissance"].ToString());
                    string dimensions = reader["dimensions"].ToString();
                    float masse = float.Parse(reader["masse"].ToString());
                    int stock = Int32.Parse(reader["stock"].ToString());
                    float prixAchat = float.Parse(reader["prixAchat"].ToString());
                    float prixLocation = float.Parse(reader["prixLocation"].ToString());
                    float prixVente = float.Parse(reader["prixVente"].ToString());
                    string image = reader["image"].ToString();
                    mat = new Materiel(nom, puissance, dimensions, masse, stock, prixAchat, prixLocation, prixVente, image);
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

        public static List<Materiel> readAll()
        {
            List<Materiel> res = new List<Materiel>();
            Materiel mat = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM materiels";
            cmd.Connection = Connexion.getInstance();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nom = reader["nom"].ToString();
                    int puissance = Int32.Parse(reader["puissance"].ToString());
                    string dimensions = reader["dimensions"].ToString();
                    float masse = float.Parse(reader["masse"].ToString());
                    int stock = Int32.Parse(reader["stock"].ToString());
                    float prixAchat = float.Parse(reader["prixAchat"].ToString());
                    float prixLocation = float.Parse(reader["prixLocation"].ToString());
                    float prixVente = float.Parse(reader["prixVente"].ToString());
                    string image = reader["image"].ToString();
                    mat = new Materiel(nom, puissance, dimensions, masse, stock, prixAchat, prixLocation, prixVente, image);
                    res.Add(mat);
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
        public static List<Materiel> findByRecherche(string recherche)
        {
            List<Materiel> res = new List<Materiel>();
            Materiel mat = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM materiels WHERE nom LIKE '" + recherche + "%'";

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
                    string nom = reader["nom"].ToString();
                    int puissance = Int32.Parse(reader["puissance"].ToString());
                    string dimensions = reader["dimensions"].ToString();
                    float masse = float.Parse(reader["masse"].ToString());
                    int stock = Int32.Parse(reader["stock"].ToString());
                    float prixAchat = float.Parse(reader["prixAchat"].ToString());
                    float prixLocation = float.Parse(reader["prixLocation"].ToString());
                    float prixVente = float.Parse(reader["prixVente"].ToString());
                    string image = reader["image"].ToString();
                    mat = new Materiel(nom, puissance, dimensions, masse, stock, prixAchat, prixLocation, prixVente, image);
                    res.Add(mat);
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
