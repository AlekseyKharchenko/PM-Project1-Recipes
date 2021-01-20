using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1
{
    public class Ingredient
    {
        public string Name { get; set; }
        public Points MeasuringP { get; set; }
        public float Amount { get; set; }

        public Ingredient(string name, Points mPoints, float amount = 1.0f)
        {
            Name = name;
            MeasuringP = mPoints;
            if (amount > 0)
            {
                Amount = amount;
            }
        }

        public void DisplayIngredient()
        {
            Console.WriteLine(String.Format(" - {0} {1} {2}", Name, Amount, MeasuringP));
        }
    }

    public enum Points
    {
        pieces,
        cups,
        glasses,
        ml,
        g,
        tbsp,
        tsp
    }
}
