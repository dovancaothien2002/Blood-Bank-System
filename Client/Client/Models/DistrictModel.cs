using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class DistrictModel
    {
        [Display(Name = "Id")]
        public  int districtId { get; set; }
        [Display(Name = "Name")]
        public string districtName { get; set; }
        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }

        [Display(Name = "City Id")]
        public int cityId { get; set; }
        [Display(Name = "City Name")]
        public string cityName { get; set; }
    }
}
