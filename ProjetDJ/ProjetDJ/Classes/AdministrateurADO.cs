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
            cmd.CommandText = "INSERT INTO administration(nom, prenom, mail, mdp) " +
                "VALUES(@nom, @prenom, @mail, @mdp)";
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

        public static bool update(Administrateur admin)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE administration SET nom = @nom, prenom = @prenom, mail = @mail, mdp = @mdp WHERE idA = @idA";
            cmd.Parameters.AddWithValue("@nom", admin.Nom);
            cmd.Parameters.AddWithValue("@prenom", admin.Prenom);
            cmd.Parameters.AddWithValue("@mail", admin.Mail);
            cmd.Parameters.AddWithValue("@mdp", admin.Motdepasse);
            cmd.Parameters.AddWithValue("@idA", admin.Id);
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

        public static bool delete(Administrateur admin)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM administration WHERE idA = @idA";
            cmd.Parameters.AddWithValue("@idA", admin.Id);
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

        public static Administrateur findById(string id)
        {
            Administrateur admin = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM administration WHERE idA = @idA";
            cmd.Parameters.AddWithValue("@idA", id);

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
                    string mail = reader["mail"].ToString();
                    string mdp = reader["mdp"].ToString();
                    admin = new Administrateur( nom, prenom, mail, mdp);
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
            return admin;
        }

        public static List<Administrateur> readAll()
        {
            List<Administrateur> res = new List<Administrateur>();
            Administrateur admin = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM administration";
            cmd.Connection = Connexion.getInstance();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nom = reader["nom"].ToString();
                    string prenom = reader["prenom"].ToString();
                    string mail = reader["mail"].ToString();
                    string mdp = reader["mdp"].ToString();
                    admin = new Administrateur(nom, prenom, mail, mdp);
                    res.Add(admin);
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
        public static List<Administrateur> findByRecherche(string recherche)
        {
            List<Administrateur> res = new List<Administrateur>();
            Administrateur admin = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM administration WHERE mail LIKE '" + recherche + "%'";

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
                    string prenom = reader["prenom"].ToString();
                    string mail = reader["mail"].ToString();
                    string mdp = reader["mdp"].ToString();
                    admin = new Administrateur( nom, prenom, mail, mdp);
                    res.Add(admin);
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

