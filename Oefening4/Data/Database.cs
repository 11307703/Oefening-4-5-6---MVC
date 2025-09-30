using Oefening4.Models;

namespace Oefening4.Data
{
    public class Database
    {
        public static List<Client> Clients { get; set; }
        public static List<Location> Locations { get; set; }

        public static void StartDatabase()
        {
            Clients = new List<Client>();
            Clients.Add(new Client(1,1,"Tolga"));
            Clients.Add(new Client(2, 2, "Melihcan"));

            Locations= new List<Location>();
            Locations.Add(new Location(1, "3600", "Genk"));
            Locations.Add(new Location(1, "3660", "Oudsbergen"));

        }

    }
}
