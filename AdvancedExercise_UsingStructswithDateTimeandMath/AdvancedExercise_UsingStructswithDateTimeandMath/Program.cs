using System;
using System.Security.Cryptography.X509Certificates;

namespace AdvancedExercise_UsingStructswithDateTimeandMath
{
    public struct Event
    {
        // TODO: Add your code here
        public DateTime StartDate;
        public DateTime EndDate;

        public double GetDuration()
        {
            double daysPassed;
            TimeSpan numberOfDays = StartDate.Subtract(EndDate);
            Math.Abs(-25);
            daysPassed = Math.Abs(numberOfDays.Days);

            return daysPassed;
        }

        public bool IsOverlapping(Event otherEvent)
        {
            return this.StartDate < otherEvent.EndDate && otherEvent.StartDate < this.EndDate;
        }
    }
    

    public class Exercise
    {
        public void TestEvents()
        {
            // TODO: Add your code here
            Event event1 = new Event();
            event1.StartDate = new DateTime(2024,07,01);
            event1.EndDate = new DateTime(2024, 07, 10);
            Console.WriteLine($"Event 1 Duration: {event1.GetDuration()}"); 

            Event event2 = new Event();
            event2.StartDate = new DateTime(2024, 07, 05);
            event2.EndDate = new DateTime(2024, 07, 15);
            Console.WriteLine($"Event 2 Duration: {event2.GetDuration()}");

            bool overlap = event1.IsOverlapping(event2);
            Console.WriteLine($"Events Overlap: {overlap}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.TestEvents();
            Console.ReadKey();
        }
    }
}
