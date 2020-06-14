using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Transport_Server.Models
{
    public class Vehicle
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(7)]
        public string Color { get; set; }
        
        [Required]
        [StringLength(250)]
        public string Company { get; set; }
        
        [Required]
        [StringLength(250)]
        public string Model { get; set; }
        
        [Required]
        [DataType("smalldatetime")]
        public DateTime Year { get; set; }

        //Navigation Properties

        public List<VehicleService> VehicleServices { get; set; }
    }
}
