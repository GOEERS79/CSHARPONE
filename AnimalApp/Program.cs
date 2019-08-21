using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog c = new Dog();
            c.Weight = 30;
            c.Color = "Brown";
            c.MakeSound(1);
            c.MyMethod();
            Console.ReadKey();
        }
    }
}
