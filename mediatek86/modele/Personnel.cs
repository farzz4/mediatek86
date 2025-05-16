namespace MediaTek86.Modele
{
    /// <summary>
    /// Création de la classe métier pour la table Personnel
    /// Génération des Getters pour les colonnes de la table Personnel
    /// </summary>
    public class Personnel
    {

        private int IDPERSONNEL;
        private string NOM;
        private string PRENOM;
        private string TEL;
        private string MAIL;
        private int IDSERVICE;
        private string SERVICE;

        /// <summary>
        /// Création du getter de l'Idpersonnel
        /// </summary>
        public int Idpersonnel { get => IDPERSONNEL; }
        /// <summary>
        /// Création du getter du nom du personnel
        /// </summary>
        public string Nom { get => NOM; }
        /// <summary>
        /// Création du gprénom du personnel
        /// </summary>
        public string Prenom { get => PRENOM; }
        /// <summary>
        /// Création du getter du numéro de téléphone du personnel
        /// </summary>
        public string Tel { get => TEL; }
        /// <summary>
        /// Création du getter de l'adresse mail du personnel
        /// </summary>
        public string Mail { get => MAIL; }
        /// <summary>
        /// Création du getter de l'Idservice du personnel
        /// </summary>
        public int Idservice { get => IDSERVICE; }
        /// <summary>
        /// Création du getter du service d'affectation du personnel
        /// </summary>
        public string Service { get => SERVICE; }


        /// <summary>
        /// Constructeur : Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice, string service)
        {
            this.IDPERSONNEL = idpersonnel;
            this.NOM = nom;
            this.PRENOM = prenom;
            this.TEL = tel;
            this.MAIL = mail;
            this.IDSERVICE = idservice;
            this.SERVICE = service;
        }
    
    }

}
