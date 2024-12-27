using GestionCommandes_.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Reflection;

namespace GestionCommandes_.Views
{
    

 <h2>Détails de la Commande</h2>
<p>ID : @Model.CommandeId</p>
 <p>Date : @Model.DateCommande.ToShortDateString()</p>
<p>Montant : @Model.Montant</p>
 <p>Statut : @Model.Statut</p>
 <p>Client : @Model.Client.Nom @Model.Client.Prenom</p>

}
