﻿namespace _05_Indexeurs.Models
{
   public enum Couleurs
    {
        Coeur,
        Pique,
        Trefle,
        Carreau
    }

    public enum Valeurs
    {
        Deux = 2,
        Trois,
        Quatre,
        Cinq,
        Six,
        Sept,
        Huit,
        Neuf,
        Dix,
        Valet,
        Dame,
        Roi,
        As
    }

    internal class Card
    {
        public Couleurs Couleur;
        public Valeurs Valeur;
    }
}
