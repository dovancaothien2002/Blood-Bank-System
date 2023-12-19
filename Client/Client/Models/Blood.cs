using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Blood
    {
        [DisplayName("Id")]
        public int bloodId { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Please enter the blood group name")]
        public string bloodName { get; set; }

        [DisplayName("Created Date")]
        [DataType(DataType.Date)]
        public DateTime create_at { get; set; }
        [DisplayName("Updated Date")]
        [DataType(DataType.Date)]
        public DateTime update_at { get; set; }

        ICollection<BloodStock> bloodStocks { get; set; }
        ICollection<RequestToBloodBank> requestToBloodBanks { get; set; }
        ICollection<Donor> donors { get; set; }
        ICollection<MobiLinkRequest> mobiLinkRequests { get; set; }
    }
}
