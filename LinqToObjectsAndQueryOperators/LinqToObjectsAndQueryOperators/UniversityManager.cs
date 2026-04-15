using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectsAndQueryOperators
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //Let's add some Universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            //Let's add some Students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void MaleStudent()
        {
            IEnumerable<Student> malestudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("[----- MALE - STUDENTS -----]");

            foreach (Student student in malestudents) 
            {
                student.Print();
            }
        }

        public void FemaleStudent()
        {
            IEnumerable<Student> femalestudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("[----- FEMALE - STUDENTS -----]");

            foreach (Student student in femalestudents)
            {
                student.Print();
            }
        }

        public void SortStudentByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("[----- STUDENT SORTED BY AGE -----]");

            foreach(Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentFromBeijingTech()
        {
            IEnumerable<Student> beijingStudents = from student in students 
                                               join university in universities on student.UniversityId equals university.Id 
                                               where university.Name == "Beijing Tech" 
                                               select student;

            Console.WriteLine("[----- STUDENT FROM BEIJING TECH -----]");
            foreach(Student student in beijingStudents)
            {
                student.Print();
            }
        }

        public void AllStudentFromYale()
        {
            IEnumerable<Student> yaleStudents = from student in students
                                                   join university in universities on student.UniversityId equals university.Id
                                                   where university.Name == "Yale"
                                                   select student;

            Console.WriteLine("[----- STUDENT FROM YALE -----]");
            foreach (Student student in yaleStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUni(int Id)
        {
            IEnumerable<Student> myStudents = from student in students
                                              join university in universities on student.UniversityId equals university.Id
                                              where university.Id == Id
                                              select student;

            Console.WriteLine("Students from that uni {0}", Id);
            foreach (Student student in myStudents)
            {
                student.Print();
            }

        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniverstityName = university.Name };

            Console.WriteLine("New Collection: ");

            foreach(var col in newCollection)
            {
                Console.WriteLine($"Student {col.StudentName} from University {col.UniverstityName}");
            }
        }
    }
}
