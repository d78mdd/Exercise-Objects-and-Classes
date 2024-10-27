using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int countOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfStudents; i++)
            {
                string input = Console.ReadLine().Trim();

                string[] tokens = input.Split(' ');

                string firstName = tokens[0];
                string lastName = tokens[1].Trim();
                double grade = double.Parse(tokens[2].Trim());

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);
            }

            //sort
            IEnumerable<Student> sortedStudents = students.OrderByDescending(s => s.Grade);


            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public override String ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }

    }
}
