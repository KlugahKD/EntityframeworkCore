using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class BusRoute
    {
        public int BusId { get; set; }
        public virtual Bus Bus { get; set; }
        public int RouteId { get; set; }
        public virtual Route Route { get; set; }

    }
}
