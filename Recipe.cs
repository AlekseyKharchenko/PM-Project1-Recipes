using System;
using System.Collections.Generic;
using System.Text;

namespace Project_1
{
    class Recipe
    {
        public string Name { get; private set; }
        public class NutritionFacts
        {
            public float Calories { get; set; }
            public float Protein { get; set; }
            public float Fat { get; set; }
            public float Carbohydrates { get; set; }

            public NutritionFacts(float calories, float protein, float fat, float carbs)
            {
                if(calories > 0) { Calories = calories; }
                else {  Calories = 100; }

                if(protein >= 0 && protein < 100) { Protein = protein; }
                else { Protein = 0; }

                if(fat >= 0 && fat < 100) { Fat = fat; }
                else { Fat = 0; }

                if(carbs >= 0 && carbs < 100) { Carbohydrates = carbs; }
                else { Carbohydrates = 0; }
            }
        }

        List<Ingredient> ingredients = new List<Ingredient>();
        public List<Ingredient> Ingredients 
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        public NutritionFacts Nutrition { get; set; }

        public Recipe(string name, List<Ingredient> ingredients, 
            int calories, float protein, float fat, float carbs)
        {
            Name = name;
            this.ingredients = ingredients;
            Nutrition = new NutritionFacts(calories, protein, fat, carbs);
        }

        public void DisplayRecipe()
        {
            Console.WriteLine(String.Format("\t{0}", Name.ToUpper()));
            Console.WriteLine(" Ingrediedients");
            foreach(Ingredient i in ingredients)
            {
                i.DisplayIngredient();
            }
            Console.WriteLine(" Nutrition Facts");
            Console.WriteLine("   Protein " + Nutrition.Protein);
            Console.WriteLine("   Fat " + Nutrition.Fat);
            Console.WriteLine("   Carbohydrates " + Nutrition.Carbohydrates);
            Console.WriteLine("---------------------------");
            Console.WriteLine(" Total calories " + Nutrition.Calories);
            Console.WriteLine();
            Console.WriteLine();
        }
        public bool ContainsIngredient(string name)
        {
            name = name.ToLower();
            foreach(Ingredient i in ingredients)
            {
                if(i.Name.ToLower().Contains(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
