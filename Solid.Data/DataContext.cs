using Microsoft.EntityFrameworkCore;
using Solid.Core;

namespace Bank.Entities
{
    public class DataContext : DbContext
    {
        public DbSet<Banker> Bankers { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Turn> Turns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }


        //public DataContext()
        //{
        //    Bankers = new List<Banker> {
        //    new Banker { Id = 1, Name = "Avi" },
        //    new Banker { Id = 2, Name = "Baruch" } };

        //    Clients = new List<Client> {
        //    new Client { Id = 1, Name = "Aharon", Phone="0504172639" },
        //    new Client { Id = 2, Name = "Bluma", Phone="0527154148"} };

        //    Turns = new List<Turn> {
        //    new Turn { Id = 1, ClientId=2, BankerId=1},
        //    new Turn { Id = 2, ClientId=1, BankerId=2 } };
        //}
    }
}
