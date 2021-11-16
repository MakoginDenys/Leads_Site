namespace WebApplication1.Models
{
    public class Lead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyLink { get; set; }
        public double Salary { get; set; }
        public Lead()
        {
            Name = "Unset";
            Surname = "Unset";
            CompanyLink = "Unset";
            Salary = 0;
        }
    }
}
