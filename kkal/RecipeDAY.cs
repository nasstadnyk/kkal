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
            int[] suma = new int[12];
            int calories = 0;
            int allcalories = 0;
            int proteins = 0;
            int allproteins = 0;
            int fats = 0;
            int allfats = 0;
            int carbohydrates = 0;
            int allcarbohydrates = 0;
            int vitamins = 0;
            int allvitamins = 0;
            int minerals = 0;
            int allminerals = 0;



            

            foreach (Recipe recipe in chosenRecipe)
            {

                foreach (Product products in recipe.products)
                {
                    calories += products.kkal * products.mass / 100;
                    allcalories += calories;
                    proteins += products.protein * products.mass / 100;
                    allproteins += proteins;
                    fats += products.fat * products.mass / 100;
                    allfats += fats;
                    carbohydrates += products.carbohydrate * products.mass / 100;
                    allcarbohydrates += carbohydrates;
                    vitamins += products.vitamin * products.mass / 100;
                    allvitamins += vitamins;
                    minerals += products.mineral * products.mass / 100;
                    allminerals += minerals;


                }

            }

            suma[0] = calories;
            suma[1] = allcalories;
            suma[2] = proteins;
            suma[3] = allproteins;
            suma[4] = fats;
            suma[5] = allfats;
            suma[6] = carbohydrates;
            suma[7] = allcarbohydrates;
            suma[8] = vitamins;
            suma[9] = allvitamins;
            suma[10] = minerals;
            suma[11] = allminerals;

            return suma;
        }


    }
}
