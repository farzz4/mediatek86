namespace MediaTek86.Modele
{
    /// <summary>
    /// Création de la classe métier correspondant aux Motifs des absences
    /// Utilisation des fonctions Getter pour l'IdMotif et le libelle
    /// </summary>
    public class Motif
    { 
        private int idmotif;
        private string libelle;

        /// <summary>
        /// Création du getter de l'Idmotif des absences
        /// </summary>
        public int Idmotif { get => idmotif; }
        /// <summary>
        /// Création du getter du nom du motif de l'absence
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>Nom du motif</returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
