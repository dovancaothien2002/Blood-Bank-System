using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    [Table("Message")]
    public class Message
    {
        [Key]
        public int mId { get; set; }

        public string fullname { get; set; }

        public string email { get; set; }

        public bool status { get; set; }

        public string message { get; set; }
    }
}
