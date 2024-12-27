namespace GestionCommandes_.Models
{
    public class ProduitCommande
    {
        public int CommandeId { get; set; }
        public Commande Commande { get; set; }
        public int ProduitId { get; set; }
        public Produit Produit { get; set; }
        public int Quantite { get; set; }
    }

}
