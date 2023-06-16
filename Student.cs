using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    internal class Student
    {
        

        private int studentGrade;

        public static int studentCount;
        

        public int StudentGrade { 

            get { return studentGrade; }
            set {
                if (value >= 0 && value <= 100)
                { studentGrade = value; 
                
                }

                else
                {
                    throw new Exception();
                }
           }   
        }


        public string studentName { get; set; }


        public override string ToString()
        {
            return $"Student Name: {studentName}, {studentName}'s grade {StudentGrade}, Total Students in the class: {studentCount}";
        }
    }
}
