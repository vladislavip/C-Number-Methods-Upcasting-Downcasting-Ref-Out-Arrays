using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;

namespace Homework_14
{
    internal class Program
    {
        static void Main(string[] args)
        {   


            Student[] studentsArray = new Student[0];

            Console.WriteLine("Enter total student count:");

            Student.studentCount = int.Parse(Console.ReadLine());

            Array.Resize(ref studentsArray, Student.studentCount);



            for (int i = 0; i < studentsArray.Length; i++)

            {

                Student student = new Student();

                Console.WriteLine("Enter students's name: ");
                string studentName  = Console.ReadLine();
                student.studentName = studentName;

                Console.WriteLine($"Enter {student.studentName}'s grade ");
                int studentGrade= int.Parse(Console.ReadLine());
                student.StudentGrade = studentGrade;
                

                studentsArray[i] = student;

               
            }

            Console.Clear();
        

            Menu:

            Console.WriteLine("A.Get Average grade of class");
            Console.WriteLine("B.Get Highest Grade of class");
            Console.WriteLine("C.Get lowest grade of class");
            Console.WriteLine("D.List all students in the class");


            ConsoleKey key = Console.ReadKey().Key;
            switch (key) 
            
            {
                case ConsoleKey.A:

                    StatisticsHelper.GetAverageGrade(studentsArray, Student.studentCount);
                    Console.WriteLine("Press any key to return to menu");
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;

                case ConsoleKey.B:
                    StatisticsHelper.GetHighestGrade(studentsArray);
                    Console.WriteLine("Press any key to return to menu");
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;

                case ConsoleKey.C:
                    StatisticsHelper.GetLowestGrade(studentsArray);
                    Console.WriteLine("Press any key to return to menu");
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;
                case ConsoleKey.D:
                    foreach (Student st in studentsArray)
                    {
                        Console.WriteLine(st);
                    }
                    Console.WriteLine("Press any key to return to menu");
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;

                default:
                     Console.ReadKey();
                    Console.Clear();
                    goto Menu;

            }

        }
    }
}