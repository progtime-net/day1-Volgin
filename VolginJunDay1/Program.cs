using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolginJunDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("How old are you?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"ten years later you will {a + 10} years");
            Console.ReadLine();
        }
    }
}
