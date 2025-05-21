using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using mediatek86.Bd;

namespace mediatek86.forms
{
    public partial class gestion_personnel : Form
    {
        private readonly BddManager bddManager = new BddManager();
        private DataTable dtPersonnel = new DataTable();

        /// <summary>
        /// Initialise une nouvelle instance de la classe gestion_personnel.
        /// </summary>
        public gestion_personnel()
        {
            InitializeComponent();
            Load += GestionPersonnel_Load;
            dataGridpersonel.SelectionChanged += dataGridpersonel_SelectionChanged;
        }

        /// <summary>
        /// Gère l'événement de chargement du formulaire pour initialiser les données.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void GestionPersonnel_Load(object sender, EventArgs e)
        {
            ChargerServices();
            ConfigurerDataGrid();
            ChargerPersonnel();
        }

        /// <summary>
        /// Configure le DataGridView pour afficher les informations du personnel.
        /// </summary>
        private void ConfigurerDataGrid()
        {
            dataGridpersonel.AutoGenerateColumns = false;
            dataGridpersonel.DataSource = dtPersonnel;
            dataGridpersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridpersonel.Columns.Clear();

            // Ajout des colonnes avec le nom (Name) et DataPropertyName
            dataGridpersonel.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "idpersonnel", // Nom de la colonne
                DataPropertyName = "idpersonnel", // Doit correspondre au DataTable
                HeaderText = "ID",
                Visible = false
            });

