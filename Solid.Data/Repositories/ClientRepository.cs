using Bank.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;

        public ClientRepository(DataContext context)
        {
            _context = context;
        }

        public List<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        public Client GetById(int id)
        {
            return _context.Clients.ToList().Find(c => c.Id == id);
        }

        public Client GetByName(string name)
        {
            return _context.Clients.ToList().Find(c => c.Name == name);
        }

        public Client AddClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
            return client;
        }

        public Client UpdateClient(int id, Client client)
        {
            var updateClient = _context.Clients.ToList().Find(c => c.Id == id);

            if (updateClient != null)
            {
                updateClient.Name = client.Name;
                updateClient.Phone = client.Phone;

                _context.SaveChanges();

                return updateClient;
            }
            return null;
        }

        public void DeleteClient(int id)
        {
            _context.Clients.Remove(_context.Clients.ToList().Find(c => c.Id == id));
            _context.SaveChanges();
        }
    }
}
