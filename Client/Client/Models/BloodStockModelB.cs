using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class BloodStockModelB
    {
        [Display(Name = "Id")]
        public int bloodstockId { get; set; }

        [Display(Name = "Amount")]
        public float quantity { get; set; }
        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }
        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }


        [Display(Name = "Blood Bank Id")]
        public int bbId { get; set; }

        [Display(Name = "Blood Bank Name")]
        public string bbName { get; set; }
        public string bbAddress { get; set; }
        public string bbCalendar { get; set; }
        public string bbEmail { get; set; }
        public string bbHotline { get; set; }

        [Display(Name = "Blood Group Id")]
        public int bloodId { get; set; }
        [Display(Name = "Blood Group Name")]
        public string bloodName { get; set; }
    }
}
