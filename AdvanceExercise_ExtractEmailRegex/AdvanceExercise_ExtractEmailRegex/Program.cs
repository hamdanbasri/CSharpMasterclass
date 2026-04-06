using System.Text.RegularExpressions;

namespace AdvanceExercise_ExtractEmailRegex
{
    public class Exercise
    {

        public void ExtractPatterns(string input)
        {
            // TODO: Implement the method to extract and print email addresses using regex
            //string email_1 = "support@example.com";
            //string email_2 = "sales@example.org";
            string pattern = @"(\w+)\@\w+\.\w+";
            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match match in matchCollection) 
            {
                GroupCollection group = match.Groups;
                Console.WriteLine($"{group[0].Value}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.ExtractPatterns("support@example.com");            
            exercise.ExtractPatterns("sales@example.org");
            Console.ReadKey();
        }
    }
}
