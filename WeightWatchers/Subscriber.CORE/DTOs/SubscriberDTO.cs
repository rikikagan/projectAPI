using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber.CORE.DTOs
{
    public class SubscriberDTO
    {
        public string? TZ { get; set; } 
        public string? FirstName { get; set; }  
        public string? LastName { get; set; }      
        public string? Email { get; set; }
        public string? Password { get; set; }
        public double Height { get; set; }

    }
}
