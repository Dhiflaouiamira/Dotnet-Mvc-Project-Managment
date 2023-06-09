
namespace Project_management.Models

{
    public class Project
    {
        public int Id  { get; set; }
        public string Name { get; set; }

        public ICollection<Ticket> Tickets { get; } = new List<Ticket>();
     

    }
}
