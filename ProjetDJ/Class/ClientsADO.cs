using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDJ
{
    class ClientsADO
    {
        public static void create(Utilisateur utilisateur)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO utilisateur(nom, prenom, username, email, motdepasse, photo, date) " +
                "VALUES(@nom, @prenom, @username, @email, @motdepasse, @photo, @date)";
            cmd.Parameters.AddWithValue("@nom", utilisateur.Nom);
            cmd.Parameters.AddWithValue("@prenom", utilisateur.Prenom);
            cmd.Parameters.AddWithValue("@username", utilisateur.Username);
            cmd.Parameters.AddWithValue("@email", utilisateur.Email);
            cmd.Parameters.AddWithValue("@motdepasse", utilisateur.Motdepasse);
            cmd.Parameters.AddWithValue("@photo", utilisateur.Photo);
            cmd.Parameters.AddWithValue("@date", utilisateur.Date);
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

        public static bool update(Utilisateur utilisateur)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE utilisateur SET nom = @nom, prenom = @prenom, username = @username, email = @email, motdepasse = @motdepasse, photo = @photo WHERE id = @id";
            cmd.Parameters.AddWithValue("@nom", utilisateur.Nom);
            cmd.Parameters.AddWithValue("@prenom", utilisateur.Prenom);
            cmd.Parameters.AddWithValue("@username", utilisateur.Username);
            cmd.Parameters.AddWithValue("@email", utilisateur.Email);
            cmd.Parameters.AddWithValue("@motdepasse", utilisateur.Motdepasse);
            cmd.Parameters.AddWithValue("@photo", utilisateur.Photo);
            cmd.Parameters.AddWithValue("@id", utilisateur.Id);
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

        public static bool delete(Utilisateur utilisateur)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM utilisateur WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", utilisateur.Id);
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

        public static Utilisateur findById(string id)
        {
            Utilisateur utilisateur = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM utilisateur WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            //Connexion temporaire !
            string chaineDeConnexion = "database=cookandme; server=164.132.50.171; user id=ptanguy; pwd=olmeto";
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
                    string prenom = reader["prenom"].ToString();
                    string username = reader["username"].ToString();
                    string email = reader["email"].ToString();
                    string motdepasse = reader["motdepasse"].ToString();
                    string photo = reader["photo"].ToString();
                    DateTime date = DateTime.Parse(reader["date"].ToString());
                    utilisateur = new Utilisateur(id, nom, prenom, username, email, motdepasse, photo, date);
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
            return utilisateur;
        }

        public static List<Utilisateur> readAll()
        {
            List<Utilisateur> res = new List<Utilisateur>();
            Utilisateur utilisateur = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM utilisateur";
            cmd.Connection = Connexion.getInstance();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string nom = reader["nom"].ToString();
                    string prenom = reader["prenom"].ToString();
                    string username = reader["username"].ToString();
                    string email = reader["email"].ToString();
                    string motdepasse = reader["motdepasse"].ToString();
                    string photo = reader["photo"].ToString();
                    DateTime date = DateTime.Parse(reader["date"].ToString());
                    utilisateur = new Utilisateur(id, nom, prenom, username, email, motdepasse, photo, date);
                    res.Add(utilisateur);
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

        // ************************************************ ABONNEMENT ********************************************************

        public static void createAbonner(Utilisateur utilisateur, Utilisateur utilisateurSuivi)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO abonner(idUtilisateur, idUtilisateurSuivi) " +
                "VALUES(@idUtilisateur, @idUtilisateurSuivi)";
            cmd.Parameters.AddWithValue("@idUtilisateur", utilisateur.Id);
            cmd.Parameters.AddWithValue("@idUtilisateurSuivi", utilisateurSuivi.Id);
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

        public static bool deleteAbonner(Utilisateur utilisateur, Utilisateur utilisateurSuivi)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM abonner WHERE idUtilisateur = @idUtilisateur AND idUtilisateurSuivi = @idUtilisateurSuivi";
            cmd.Parameters.AddWithValue("@idUtilisateur", utilisateur.Id);
            cmd.Parameters.AddWithValue("@idUtilisateurSuivi", utilisateurSuivi.Id);
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

        public static List<Utilisateur> findAbonner(Utilisateur utilisateur)
        {
            List<Utilisateur> res = new List<Utilisateur>();
            Utilisateur utilisateurSuivi = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM abonner WHERE idUtilisateur = @idUtilisateur";
            cmd.Parameters.AddWithValue("@idUtilisateur", utilisateur.Id);

            //Connexion temporaire !
            string chaineDeConnexion = "database=cookandme; server=164.132.50.171; user id=ptanguy; pwd=olmeto";
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
                    string idUtilisateurSuivi = reader["idUtilisateurSuivi"].ToString();
                    utilisateurSuivi = UtilisateurADO.findById(idUtilisateurSuivi);
                    res.Add(utilisateurSuivi);
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

        // ************************************************ FAVORIS ********************************************************

        public static void createFavoris(Utilisateur utilisateur, Recette recette)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO favoris(idUtilisateur, idRecette) " +
                "VALUES(@idUtilisateur, @idRecette)";
            cmd.Parameters.AddWithValue("@idUtilisateur", utilisateur.Id);
            cmd.Parameters.AddWithValue("@idRecette", recette.Id);
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

        public static bool deleteFavoris(Utilisateur utilisateur, Recette recette)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM favoris WHERE idUtilisateur = @idUtilisateur AND idRecette = @idRecette";
            cmd.Parameters.AddWithValue("@idUtilisateur", utilisateur.Id);
            cmd.Parameters.AddWithValue("@idRecette", recette.Id);
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

        public static List<Recette> findFavoris(Utilisateur utilisateur)
        {
            List<Recette> res = new List<Recette>();
            Recette recette = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM favoris WHERE idUtilisateur = @idUtilisateur";
            cmd.Parameters.AddWithValue("@idUtilisateur", utilisateur.Id);

            //Connexion temporaire !
            string chaineDeConnexion = "database=cookandme; server=164.132.50.171; user id=ptanguy; pwd=olmeto";
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
                    string idRecette = reader["idRecette"].ToString();
                    recette = RecetteADO.findById(idRecette);
                    res.Add(recette);
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

        // **************************************** RECHERCHE **************************************
        public static List<Utilisateur> findByRecherche(string recherche)
        {
            List<Utilisateur> res = new List<Utilisateur>();
            Utilisateur utilisateur = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM utilisateur WHERE username LIKE '" + recherche + "%'";

            //Connexion temporaire !
            string chaineDeConnexion = "database=cookandme; server=164.132.50.171; user id=ptanguy; pwd=olmeto";
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
                    string id = reader["id"].ToString();
                    string nom = reader["nom"].ToString();
                    string prenom = reader["prenom"].ToString();
                    string username = reader["username"].ToString();
                    string email = reader["email"].ToString();
                    string motdepasse = reader["motdepasse"].ToString();
                    string photo = reader["photo"].ToString();
                    DateTime date = DateTime.Parse(reader["date"].ToString());
                    utilisateur = new Utilisateur(id, nom, prenom, username, email, motdepasse, photo, date);
                    res.Add(utilisateur);
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
}
