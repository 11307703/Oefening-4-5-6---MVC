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
            Clients.Add(new Client(1,1,"Alpha"));
            Clients.Add(new Client(2, 2, "Bravo"));

            Locations= new List<Location>();
            Locations.Add(new Location(1, "3600", "Genk"));
            Locations.Add(new Location(2, "3660", "Oudsbergen"));
        }

        public static InsertResult AddClient(Client c)
        {
            InsertResult result = new InsertResult();
            Clients.Add(c);
            result.Succeeded = true;
            return result;
        }

        public static InsertResult AddLocation(Location l)
        {
            InsertResult result = new InsertResult();
            Locations.Add(l);
            result.Succeeded = true;
            return result;
        }

    }
}
