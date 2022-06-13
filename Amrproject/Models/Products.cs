using Amrproject.Audits;

namespace Amrproject.Models
{
    public class Products : AuditEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

    }
}
