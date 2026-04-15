using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectsAndQueryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.MaleStudent();
            Console.WriteLine("\n");
            um.FemaleStudent();
            Console.WriteLine("\n");
            um.SortStudentByAge();
            Console.WriteLine("\n");
            um.AllStudentFromBeijingTech();
            Console.WriteLine("\n");
            um.AllStudentFromYale();
            Console.WriteLine("\n");
            um.StudentAndUniversityNameCollection();
            Console.WriteLine("\n");

            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach (int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            foreach (int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Enter the University ID: ");
            string input = Console.ReadLine();
            try
            {
                int inputAsInt = Convert.ToInt32(input);

                um.AllStudentsFromThatUni(inputAsInt);
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong value");
            }

            Console.ReadKey();
        }
    }
}
