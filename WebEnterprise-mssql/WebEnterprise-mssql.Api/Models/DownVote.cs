using System;

namespace WebEnterprise_mssql.Api.Models
{
    public class DownVote
    {
        public Guid ID { get; set; }
        public string userId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string postId { get; set; }
        public virtual Posts posts { get; set; }
    }
}