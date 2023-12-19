using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class City
    {
        [Display(Name = "Id")]
        public int cityId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter the city name")]
        public string cityName { get; set; }
        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }
        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }

        ICollection<District> districts { get; set; }

    }
}
