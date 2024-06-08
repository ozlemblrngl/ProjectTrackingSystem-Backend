using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concretes
{
    public class Project : Entity<int>
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public User? User { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
}
