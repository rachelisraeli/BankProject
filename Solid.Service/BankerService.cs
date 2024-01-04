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
    public class BankerService : IBankerService
    {
        private readonly IBankerRepository _bankerRepository;

        public BankerService(IBankerRepository bankerRepository)
        {
            _bankerRepository = bankerRepository;
        }
        public List<Banker> GetBankers()
        {
            return _bankerRepository.GetBankers();
        }

        public Banker GetById(int id)
        {
            return _bankerRepository.GetById(id);
        }

        public Banker GetByName(string name)
        {
            return _bankerRepository.GetByName(name);
        }

        public void Post(Banker banker)
        {
            _bankerRepository.AddBanker(banker);
        }

        public Banker Put(int id, Banker banker)
        {
            return _bankerRepository.UpdateBanker(id, banker);
        }

        public void Delete(int id)
        {
            _bankerRepository.DeleteBanker(id);
        }
    }
}
