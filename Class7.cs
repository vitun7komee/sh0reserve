using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        private string fullName;
        private int age;

        public Person()
        {
            fullName = "Unknown";
            age = 0;
        }

        public Person(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }

        public void move()
        {
            Console.WriteLine($"{fullName} is moving.");
        }

        public void talk()
        {
            Console.WriteLine($"{fullName} is talking.");
        }
    }
}
