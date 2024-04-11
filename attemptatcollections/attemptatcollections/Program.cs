using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attemptatcollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentList = new ArrayList();

            studentList.Add(new Student("jackie", 21));
            studentList.Add(new Student("john", 30));
            studentList.Add(new Student("jamie", 22));

            Console.WriteLine("Student List:");

            foreach (var student in studentList)
            {
                Console.WriteLine(student);

            }

            Console.WriteLine(" Change in the Student List:");


            ((Student)studentList[1]).Age = 31;
            ((Student)studentList[2]).Age = 30;

            studentList.Add(new Student("Danny", 23));
            studentList.Add(new Student("Sarah", 29));


            foreach (var student in studentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
