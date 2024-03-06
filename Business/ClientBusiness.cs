using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Repository.Contracts;
using Business.Contracts;
using Repository;
using static System.Collections.Specialized.BitVector32;
using System.Net.Sockets;

namespace Business
{
    public class ClientBusiness : IClientBusiness
    {
  
        private IClientRepository _clientRep;
        public ClientBusiness(IClientRepository clientRepository)
        {
            _clientRep = clientRepository;
        }

        public void AjouterClient(Client client)
        {
             _clientRep.AjouterClient(client); 
        }

        public List<Client> Afficher()
        {
            return _clientRep.Afficher();
        }

        public Client RechercherClient(int id)
        {
            return _clientRep.RechercherClient(id);
        }

        public void SupprimerClient(int id)
        {
            _clientRep.SupprimerClient(id);
        }

        public void UpdateClient(int idClient, Client newClient, int selection)
        {
            _clientRep.UpdateClient(idClient, newClient, selection);
        }
    }
}
