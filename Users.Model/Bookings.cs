using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Model
{
    public class Bookings
    {
        public int Id { get; set; }
        public required DateTime BookedDateTime { get; set; }
        public required User User { get; set; }
        public required Doctor Doctor { get; set; }
    }
}
