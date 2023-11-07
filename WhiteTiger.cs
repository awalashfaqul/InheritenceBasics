using System;
namespace InheritenceBasics
{
    // Derived class for White Tiger, inherited from tiger
    class WhiteTiger : Tiger
    {
        // New property specific to White tigers
        public bool GrowFaster { get; set; }

        // Constructor for creating White tigers
        public WhiteTiger(string name, String gender, string color, int age, string diet, int weightkg, bool isWild, bool hasStripes, bool growfaster)
            : base(name, gender, color, age, diet, weightkg, isWild, hasStripes)
        {
            GrowFaster = growfaster;
        }

        // Overlay method specific to White tigers
        public new void Pounce()
        {
            Console.WriteLine("The White Tiger pounces gracefully with a stunning white coat!");
        }
    }
}

