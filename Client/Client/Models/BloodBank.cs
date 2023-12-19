using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class BloodBank
    {
        [Display(Name = "Id")]
        public int bbId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter the blood bank name")]
        [MinLength(6, ErrorMessage = "Blood bank name must have at least 6 characters")]
        [MaxLength(35, ErrorMessage = "Blood bank names can be up to 35 characters long")]
        public string bbName { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter the address")]
        [MinLength(6, ErrorMessage = "Address must have at least 6 characters")]
        [MaxLength(300, ErrorMessage = "Address can be up to 300 characters long")]
        public string address { get; set; }

        [Display(Name = "Calendar")]
        [Required(ErrorMessage = "Please enter the calendar")]
        public string calendar { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter the email")]
        [RegularExpression(@"^[a-zA-Z0-9_\.]{5,32}@[a-zA-Z0-9]{2,}(\.[a-zA-Z0-9]{2,4}){1,2}$", ErrorMessage = "Incorrect email format")]
        public string email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter the password")]
        public string password { get; set; }
       
        [Display(Name = "Hotline")]
        [Required(ErrorMessage = "Please enter the hotline")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Incorrect hotline number format")]
        public string hotline { get; set; }

        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }

        [Display(Name = "District")]
        public int districtId { get; set; }
        public District district { get; set; }

        ICollection<BloodStock> bloodStocks { get; set; }
        ICollection<DonationRequest> donationRequests { get; set; }
        ICollection<RequestToBloodBank> requestToBloodBanks { get; set; }

    }
}
