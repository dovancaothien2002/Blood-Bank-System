using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    public class BloodStockModel
    {
        public int bloodstockId { get; set; }

        public float quantity { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }

        public int bbId { get; set; }
        public string bbName { get; set; }

        public int bloodId { get; set; }
        public string bloodName { get; set; }

    }
}
