using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetDJ
{
    class LocationADO
    {
        public static void create(Location loc)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO locations (idCo, dateDebut, dateFin, demandeInstallation, prixTotal, effectifMaterielTotal idCl) " +
                    "VALUES(@idCo, @dateDebut, @dateFin, @demandeInstallation, @prixTotal, @effectifMaterielTotal, @idCl)";
            cmd.Parameters.AddWithValue("@idCo", loc.IdCo);
            cmd.Parameters.AddWithValue("@dateDebut", loc.DateD);
            cmd.Parameters.AddWithValue("@dateFin", loc.DateF);
            cmd.Parameters.AddWithValue("@demandeInstallation", loc.DemandeI);
            cmd.Parameters.AddWithValue("@effectifMaterielTotal", loc.EffectifMT);
            cmd.Parameters.AddWithValue("@idCl", loc.Client);

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

        public static bool update(Location loc)
{
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE locations SET idCo = @idCo, dateDebut = @dateDebut, dateFin = @dateFin, demandeInstallation = @demandeInstallation, prixTotal = @prixTotal, effectifMaterielTotal = @effectifMaterielTotal, idCl = @idCl WHERE idCo = @idCo";
            cmd.Parameters.AddWithValue("@idCo", loc.IdCo);
            cmd.Parameters.AddWithValue("@dateDebut", loc.DateD);
            cmd.Parameters.AddWithValue("@dateFin", loc.DateF);
            cmd.Parameters.AddWithValue("@demandeInstallation", loc.DemandeI);
            cmd.Parameters.AddWithValue("@prixTotal", loc.PrixTotal);
            cmd.Parameters.AddWithValue("@effectifMaterielTotal", loc.EffectifMT);
            cmd.Parameters.AddWithValue("@idCl", loc.Client);

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

        public static bool delete(Location loc)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM locations WHERE idCo = @idCo";
            cmd.Parameters.AddWithValue("@idCo", loc.IdCo);
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

        public static Location findById(string id)
        {
            Location loc = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM locations WHERE idCo = @idCo";
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
                    Commande idCo = CommandeADO.findById(reader["idCo"].ToString());
                    DateTime dateD = DateTime.Parse(reader["dateDebut"].ToString());
                    DateTime dateF = DateTime.Parse(reader["dateFin"].ToString());
                    bool demandeI = bool.Parse(reader["demandeInstallation"].ToString());
                    float prixTotal = float.Parse(reader["prixTotal"].ToString());
                    int effectifMT = Int32.Parse(reader["effectifMaterielTotal"].ToString());                  
                    Clients idCl = ClientsADO.findById(reader["idCl"].ToString());
                    loc = new Location(idCo, dateD, dateF, demandeI, prixTotal,  effectifMT, idCl);
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
            return loc;
        }

        public static List<Location> readAll()
        {
            List<Location> res = new List<Location>();
            Location loc = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM locations";
            cmd.Connection = Connexion.getInstance();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Commande idCo = CommandeADO.findById(reader["idCo"].ToString());
                    DateTime dateD = DateTime.Parse(reader["dateDebut"].ToString());
                    DateTime dateF = DateTime.Parse(reader["dateFin"].ToString());
                    bool demandeI = bool.Parse(reader["demandeInstallation"].ToString());
                    float prixTotal = float.Parse(reader["prixTotal"].ToString());
                    int effectifMT = Int32.Parse(reader["effectifMaterielTotal"].ToString());
                    Clients idCl = ClientsADO.findById(reader["idCl"].ToString());
                    loc = new Location(idCo, dateD, dateF, demandeI, prixTotal, effectifMT, idCl);
                    res.Add(loc);
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
        public static List<Location> findByRecherche(string recherche)
        {
            List<Location> res = new List<Location>();
            Location loc = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM locations WHERE idCo LIKE '" + recherche + "%'";

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
                    Commande idCo = CommandeADO.findById(reader["idCo"].ToString());
                    DateTime dateD = DateTime.Parse(reader["dateDebut"].ToString());
                    DateTime dateF = DateTime.Parse(reader["dateFin"].ToString());
                    bool demandeI = bool.Parse(reader["demandeInstallation"].ToString());
                    float prixTotal = float.Parse(reader["prixTotal"].ToString());
                    int effectifMT = Int32.Parse(reader["effectifMaterielTotal"].ToString());
                    Clients idCl = ClientsADO.findById(reader["idCl"].ToString());
                    loc = new Location(idCo, dateD, dateF, demandeI, prixTotal, effectifMT, idCl);
                    res.Add(loc);
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
