using Amrproject.Audits;
using Amrproject.Models.Location;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amrproject.Parent
{
    public class People : AuditEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BrithDay { get; set; }
        public List<Address> addresses { get; set; }
        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
