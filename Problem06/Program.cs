using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Task
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Marks { get; set; }

        public Student(string firstName, string lastName, params int[] marks)
        {
            FirstName = firstName;
            LastName = lastName;
            Marks = marks.ToList();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Ahmed", "Hassan", 6, 6, 6, 5),
                new Student("Omar", "Mahmoud", 3, 4, 5, 6),
                new Student("Mohamed", "Ali", 4, 2, 3, 4),
                new Student("Fatma", "Ibrahim", 5, 6, 5, 5),
                new Student("Yasmin", "Abdel-Rahman", 5, 3, 4, 2)
            };

            /*
             * PROBLEM 6: Weak Students
             * 
             * Task: Extract students with at least 2 marks under or equal to "3". Use LINQ.
             * 
             * Expected Output:
             * Mohamed Ali
             * Yasmin Abdel-Rahman
             */

            // ============================================
            var students2 = students.Where(s => s.Marks.Contains(3) && s.Marks.Contains(2));

            foreach (Student student in students2)
            {
                Console.WriteLine(student);
            }
            // ============================================

        }
    }
}