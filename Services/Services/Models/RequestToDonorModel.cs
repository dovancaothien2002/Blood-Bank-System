using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    public class RequestToDonorModel
    {
        public int rtdId { get; set; }
        public string fullname { get; set; }
        public string address { get; set; }
        public bool gender { get; set; }
        public DateTime birthday { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public float amount { get; set; }
        public string note { get; set; }
        public string hospitaltreatment { get; set; }
        public int status { get; set; }

        public int donorId { get; set; }
        public string donorName { get; set; }


        public DateTime expected_date { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }
    }
}
