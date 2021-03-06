﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Transport_Server.Models
{
    public class VehicleService
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int VehicleId { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        public int MechanicId { get; set; }

        public DateTime DateTime { get; set; }
        
        public int Duration { get; set; }   // Duration counts As Minutes
        
        [Required]
        public long Price { get; set; }

        // Navigation Properties
        public Vehicle Vehicle { get; set; }

        public Mechanic Mechanic { get; set; }

        public Service Service { get; set; }

        public List<VehicleServicePart> VehicleServiceParts { get; set; }

    }
}
