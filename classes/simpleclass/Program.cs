using System;

namespace DogApp
{
    /// <summary>
    /// Represents a Dog with a name and age, capable of barking.
    /// </summary>
    public class Dog
    {
        /// <summary>
        /// Gets or sets the name of the dog.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the age of the dog.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dog"/> class with the specified name and age.
        /// </summary>
        /// <param name="name">The name of the dog.</param>
        /// <param name="age">The age of the dog.</param>
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /// <summary>
        /// Makes the dog bark by printing a message to the console.
        /// </summary>
        public void Bark()
        {
            Console.WriteLine($"{Name} says Woof!");
        }
    }

    /// <summary>
    /// The entry point of the program.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new Dog instance
            Dog myDog = new Dog("Buddy", 3);

            // Make the dog bark
            myDog.Bark();
        }
    }
}
