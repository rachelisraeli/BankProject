using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private static List<Client> clients = new List<Client>
        {
            new Client { Id = 1, Name = "Aharon", Phone="0504172639" },
            new Client { Id = 2, Name = "Bluma", Phone="0527154148"}
        };

        static int index = 2;

        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return clients;
        }

        // GET api/<ClientController>/5
        [HttpGet("id/{id}")]
        public Client Get(int id)
        {
            var client = clients.FirstOrDefault(c => c.Id == id);
            return client;
        }

        [HttpGet("name/{name}")]
        public Client GetByName(string name)
        {
            var client = clients.FirstOrDefault(c => c.Name == name);
            return client;
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Client c)
        {
            index++;
            clients.Add(new Client { Id = index, Name = c.Name, Phone = c.Phone });
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client c)
        {
            var client = clients.FirstOrDefault(b => b.Id == id);
            client.Name = c.Name;
            client.Phone = c.Phone;
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var client = clients.FirstOrDefault(c => c.Id == id);
            clients.Remove(client);
            for (int i = clients.FindIndex(b => b.Id == id) + 1; i < clients.Count; i++)
            {
                clients[i].Id--;
            }
            index--;
        }
    }
}
