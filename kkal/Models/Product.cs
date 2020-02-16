using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkal
{
    class Product
    {
        RecipeDAY day = new RecipeDAY();
        private string Name;
        public string name { get { return Name; } }
        private string Type;
        public string type { get { return Type; } }
        private int Kkal;
        public int kkal { get { return Kkal; } }
        private int Mass;
        public int mass { get { return Mass; } }
        private int Protein;
        public int protein { get { return Protein; } }
        private int Fat;
        public int fat { get { return Fat; } }
        private int Carbohydrate;
        public int carbohydrate { get { return Carbohydrate; } }
        private int Vitamin;
        public int vitamin { get { return Vitamin; } }
        private int Mineral;
        public int mineral { get { return Mineral; } }


        public Product()
        { }

        public Product(string name, string type, int kkal, int mass,
                       int protein, int fat, int carbohydrate, int vitamin, int mineral)
        {
            Name = name;
            Type = type;
            Kkal = kkal;
            Mass = mass;
            Protein = protein;
            Fat = fat;
            Carbohydrate = carbohydrate;
            Vitamin = vitamin;
            Mineral = mineral;
        }

        public Product(int kkal, int mass)
        {
            this.Kkal = kkal;
            this.Mass = mass;
        }

        private void ingredient(object sender, EventArgs e)
        {
            day.AllIngredient.Add(new Product("popato", "plant", 120, 0, 0, 0, 0, 0, 0));
            day.AllIngredient.Add(new Product("meat", "animal", 250, 0, 0, 0, 0, 0, 0));
            day.AllIngredient.Add(new Product("apple", "plant", 10, 0, 0, 0, 0, 0, 0));
            day.AllIngredient.Add(new Product("fish", "animal", 55, 0, 0, 0, 0, 0, 0));
            day.AllIngredient.Add(new Product("oil", "plant", 99, 0, 0, 0, 0, 0, 0));
            day.AllIngredient.Add(new Product("banana", "plant", 29, 0, 0, 0, 0, 0, 0));

            //List<Product> productR1 = new List<Product>();
            //productR1.Add(new Product("popato", "plant", 120, 200, 9, 5, 40, 23, 36));
            //productR1.Add(new Product("oil", "plant", 99, 10, 1, 87, 15, 34, 35));
            //List<Product> productR2 = new List<Product>();
            //productR2.Add(new Product("meat", "animal", 250, 500, 89, 45, 12, 23, 65));
            //productR2.Add(new Product("oil", "plant", 99, 20, 1, 87, 15, 34, 35));
            //productR2.Add(new Product("apple", "plant", 10, 0, 3, 5, 13, 65, 44));
            //List<Product> productR3 = new List<Product>();
            //productR3.Add(new Product("fish", "animal", 55, 435, 46, 67, 23, 66, 32));
            //productR3.Add(new Product("oil", "plant", 99, 10, 1, 87, 15, 34, 35));
            //productR3.Add(new Product("banana", "plant", 29, 120, 6, 2, 56, 88, 45));

            //dAY.AllRecipes.Add(new Recipe() { NameR = "Potato", products = productR1 });
            //dAY.AllRecipes.Add(new Recipe() { NameR = "Meat", products = productR2 });
            //dAY.AllRecipes.Add(new Recipe() { NameR = "Salate", products = productR3 });

        }




    }
}
