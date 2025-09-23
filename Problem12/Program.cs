using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cairoStudents = new List<string>
            {
                "Ahmed Hassan",
                "Fatma Ibrahim",
                "Omar Mahmoud",
                "Yasmin Abdel-Rahman",
                "Mohamed Ali"
            };

            List<string> alexandriaStudents = new List<string>
            {
                "Omar Mahmoud",
                "Nour El-Sayed",
                "Yasmin Abdel-Rahman",
                "Khaled Farouk",
                "Amr Mostafa"
            };

            List<string> gizaStudents = new List<string>
            {
                "Ahmed Hassan",
                "Nour El-Sayed",
                "Abdel-Rahman El-Masry"
            };

            /*
             * PROBLEM 12: Set Operations
             * 
             * Task A: Find students who are in both Cairo and Alexandria (Intersect)
             * Task B: Find all unique students from all cities (Union)
             * Task C: Find students who are in Cairo but not in Alexandria (Except)
             * Task D: Remove duplicate names from Cairo students list (Distinct)
             * 
             * Expected Output:
             * Intersection (Cairo ∩ Alexandria):
             * Omar Mahmoud
             * Yasmin Abdel-Rahman
             * 
             * Union (All unique students):
             * Ahmed Hassan
             * Fatma Ibrahim
             * Omar Mahmoud
             * Yasmin Abdel-Rahman
             * Mohamed Ali
             * Nour El-Sayed
             * Khaled Farouk
             * Amr Mostafa
             * Abdel-Rahman El-Masry
             * 
             * Cairo Except Alexandria:
             * Ahmed Hassan
             * Fatma Ibrahim
             * Mohamed Ali
             */

            // ============================================
            var TaskA = cairoStudents.Intersect(alexandriaStudents);
            foreach (var student in TaskA)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-------TaskB-------");

            var TaskB = cairoStudents.Union(gizaStudents).Union(alexandriaStudents);
            foreach (var student in TaskB) 
            { 
                Console.WriteLine(student);
            }

            Console.WriteLine("-------TaskC-------");

            var TaskC = cairoStudents.Except(alexandriaStudents);
            foreach (var student in TaskC)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-------TaskD-------");

            var TaskD = cairoStudents.Distinct();
            foreach (var student in TaskD)
            {
                Console.WriteLine(student);
            }


            // ============================================

        }
    }
}