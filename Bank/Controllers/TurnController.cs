using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        private static List<Turn> turns = new List<Turn>
        {
            new Turn { Id = 1, ClientId=2, BankerId=1},
            new Turn { Id = 2, ClientId=1, BankerId=2 }
            //new Turn { Id = 1, Date = new DateOnly(2023, 12, 5), Hour = new TimeOnly(08, 30), ClientId=2, BankerId=1},
            //new Turn { Id = 2, Date = new DateOnly(2023, 12, 3), Hour = new TimeOnly(12, 40), ClientId=1, BankerId=2 }
        };

        static int index = 2;

        // GET: api/<TurnController>
        [HttpGet]
        public IEnumerable<Turn> Get()
        {
            return turns;
        }

        // GET api/<TurnController>/5
        [HttpGet("id/{id}")]
        public Turn Get(int id)
        {
            var turn = turns.FirstOrDefault(t => t.Id == id);
            return turn;
        }

        [HttpGet("ClientId/{ClientId}")]
        public Turn GetByClientId(int cId)
        {
            var turn = turns.FirstOrDefault(t => t.ClientId == cId);
            return turn;
        }

        [HttpGet("BankerId/{BankerId}")]
        public Turn GetByBankerId(int bId)
        {
            var turn = turns.FirstOrDefault(t => t.BankerId == bId);
            return turn;
        }

        // POST api/<TurnController>
        [HttpPost]
        public void Post([FromBody] Turn t)
        {
            index++;
            turns.Add(new Turn { Id = index, ClientId = 1, BankerId = 2 });
            //turns.Add(new Turn { Id = index, Date = t.Date, Hour = t.Hour, ClientId = 1, BankerId = 2 });
        }

        // PUT api/<TurnController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Turn t)
        {
            var turn = turns.FirstOrDefault(b => b.Id == id);
            //turn.Hour = t.Hour;
            //turn.Date = t.Date;
            turn.BankerId = t.BankerId;
            turn.ClientId = t.ClientId;
        }

        // DELETE api/<TurnController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var turn = turns.FirstOrDefault(t => t.Id == id);
            turns.Remove(turn); for (int i = turns.FindIndex(b => b.Id == id) + 1; i < turns.Count; i++)
            {
                turns[i].Id--;
            }
            index--;
        }
    }
}