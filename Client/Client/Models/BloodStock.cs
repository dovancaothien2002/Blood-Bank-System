using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
   
    public class BloodStock
    {

        [Display(Name = "Id")]
        public int bloodstockId { get; set; }

        [Display(Name = "Quantity")]
        public float quantity { get; set; }
        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }
        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }

        [Display(Name = "Blood Bank Id")]
        public int bbId { get; set; }
        public BloodBank bloodBank { get; set; }

        [Display(Name = "Blood Group Id")]
        public int bloodId { get; set; }
        public Blood blood { get; set; }

    }
}
