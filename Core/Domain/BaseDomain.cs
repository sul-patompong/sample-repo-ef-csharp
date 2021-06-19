using System;

namespace sample_repo_ef_csharp.Core.Domain
{
    public class BaseDomain
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}