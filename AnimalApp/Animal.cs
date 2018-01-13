using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    abstract class Animal
    {
        private int _weight;
        //property
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public abstract void Eat();
        public void MakeSound()
        {
            Console.WriteLine("Animal makesound ...");
        }
        public Animal()
        {
            Console.WriteLine("Animal base ...");
        }
        public virtual void myMethod()
        {
            Console.WriteLine("Animal mymethod ...");
        }
    }
}
