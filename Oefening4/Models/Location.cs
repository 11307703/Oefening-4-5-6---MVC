namespace Oefening4.Models
{
    public class Location
    {

        public Location()
        {
            
        }
        public Location(int id, string postCode, string city)
        {
            LocationID = id;
            PostCode = postCode;
            City = city;
        }

        public int LocationID { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
    }
}
