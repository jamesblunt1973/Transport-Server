using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Transport_Server.Models
{
    public class Mechanic
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        // Navigation Properties

        public List<CarService> CarServices { get; set; }
    }
}
