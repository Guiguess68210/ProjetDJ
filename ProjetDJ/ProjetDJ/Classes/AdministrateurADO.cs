using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetDJ
{
    class AdministrateurADO
    {
        public static void create(Administrateur admin)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO utilisateur(nom, prenom, adresse, ville, codePostal, numFixe, numPortable, mail, mdp) " +
                "VALUES(@nom, @prenom, @adresse, @ville, @codepostal, @numFixe, @numPortable, @mail, @mdp)";
            cmd.Parameters.AddWithValue("@nom", admin.Nom);
            cmd.Parameters.AddWithValue("@prenom", admin.Prenom);
            cmd.Parameters.AddWithValue("@mail", admin.Mail);
            cmd.Parameters.AddWithValue("@mdp", admin.Motdepasse);

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

        public static bool update(Clients clients)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE administration SET nom = @nom, prenom = @prenom, adresse = @adresse, ville = @ville, codePostal = @codePostal, numFixe = @numPortable, mail = @mail, mdp = @mdp WHERE idCl = @idCl";
            cmd.Parameters.AddWithValue("@nom", clients.Nom);
            cmd.Parameters.AddWithValue("@prenom", clients.Prenom);
            cmd.Parameters.AddWithValue("@adresse", clients.Adresse);
            cmd.Parameters.AddWithValue("@ville", clients.Ville);
            cmd.Parameters.AddWithValue("@codePostal", clients.CodePostal);
            cmd.Parameters.AddWithValue("@numFixe", clients.NumFixe);
            cmd.Parameters.AddWithValue("@numPortable", clients.NumPortable);
            cmd.Parameters.AddWithValue("@mail", clients.Email);
            cmd.Parameters.AddWithValue("@mdp", clients.Motdepasse);
            cmd.Parameters.AddWithValue("@idCl", clients.IdCl);
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

        public static bool delete(Clients clients)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM clients WHERE id = @idCl";
            cmd.Parameters.AddWithValue("@id", clients.Id);
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

        public static Clients findById(string id)
        {
            Clients clients = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM clients WHERE idCl = @idCl";
            cmd.Parameters.AddWithValue("@idCl", id);

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
                    string adresse = reader["adresse"].ToString();
                    string ville = reader["ville"].ToString();
                    string codePostal = reader["codePostal"].ToString();
                    string numFixe = reader["numFixe"].ToString();
                    string numPortable = reader["numPortable"].ToString();
                    string mail = reader["mail"].ToString();
                    string mdp = reader["mdp"].ToString();
                    clients = new Clients(id, nom, prenom, adresse, ville, codePostal, numFixe, numPortable, mail, mdp);
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
            return clients;
        }

        public static List<Clients> readAll()
        {
            List<Clients> res = new List<Clients>();
            Clients clients = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM clients";
            cmd.Connection = Connexion.getInstance();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string nom = reader["nom"].ToString();
                    string prenom = reader["prenom"].ToString();
                    string adresse = reader["adresse"].ToString();
                    string ville = reader["ville"].ToString();
                    string codePostal = reader["codePostal"].ToString();
                    string numfixe = reader["numFixe"].ToString();
                    string numPortable = reader["numportable"].ToString();
                    string mail = reader["mail"].ToString();
                    string mdp = reader["mdp"].ToString();
                    clients = new Clients(id, nom, prenom, adresse, ville, codePostal, numfixe, numPortable, mail, mdp);
                    res.Add(clients);
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
        public static List<Clients> findByRecherche(string recherche)
        {
            List<Clients> res = new List<Clients>();
            Clients clients = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM clients WHERE mail LIKE '" + recherche + "%'";

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
                    string adresse = reader["adresse"].ToString();
                    string ville = reader["ville"].ToString();
                    string codePostal = reader["codePostal"].ToString();
                    string numFixe = reader["numFixe"].ToString();
                    string numPortable = reader["numPortable"].ToString();
                    string mail = reader["mail"].ToString();
                    string mdp = reader["mdp"].ToString();
                    clients = new Utilisateur(id, nom, prenom, adresse, ville, codePostal, numFixe, numPortable, mail, mdp);
                    res.Add(clients);
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

