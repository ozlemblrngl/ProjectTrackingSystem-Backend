namespace Entities.Concretes
{
    public class User : Core.Entities.Concrete.User
    {
        public List<Project> Projects { get; set; }
    }
}
