using GestionCommandes_.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GestionCommandes_.Controllers
{
    public class StockController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        // Ajouter un produit
        [HttpPost]
        public ActionResult AjouterProduit(Produit produit)
        {
            _context.Produits.Add(produit);
            _context.SaveChanges();
            return RedirectToAction("ListeProduits");
        }

        // Voir les produits
        public ActionResult ListeProduits()
        {
            var produits = _context.Produits.ToList();
            return View(produits);
        }
    }

}
