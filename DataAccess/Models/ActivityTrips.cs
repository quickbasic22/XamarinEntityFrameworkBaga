using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ActivityTrips
    {
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        public Guid Identifier { get; set; }
        public Trip Trip { get; set; }
    }
}
