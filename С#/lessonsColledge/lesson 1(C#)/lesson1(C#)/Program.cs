//Типы данных в C# - 1

//public class Program
//{
//    static void Main(string[] args)
//    {
//        byte b = 155;
//        System.Byte b1 = 155;
//        Преобразование типов
//        int i = b;
//        double d = b1;//неявное приведение
//        int j = (int)d; //явное приведение
//        Преобразование из string в int
//        string s = "5";
//        int k = int.Parse(s);
//        int n;
//        Проверка, возможно ли преобразование
//        int.TryParse(s, out n);

//        int v = Convert.ToInt32(s); //позволяет преобразовывать любые типы данных


//        Особые типы данных:
//        int? val = null; //позволяет хранить null
//        Nullable<System.Int32> vall = null; //тоже самое
//        bool e = val.HasValue;

//        int[] ints = new int[b]; // Любой массив в C# сразу динамический
//        (int, int, double) asd; //Кортеж
//    }
//}

//Структура программы - 2

using System; // Подключение библиотек

namespace ConsoleApp1 
{
    public class Programs //основной класс
    {
        static void Main(string[] args) //точка входа в приложение, статический метод
        {
            System.Drawing.Color color = System.Drawing.Color.Red;

            Console.WriteLine("Hello World"); //с переносом строки
            Console.Write(color.ToArgb()); //без переноса строки

            var str = Console.ReadLine();// считывает линию
            Console.Read(); // считывает только один символ
        }
    }
}