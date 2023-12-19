using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Donor
    {
        [Display(Name = "Id")]
        public int donorId { get; set; }

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Please enter your full name")]
        public string donorName { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter your address")]
        public string address { get; set; }

        [Display(Name = "Weight")]
        [Required(ErrorMessage = "Please enter your weight")]
        public float weight { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your email")]
        public string email { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Please enter your phone number")]
        public string phone { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter your password")]
        public string password { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Please enter your age")]
        public int age { get; set; }

        [Display(Name = "Birthday")]
        [Required(ErrorMessage = "Please enter your birthday")]
        public DateTime birthday { get; set; }

        [Display(Name = "Gender")]
        public bool gender { get; set; }

        [Display(Name = "Status")]
        public bool status { get; set; }

        [Display(Name = "Blood Group Id")]
        public int bloodId { get; set; }

        [Display(Name = "Blood Group Name")]
        public Blood blood { get; set; }

        [Display(Name = "District Id")]
        [Range(1, 10000000, ErrorMessage = "Please select district")]
        public int districtId { get; set; }
        public District district { get; set; }

        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }

        ICollection<RequestToDonor> requestToDonors { get; set; }
        ICollection<DonationRequest> donationRequests { get; set; }

    }
}
