using System;
using System.Data;
using System.Windows.Forms;
using mediatek86.Bd;

namespace mediatek86.controllers
{
    public class PersonnelController
    {
        private readonly BddManager _bddManager;

        public PersonnelController()
        {
            _bddManager = new BddManager();
        }

        /// <summary>
        /// Ajoute un nouveau membre du personnel.
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
                _bddManager.AjouterPersonnel(nom, prenom, tel, mail, idservice);
                MessageBox.Show("Personnel ajouté avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du personnel : {ex.Message}");
            }
        }

        /// <summary>
        /// Supprime un membre du personnel.
        /// </summary>
        /// <param name="idpersonnel">L'ID du personnel à supprimer.</param>
        public void SupprimerPersonnel(int idpersonnel)
        {
            try
            {
                _bddManager.SupprimerPersonnel(idpersonnel);
                MessageBox.Show("Personnel supprimé avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression du personnel : {ex.Message}");
            }
        }

        /// <summary>
        /// Modifie les informations d'un membre du personnel.
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
                _bddManager.ModifierPersonnel(idpersonnel, nom, prenom, tel, mail, idservice);
                MessageBox.Show("Personnel modifié avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification du personnel : {ex.Message}");
            }
        }

        /// <summary>
        /// Récupère la liste de tout le personnel.
        /// </summary>
        /// <returns>Un DataTable contenant les informations du personnel.</returns>
        public DataTable ListerPersonnel()
        {
            try
            {
                return _bddManager.ListerPersonnel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération du personnel : {ex.Message}");
                return new DataTable();
            }
        }
    }
}
