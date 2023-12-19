using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
   
    public class Message
    {
        [Display(Name = "Message Id")]
        public int mId { get; set; }
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Please enter your full name")]
        public string fullname { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your Email")]
        public string email { get; set; }
        [Display(Name = "Status")]
        public bool status { get; set; }
        [Display(Name = "Message")]
        [Required(ErrorMessage = "Please enter your Message")]
        public string message { get; set; }
    }
}
