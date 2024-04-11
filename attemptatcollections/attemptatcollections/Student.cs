using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attemptatcollections
{
    internal class Student
    {
        public string Name;
        public int Age;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old";
        }

        
        
        
    }
}
