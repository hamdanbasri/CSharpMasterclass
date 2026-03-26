namespace AdvancedExercise_AdvancedDictionary
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Grade { get; set; }

        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var item = new Dictionary<string, Student>();

            item.Add("student_1", new Student(1, "John", 85));
            item.Add("student_2", new Student(2, "Alice", 90));
            item.Add("student_3", new Student(3, "Bob", 78));

            foreach (var student in item) {
                Console.WriteLine($"Name: {student.Value.Name}, Id: {student.Value.Id}, Grade: {student.Value.Grade}");
            }

            Console.ReadKey();
        }
    }
}
