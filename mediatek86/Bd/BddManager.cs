using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace mediatek86.Bd
{
    public class BddManager
    {
        private readonly string _connectionString = "Database=mediatek86;server=localhost;user Id=root;pwd=;";

        /// <summary>
        /// Ajoute un nouveau membre du personnel à la base de données.
        /// </summary>
        /// <param name="nom">Le nom du personnel.</param>
        /// <param name="prenom">Le prénom du personnel.</param>
        /// <param name="tel">Le numéro de téléphone du personnel.</param>
        /// <param name="mail">L'adresse email du personnel.</param>
        /// <param name="idservice">L'ID du service auquel le personnel appartient.</param>
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

        /// <summary>
        /// Supprime un membre du personnel de la base de données.
        /// </summary>
        /// <param name="idpersonnel">L'ID du personnel à supprimer.</param>
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

        /// <summary>
        /// Modifie les informations d'un membre du personnel dans la base de données.
        /// </summary>
        /// <param name="idpersonnel">L'ID du personnel à modifier.</param>
        /// <param name="nom">Le nouveau nom du personnel.</param>
        /// <param name="prenom">Le nouveau prénom du personnel.</param>
        /// <param name="tel">Le nouveau numéro de téléphone du personnel.</param>
        /// <param name="mail">La nouvelle adresse email du personnel.</param>
        /// <param name="idservice">Le nouvel ID du service auquel le personnel appartient.</param>
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

        /// <summary>
        /// Liste tous les membres du personnel avec leurs informations.
        /// </summary>
        /// <returns>Un DataTable contenant les informations du personnel.</returns>
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

        /// <summary>
        /// Obtient une nouvelle connexion à la base de données sans l'ouvrir.
        /// </summary>
        /// <returns>Une nouvelle instance de MySqlConnection.</returns>
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
