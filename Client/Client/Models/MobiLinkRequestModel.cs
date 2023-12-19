using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
   
    public class MobiLinkRequestModel
    {

        [Display(Name = "Id")]
        public int mlrId { get; set; }
        [Display(Name = "Pateint name")]
        public string fullname { get; set; }
        [Display(Name = "Pateint address")]
        public string address { get; set; }

        [Display(Name = "Pateint email")]
        public string email { get; set; }
        [Display(Name = "Pateint phone")]
        public string phone { get; set; }
        [Display(Name = "Note")]
        public string note { get; set; }
        [Display(Name = "Hospital treatment")]
        public string hospitaltreatment { get; set; }
        [Display(Name = "Status")]
        public int status { get; set; }

        [Display(Name = "Blood Id")]
        public int bloodId { get; set; }
        [Display(Name = "Blood Group")]
        public string bloodName { get; set; }

        [Display(Name = "Expected Date")]
        public DateTime expected_date { get; set; }

        [Display(Name = "Created Date")]
        public DateTime create_at { get; set; }

        [Display(Name = "Updated Date")]
        public DateTime update_at { get; set; }

    }
}
