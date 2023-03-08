namespace EMSProjectAssignment.Entities
{
    public class Address
    {
        public int? Id { get; set; }
        public string Door { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Pincode { get; set; }
    }
}
