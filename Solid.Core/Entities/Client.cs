﻿namespace Bank.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public List<Turn> Turns { get; set; }
    }
}
