using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    public class Cat : ISleeper
    {
        public string Name { get; set; }
        public void Sleep()
        {
            Console.WriteLine("Mrrr-mrrr-mrrr...");
        }
        public override string ToString()
        {
            return $"{Name} is a cat";
        }
    }
}
