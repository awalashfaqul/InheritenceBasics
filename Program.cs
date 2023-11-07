using System;

namespace InheritenceBasics;

class Program
{
    public static void Main(string[] args)
    {
        Animal lion = new Lion("Lion", "Male", "Golden", 6, "Meat", 225, true, "Dark Brown", true);
        /*
 
        public Lion(string name, string gender, string color, int age, string diet, int weightkg, bool mane, string maneColor, bool isWild)
            : base(name, gender, color, age, diet, weightkg, isWild)

        name = "Lion",
        gender = "Male",
        color = "Golden",
        age = 6,
        diet = "Meat",
        weightkg = 390,
        mane = true,
        maneColor = "Dark Brown",
        isWild = true
        */
        lion.MakeSound();
        lion.Move();

        Animal tiger = new Tiger("Tiger", "Female", "Yellow", 7, "Meat", 200, true, true);
        /*
        public Tiger(string name, String gender, string color, int age, string diet, int weightkg, bool isWild, bool hasStripes)
            : base(name, gender, color, age, diet, weightkg, isWild)

        name = "Tiger",
        gender = "Female",
        color = "Yellow",
        age = 7,
        diet = "Meat",
        weightkg = 200,
        isWild = true
        hasStripes = true
        */
        tiger.MakeSound();
        tiger.Eat();

        Animal bengalTiger = new BengalTiger("Bengal Tiger", "Male", "Yellow", 6, "Meat", 220, true, true, true);
        /*
        public BengalTiger(string name, String gender, string color, int age, string diet, int weightkg, bool isWild, bool hasStripes, bool hasblackstripes)
            : base(name, gender, color, age, diet, weightkg, isWild, hasStripes)
        
        name = "Bengal Tiger",
        gender = "Male",
        color = "Yellow",
        age = 7,
        diet = "Meat",
        weightkg = 220,
        isWild = true
        hasStripes = true
        hasblackstripes = true
        
        */
        bengalTiger.MakeSound();
        bengalTiger.Play();

        Animal whiteTiger = new WhiteTiger("White Tiger", "Male", "White", 6, "Meat", 250, true, true, true);
        /*
        name = "Bengal Tiger",
        gender = "Male",
        color = "Yellow",
        age = 7,
        diet = "Meat",
        weightkg = 220,
        isWild = true
        hasStripes = true
        hasblackstripes = true
        growfaster = true
        */
        whiteTiger.MakeSound();
        whiteTiger.Sleep();
    }
}

