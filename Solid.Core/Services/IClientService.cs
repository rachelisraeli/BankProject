using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IClientService
    {
        List<Client> GetClients();

        Client GetById(int id);

        Client GetByName(string name);

        void Post(Client client);

        Client Put(int id, Client client);

        void Delete(int id);
    }
}
