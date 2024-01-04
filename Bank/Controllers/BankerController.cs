using Bank.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core;
using Solid.Core.Services;
using Solid.Service;
using System.Collections.Generic;

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankerController : ControllerBase
    {
        static int index = 0;

        private readonly IBankerService _bankerService;

        public BankerController(IBankerService bankerService)
        {
            _bankerService = bankerService;
        }

        // GET: api/<BankayController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_bankerService.GetBankers());
        }

        // GET api/<BankayController>/5
        [HttpGet("id/{id}")]
        public ActionResult Get(int id)
        {
            //var banker = _context.Bankers.FirstOrDefault(b => b.Id == id);
            var banker = _bankerService.GetById(id);
            if (banker is null)
            {
                return NotFound();
            }
            return Ok(banker);
        }

        [HttpGet("name/{name}")]
        public ActionResult GetByName(string name)
        {
            //var banker = _context.Bankers.FirstOrDefault(b => b.Name == name);
            var banker = _bankerService.GetByName(name);
            if (banker is null)
            {
                return NotFound();
            }
            return Ok(banker);
        }

        // POST api/<BankayController>
        [HttpPost]
        public void Post([FromBody] Banker b)
        {
            index++;
            _bankerService.Post(b);
            //_context.Bankers.Add(new Banker { Id = ++index, Name = b.Name });
        }

        // PUT api/<BankayController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Banker b)
        {
            //var banker = _context.Bankers.FirstOrDefault(b => b.Id == id);
            var banker = _bankerService.Put(id, b);
            banker.Name = b.Name;
        }

        // DELETE api/<BankayController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //var banker = _context.Bankers.FirstOrDefault(b => b.Id == id);
            //_context.Bankers.Remove(banker);
            //for (int i = _context.Bankers.FindIndex(b => b.Id == id) + 1; i < _context.Bankers.Count; i++)
            //{
            //    _context.Bankers[i].Id--;
            //}
            _bankerService.Delete(id);
            index--;
        }
    }
}
