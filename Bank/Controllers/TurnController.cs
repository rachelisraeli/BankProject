using Bank.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Services;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        private readonly ITurnService _turnService;

        public TurnController(ITurnService turnService)
        {
            _turnService = turnService;
        }

        static int index = 2;

        // GET: api/<TurnController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_turnService.GetTurns());
        }

        [HttpGet("id/{id}")]
        public ActionResult Get(int id)
        {
            var turn = _turnService.GetById(id);
            if (turn is null)
            {
                return NotFound();
            }
            return Ok(turn);
        }

        [HttpGet("ClientId/{ClientId}")]
        public ActionResult GetByClientId(int cId)
        {
            var turn = _turnService.GetByClientId(cId);
            if (turn is null)
            {
                return NotFound();
            }
            return Ok(turn);
        }

        [HttpGet("BankerId/{BankerId}")]
        public ActionResult GetByBankerId(int bId)
        {
            var turn = _turnService.GetByBankerId(bId);
            if (turn is null)
            {
                return NotFound();
            }
            return Ok(turn);
        }

        // POST api/<TurnController>
        [HttpPost]
        public void Post([FromBody] Turn t)
        {
            index++;
            _turnService.Post(t);
            //_context.Turns.Add(new Turn { Id = index, ClientId = 1, BankerId = 2 });
            //turns.Add(new Turn { Id = index, Date = t.Date, Hour = t.Hour, ClientId = 1, BankerId = 2 });
        }

        // PUT api/<TurnController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Turn t)
        {
            var turn = _turnService.Put(id, t);
            //turn.Hour = t.Hour;
            //turn.Date = t.Date;
            turn.BankerId = t.BankerId;
            turn.ClientId = t.ClientId;
        }

        // DELETE api/<TurnController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //var turn = _context.Turns.FirstOrDefault(t => t.Id == id);
            //_context.Turns.Remove(turn); for (int i = _context.Turns.FindIndex(b => b.Id == id) + 1; i < _context.Turns.Count; i++)
            //{
            //    _context.Turns[i].Id--;
            //}
            _turnService.Delete(id);
            index--;
        }

        //private readonly IDataContext _context;
        //public TurnController(IDataContext context)
        //{
        //    _context = context;
        //}
        // GET api/<TurnController>/5
        //[HttpGet("id/{id}")]
        //public ActionResult Get(int id)
        //{
        //    var turn = _context.Turns.FirstOrDefault(t => t.Id == id);
        //    if (turn is null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(turn);
        //}
        //[HttpGet("ClientId/{ClientId}")]
        //public ActionResult GetByClientId(int cId)
        //{
        //    var turn = _context.Turns.FirstOrDefault(t => t.ClientId == cId);
        //    if (turn is null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(turn);
        //}
        //[HttpGet("BankerId/{BankerId}")]
        //public ActionResult GetByBankerId(int bId)
        //{
        //    var turn = _context.Turns.FirstOrDefault(t => t.BankerId == bId);
        //    if (turn is null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(turn);
        //}
        // POST api/<TurnController>
        //[HttpPost]
        //public void Post([FromBody] Turn t)
        //{
        //    index++;
        //    _context.Turns.Add(new Turn { Id = index, ClientId = 1, BankerId = 2 });
        //    //turns.Add(new Turn { Id = index, Date = t.Date, Hour = t.Hour, ClientId = 1, BankerId = 2 });
        //}
        //// PUT api/<TurnController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Turn t)
        //{
        //    var turn = _context.Turns.FirstOrDefault(b => b.Id == id);
        //    //turn.Hour = t.Hour;
        //    //turn.Date = t.Date;
        //    turn.BankerId = t.BankerId;
        //    turn.ClientId = t.ClientId;
        //}
        //// DELETE api/<TurnController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    var turn = _context.Turns.FirstOrDefault(t => t.Id == id);
        //    _context.Turns.Remove(turn); for (int i = _context.Turns.FindIndex(b => b.Id == id) + 1; i < _context.Turns.Count; i++)
        //    {
        //        _context.Turns[i].Id--;
        //    }
        //    index--;
        //}
    }
}