namespace GestionCommandes_.Models
{
    public class Livraison
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string AdresseLivraison { get; set; }
        public int CommandeId { get; set; }
        public Commande Commande { get; set; }
        public int LivreurId { get; set; }
        public Livreur Livreur { get; set; }
    }

}
