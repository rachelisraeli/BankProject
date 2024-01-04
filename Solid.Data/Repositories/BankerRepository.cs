using Bank.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class BankerRepository : IBankerRepository
    {
        private readonly DataContext _context;

        public BankerRepository(DataContext context)
        {
            _context = context;
        }

        public List<Banker> GetBankers()
        {
            return _context.Bankers.ToList();
        }

        public Banker GetById(int id)
        {
            return _context.Bankers.ToList().Find(b => b.Id == id);
        }

        public Banker GetByName(string name)
        {
            return _context.Bankers.ToList().Find(b => b.Name == name);
        }

        public Banker AddBanker(Banker banker)
        {
            _context.Bankers.Add(banker);
            _context.SaveChanges();
            return banker;
        }

        public Banker UpdateBanker(int id, Banker banker)
        {
            var updateBanker = _context.Bankers.ToList().Find(b => b.Id == id);

            if (updateBanker != null)
            {
                updateBanker.Name = banker.Name;

                _context.SaveChanges();

                return updateBanker;
            }
            return null;
        }

        public void DeleteBanker(int id)
        {
            _context.Bankers.Remove(_context.Bankers.ToList().Find(b => b.Id == id));
            _context.SaveChanges();
        }

    }
}
