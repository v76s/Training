using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Complete_cSharp
{
    /// <summary>
    /// The purpose of the encapsulation class is to demonstrate the
    /// public - private - protected and internal access modifiers
    /// </summary>
    public class EncapsulationAnimals
    {        
        public EncapsulationAnimals()
        {
            Console.WriteLine("EncapsulationAnimals constructor implemented ...");
        }

        private string? privateVariable;
        public string? publicVariable;
        protected string? protectedVariable;
        internal string? internalVariable;

        private void TrainPrivate() {; }

        public void TrainPublic() {; }

        protected void TrainProtected() {; }   

        internal void TrainInternal() {; }
    } 

    class EncapsulationDogs : EncapsulationAnimals
    {
        public EncapsulationDogs() {; }
        EncapsulationDogs dogs = new EncapsulationDogs();   
        void FeedDogs()
        {
            // Try to call all other methods and variables to see
            dogs.TrainInternal();
            Console.WriteLine("TrainInternal executed"); 
        }
    }

    class EncapsulationCats : EncapsulationAnimals
    {
        public EncapsulationCats() {
            Console.WriteLine();             
        }
        EncapsulationAnimals animals = new EncapsulationAnimals();
        void FeedAnimals()
        {
            // Public and Internal variables are accessible due to 
            // encapsulation 

            // animals.publicVariable;
        }
    }
}
