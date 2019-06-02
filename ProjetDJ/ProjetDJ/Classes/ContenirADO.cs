using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetDJ
{
    class ContenirADO
    {
        public static void create(Contenir ctnr)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO contenir (idM, idCo, nbMateriel) " +
                    "VALUES(@idM, @idCo, @nbMateriel)";
            cmd.Parameters.AddWithValue("@idM", ctnr.IdM);
            cmd.Parameters.AddWithValue("@idCo", ctnr.IdCo);
            cmd.Parameters.AddWithValue("@nbMateriel", ctnr.NbMateriel);

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

        public static bool update(Contenir ctnr)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE contenir SET idM= @idM, idCo = @idCo, nbMateriel = @nbMateriel WHERE idCo = @idCo";
            cmd.Parameters.AddWithValue("@idM", ctnr.IdM);
            cmd.Parameters.AddWithValue("@idCo", ctnr.IdCo);
            cmd.Parameters.AddWithValue("@nbMateriel", ctnr.NbMateriel);

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

        public static bool delete(Contenir ctnr)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM commandes WHERE idCo = @idCo";
            cmd.Parameters.AddWithValue("@idCo", ctnr.IdCo);
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

        public static Contenir findById(string id)
        {
            Contenir ctnr = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM contenir WHERE idCo = @idCo";
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
                    Materiel idM = MaterielADO.findById(reader["idM"].ToString());
                    Commande idCo = CommandeADO.findById(reader["idCo"].ToString());
                    string nbMateriel = reader["nbMateriel"].ToString();
                    ctnr = new Contenir(idM, idCo, nbMateriel);
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
            return ctnr;
        }

        public static List<Contenir> readAll()
        {
            List<Contenir> res = new List<Contenir>();
            Contenir ctnr = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM materiels";
            cmd.Connection = Connexion.getInstance();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Materiel idM = MaterielADO.findById(reader["idM"].ToString());
                    Commande idCo = CommandeADO.findById(reader["idCo"].ToString());
                    string nbMateriel = reader["nbMateriel"].ToString();
                    ctnr = new Contenir(idM, idCo, nbMateriel);
                    res.Add(ctnr);
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
        public static List<Contenir> findByRecherche(string recherche)
        {
            List<Contenir> res = new List<Contenir>();
            Contenir ctnr = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM contenir WHERE idCo LIKE '" + recherche + "%'";

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
                    Materiel idM = MaterielADO.findById(reader["idM"].ToString());
                    Commande idCo = CommandeADO.findById(reader["idCo"].ToString());
                    string nbMateriel = reader["nbMateriel"].ToString();
                    ctnr = new Contenir(idM, idCo, nbMateriel);
                    res.Add(ctnr);
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
