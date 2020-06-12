using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.NET_FRAMEWORK_COURSE_101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int ticket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            bool candrive = (age >= 15 && dui == "false" && ticket < 3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(candrive);
            Console.ReadLine();
        }
    }
}