            dataGridpersonel.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "nom", // Nom de la colonne
                DataPropertyName = "nom",
                HeaderText = "Nom"
            });

            dataGridpersonel.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "prenom",
                DataPropertyName = "prenom",
                HeaderText = "Prénom"
            });

            dataGridpersonel.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "tel",
                DataPropertyName = "tel",
                HeaderText = "Téléphone"
            });

            dataGridpersonel.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "mail",
                DataPropertyName = "mail",
                HeaderText = "Email"
            });

            dataGridpersonel.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "service",
                DataPropertyName = "service",
                HeaderText = "service"
            });

            dataGridpersonel.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "idservice",
                DataPropertyName = "idservice",
                HeaderText = "ID Service",
                Visible = false
            });
        }

        /// <summary>
        /// Charge la liste des services depuis la base de données.
        /// </summary>
        private void ChargerServices()
        {
            try
            {
                using (var conn = bddManager.GetConnection())
                {
                    conn.Open();
                    var da = new MySqlDataAdapter("SELECT idservice, nom FROM service", conn);
                    var dt = new DataTable();
                    da.Fill(dt);

                    boxservice.DisplayMember = "nom";
                    boxservice.ValueMember = "idservice";
                    boxservice.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement services : {ex.Message}");
            }
        }

        /// <summary>
        /// Charge la liste du personnel depuis la base de données.
        /// </summary>
        private void ChargerPersonnel()
        {
            try
            {
                using (var conn = bddManager.GetConnection())
                {
                    conn.Open();
                    var query = @"SELECT
                                p.idpersonnel,
                                p.nom,
                                p.prenom,
                                p.tel,
                                p.mail,
                                p.idservice,
                                s.nom AS service
                                FROM personnel p
                                INNER JOIN service s ON p.idservice = s.idservice";

                    var da = new MySqlDataAdapter(query, conn);
                    dtPersonnel.Clear();
                    da.Fill(dtPersonnel);
                    dataGridpersonel.ClearSelection();
                    dataGridpersonel.CurrentCell = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement : {ex.Message}");
            }
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton d'ajout de personnel.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnajouterpersonel_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            try
            {
                using (var conn = bddManager.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES (@nom, @prenom, @tel, @mail, @idservice)",
                        conn);

                    RemplirParametres(cmd);
                    cmd.ExecuteNonQuery();

                    ChargerPersonnel();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur insertion : {ex.Message}");
            }
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de modification de personnel.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnmodifierpersonel_Click(object sender, EventArgs e)
        {
            if (dataGridpersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un membre du personnel");
                return;
            }

            if (!ValiderChamps()) return;

            try
            {
                using (var conn = bddManager.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand(
                        "UPDATE personnel SET nom=@nom, prenom=@prenom, tel=@tel, mail=@mail, idservice=@idservice WHERE idpersonnel=@id",
                        conn);

                    RemplirParametres(cmd);
                    cmd.Parameters.AddWithValue("@id", ObtenirIdSelectionne());
                    cmd.ExecuteNonQuery();

                    ChargerPersonnel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur modification : {ex.Message}");
            }
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de suppression de personnel.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnsupprimerpersonel_Click(object sender, EventArgs e)
        {
            if (dataGridpersonel.SelectedRows.Count == 0) return;

            if (MessageBox.Show("Confirmez la suppression ?", "Confirmation",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = bddManager.GetConnection())
                    {
                        conn.Open();
                        var cmd = new MySqlCommand(
                            "DELETE FROM personnel WHERE idpersonnel=@id",
                            conn);

                        cmd.Parameters.AddWithValue("@id", ObtenirIdSelectionne());
                        cmd.ExecuteNonQuery();

                        ChargerPersonnel();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur suppression : {ex.Message}");
                }
            }
        }

        /// <summary>
        /// Gère l'événement de changement de sélection dans le DataGridView du personnel.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void dataGridpersonel_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridpersonel.SelectedRows.Count > 0)
            {
                var row = dataGridpersonel.SelectedRows[0];
                txtnom.Text = row.Cells["nom"].Value.ToString();
                txtprenom.Text = row.Cells["prenom"].Value.ToString();
                txttel.Text = row.Cells["tel"].Value?.ToString() ?? "";
                txtemail.Text = row.Cells["mail"].Value.ToString();
                boxservice.SelectedValue = row.Cells["idservice"].Value;
            }
        }

        /// <summary>
        /// Obtient l'ID du personnel sélectionné.
        /// </summary>
        /// <returns>L'ID du personnel sélectionné.</returns>
        private int ObtenirIdSelectionne()
        {
            return Convert.ToInt32(dataGridpersonel.SelectedRows[0].Cells["idpersonnel"].Value);
        }

        /// <summary>
        /// Valide les champs du formulaire.
        /// </summary>
        /// <returns>True si les champs sont valides, sinon False.</returns>
        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtnom.Text)) return AfficherErreur("Nom");
            if (string.IsNullOrWhiteSpace(txtprenom.Text)) return AfficherErreur("Prénom");
            if (string.IsNullOrWhiteSpace(txtemail.Text)) return AfficherErreur("Email");
            return true;

            bool AfficherErreur(string champ)
            {
                MessageBox.Show($"{champ} est obligatoire !");
                return false;
            }
        }

        /// <summary>
        /// Remplit les paramètres d'une commande SQL avec les valeurs du formulaire.
        /// </summary>
        /// <param name="cmd">La commande SQL à remplir.</param>
        private void RemplirParametres(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@nom", txtnom.Text.Trim());
            cmd.Parameters.AddWithValue("@prenom", txtprenom.Text.Trim());
            cmd.Parameters.AddWithValue("@tel", txttel.Text.Trim());
            cmd.Parameters.AddWithValue("@mail", txtemail.Text.Trim());
            cmd.Parameters.AddWithValue("@idservice", boxservice.SelectedValue);
        }

        /// <summary>
        /// Réinitialise le formulaire.
        /// </summary>
        private void ResetForm()
        {
            txtnom.Clear();
            txtprenom.Clear();
            txttel.Clear();
            txtemail.Clear();
            boxservice.SelectedIndex = -1;
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de rechargement du personnel.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btncharger_Click(object sender, EventArgs e)
        {
            ChargerPersonnel();
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton d'initialisation du formulaire.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void but_rnitialiser_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de gestion des absences.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void gereabsence_Click(object sender, EventArgs e)
        {
            if (dataGridpersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un membre du personnel !");
                return;
            }

            int idPersonnel = ObtenirIdSelectionne();
            gestion_absence gbsform = new gestion_absence(); // Passe l'ID du personnel sélectionné
            gbsform.Show();
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton d'initialisation du formulaire.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void but_rnitialiser_Click_1(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
