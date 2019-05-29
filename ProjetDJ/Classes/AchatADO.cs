using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetDJ
{
    class AchatADO
    {
        public static void create(Achat achat)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO achats (idCo, demandeLivraison, prixTotal, effectifMaterielTotal idCl) " +
                    "VALUES(@idCo, @demandeLivraison, @prixTotal, @effectifMaterielTotal, @idCl)";
            cmd.Parameters.AddWithValue("@idCo", achat.IdCo);
            cmd.Parameters.AddWithValue("@demandeLivraison", achat.DemandeL);
            cmd.Parameters.AddWithValue("@effectifMaterielTotal", achat.EffectifMT);
            cmd.Parameters.AddWithValue("@idCl", achat.Client);

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

        public static bool update(Achat achat)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE Achats SET idCo = @idCo, demandeLivraison = @demandeLivraison, prixTotal = @prixTotal, effectifMaterielTotal = @effectifMaterielTotal, idCl = @idCl WHERE idCo = @idCo";
            cmd.Parameters.AddWithValue("@idCo", achat.IdCo);
            cmd.Parameters.AddWithValue("@demandeLivraison", achat.DemandeL);
            cmd.Parameters.AddWithValue("@prixTotal", achat.PrixTotal);
            cmd.Parameters.AddWithValue("@effectifMaterielTotal", achat.EffectifMT);
            cmd.Parameters.AddWithValue("@idCl", achat.Client);

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

        public static bool delete(Achat achat)
        {
            bool res = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM achats WHERE idCo = @idCo";
            cmd.Parameters.AddWithValue("@idCo", achat.IdCo);
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

        public static Achat findById(string id)
        {
            Achat achat = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM achats WHERE idCo = @idCo";
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
                    bool demandeL = bool.Parse(reader["demandeLivraison"].ToString());
                    float prixTotal = float.Parse(reader["prixTotal"].ToString());
                    int effectifMT = Int32.Parse(reader["effectifMaterielTotal"].ToString());
                    Clients idCl = ClientsADO.findById(reader["idCl"].ToString());
                    achat = new Achat(idCo, demandeL, prixTotal, effectifMT, idCl);
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
            return achat;
        }

        public static List<Achat> readAll()
        {
            List<Achat> res = new List<Achat>();
            Achat achat = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM locations";
            cmd.Connection = Connexion.getInstance();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Commande idCo = CommandeADO.findById(reader["idCo"].ToString());
                    bool demandeL = bool.Parse(reader["demandeLivraison"].ToString());
                    float prixTotal = float.Parse(reader["prixTotal"].ToString());
                    int effectifMT = Int32.Parse(reader["effectifMaterielTotal"].ToString());
                    Clients idCl = ClientsADO.findById(reader["idCl"].ToString());
                    achat = new Achat(idCo, demandeL, prixTotal, effectifMT, idCl);
                    res.Add(achat);
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
        public static List<Achat> findByRecherche(string recherche)
        {
            List<Achat> res = new List<Achat>();
            Achat achat = null;

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM achats WHERE idCo LIKE '" + recherche + "%'";

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
                    bool demandeL = bool.Parse(reader["demandeLivraison"].ToString());
                    float prixTotal = float.Parse(reader["prixTotal"].ToString());
                    int effectifMT = Int32.Parse(reader["effectifMaterielTotal"].ToString());
                    Clients idCl = ClientsADO.findById(reader["idCl"].ToString());
                    achat = new Achat(idCo, demandeL, prixTotal, effectifMT, idCl);
                    res.Add(achat);
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
