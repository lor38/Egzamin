using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUZCH.app
{
    internal class Leave__Urlop_
    {
        public DateTime StartDate { get; set; } // Start date of the leave
        public DateTime EndDate { get; set; } // End date of the leave

        // Constructor
        public Leave__Urlop_(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
       
       // Leave__Urlop_ urlop = new Leave__Urlop_(DateTime.Now, DateTime.Now.AddDays(14));

    }
}
