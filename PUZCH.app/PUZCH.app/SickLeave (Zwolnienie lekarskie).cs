using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUZCH.app
{
    internal class SickLeave__Zwolnienie_lekarskie_
    {
        public DateTime StartDate { get; set; } // Data rozpoczęcia zwolnienia lekarskiego
        public DateTime EndDate { get; set; } // Data zakończenia zwolnienia lekarskiego

        // Konstruktor
        public SickLeave__Zwolnienie_lekarskie_(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        //SickLeave__Zwolnienie_lekarskie_ zwolnienie = new SickLeave__Zwolnienie_lekarskie_(DateTime.Now, DateTime.Now.AddDays(7));

    }
}
