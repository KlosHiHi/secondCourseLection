using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.persons
{
    public class person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Age}, {Address}"; //Интерполяция
        }
    }

    public enum OrderStatus
    {
        Ordered = 0b_0000_0000,
        InTheWay = 0b_0000_0001,
        Delivered = 0b_0000_0010
    }
}
