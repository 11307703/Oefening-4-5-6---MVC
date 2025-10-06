using Oefening4.Data;

namespace Oefening4.Models
{
    public class ClientLocation
    {
        public string ClientName { get; set; }
        public string City { get; set; }

        public static IEnumerable<ClientLocation> OverView()
        {
            var clients = Database.Clients ?? new List<Client>();
            var locations = Database.Locations ?? new List<Location>();

            return clients.Join(
                        locations,
                        c => c.LocationID,
                        l => l.LocationID,
                        (c, l) => new ClientLocation
                        {
                            ClientName = c.ClientName,
                            City = l.City
                        });
        }

    }
}
