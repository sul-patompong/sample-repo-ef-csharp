namespace sample_repo_ef_csharp.Core.Domain
{
    public class Car : BaseDomain
    {
        public int CarId { get; set; }
        public string LicenseCode { get; set; }
        public string Province { get; set; }
    }
}