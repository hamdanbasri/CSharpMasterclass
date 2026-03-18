namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of Malaysia?", // QUESTION TEXT
                    new string[] {"Kuala Lumpur", "Johor", "Pahang", "Putrajaya"}, // ANSWER ARRAY
                    0 // CORRECT ANSWER INDEX
                ),
                new Question("What is 2 + 2?", // QUESTION TEXT
                    new string[] {"3", "4", "5", "6"}, // ANSWER ARRAY
                    1 // CORRECT ANSWER INDEX
                ),
                new Question("What is 3 x 3?", // QUESTION TEXT
                    new string[] {"3", "6", "9", "12"}, // ANSWER ARRAY
                    2 // CORRECT ANSWER INDEX
                )
            };
            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
