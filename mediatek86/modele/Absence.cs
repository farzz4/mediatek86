using System;

namespace MediaTek86.Modele
{
    /// <summary>
    /// Création de la classe métier pour la table des Absences
    /// Utilisation des fonctions getter pour les colonnes contenues dans la table Absences
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Initialisation des paramètres
        /// </summary>
        private DateTime datedebut;
        private DateTime datefin;
        private int idpersonnel;
        private int idmotif;
        private string motif;

        /// <summary>
        /// Création du getter de la date du début de l'absence
        /// </summary>
        public DateTime Datedebut { get => datedebut.Date; }
        /// <summary>
        /// Création du getter de la date du fin de l'absence
        /// </summary>
        public DateTime Datefin { get => datefin.Date; }
        /// <summary>
        /// Création du getter de l'id du personnel absent
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }
        /// <summary>
        /// Création du getter de l'id du motif de l'absence
        /// </summary>
        public int Idmotif { get => idmotif; }
        /// <summary>
        /// Création du getter du nom du motif de l'absence
        /// </summary>
        public string Motif { get => motif; }

        /// <summary>
        /// Constructeur : Valorise les propriétés
        /// </summary>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idpersonnel"></param>
        /// <param name="idmotif"></param>
        /// <param name="motif"></param>
        public Absence(DateTime datedebut, DateTime datefin, int idpersonnel, int idmotif, string motif)
        {
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idpersonnel = idpersonnel;
            this.idmotif = idmotif;
            this.motif = motif;
        }
    }
}
