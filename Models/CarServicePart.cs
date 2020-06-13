using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Transport_Server.Models
{
    public class CarServicePart
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public int PartId { get; set; }
        
        [Required]
        public int CarServiceId { get; set; }
        
        public int NumberOfParts { get; set; }

        // Navigation Properties

        public Part Part { get; set; }

        public CarService CarService { get; set; }
    }
}
