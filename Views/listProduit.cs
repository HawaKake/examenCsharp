using GestionCommandes_.Models;
using System.Reflection;
using System.Threading;
using System;

namespace GestionCommandes_.Views
{
    public class listProduit
    {


<h2>Liste des Produits</h2>
<table class="table">
    <thead>
        <tr>
            <th>ID</th>
            <th>Libellé</th>
            <th>Quantité en Stock</th>
            <th>Prix Unitaire</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var produit in Model)
        {
            < tr >
                < td > @produit.ProduitId </ td >
                < td > @produit.Libelle </ td >
                < td > @produit.QuantiteStock </ td >
                < td > @produit.PrixUnitaire </ td >
                < td >
                    < !--Lien pour modifier ou supprimer(à implémenter) -->
                </ td >
            </ tr >
        }
    </tbody>
</table>

    }
}
