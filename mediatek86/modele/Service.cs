namespace MediaTek86.Modele
{
    /// <summary>
    /// Création de la classe métier correspondant aux Services
    /// Utilisation des fonctions getter pour l'idservice et le nom du service
    /// </summary>
    public class Service
    {
        private int IDSERVICE;
        private string NOM;

        /// <summary>
        /// Création du getter de l'Idservice
        /// </summary>
        public int Idservice { get => IDSERVICE; }
        /// <summary>
        /// Création du getter du nom du service
        /// </summary>
        public string Nom { get => NOM; }

        /// <summary>
        /// Constructeur : Valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.IDSERVICE = idservice;
            this.NOM = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>Nom du service</returns>
        public override string ToString()
        {
            return this.NOM;
        }
    }
}
