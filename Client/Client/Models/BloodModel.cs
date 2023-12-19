using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class BloodModel
    {
        public int bloodId { get; set; }

        public string bloodName { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }

    }
}
