namespace Core.Entities.Concrete
{
    public class UserOperationClaim : Entity<int>
    {

        public int UserId { get; set; }

        public int OperationClaimId { get; set; }
    }
}
