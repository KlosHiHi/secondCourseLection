using ConsoleApp1.persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    public class Student : person
    {
        public int Grade { get; set; }

        public void Sleep()
        {
            Console.WriteLine("Z-z-z...");
        }

        public override string ToString()
        {
            return base.ToString() + $" {Grade} grade student";
        }
    }
}
