using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// https://www.tutorialspoint.com/entity_framework/entity_framework_multiple_dbcontext.htm
namespace EF6CodeFirst
{
    /*class Program
    {
        static void Main(string[] args) { }
    }*/

    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int TeacherID { get; set; }
        public int KokkuID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
        public virtual Kokku Kokku { get; set; }
        public virtual Teacher Teacher { get; set; }
    }

    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public class Kokku
    {
        public int KokkuID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }        

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public class MyContext : DbContext
    {
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Kokku> Kokkus { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyContext())
            {
                // Create and save a new Students
                Console.WriteLine("Adding new students");

                var student = new Student
                {
                    FirstMidName = "Moosi",
                    LastName = "Varas",
                    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                };

                context.Students.Add(student);

                var student1 = new Student
                {
                    FirstMidName = "Varga",
                    LastName = "Püüdja",
                    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                };

                context.Students.Add(student1);

                var student2 = new Student
                {
                    FirstMidName = "Mulle",
                    LastName = "Meeldib",
                    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                };

                context.Students.Add(student2);
                context.SaveChanges();

                // Display all Students from the database
                var students = (from s in context.Students
                                orderby s.FirstMidName
                                select s).ToList<Student>();

                Console.WriteLine("Retrieve all Students from the database:");

                foreach (var stdnt in students)
                {
                    string name = stdnt.FirstMidName + " " + stdnt.LastName;
                    Console.WriteLine("ID: {0}, Name: {1}", stdnt.ID, name);
                }

                //Console.WriteLine("Press any key to exit...");
                //Console.ReadKey();
            }

            using (var context = new MyContext())
            {
                // Create and save a new Teacher
                Console.WriteLine("Adding new teacher");

                var teacher = new Teacher
                {
                    Name = "Õpetaja Juuli",
                };

                context.Teachers.Add(teacher);

                var teacher1 = new Teacher
                {
                    Name = "Õpetaja Kalle",
                };

                context.Teachers.Add(teacher1);
                context.SaveChanges();

                // Display all Teachers from the database
                var teachers = (from s in context.Teachers
                                orderby s.Name
                                select s).ToList<Teacher>();
                Console.WriteLine();
                Console.WriteLine("Retrieve all Teatchers from the database:");

                foreach (var tcher in teachers)
                {
                    string name = tcher.Name;
                    Console.WriteLine("TeacherID: {0}, Name: {1}", tcher.TeacherID, name);
                }
            }

            using (var context = new MyContext())
            {
                // Create and save a new Students
                Console.WriteLine("Adding new curse");

                var course = new Course
                {
                    Title = "Matemaatika",
                    Credits = 5,
                };

                context.Courses.Add(course);

                var course1 = new Course
                {
                    Title = "Füüsika",
                    Credits = 4,
                };

                context.Courses.Add(course1);
                context.SaveChanges();

                // Display all Students from the database
                var courses = (from s in context.Courses
                               orderby s.Title
                               select s).ToList<Course>();
                Console.WriteLine();
                Console.WriteLine("Retrieve all Courses from the database:");

                foreach (var crses in courses)
                {
                    string name = crses.Title + " " + crses.Credits;
                    Console.WriteLine("CoureID: {0}, Title: {1}", crses.CourseID, name);
                }

            }

            using (var context = new MyContext())
            {
                // Create and save a new Students
                Console.WriteLine("Adding new curse");

                var kokku = new Kokku
                {
                    Name = "Õpetaja Juuli",
                    Title = "Matemaatika",
                    Credits = 5,
                };

                context.Kokkus.Add(kokku);

                var kokku1 = new Kokku
                {
                    Name = "Õpetaja Kalle",
                    Title = "Füüsika",
                    Credits = 4,
                };

                context.Kokkus.Add(kokku1);
                context.SaveChanges();

                // Display all Students from the database
                var kokkul = (from s in context.Kokkus
                               orderby s.Title
                               select s).ToList<Kokku>();
                Console.WriteLine();
                Console.WriteLine("Retrieve all Kokku from the database:");

                foreach (var kokk in kokkul)
                {
                    string name = kokk.Name + " "+ kokk.Title + " " + kokk.Credits;
                    Console.WriteLine("KokkuID: {0}, {1}", kokk.KokkuID, name);
                }                               

            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
