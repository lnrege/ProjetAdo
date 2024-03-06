using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Business;
using Business.Contracts;
using Repository;
using static System.Collections.Specialized.BitVector32;
using System.Net.Sockets;

namespace Controller
{
    public class ClientController
    {
        private IClientBusiness _clientBusiness;
        public ClientController(IClientBusiness clientBusiness)
        {
            _clientBusiness = clientBusiness;
        }
        public void AjouterClient(string nom, string prenom, DateOnly ddn, string adresse, string cp, string ville)
        {
            Client client = new Client(nom, prenom, ddn, adresse, cp, ville);
            _clientBusiness.AjouterClient(client);
        }

        public List<Client> Afficher()
        {
            return _clientBusiness.Afficher();
        }

        public Client RechercherClient(int id)
        {
            return _clientBusiness.RechercherClient(id);
        }

        public void SupprimerClient(int id)
        {
            _clientBusiness.SupprimerClient(id);
        }

        public void UpdateClient(int idClient, Client newClient, int selection)
        {
            _clientBusiness.UpdateClient(idClient, newClient, selection);
        }
    }
}