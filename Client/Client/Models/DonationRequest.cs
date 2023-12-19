using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class DonationRequest
    {
        [Display(Name = "Id")]
        public int drId { get; set; }
        [Display(Name = "Amount")]
        public float amount { get; set; }
        [Display(Name = "Note")]
        public string note { get; set; }
        [Display(Name = "Status")]
        public int status { get; set; }

        [Display(Name = "Donor Id")]
        public int donorId { get; set; }
        public Donor donor { get; set; }

        [Display(Name = "Blood Bank Id")]
        public int bbId { get; set; }
        public BloodBank bloodBank { get; set; }

        [Display(Name = "Expected Date")]
        public DateTime expected_date { get; set; }

        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }
    }
}
