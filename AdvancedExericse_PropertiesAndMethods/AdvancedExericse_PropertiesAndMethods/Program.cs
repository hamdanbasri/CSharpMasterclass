using System.Runtime.CompilerServices;

namespace AdvancedExericse_PropertiesAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 30);
            person.Greet();
            Console.ReadKey();
        }

        public class Person
        {
            // TODO
            private string _name;
            private int _age;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public int Age
            {
                get { return _age; }
                set
                {
                    if (value > 0)
                    {
                        _age = value;
                    }
                }
            }

            public Person(string name, int age)
            {
                _name = name;
                Age = age;
            }

            public void Greet()
            {
                Console.WriteLine($"Hello, my name is {_name} and I am {_age} years old.");
            }
        }       
    }
}




    
        

