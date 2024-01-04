using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IClientRepository
    {
        List<Client> GetClients();

        Client GetById(int id);

        Client GetByName(string name);

        Client AddClient(Client client);

        Client UpdateClient(int id, Client client);

        void DeleteClient(int id);
    }
}
