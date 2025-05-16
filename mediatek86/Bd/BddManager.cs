using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace mediatek86.Bd
{
    public class BddManager
    {
        private readonly string _connectionString = "Database=mediatek86;server=localhost;user Id=root;pwd=;";

        // AJOUTER un personnel
        public void AjouterPersonnel(string nom, string prenom, string tel, string mail, int idservice)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO personnel (nom, prenom, tel, mail, idservice) 
                                   VALUES (@nom, @prenom, @tel, @mail, @idservice)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@idservice", idservice);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erreur MySQL : {ex.Message}", ex);
            }
        }

        // SUPPRIMER un personnel
        public void SupprimerPersonnel(int idpersonnel)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM personnel WHERE idpersonnel = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idpersonnel);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erreur MySQL : {ex.Message}", ex);
            }
        }

        // MODIFIER un personnel
        public void ModifierPersonnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE personnel 
                                   SET nom = @nom, prenom = @prenom, tel = @tel, 
                                       mail = @mail, idservice = @idservice 
                                   WHERE idpersonnel = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@idservice", idservice);
                    cmd.Parameters.AddWithValue("@id", idpersonnel);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erreur MySQL : {ex.Message}", ex);
            }
        }

        // LISTER tous les personnels
        public DataTable ListerPersonnel()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"SELECT p.*, s.nom as service_nom 
                                   FROM personnel p
                                   JOIN service s ON p.idservice = s.idservice";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);
                }
                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erreur MySQL : {ex.Message}", ex);
            }
        }

        // Obtenir une connexion (sans l'ouvrir)
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}