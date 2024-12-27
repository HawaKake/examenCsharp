using GestionCommandes_.Models;
using Microsoft.EntityFrameworkCore;


namespace GestionCommandes_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<ProduitCommande> ProduitCommandes { get; set; }
        public DbSet<Livraison> Livraisons { get; set; }
        public DbSet<Livreur> Livreurs { get; set; }
        public DbSet<Paiement> Paiements { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }

}
