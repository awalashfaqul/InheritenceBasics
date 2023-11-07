using System;
namespace InheritenceBasics
{
    // Derived class for Bengal Tiger, inherited from Tiger class
    class BengalTiger : Tiger
    {
        // New property specific to Bengal tigers
        public bool HasBlackStripes { get; set; }

        // Constructor for creating Bengal tigers
        public BengalTiger(string name, String gender, string color, int age, string diet, int weightkg, bool isWild, bool hasStripes, bool hasblackstripes)
            : base(name, gender, color, age, diet, weightkg, isWild, hasStripes)
        {
            HasBlackStripes = hasblackstripes;
        }

        // Overlay method specific to Bengal tigers
        public new void Pounce()
        {
            Console.WriteLine("The Bengal Tiger pounces gracefully with black stripes!");
        }
    }
}

