using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IBankerService
    {
        List<Banker> GetBankers();

        Banker GetById(int id);

        Banker GetByName(string name);

        void Post(Banker banker);

        Banker Put(int id, Banker banker);

        void Delete(int id);
    }
}
