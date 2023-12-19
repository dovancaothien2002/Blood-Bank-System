using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class District
    {
        [Display(Name = "Id")]
        public  int districtId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter district name")]
        [MinLength(6, ErrorMessage = "District name must have at least 6 characters")]
        [MaxLength(35, ErrorMessage = "District names can be up to 35 characters long")]
        public string districtName { get; set; }

        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }

        [Display(Name = "City Id")]
        public int cityId { get; set; }
        public City city { get; set; }

        ICollection<BloodBank> bloodBanks { get; set; }
        ICollection<Donor> donors { get; set; }
    }
}
