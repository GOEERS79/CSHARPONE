using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Dog : Animal
    {
        public override void Eat()
        {

        }
        public void MakeSound(int i) { Console.WriteLine("Dog: Sound bark,bark ..."); }
        public Dog()
        {
            //base.MakeSound();
            //base.myMethod();
            
            Console.WriteLine("Dog construct ...");
        }
        public override void MyMethod()
        {
            Console.WriteLine("Dog mymethod ...");
        }
    }
}
