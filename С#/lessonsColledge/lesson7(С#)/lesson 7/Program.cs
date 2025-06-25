using System.Text;

namespace lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            //Инициализация строки:
            string hello = "Hello, World";
            //            Console.WriteLine(hello);

            //            //Пустая строка задаётся:
            string empty = "";
            string empty2 = String.Empty;

            //            string nullstr = null;

            //            //Конкатенация строк
            //            string s1 = "Hello";
            //            string s2 = "World";
            //            string s3 = s1 + s2;
            //            Console.WriteLine(s3);

            //            //Интерполяция
            //            int age = 21;
            //            string message = $"He is {age} years old";
            //            Console.WriteLine(message);

            //            StringBuilder builder = new StringBuilder();
            //            builder.Append(s1);
            //            builder.Append(s2);
            //            Console.WriteLine(builder.ToString());

            //            //Основые методы работы со строками:
            //            Console.WriteLine(hello[0]); //Обращение к индексу
            //            Console.WriteLine(hello.Length); //Длина строки
            //            Console.WriteLine(message.ToUpper()); //Приведение к верхнему регистру
            //            Console.WriteLine(message.ToLower()); //Приведение к нижнему регистру

            //            string spaces = "     hello      ";
            //            Console.WriteLine(spaces.Trim()); //Обрезание пробела с обоих сторон
            //            Console.WriteLine(spaces.TrimEnd()); //С конца
            //            Console.WriteLine(spaces.TrimStart()); //С начала

            //            //Замена части строки
            //            Console.WriteLine(s3.Replace("l", "3"));
            //            Console.WriteLine(s3.Replace("l", "")); 

            //Сравнение строк
            Console.WriteLine(hello.Contains("e")); //поиск кусочка строки
            Console.WriteLine(hello.Contains("hello", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine(hello.StartsWith("He"));
            Console.WriteLine(hello.EndsWith("orl"));

            Console.WriteLine("Hello".Equals("hello")); //Точное сравнение строк
            Console.WriteLine("Hello".Equals("hello", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine(hello.IndexOf("world", StringComparison.InvariantCultureIgnoreCase)); //Поиск 

            Console.WriteLine("Hello World".Substring(6, 5)); //Вывод под строки длиной 5 символов, начиная с 6

            string text = "яблоко, ананас, апельсин";
            string[] fruits = text.Split(", ");
            foreach (string f in fruits) Console.WriteLine(f);

            string fruit = String.Join("^", fruits);
            Console.WriteLine(fruit);

            if (String.IsNullOrEmpty(empty) || String.IsNullOrWhiteSpace(empty))
            {

            }

            Console.WriteLine(hello.PadLeft(13, 'w'));
            Console.WriteLine(hello.PadRight(20, 'w'));
        }
    }
}