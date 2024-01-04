using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ITurnRepository
    {
        List<Turn> GetTurns();

        Turn GetById(int id);

        Turn GetByClientId(int id);

        Turn GetByBankerId(int id);

        Turn AddTurn(Turn turn);

        Turn UpdateTurn(int id, Turn turn);

        void DeleteTurn(int id);
    }
}
