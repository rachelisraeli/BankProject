using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IBankerRepository
    {
        List<Banker> GetBankers();

        Banker GetById(int id);

        Banker GetByName(string name);

        Banker AddBanker(Banker banker);

        Banker UpdateBanker(int id, Banker banker);

        void DeleteBanker(int id);
    }
}
