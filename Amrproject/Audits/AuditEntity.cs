using Amrproject.Bases;

namespace Amrproject.Audits
{
    public class AuditEntity : Base
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
