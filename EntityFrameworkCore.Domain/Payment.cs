using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Domain
{
    public class Payment
      {
         public int Id { get; set; }
         [Required]
         public decimal Amount { get; set; }
         public DateTime PaymentDate { get; set; }
         public string UserId { get; set; }
         public User Users { get; set; }
      }

 
}
