


using GestionCommandes_.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GestionCommandes_.Controllers

{
   

    public class ClientController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        // Afficher les commandes d'un client
        public ActionResult Commandes(int clientId)
        {
            var commandes = _context.Commandes
                .Where(c => c.ClientId == clientId)
                .ToList();
            return View(commandes);
        }

        // Enregistrer une commande
        [HttpPost]
        public ActionResult PasserCommande(Commande commande)
        {
            _context.Commandes.Add(commande);
            _context.SaveChanges();
            return RedirectToAction("Commandes", new { clientId = commande.ClientId });
        }
    }

}
