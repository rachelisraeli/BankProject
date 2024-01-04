using Bank.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public List<Client> GetClients()
        {
            return _clientRepository.GetClients();
        }

        public Client GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public Client GetByName(string name)
        {
            return _clientRepository.GetByName(name);
        }

        public void Post(Client client)
        {
            _clientRepository.AddClient(client);
        }

        public Client Put(int id, Client client)
        {
            return _clientRepository.UpdateClient(id, client);
        }

        public void Delete(int id)
        {
            _clientRepository.DeleteClient(id);
        }
    }
}
