using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek86.forms
{
    public partial class menu : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe menu.
        /// </summary>
        public menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de gestion des absences.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnGestionAbsence_Click(object sender, EventArgs e)
        {
            gestion_absence gbsform = new gestion_absence(); // Ouvre en mode général
            gbsform.Show();
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de gestion du personnel.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnGestionPersonnel_Click(object sender, EventArgs e)
        {
            gestion_personnel gpsform = new gestion_personnel();
            gpsform.Show();
        }

        /// <summary>
        /// Gère l'événement de clic sur le bouton de déconnexion.
        /// </summary>
        /// <param name="sender">La source de l'événement.</param>
        /// <param name="e">Les données de l'événement.</param>
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
