using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface ITurnService
    {
        List<Turn> GetTurns();

        Turn GetById(int id);

        Turn GetByClientId(int id);

        Turn GetByBankerId(int id);

        void Post(Turn turn);

        Turn Put(int id, Turn turn);

        void Delete(int id);
    }
}
