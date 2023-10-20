using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class Route
    {
        public int Id { get; set; }

        [Required]
        public string RouteName { get; set; }
        [Required]
        public  TimeSpan Duration{ get; set; }
        [Required]
        public decimal Price { get; set; }

    }
}
