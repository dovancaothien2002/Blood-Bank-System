﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Models
{
    [Table("City")]
    public class City
    {
        [Key]
        public int cityId { get; set; }

        public string cityName { get; set; }
        public DateTime create_at { get; set; }
        public DateTime update_at { get; set; }

        ICollection<District> districts { get; set; }

    }
}
