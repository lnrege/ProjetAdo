using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Entity;
using static System.Collections.Specialized.BitVector32;

namespace Business.Contracts
{
    public interface IClientBusiness
    {
        public void AjouterClient(Client client);
        public List<Client> Afficher();
        public Client RechercherClient(int id);
        public void SupprimerClient(int id);

        public void UpdateClient(int idClient, Client newClient, int selection);

    }
}

