using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    [Table("BloodStock")]
    public class BloodStock
    {
        [Key]
        public int bloodstockId { get; set; }

        public float quantity { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }

        public int bbId { get; set; }
        public BloodBank bloodBank { get; set; }

        public int bloodId { get; set; }
        public Blood blood { get; set; }

    }
}
