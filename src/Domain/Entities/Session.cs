using FluentValidation;


namespace Domain.Entities
{
    public class Session
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        public Guid Day_Id { get; set; }
        public string Location_Type { get; set; }
        public string Venue_Name { get; set; }
        public string First_Address { get; set; }
        public string? Second_Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public Guid Link_Id { get; set; }
        public IEnumerable<string> Links { get; set; }
    }
}
