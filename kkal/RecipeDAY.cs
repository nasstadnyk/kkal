using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkal
{
    class RecipeDAY
    {
        private List<Product> allIngredient = new List<Product>();
        public List<Product> AllIngredient { get { return allIngredient; } }
        private List<Recipe> allRecipes = new List<Recipe>();
        public List<Recipe> AllRecipes { get { return allRecipes; } }
        private List<Recipe> chosenRecipe = new List<Recipe>();
        public List<Recipe> ChosenRecipe { get { return chosenRecipe; } }

        public int[] SumCalories()
        {
            int[] suma = new int[2];
            int calories = 0;
            int allcalories = 0;
            

            foreach (Recipe recipe in chosenRecipe)
            {

                foreach (Product products in recipe.products)
                {
                    calories += products.kkal * products.mass / 100;
                    allcalories += calories;
                }

            }

            suma[0] = calories;
            suma[1] = allcalories;

            return suma;
        }


    }
}
