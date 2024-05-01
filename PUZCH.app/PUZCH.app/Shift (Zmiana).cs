using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUZCH.app
{
    internal class Shift__Zmiana_
    {
        public DateTime StartTime { get; set; } // Czas rozpoczęcia zmiany
        public DateTime EndTime { get; set; } // Czas zakończenia zmiany

        // Konstruktor
        public Shift__Zmiana_(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        //Shift__Zmiana_ zmiana = new Shift__Zmiana_(DateTime.Now, DateTime.Now.AddHours(8));

    }
}
