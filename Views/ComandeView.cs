using System.Reflection;

namespace GestionCommandes_.Views
{
    public class ComandeView
    {

        @model IEnumerable<YourNamespace.Models.Commande>

<h2>Mes Commandes</h2>
<table class="table">
    <thead>
        <tr>
            <th>ID</th>
            <th>Date</th>
            <th>Montant</th>
            <th>Statut</th>
        </tr>
    </thead>
    <tbody>
        @foreach(var commande in Model)
        {
            < tr >
                < td > @commande.CommandeId </ td >
                < td > @commande.DateCommande.ToShortDateString() </ td >
                < td > @commande.Montant </ td >
                < td > @commande.Statut </ td >
            </ tr >
        }
    </tbody>
</table>

    }
}
