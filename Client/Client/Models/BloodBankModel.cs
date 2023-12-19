using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class BloodBankModel
    {
        [Display(Name = "Id")]
        public int bbId { get; set; }

        [Display(Name = "Name")]
        public string bbName { get; set; }
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name = "Calendar")]
        public string calendar { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Password")]
        public string password { get; set; }
        [Display(Name = "Hotline")]
        public string hotline { get; set; }
        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }
        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }

        [Display(Name = "District Id")]
        public int districtId { get; set; }
        [Display(Name = "District Name")]
        public string districtName { get; set; }

    }
}
