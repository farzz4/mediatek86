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

        public gestion_personnel()
        {
            InitializeComponent();
            Load += GestionPersonnel_Load;
            dataGridpersonel.SelectionChanged += dataGridpersonel_SelectionChanged;
        }

        private void GestionPersonnel_Load(object sender, EventArgs e)
        {
            ChargerServices();
            ConfigurerDataGrid();
            ChargerPersonnel();
        }

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
                HeaderText = "Service"
            });

            dataGridpersonel.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "idservice",
                DataPropertyName = "idservice",
                HeaderText = "ID Service",
                Visible = false
            });
        }
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

        private int ObtenirIdSelectionne()
        {
            return Convert.ToInt32(dataGridpersonel.SelectedRows[0].Cells["idpersonnel"].Value);
        }

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

        private void RemplirParametres(MySqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@nom", txtnom.Text.Trim());
            cmd.Parameters.AddWithValue("@prenom", txtprenom.Text.Trim());
            cmd.Parameters.AddWithValue("@tel", txttel.Text.Trim());
            cmd.Parameters.AddWithValue("@mail", txtemail.Text.Trim());
            cmd.Parameters.AddWithValue("@idservice", boxservice.SelectedValue);
        }

        private void ResetForm()
        {
            txtnom.Clear();
            txtprenom.Clear();
            txttel.Clear();
            txtemail.Clear();
            boxservice.SelectedIndex = -1;
        }

        private void btncharger_Click(object sender, EventArgs e)
        {
            ChargerPersonnel();
        }

        private void but_rnitialiser_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void gereabsence_Click(object sender, EventArgs e)
        {
            if (dataGridpersonel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un membre du personnel !");
                return;
            }

            int idPersonnel = ObtenirIdSelectionne();
            gestion_absence gbsform = new gestion_absence(); // Pass the selected personnel ID
            gbsform.Show();
        }

    }
}