using Amrproject.Audits;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amrproject.Models.Location
{
    public class City : AuditEntity
    {
        public string Name { get; set; }
        public int GovernroteId { get; set; }
        [ForeignKey("GovernroteId")]
        public Governrote governrote { get; set; }
        public List<Address> addresses { get; set; }
    }
}
