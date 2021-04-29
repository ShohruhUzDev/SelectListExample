﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SelectListExample.Models
{
    public class City
    {
        [Key]
        [MaxLength(3)]
        public string Code { get; set; }
        [Required]
        [MaxLength(75)]
        public string Name { get; set; }
        
        [ForeignKey("Country")]
        public string  CountryCode { get; set; }
        public virtual Country Country { get; set; }

    }
}
