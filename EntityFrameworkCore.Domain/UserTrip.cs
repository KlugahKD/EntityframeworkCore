using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class UserTrip
    {
        public int Id { get; set; }
        public int UsersId { get; set; }
        public virtual Users Users { get; set; } 
        public int TripId { get; set; }
        public virtual Trip Trip { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
    }
}
