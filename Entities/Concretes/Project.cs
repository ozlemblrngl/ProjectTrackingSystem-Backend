using Core.Entities;

namespace Entities.Concretes
{
    public class Project : Entity<int>
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Assignment> Assignments { get; set; }
    }
}
