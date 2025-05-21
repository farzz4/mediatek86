using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using mediatek86.Bd;

namespace mediatek86.controllers
{
    public class AbsenceController
    {
        private readonly BddManager _bddManager;

        public AbsenceController()
        {
            _bddManager = new BddManager();
        }

        /// <summary>
        /// Ajoute une nouvelle absence pour un membre du personnel.
        /// </summary>
        /// <param name="idpersonnel">L'ID du personnel.</param>
        /// <param name="dateDebut">La date de début de l'absence.</param>
        /// <param name="dateFin">La date de fin de l'absence.</param>
        /// <param name="idmotif">L'ID du motif de l'absence.</param>
        public void AjouterAbsence(int idpersonnel, DateTime dateDebut, DateTime dateFin, int idmotif)
        {
            try
            {
                using (var conn = _bddManager.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @dateDebut, @dateFin, @idmotif)",
                        conn);

                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@dateDebut", dateDebut);
                    cmd.Parameters.AddWithValue("@dateFin", dateFin);
                    cmd.Parameters.AddWithValue("@idmotif", idmotif);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Absence ajoutée avec succès.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de l'absence : {ex.Message}");
            }
        }

        /// <summary>
        /// Supprime une absence pour un membre du personnel.
        /// </summary>
        /// <param name="idpersonnel">L'ID du personnel.</param>
        /// <param name="dateDebut">La date de début de l'absence.</param>
        public void SupprimerAbsence(int idpersonnel, DateTime dateDebut)
        {
            try
            {
                using (var conn = _bddManager.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND datedebut = @dateDebut",
                        conn);

                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@dateDebut", dateDebut);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Absence supprimée avec succès.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de l'absence : {ex.Message}");
            }
        }

        /// <summary>
        /// Modifie une absence pour un membre du personnel.
        /// </summary>
        /// <param name="idpersonnel">L'ID du personnel.</param>
        /// <param name="ancienneDateDebut">L'ancienne date de début de l'absence.</param>
        /// <param name="nouvelleDateDebut">La nouvelle date de début de l'absence.</param>
        /// <param name="nouvelleDateFin">La nouvelle date de fin de l'absence.</param>
        /// <param name="idmotif">L'ID du motif de l'absence.</param>
        public void ModifierAbsence(int idpersonnel, DateTime ancienneDateDebut, DateTime nouvelleDateDebut, DateTime nouvelleDateFin, int idmotif)
        {
            try
            {
                using (var conn = _bddManager.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "UPDATE absence SET datedebut = @nouvelleDateDebut, datefin = @nouvelleDateFin, idmotif = @idmotif WHERE idpersonnel = @idpersonnel AND datedebut = @ancienneDateDebut",
                        conn);

                    cmd.Parameters.AddWithValue("@nouvelleDateDebut", nouvelleDateDebut);
                    cmd.Parameters.AddWithValue("@nouvelleDateFin", nouvelleDateFin);
                    cmd.Parameters.AddWithValue("@idmotif", idmotif);
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@ancienneDateDebut", ancienneDateDebut);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Absence modifiée avec succès.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification de l'absence : {ex.Message}");
            }
        }

        /// <summary>
        /// Récupère la liste des absences pour tout le personnel.
        /// </summary>
        /// <returns>Un DataTable contenant les informations des absences.</returns>
        public DataTable ListerAbsences()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = _bddManager.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT p.idpersonnel, p.nom, p.prenom, a.datedebut, a.datefin, m.libelle AS motif, m.idmotif
                                   FROM absence a
                                   INNER JOIN motif m ON a.idmotif = m.idmotif
                                   INNER JOIN personnel p ON a.idpersonnel = p.idpersonnel";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des absences : {ex.Message}");
                return dt;
            }
        }
    }
}
