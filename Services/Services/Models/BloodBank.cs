using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    [Table("BloodBank")]
    public class BloodBank
    {
        [Key]
        public int bbId { get; set; }
        public string bbName { get; set; }
        public string address { get; set; }
        public string calendar { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string hotline { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }

        public int districtId { get; set; }
        public District district { get; set; }

        ICollection<BloodStock> bloodStocks { get; set; }
        ICollection<DonationRequest> donationRequests { get; set; }
        ICollection<RequestToBloodBank> requestToBloodBanks { get; set; }

    }
}
