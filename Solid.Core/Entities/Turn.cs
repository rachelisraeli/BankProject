namespace Bank.Entities
{
    public class Turn
    {
        public int Id { get; set; }

        //public DateOnly Date { get; set; }

        //public TimeOnly Hour { get; set; }

        public int BankerId { get; set; }


        //Foreign Key
        public int ClientId { get; set; }


        //Reference Navigation Property
        public Client Client { get; set; }


    }
}
