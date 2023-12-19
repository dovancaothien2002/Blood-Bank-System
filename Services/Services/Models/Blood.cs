using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    [Table("Blood")]
    public class Blood
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bloodId { get; set; }

        public string bloodName { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }

        public ICollection<BloodStock> bloodStocks { get; set; }
        public ICollection<RequestToBloodBank> requestToBloodBanks { get; set; }
        public ICollection<Donor> donors { get; set; }
        public ICollection<MobiLinkRequest> mobiLinkRequests { get; set; }
    }
}
