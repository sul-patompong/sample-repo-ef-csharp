namespace sample_repo_ef_csharp.Core.Domain
{
    public class User : BaseDomain
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}