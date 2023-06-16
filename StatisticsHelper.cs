using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Homework_14
{
    internal class StatisticsHelper
    {

        public static void GetAverageGrade(Student[] arr,int studentsCount )

        {
            int cumulativeGrade = 0;
          
            foreach (var st in arr)
            {


                cumulativeGrade += st.StudentGrade;
                

            }

           int averageGrade =cumulativeGrade/studentsCount;

            Console.WriteLine($"Class average grade is {averageGrade}");
           



        }


        public static void GetHighestGrade(Student[] arr)

        {

            int maxStudentGrade = 0;
            foreach (var st in arr)
            {  
                
                if (st.StudentGrade >= maxStudentGrade)

                {
                    maxStudentGrade=st.StudentGrade;

                }

            }
            Console.WriteLine($"Max student grade is {maxStudentGrade}");
        }

        public static void  GetLowestGrade(Student [] arr)

        {
            int minStudentGrade = 100;            // we comparing with highest 
            foreach (var st in arr)
            {
                
                if (st.StudentGrade < minStudentGrade)

                {
                    minStudentGrade = st.StudentGrade;

                }

            }
            Console.WriteLine($"Min student grade is {minStudentGrade}");

        }


    }
}
