using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class Bus
    {
        public int Id { get; set; }

        [Required]
        public string BusName { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        [Required]
        public string BusColor { get; set;}
    }
}
