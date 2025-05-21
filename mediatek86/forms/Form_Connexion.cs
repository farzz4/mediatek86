using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace mediatek86.forms
{
    public partial class form_connexion : Form
    {
        private string connectionString = "Server=localhost;Database=mediatek86;Uid=root;Pwd=;CharSet=utf8mb4;";

        /// <summary>
        /// Initialise une nouvelle instance de la classe form_connexion.
        /// </summary>
        public form_connexion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcule le hachage SHA256 de la chaîne d'entrée.
        /// </summary>
        /// <param name="rawData">La chaîne d'entrée à hacher.</param>
        /// <returns>Le hachage SHA256 sous forme de chaîne hexadécimale.</returns>
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes) builder.Append(b.ToString("x2")); // Format basse casse
                return builder.ToString();
            }
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de connexion. Valide les informations d'identification de l'utilisateur par rapport à la base de données.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string mdp = txtMdp.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Veuillez saisir un login et un mot de passe.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Vérification du login (comparaison insensible à la casse)
                    string query = "SELECT pwd FROM responsable WHERE LOWER(login) = LOWER(@login)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string vraiHash = reader.GetString(0);
                            string hashSaisi = ComputeSha256Hash(mdp);

                            // 2. Comparaison des hashs en insensible à la casse
                            if (string.Equals(vraiHash, hashSaisi, StringComparison.OrdinalIgnoreCase))
                            {
                                // 3. Gestion correcte de la navigation
                                this.Hide();
                                new menu().ShowDialog(); // Mode modal
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show($"Échec de comparaison :\nBase: {vraiHash}\nSaisi: {hashSaisi}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login introuvable");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur critique : {ex.Message}\n{ex.StackTrace}");
            }
        }

        /// <summary>
        /// Gère l'événement de changement d'état de la case à cocher pour basculer la visibilité du mot de passe.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMdp.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
