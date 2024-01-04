using Bank.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core;
using Solid.Core.Services;
using Solid.Service;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        static int index = 2;

        // GET: api/<ClientController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_clientService.GetClients());
        }

        // GET api/<ClientController>/5
        [HttpGet("id/{id}")]
        public ActionResult Get(int id)
        {
            //var client = _context.Clients.FirstOrDefault(c => c.Id == id);
            var client = _clientService.GetById(id);
            if (client is null)
            {
                return NotFound();
            }
            return Ok(client);
        }

        [HttpGet("name/{name}")]
        public ActionResult GetByName(string name)
        {
            //var client = _context.Clients.FirstOrDefault(c => c.Name == name);
            var client = _clientService.GetByName(name);
            if (client is null)
            {
                return NotFound();
            }
            return Ok(client);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Client c)
        {
            index++;
            _clientService.Post(c);
            //_context.Clients.Add(new Client { Id = index, Name = c.Name, Phone = c.Phone });
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client c)
        {
            var client = _clientService.Put(id, c);
            //var client = _context.Clients.FirstOrDefault(b => b.Id == id);
            client.Name = c.Name;
            client.Phone = c.Phone;
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            //var client = _context.Clients.FirstOrDefault(c => c.Id == id);
            //_context.Clients.Remove(client);
            //for (int i = _context.Clients.FindIndex(b => b.Id == id) + 1; i < _context.Clients.Count; i++)
            //{
            //    _context.Clients[i].Id--;
            //}
            _clientService.Delete(id);
            index--;
        }
    }
}
