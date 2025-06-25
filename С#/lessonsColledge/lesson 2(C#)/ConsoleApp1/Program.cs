using System;
using ConsoleApp1.persons;
using System.ComponentModel;
using ConsoleApp1.models;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            person person = new person();
            person.Name = "Mike";
            person.Age = 18;
            person.Address = "33 Rozi Shaninoy st.";

            Console.WriteLine(person);

            if (person.Age >= 18)
            {
                Console.WriteLine("\nHe is adult.\n");
            }

            person[] people = new person[]
            {
                person,
                new Student { Name="Ann", Age=16, Address="4 Chinas st.", Grade=3}
            };

            foreach (var p in people) //Перебор значений
            {
                Console.WriteLine(p);
            }

            ISleeper[] sleepes = [
                new Student { Name="Ann", Age=17, Address = "1 Troickiy pr.", Grade=3}
                new Cat {Name = "Barsik"}
                ];

            foreach (ISleeper s in sleepes)
            {
                Console.WriteLine(s);
                s.Sleep();
            }

            List<Student> students = new List<Student>();
            students.Add(new Student { Name="Nickolay", Age=19, Grade=1, Address = "75 Loblove st."});
            students.Add(new Student { Name = "Verohicka", Age = 13, Grade = 0, Address = "104 Qustov st." });
            students.Add(new Student { Name = "Nickolay", Age = 19, Grade = 1, Address = "75 Loblove st." });

            students.RemoveAt(1);
            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
            Console.ReadLine();
        }
    }
}
