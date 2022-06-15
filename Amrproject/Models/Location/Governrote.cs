using Amrproject.Audits;

namespace Amrproject.Models.Location
{
    public class Governrote : AuditEntity
    {
        public string Name { get; set; }
        public List<City> cities { get; set; }
    }
}
