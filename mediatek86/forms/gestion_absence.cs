using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using mediatek86.Bd;

namespace mediatek86.forms
{
    public partial class gestion_absence : Form
    {
        private readonly BddManager bddManager = new BddManager();

        /// <summary>
        /// Initialise une nouvelle instance de la classe gestion_absence.
        /// </summary>
        public gestion_absence()
        {
            InitializeComponent();
            ConfigureUI();
            Load += GestionAbsence_Load;
            dataGridViewAbsences.SelectionChanged += dataGridViewAbsences_SelectionChanged;
        }

        /// <summary>
        /// Configure l'interface utilisateur, notamment les formats de date et les colonnes du DataGridView.
        /// </summary>
        private void ConfigureUI()
        {
            dateTimePickerdebut.Format = DateTimePickerFormat.Custom;
            dateTimePickerdebut.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerfin.Format = DateTimePickerFormat.Custom;
            dateTimePickerfin.CustomFormat = "dd/MM/yyyy HH:mm";

            dataGridViewAbsences.AutoGenerateColumns = false;
            dataGridViewAbsences.Columns.Clear();

            dataGridViewAbsences.Columns.Add(new DataGridViewTextBoxColumn { Name = "idpersonnel", DataPropertyName = "idpersonnel", HeaderText = "ID Personnel", Visible = false });
            dataGridViewAbsences.Columns.Add(new DataGridViewTextBoxColumn { Name = "nom", DataPropertyName = "nom", HeaderText = "Nom" });
            dataGridViewAbsences.Columns.Add(new DataGridViewTextBoxColumn { Name = "prenom", DataPropertyName = "prenom", HeaderText = "Prénom" });
            dataGridViewAbsences.Columns.Add(new DataGridViewTextBoxColumn { Name = "datedebut", DataPropertyName = "datedebut", HeaderText = "Date Début" });
            dataGridViewAbsences.Columns.Add(new DataGridViewTextBoxColumn { Name = "datefin", DataPropertyName = "datefin", HeaderText = "Date Fin" });
            dataGridViewAbsences.Columns.Add(new DataGridViewTextBoxColumn { Name = "motif", DataPropertyName = "motif", HeaderText = "Motif" });
            dataGridViewAbsences.Columns.Add(new DataGridViewTextBoxColumn { Name = "idmotif", DataPropertyName = "idmotif", HeaderText = "ID Motif", Visible = false });
        }

        /// <summary>
        /// Gère l'événement de chargement du formulaire pour initialiser les données.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void GestionAbsence_Load(object sender, EventArgs e)
        {
            try
            {
                ChargerEmployes();
                ChargerMotifs();
                ChargerAbsences();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur initialisation : {ex.Message}");
                this.Close();
            }
        }

