using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
   
    public class RequestToDonorModel
    {
        [Display(Name = "Id")]
        public int rtdId { get; set; }

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Please enter your fullname")]
        public string fullname { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter your address")]
        public string address { get; set; }

        [Display(Name = "Gender")]
        public bool gender { get; set; }

        [Display(Name = "Birthday")]
        public DateTime birthday { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your email")]
        public string email { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Please enter your phone")]
        public string phone { get; set; }

        [Display(Name = "Amount")]
        [Required(ErrorMessage = "Please enter your amount")]
        public float amount { get; set; }

        [Display(Name = "Note")]
        public string note { get; set; }
        [Display(Name = "Hospital treatment")]
        public string hospitaltreatment { get; set; }
        [Display(Name = "Status")]
        public int status { get; set; }

        [Display(Name = "Donor id")]
        public int donorId { get; set; }

        [Display(Name = "Donor name")]
        public string donorName { get; set; }

        [Display(Name = "Expected Date ")]
        public DateTime expected_date { get; set; }

        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }

    }
}
