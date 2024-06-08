using Core.Entities;
using Entities.Enums;

namespace Entities.Concretes
{
    public class Assignment : Entity<int>
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }

        public string? Description { get; set; }

        public Status Status { get; set; }

        public Project? Project { get; set; }
    }
}
