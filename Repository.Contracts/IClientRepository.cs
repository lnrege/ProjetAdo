using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Repository.Contracts
{
    public interface IClientRepository
    {
        public void AjouterClient(Client client);
        public List<Client> Afficher();

        public Client RechercherClient(int id);

        public void SupprimerClient(int id);

        public void UpdateClient(int id, Client client, int selection);
    }
}
