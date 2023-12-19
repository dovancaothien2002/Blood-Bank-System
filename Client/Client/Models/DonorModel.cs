using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
   
    public class DonorModel
    {
        [Display(Name = "Id")]
        public int donorId { get; set; }

        [Display(Name = "Full name")]
        public string donorName { get; set; }

        [Display(Name = "Address")]
        public string address { get; set; }

        [Display(Name = "Weight")]
        public float weight { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Phone")]
        public string phone { get; set; }

        [Display(Name = "Password")]
        public string password { get; set; }

        [Display(Name = "Age")]
        public int age { get; set; }

        [Display(Name = "Birthday")]
        public DateTime birthday { get; set; }

        [Display(Name = "Gender")]
        public bool gender { get; set; }

        [Display(Name = "Status")]
        public bool status { get; set; }

        [Display(Name = "Blood Group Id")]
        public int bloodId { get; set; }
        [Display(Name = "Blood Group")]
        public string bloodName { get; set; }
        [Display(Name = "District Id")]
        public int districtId { get; set; }
        [Display(Name = "District")]
        public string districtName { get; set; }
        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }

    }
}
