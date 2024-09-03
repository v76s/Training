using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    interface LivingThing
    {
        string Name { get; }
        void Breathe();
        void Move();
        public class Animal : LivingThing
        {
            public string Name { get; set; }
            public DateTime DateOfBirth { get; set; }

            public void Breathe()
            {
                Console.WriteLine("Animal breating");
            }

            public void FeedAnimal()
            {

            }

            public void Move()
            {
                Console.WriteLine("Animal Moving");
            }
        }

        public class Dog : Animal
        {
            public string Breed { get; set; }
            public string Intelligence { get; set; }
            public bool IsTrained { get; set; }
        }

        public class Bird
        {
            public Color Color { get; set; }
            public string Type { get; set; }
        }
    }
}
