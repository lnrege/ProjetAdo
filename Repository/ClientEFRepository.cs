using Entity;
using Repository.Contracts;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Repository
{
    public class ClientEFRepository : IClientRepository
    {
        public List<Client> Afficher()
        {
            LOCATIONContext context = new LOCATIONContext();
            List<Client> res = context.Clients.ToList();
            return res;
        }

        public void AjouterClient(Client client)
        {
            LOCATIONContext context = new LOCATIONContext();
            context.Clients.Add(client);
            context.SaveChanges();
        }
        public Client RechercherClient(int id)
        {
            LOCATIONContext context = new LOCATIONContext();
            List<Client> res = context.Clients.Where(c => c.Id == id).ToList();
            return res.FirstOrDefault();
        }

        public void SupprimerClient(int id)
        {
            LOCATIONContext context = new LOCATIONContext();
            Client res = context.Clients.Find(id);
            context.Clients.Remove(res);
            context.SaveChanges();
        }

        public void UpdateClient(int idClient, Client newClient, int selection)
        {
            LOCATIONContext context = new LOCATIONContext();
            Client clientToUpdate = context.Clients.Find(idClient);
            switch (selection)
            {
                case 1: clientToUpdate.Nom = newClient.Nom; break;
                case 2: clientToUpdate.Prenom = newClient.Prenom; break;
                case 3: clientToUpdate.DateNaissance = newClient.DateNaissance; break;
                case 4: clientToUpdate.Adresse = newClient.Adresse; break;
                case 5: clientToUpdate.CodePostal = newClient.CodePostal; break;
                case 6: clientToUpdate.Ville = newClient.Ville; break;
                default: break;
            }
            context.SaveChanges();
        }
    }
}
