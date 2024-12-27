﻿namespace GestionCommandes_.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int QuantiteEnStock { get; set; }
        public decimal PrixUnitaire { get; set; }
        public int QuantiteSeuil { get; set; }
        public string ImageUrl { get; set; }
    }

}
