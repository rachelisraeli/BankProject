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
    public class TurnService : ITurnService
    {
        private readonly ITurnRepository _turnRepository;

        public TurnService(ITurnRepository turnRepository)
        {
            _turnRepository = turnRepository;
        }

        public List<Turn> GetTurns()
        {
            return _turnRepository.GetTurns();
        }

        public Turn GetById(int id)
        {
            return _turnRepository.GetById(id);
        }

        public Turn GetByClientId(int id)
        {
            return _turnRepository.GetByClientId(id);
        }

        public Turn GetByBankerId(int id)
        {
            return _turnRepository.GetByBankerId(id);
        }

        public void Post(Turn turn)
        {
            _turnRepository.AddTurn(turn);
        }

        public Turn Put(int id, Turn turn)
        {
            return _turnRepository.UpdateTurn(id, turn);
        }

        public void Delete(int id)
        {
            _turnRepository.DeleteTurn(id);
        }

    }
}
