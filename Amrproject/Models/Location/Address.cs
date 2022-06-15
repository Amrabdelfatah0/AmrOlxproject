using Amrproject.Audits;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amrproject.Models.Location
{
    public class Address : AuditEntity
    {

        public int UserId { get; set; }
        public int CityId { get; set; }
        public string AddressDetails { get; set; }
        [ForeignKey("CityId")]
        public City city { get; set; }
        [ForeignKey("UserId")]
        public User user { get; set; }
    }
}