        /// <summary>
        /// Charge la liste des employés depuis la base de données.
        /// </summary>
        private void ChargerEmployes()
        {
            try
            {
                using (var conn = bddManager.GetConnection())
                {
                    conn.Open();
                    var da = new MySqlDataAdapter("SELECT idpersonnel, CONCAT(nom, ' ', prenom) AS nomcomplet FROM personnel", conn);
                    var dt = new DataTable();
                    da.Fill(dt);

                    comboEmployees.DataSource = dt;
                    comboEmployees.DisplayMember = "nomcomplet";
                    comboEmployees.ValueMember = "idpersonnel";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement employés : {ex.Message}");
            }
        }

        /// <summary>
        /// Charge la liste des motifs depuis la base de données.
        /// </summary>
        private void ChargerMotifs()
        {
            try
            {
                using (var conn = bddManager.GetConnection())
                {
                    conn.Open();
                    var da = new MySqlDataAdapter("SELECT idmotif, libelle FROM motif", conn);
                    var dt = new DataTable();
                    da.Fill(dt);

                    comboMotif.DataSource = dt;
                    comboMotif.DisplayMember = "libelle";
                    comboMotif.ValueMember = "idmotif";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement motifs : {ex.Message}");
            }
        }

        /// <summary>
        /// Charge la liste des absences depuis la base de données.
        /// </summary>
        private void ChargerAbsences()
        {
            try
            {
                using (var conn = bddManager.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT p.idpersonnel, p.nom, p.prenom, a.datedebut, a.datefin, m.libelle AS motif, m.idmotif
                                     FROM absence a
                                     INNER JOIN motif m ON a.idmotif = m.idmotif
                                     INNER JOIN personnel p ON a.idpersonnel = p.idpersonnel";
                    var da = new MySqlDataAdapter(query, conn);
                    var dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewAbsences.DataSource = dt;
                    dataGridViewAbsences.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement absences : {ex.Message}");
            }
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton d'ajout d'absence.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnajoutabsen_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de suppression d'absence.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnsupprimerabsen_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Valide les champs de date et de motif.
        /// </summary>
        /// <returns>True si les champs sont valides, sinon False.</returns>
        private bool ValiderChamps()
        {
            if (dateTimePickerdebut.Value >= dateTimePickerfin.Value)
            {
                MessageBox.Show("La date de fin doit être postérieure au début !");
                return false;
            }

            if (comboMotif.SelectedIndex == -1)
            {
                MessageBox.Show("Sélectionnez un motif !");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valide la sélection d'un employé.
        /// </summary>
        /// <returns>True si un employé est sélectionné, sinon False.</returns>
        private bool ValiderID()
        {
            if (ObtenirIdSelectionne() == -1)
            {
                MessageBox.Show("Aucun personnel sélectionné !");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Gère l'événement de changement de sélection dans le DataGridView des absences.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void dataGridViewAbsences_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAbsences.SelectedRows.Count > 0)
            {
                var row = dataGridViewAbsences.SelectedRows[0];
                dateTimePickerdebut.Value = Convert.ToDateTime(row.Cells["datedebut"].Value);
                dateTimePickerfin.Value = Convert.ToDateTime(row.Cells["datefin"].Value);
                comboMotif.SelectedValue = row.Cells["idmotif"].Value;
            }
        }

        /// <summary>
        /// Obtient l'ID de l'employé sélectionné.
        /// </summary>
        /// <returns>L'ID de l'employé sélectionné ou -1 si aucun employé n'est sélectionné.</returns>
        private int ObtenirIdSelectionne()
        {
            if (comboEmployees.SelectedIndex >= 0)
            {
                return Convert.ToInt32(comboEmployees.SelectedValue);
            }
            return -1;
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de rafraîchissement des absences.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            ChargerAbsences();
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton d'ajout d'absence.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnajoutabsen_Click_1(object sender, EventArgs e)
        {

            if (!ValiderChamps() || !ValiderID()) return;

            int idPersonnel = ObtenirIdSelectionne();
            DateTime dateDebut = dateTimePickerdebut.Value;
            DateTime dateFin = dateTimePickerfin.Value;
            int idMotif = Convert.ToInt32(comboMotif.SelectedValue);

            // MessageBox pour afficher les données saisies avant insertion
            MessageBox.Show(
                $"Données saisies :\n" +
                $"ID Personnel = {idPersonnel}\n" +
                $"Date début = {dateDebut:dd/MM/yyyy HH:mm}\n" +
                $"Date fin = {dateFin:dd/MM/yyyy HH:mm}\n" +
                $"ID Motif = {idMotif}",
                "Confirmation des données"
            );

            try
            {
                using (var conn = bddManager.GetConnection())
                {
                    conn.Open();

                    // Vérification existence doublon exact (id + date début)
                    using (var checkCmd = new MySqlCommand("SELECT COUNT(*) FROM absence WHERE idpersonnel = @id AND datedebut = @debut", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", idPersonnel);
                        checkCmd.Parameters.AddWithValue("@debut", dateDebut);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Une absence existe déjà pour cette date de début !");
                            return;
                        }
                    }

                    // Insertion réelle
                    using (var insertCmd = new MySqlCommand("INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@id, @debut, @fin, @motif)", conn))
                    {
                        insertCmd.Parameters.AddWithValue("@id", idPersonnel);
                        insertCmd.Parameters.AddWithValue("@debut", dateDebut);
                        insertCmd.Parameters.AddWithValue("@fin", dateFin);
                        insertCmd.Parameters.AddWithValue("@motif", idMotif);

                        int rowsInserted = insertCmd.ExecuteNonQuery();

                        if (rowsInserted > 0)
                        {
                            MessageBox.Show("Absence ajoutée avec succès !");
                            ChargerAbsences();
                        }
                        else
                        {
                            MessageBox.Show("Aucune ligne insérée !");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ajout : {ex.Message}");
            }
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de modification d'absence.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnmodifierabsen_Click(object sender, EventArgs e)
        {

            if (dataGridViewAbsences.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionnez une absence à modifier");
                return;
            }

            if (!ValiderChamps() || !ValiderID()) return;

            try
            {
                DateTime ancienneDate = Convert.ToDateTime(dataGridViewAbsences.SelectedRows[0].Cells["datedebut"].Value);
                int idPersonnel = ObtenirIdSelectionne();
                DateTime nouvelleDateDebut = dateTimePickerdebut.Value;
                DateTime nouvelleDateFin = dateTimePickerfin.Value;
                int idMotif = Convert.ToInt32(comboMotif.SelectedValue);

                // Affichage des données modifiées avant mise à jour
                MessageBox.Show(
                    $"Données modifiées :\n" +
                    $"ID Personnel = {idPersonnel}\n" +
                    $"Ancienne date début = {ancienneDate:dd/MM/yyyy HH:mm}\n" +
                    $"Nouvelle date début = {nouvelleDateDebut:dd/MM/yyyy HH:mm}\n" +
                    $"Nouvelle date fin = {nouvelleDateFin:dd/MM/yyyy HH:mm}\n" +
                    $"ID Motif = {idMotif}",
                    "Confirmation modification"
                );

                using (var conn = bddManager.GetConnection())
                {
                    conn.Open();

                    using (var updateCmd = new MySqlCommand("UPDATE absence SET datedebut = @newDebut, datefin = @newFin, idmotif = @motif WHERE idpersonnel = @id AND datedebut = @oldDebut", conn))
                    {
                        updateCmd.Parameters.AddWithValue("@newDebut", nouvelleDateDebut);
                        updateCmd.Parameters.AddWithValue("@newFin", nouvelleDateFin);
                        updateCmd.Parameters.AddWithValue("@motif", idMotif);
                        updateCmd.Parameters.AddWithValue("@id", idPersonnel);
                        updateCmd.Parameters.AddWithValue("@oldDebut", ancienneDate);

                        int rowsUpdated = updateCmd.ExecuteNonQuery();

                        if (rowsUpdated > 0)
                        {
                            ChargerAbsences();
                            MessageBox.Show("Modification réussie !");
                        }
                        else
                        {
                            MessageBox.Show("Aucune modification effectuée.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur modification : {ex.Message}");
            }
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de suppression d'absence.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnsupprimerabsen_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewAbsences.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Confirmez la suppression ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DateTime dateDebut = Convert.ToDateTime(dataGridViewAbsences.SelectedRows[0].Cells["datedebut"].Value);

                    using (var conn = bddManager.GetConnection())
                    {
                        conn.Open();
                        using (var cmd = new MySqlCommand("DELETE FROM absence WHERE idpersonnel = @id AND datedebut = @debut", conn))
                        {
                            cmd.Parameters.AddWithValue("@id", ObtenirIdSelectionne());
                            cmd.Parameters.AddWithValue("@debut", dateDebut);
                            cmd.ExecuteNonQuery();
                        }

                        ChargerAbsences();
                        MessageBox.Show("Suppression effectuée !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur suppression : {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de retour.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnretour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
