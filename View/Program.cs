using View;
using Unity;
using Repository.Contracts;
using Business;
using Business.Contracts;
using Entity;
using Controller;
using Repository;
using System.Linq;
using System.Threading.Channels;


int choix = 18;

IUnityContainer unitycontainer = new UnityContainer();
unitycontainer.RegisterType<IClientRepository, ClientEFRepository>();
unitycontainer.RegisterType<IClientBusiness, ClientBusiness>();
ClientController monController = unitycontainer.Resolve<ClientController>();

void AjouterClient()
{
    monController.AjouterClient(ConsoleHelper.GetNomClient(), ConsoleHelper.GetPrenomClient(), ConsoleHelper.GetDDNClient(), ConsoleHelper.GetAdresseClient(), ConsoleHelper.GetCPClient(), ConsoleHelper.GetVilleClient());
}

Client RunRechercherClient()
{
    return monController.RechercherClient(ConsoleHelper.GetInputIntUser("Saisir l'id du client à afficher : "));
}

void RunSupprimerClient()
{
    int id = ConsoleHelper.GetInputIntUser("Saisir l'id du client à supprimer : ");
    monController.SupprimerClient(id);
    Console.WriteLine($"Client id : {id} supprimé");
}

void RunUpdateClient()
{
    int idClient = ConsoleHelper.GetInputIntUser("Saisir l'id du client à mettre à jour : ");
    int selection = ConsoleHelper.GetInputIntUser("Saisir la donnée à mettre à jour : 1 nom, 2 prénom, 3 date de naissance, 4 adresse, 5 code postal , 6 ville : ");
    Client newClient = new Client();
    switch (selection)
    {
        case 1: newClient.Nom=ConsoleHelper.GetNomClient(); break;
        case 2: newClient.Prenom=ConsoleHelper.GetPrenomClient(); break;
        case 3: newClient.DateNaissance=ConsoleHelper.GetDDNClient(); break;
        case 4: newClient.Adresse=ConsoleHelper.GetAdresseClient(); break;
        case 5: newClient.CodePostal=ConsoleHelper.GetCPClient(); break;
        case 6: newClient.Ville=ConsoleHelper.GetVilleClient(); break;
        default: break;
    }
    
    monController.UpdateClient(idClient, newClient, selection);
    Console.WriteLine($"Client id : {idClient} mis à jour");
}

while (choix != 0)
{
    ConsoleHelper.LancerMenu();
    choix = ConsoleHelper.GetInputIntUser("Que souhaitez vous faire ?");
    Console.WriteLine("Action n°" + choix + " choisie");

    switch (choix)
    {
        case 1: AjouterClient(); break;

        case 2: Console.WriteLine(string.Join("\n", monController.Afficher())); break;

        case 3: Console.WriteLine(string.Join("\n", RunRechercherClient())); break;

        case 4: RunSupprimerClient(); break;

        case 5: RunUpdateClient(); break;

        default: break;
    }

}




