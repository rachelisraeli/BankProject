using Bank.Entities;

namespace Solid.Core
{
    public interface IDataContext
    {
        List<Banker> Bankers { get; set; }

        List<Client> Clients { get; set; }

        List<Turn> Turns { get; set; }
    }
}
