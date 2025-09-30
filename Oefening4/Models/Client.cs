namespace Oefening4.Models
{
    public class Client
    {

        public Client(int clientId, int locId, string name)
        {
            ClientID = clientId;
            LocationID = locId;
            ClientName = name;  
        }

        public int ClientID { get; set; }
        public int LocationID { get; set; }
        public string ClientName { get; set; }

    }
}
