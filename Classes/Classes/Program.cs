using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            Person person1;
            person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2;
            person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3;
            person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4;
            person4 = new Person(4, "mary", "Meals", "yellow", 28, true);

            Console.WriteLine(person2.DisplayPersonInfo);
            Console.WriteLine(person3.ToString);
            Console.WriteLine(person1.ChangeFavoriteColor);
            Console.WriteLine(person1.DisplayPersonInfo);
            Console.WriteLine(person4.GetAgeInTenYears);

        }
    }
}