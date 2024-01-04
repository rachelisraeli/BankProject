using Bank.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class TurnRepository : ITurnRepository
    {
        private readonly DataContext _context;

        public TurnRepository(DataContext context)
        {
            _context = context;
        }

        public List<Turn> GetTurns()
        {
            return _context.Turns.ToList();
        }

        public Turn GetById(int id)
        {
            return _context.Turns.ToList().Find(t => t.Id == id);
        }

        public Turn GetByClientId(int id)
        {
            return _context.Turns.ToList().Find(t => t.Id == id);
        }

        public Turn GetByBankerId(int id)
        {
            return _context.Turns.ToList().Find(t => t.Id == id);
        }

        public Turn AddTurn(Turn turn)
        {
            _context.Turns.Add(turn);
            _context.SaveChanges();
            return turn;
        }

        public Turn UpdateTurn(int id, Turn turn)
        {
            var updateTurn = _context.Turns.ToList().Find(t => t.Id == id);
            if (updateTurn != null)
            {
                updateTurn.ClientId = turn.ClientId;
                updateTurn.BankerId = turn.BankerId;

                _context.SaveChanges();

                return updateTurn;
            }
            return null;
        }

        public void DeleteTurn(int id)
        {
            _context.Turns.Remove(_context.Turns.ToList().Find(t => t.Id == id));
            _context.SaveChanges();
        }

    }
}
