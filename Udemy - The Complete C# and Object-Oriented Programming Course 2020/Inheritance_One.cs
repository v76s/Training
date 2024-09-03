using System.Drawing;


/// <summary>
/// Represents a living thing with a name and the ability to breathe and move.
/// </summary>
interface LivingThing
{
    /// <summary>
    /// Gets or sets the name of the living thing.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Breathes, which is a fundamental activity of living things.
    /// </summary>
    void Breathe();

    /// <summary>
    /// Moves, which is another fundamental activity of living things.
    /// </summary>
    void Move();

    /// <summary>
    /// Represents an animal that is a living thing.
    /// </summary>
    public class Animal : LivingThing
    {
        /// <summary>
        /// Gets or sets the name of the animal.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the animal.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Breathes, which is a fundamental activity of living things.
        /// </summary>
        public void Breathe()
        {
            Console.WriteLine("Animal breating");
        }

        /// <summary>
        /// Feeds the animal, which is an important activity for living things.
        /// </summary>
        public void FeedAnimal()
        {

        }

        /// <summary>
        /// Moves, which is another fundamental activity of living things.
        /// </summary>
        public void Move()
        {
            Console.WriteLine("Animal Moving");
        }
    }

    /// <summary>
    /// Represents a dog that is an animal.
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Gets or sets the breed of the dog.
        /// </summary>
        public string? Breed { get; set; }

        /// <summary>
        /// Gets or sets the intelligence of the dog.
        /// </summary>
        public string? Intelligence { get; set; }

        /// <summary>
        /// Gets or sets whether the dog is trained.
        /// </summary>
        public bool IsTrained { get; set; }
    }

    /// <summary>
    /// Represents a bird that is an animal.
    /// </summary>
    public class Bird : Animal
    {
        /// <summary>
        /// Gets or sets the color of the bird.
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets the type of the bird.
        /// </summary>
        public string Type { get; set; }
    }
}