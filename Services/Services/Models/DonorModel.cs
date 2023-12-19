using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
   
    public class DonorModel
    {
        public int donorId { get; set; }
        public string donorName { get; set; }
        public string address { get; set; }
        public float weight { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public DateTime birthday { get; set; }
        public bool gender { get; set; }
        public bool status { get; set; }

        public int bloodId { get; set; }
        public string bloodName { get; set; }

        public int districtId { get; set; }
        public string districtName { get; set; }

        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }


    }
}
