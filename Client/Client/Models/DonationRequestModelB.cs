using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class DonationRequestModelB
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

        [Display(Name = "Donor Name")]
        public string donorName { get; set; }

        [Display(Name = "Donor Email")]
        public string donorEmail { get; set; }
        [Display(Name = "Donor Phone")]
        public string donorPhone { get; set; }
        [Display(Name = "Donor Age")]
        public int donordAge { get; set; }
        [Display(Name = "Donor Birthday")]
        public DateTime donorBirthday { get; set; }

        [Display(Name = "Donor Gender")]
        public bool donorGender { get; set; }
        [Display(Name = "Donor Address")]
        public string donorAddress { get; set; }
        [Display(Name = "Donor Weight")]
        public float donorWeight { get; set; }
        [Display(Name = "Donor Status")]
        public bool donorStatus { get; set; }
        [Display(Name = "Blood Group Id")]
        public int donorBloodId { get; set; }
        [Display(Name = "Blood Group")]
        public string donorBloodName { get; set; }

        public int bbId { get; set; }
        public string bbName { get; set; }


        [Display(Name = "Expected Date")]
        public DateTime expected_date { get; set; }

        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }
    }
}
