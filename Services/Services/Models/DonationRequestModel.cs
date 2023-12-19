using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    public class DonationRequestModel
    {
        public int drId { get; set; }
        public float amount { get; set; }
        public string note { get; set; }
        public int status { get; set; }

        public int donorId { get; set; }
        public string donorName { get; set; }

        public int bbId { get; set; }
        public string bbName { get; set; }


        public DateTime expected_date { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }
    }
}
