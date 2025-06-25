using System.Text;

namespace workWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = "files\\text1.txt";
            
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory("files");
            }
            
            File.WriteAllText(path, "qwer"); //Запись в файл

            //if (File.Exists(path))
            //{
            //    Console.WriteLine(File.ReadAllText(path)); //Чтение из файла
            //}
            ////Удаление
            //File.Delete(path); 
            //Directory.Delete("files");

            //var files = Directory.GetFiles("C:\\");
            //foreach (var file in files) Console.WriteLine($"{file}");
            

            //Работа с файлами на объектном уровне
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                using (var fs = fileInfo.OpenWrite())
                {
                    var buffer = Encoding.UTF8.GetBytes("qwer");
                    fs.Write(buffer, 0, buffer.Length);
                }
            }

            Console.WriteLine(fileInfo.FullName); //Полное имя
            Console.WriteLine(fileInfo.Length);

            Console.WriteLine(fileInfo.Extension); //расширение

            DirectoryInfo directoryInfo = new DirectoryInfo("files");
            var f = directoryInfo.GetFiles();
            foreach (var file in f)
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}
