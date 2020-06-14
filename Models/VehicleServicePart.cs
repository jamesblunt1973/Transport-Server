using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Transport_Server.Models
{
    public class VehicleServicePart
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public int PartId { get; set; }
        
        [Required]
        public int VehicleServiceId { get; set; }
        
        public int NumberOfParts { get; set; }

        // Navigation Properties

        public Part Part { get; set; }

        public VehicleService VehicleService { get; set; }
    }
}
