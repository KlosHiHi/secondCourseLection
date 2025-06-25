using System;

namespace lesson2
{
    public class Program
    {
        private int _count;
        public int Count 
        { 
            get { return _count; } //Метод доступа, 
            set { _count = value; } 
        }

        public string Name { get; private set; } //Автореализуемое свойство

        public void Run() { Name = "Josh"; }

        static void Main(string[] args)
        { 
            Console.WriteLine("Hello, World!");
            var str = Console.ReadLine();
        }
    }
}
