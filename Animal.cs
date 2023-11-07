using System;
namespace InheritenceBasics
{
    // Defining a base class 'Animal'
    public class Animal
    {
        // Common properties of all animals 
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Diet { get; set; }
        public int WeightKg { get; set; }
        public bool IsWild { get; set; }

        // Creating constructor to create new animals
        public Animal(string name, String gender, string color, int age, string diet, int weightkg, bool isWild)
        {
            Name = name;
            Gender = gender;
            Color = color;
            Age = age;
            Diet = diet;
            WeightKg = weightkg;
            IsWild = isWild;

        }

        // Common method for all animals to make a sound
        public void MakeSound()
        {
            Console.WriteLine("The " + Name + " makes a sound.");
        }

        // Common method for all animals to make a move
        public void Move()
        {
            Console.WriteLine("The " + Name + " is moving.");
        }

        // Common method for all animals to eat
        public void Eat()
        {
            Console.WriteLine("The " + Name + " is eating.");
        }

        // Common method for all animals to play
        public void Play()
        {
            Console.WriteLine("The " + Name + " is playing.");
        }

        // Common method for all animals to sleep
        public void Sleep()
        {
            Console.WriteLine("The " + Name + " is sleeping.");
        }
    }
}

