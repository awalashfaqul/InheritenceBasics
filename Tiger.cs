using System;
namespace InheritenceBasics
{
    class Tiger : Animal
    {
        // New property specific to tigers
        public bool HasStripes { get; set; }

        // Constructor for creating tigers
        public Tiger(string name, String gender, string color, int age, string diet, int weightkg, bool isWild, bool hasStripes)
            : base(name, gender, color, age, diet, weightkg, isWild)
        {
            HasStripes = hasStripes;
        }

        // New method specific to tigers
        public void Pounce()
        {
            Console.WriteLine("The Tiger pounces with agility!");
        }
    }
}

