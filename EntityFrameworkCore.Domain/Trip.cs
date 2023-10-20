using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public enum TripStatus
    {
        NotStarted,
        InProgress,
        Completed,
        Canceled
    }

    public class Trip
    {
        public int Id { get; set; }
        [Required]
        public DateTime DepartureTime { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public TripStatus Status { get; set; }
        public int RouteId { get; set; }
        public virtual Route Route { get; set; }
        
        public string CancellationReason { get; set; }
                

    }
}
