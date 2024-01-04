using Bank.Entities;
using Solid.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBank
{
    internal class FakeContext : IDataContext
    {
        public List<Banker> Bankers { get; set; }

        public List<Client> Clients { get; set; }

        public List<Turn> Turns { get; set; }

        public FakeContext()
        {
            Bankers = new List<Banker> {
            new Banker { Id = 1, Name = "Avi" },
            new Banker { Id = 2, Name = "Baruch" } };

            Clients = new List<Client> {
            new Client { Id = 1, Name = "Aharon", Phone="0504172639" },
            new Client { Id = 2, Name = "Bluma", Phone="0527154148"} };

            Turns = new List<Turn> {
            new Turn { Id = 1, ClientId=2, BankerId=1},
            new Turn { Id = 2, ClientId=1, BankerId=2 } };
        }
    }
}
