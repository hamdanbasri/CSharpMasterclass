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
                )
            };
            Quiz myQuiz = new Quiz(questions);
            myQuiz.DisplayQuestion(questions[0]);
            Console.ReadLine();
        }
    }
}
