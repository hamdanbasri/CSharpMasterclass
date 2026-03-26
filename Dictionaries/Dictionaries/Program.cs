namespace Dictionaries
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example of Complex Object based on the class above.
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John Doe", 35, 50000));
            employees.Add(2, new Employee("Jane Doe", 25, 45000));
            employees.Add(3, new Employee("Black Doe", 15, 90000));
            employees.Add(4, new Employee("White Doe", 75, 700000));

            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} Name: {item.Value.Name} " +
                    $"Age: {item.Value.Age} " +
                    $"Salary: {item.Value.Salary}");
            }

            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["MY"] = "Malaysia",
                ["TX"] = "Texas"
            };

            if(codes.TryGetValue("NY", out string state)){
                Console.WriteLine(state);
            }

            foreach (var item in codes) {
                Console.WriteLine($"The statecode is {item.Key} " +
                    $"and the state name is {item.Value}");
            }

            // key value pair
            // Declaring and initializing a dictionary
            //Dictionary<int, string> employees = new Dictionary<int, string>();

            //// Adding Items to a Dictionary
            //employees.Add(101, "John Doe");
            //employees.Add(102, "Paul Smith");
            //employees.Add(103, "John Smith");
            //employees.Add(104, "Bob Smith");
            //employees.Add(105, "Syl Smith");

            //// Access Items in a Dictionary
            //string name = employees[101];
            //Console.WriteLine(name);

            //// Update Value in Dictionary
            //employees[102] = "Jane Smith";

            //// Remove an Item from a Dictionary
            //employees.Remove(101);

            //if(!employees.ContainsKey(104))
            //{
            //    employees.Add(104, "Mike Jike");
            //}

            //bool added = employees.TryAdd(102, "Max Verstappen");

            //if(!added)
            //{
            //    Console.WriteLine("Employee ID 102 already exist");
            //}

            //int counter = 101;

            //while (employees.ContainsKey(counter))
            //{
            //    counter++;
            //}
            //employees.Add(counter, "Hesham");

            //foreach(KeyValuePair<int, string> employee in employees)
            //{
            //    Console.WriteLine($"ID: {employee.Key} Name: {employee.Value}");
            //}


            Console.ReadKey();
        }
    }
}
