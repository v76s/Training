using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    /// <summary>
    /// Simple demonstation of an abstract class definition.
    /// An abstract class can not be directly instantiated, must be inherited 
    /// An abstract class can contain non-abstract and abstract methods inside of it. 
    /// An abstract method definition in an abstract class doesn't have an implementation in it. 
    /// If a method is defined as abstract it should be overridden in the inherited class
    /// just like a virtual method in a base class in an inheriting class.
    /// </summary>
    abstract class AbstractAnimal
    {
        // Abstract method (no implementation here)
        protected abstract void MakeSound();

        // Non-abstract method
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    class AbstractDog : AbstractAnimal
    {
        // Providing implementation for the abstract method
        protected override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    class AbstractCat : AbstractAnimal
    {
        // Providing implementation for the abstract method
        protected override void MakeSound()
        {
            Console.WriteLine("Meow!");        
        }
        

    }     
}
