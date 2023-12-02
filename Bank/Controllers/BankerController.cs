using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankerController : ControllerBase
    {
        static int index = 0;

        private static List<Banker> bankers = new List<Banker>
        {
            new Banker { Id = ++index, Name = "Avi" },
            new Banker { Id = ++index, Name = "Baruch" }
        };

        // GET: api/<BankayController>
        [HttpGet]
        public IEnumerable<Banker> Get()
        {
            return bankers;
        }

        // GET api/<BankayController>/5
        [HttpGet("id/{id}")]
        public Banker Get(int id)
        {
            var banker = bankers.FirstOrDefault(b => b.Id == id);
            return banker;
        }

        [HttpGet("name/{name}")]
        public Banker GetByName(string name)
        {
            var banker = bankers.FirstOrDefault(b => b.Name == name);
            return banker;
        }

        // POST api/<BankayController>
        [HttpPost]
        public void Post([FromBody] Banker b)
        {
            //index++;
            bankers.Add(new Banker { Id = ++index, Name = b.Name });
        }

        // PUT api/<BankayController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Banker b)
        {
            var banker = bankers.FirstOrDefault(b => b.Id == id);
            banker.Name = b.Name;
        }

        // DELETE api/<BankayController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var banker = bankers.FirstOrDefault(b => b.Id == id);
            bankers.Remove(banker);
            for (int i = bankers.FindIndex(b => b.Id == id) + 1; i < bankers.Count; i++)
            {
                bankers[i].Id--;
            }
            index--;
        }
    }
}
