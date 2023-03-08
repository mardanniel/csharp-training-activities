namespace EMSProjectAssignment.Entities
{
    public class Employee : Person
    {
        public Department Department { get; set; }
        public int Salary { get; set; }
    }
}
