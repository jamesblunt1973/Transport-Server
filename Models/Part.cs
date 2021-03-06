﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Transport_Server.Models
{
    public class Part
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        
        [Required]
        public long Price { get; set; }

        //Navigation Properties

        public List<Part> Parts { get; set; }


    }
}
