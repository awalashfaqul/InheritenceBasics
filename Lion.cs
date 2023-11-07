using System;
namespace InheritenceBasics
{
    class Lion : Animal
    {
        // New property specific to lions
        public bool Mane { get; set; }
        public string ManeColor { get; set; }

        // Constructor for creating lions
        public Lion(string name, string gender, string color, int age, string diet, int weightkg, bool mane, string maneColor, bool isWild)
            : base(name, gender, color, age, diet, weightkg, isWild)
        {
            Mane = mane;
            ManeColor = maneColor;
        }

        // New method specific to lions
        public void Roar()
        {
            Console.WriteLine("The Lion roars loudly!");
        }
    }
}

