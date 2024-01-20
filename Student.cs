using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Class_Mathods
{
    internal class Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aWeight, string aName, int aAge)
        {
            this.weight = aWeight;
            this.name = aName;
            this.age = aAge;
        }
        //you can now test the obesity of your student
        public bool IsObese()
        {
            if (weight > 60)
            {
                return true;
            }
            else return false;
        }
    }
}
