using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    [Table("District")]
    public class District
    {
        [Key]
        public  int districtId { get; set; }
        public string districtName { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }

        public int cityId { get; set; }
        public City city { get; set; }

        ICollection<BloodBank> bloodBanks { get; set; }
        ICollection<Donor> donors { get; set; }
    }
}
