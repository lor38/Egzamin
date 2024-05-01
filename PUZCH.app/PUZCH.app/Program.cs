using System;
using System.Collections.Generic;
using PUZCH.app;

namespace PUZCH
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee__Pracownik_> employees = new List<Employee__Pracownik_>();

            while (true)
            {
                // Pytanie o imię pracownika
                Console.Write("Podaj imię pracownika (lub '/', aby zakończyć): ");
                string firstName = Console.ReadLine() ?? "";

                if (firstName.ToLower() == "/")
                {
                    break;
                }

                // Pytanie o nazwisko pracownika
                Console.Write("Podaj nazwisko pracownika: ");
                string lastName = Console.ReadLine() ?? "";

                // Pytanie o adres e-mail pracownika
                Console.Write("Podaj adres e-mail pracownika: ");
                string emailAddress = Console.ReadLine() ?? "";

                // Tworzenie nowego pracownika
                Employee__Pracownik_ pracownik = new Employee__Pracownik_(firstName, lastName, emailAddress);

                // Pytanie o datę rozpoczęcia chorobowego
                Console.Write("Podaj datę rozpoczęcia chorobowego (format: RRRR-MM-DD): ");
                DateTime sickLeaveStartDate = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString());

                // Pytanie o datę zakończenia chorobowego
                Console.Write("Podaj datę zakończenia chorobowego (format: RRRR-MM-DD): ");
                DateTime sickLeaveEndDate = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString());

                // Tworzenie nowego zwolnienia lekarskiego
                SickLeave__Zwolnienie_lekarskie_ zwolnienie = new SickLeave__Zwolnienie_lekarskie_(sickLeaveStartDate, sickLeaveEndDate);

                // Pytanie o zmianę pracownika
                Console.Write("Podaj zmianę pracownika: ");
                string shift = Console.ReadLine() ?? "";

                // Dodawanie pracownika do listy
                employees.Add(pracownik);

                // Wyświetlanie informacji o pracowniku, chorobowym i zmianie
                Console.WriteLine($"Imię: {pracownik.FirstName}");
                Console.WriteLine($"Nazwisko: {pracownik.LastName}");
                Console.WriteLine($"Adres e-mail: {pracownik.EmailAddress}");
                Console.WriteLine($"Data rozpoczęcia chorobowego: {zwolnienie.StartDate.ToShortDateString()}");
                Console.WriteLine($"Data zakończenia chorobowego: {zwolnienie.EndDate.ToShortDateString()}");
                Console.WriteLine($"Zmiana: {shift}");
                Console.WriteLine();
            }

            // Czekanie na naciśnięcie klawisza, aby okno konsoli nie zamknęło się natychmiast
            Console.ReadKey();
        }
    }
}
