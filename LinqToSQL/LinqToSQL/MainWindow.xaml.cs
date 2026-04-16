using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinqToSQL
{
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.dreenaDB2ConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversities();
            //InsertStudents();
            //InsertLectures();
            InsertStudentLectureAssociations();
            //GetUniversityOfToni();
            //GetLecturesFromToni();
            //GetAllStudentsFromYale();
            //GetAllUniversitiesWithTransgenders();
            //GetAllLecturesFromBeijingTech();
            // UpdateToni();
            //DeleteJame();
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);

            University mmu = new University();
            mmu.Name = "Multimedia University";
            dataContext.Universities.InsertOnSubmit(mmu);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University mmu = dataContext.Universities.First(un => un.Name.Equals("Multimedia University"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Hada", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Idrees", Gender = "male", UniversityId = mmu.Id });
            students.Add(new Student { Name = "Ireena", Gender = "female", University = mmu});
            students.Add(new Student { Name = "Hamdan", Gender = "male", University = yale });

            dataContext.Students.InsertAllOnSubmit(students);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Physics" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            Student Hada = dataContext.Students.First(st => st.Name.Equals("Hada"));
            Student Idrees = dataContext.Students.First(st => st.Name.Equals("Idrees"));
            Student Ireena = dataContext.Students.First(st => st.Name.Equals("Ireena"));
            Student Hamdan = dataContext.Students.First(st => st.Name.Equals("Hamdan"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("Physics"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Hada, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Hamdan, Lecture = Math });

            StudentLecture slHamdan = new StudentLecture();
            slHamdan.StudentId = Idrees.Id;
            slHamdan.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(slHamdan);

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Ireena, Lecture = History });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityOfHada()
        {
            Student Hada = dataContext.Students.First(st => st.Name.Equals("Hada"));

            University TonisUniversity = Hada.University;

            List<University> universities = new List<University>();
            universities.Add(TonisUniversity);

            MainDataGrid.ItemsSource = universities;

        }

        public void GetLecturesFromHada()
        {
            Student Hada = dataContext.Students.First(st => st.Name.Equals("Hada"));

            var hadaLectures = from sl in Hada.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = hadaLectures;
        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniversitiesWithTransgenders()
        {
            var transgernderUniversities = from student in dataContext.Students
                                           join university in dataContext.Universities
                                           on student.University equals university
                                           where student.Gender == "trans-gender"
                                           select university;

            MainDataGrid.ItemsSource = transgernderUniversities;
        }

        public void GetAllLecturesFromMMU()
        {
            var lecturesFromMultimediaUniversity = from sl in dataContext.StudentLectures
                                          join student in dataContext.Students on sl.StudentId equals student.Id
                                          where student.University.Name == "Multimedia University"
                                          select sl.Lecture;

            MainDataGrid.ItemsSource = lecturesFromMultimediaUniversity;
        }

        public void UpdateHada()
        {
            Student Toni = dataContext.Students.FirstOrDefault(st => st.Name == "Hada");

            Toni.Name = "Hada Amira";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteHamdan()
        {
            Student Hamdan = dataContext.Students.FirstOrDefault(st => st.Name == "Hamdan");
            dataContext.Students.DeleteOnSubmit(Hamdan);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
