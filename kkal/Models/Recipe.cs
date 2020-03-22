using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace kkal
{
   [DataContract]
    class Recipe : Product
    {
       [DataMember]
        RecipeDAY dB = new RecipeDAY();
        [DataMember]
        public string NameR;
       // public string nameR { get { return NameR; } }
       [DataMember]
        public List<Product> products = new List<Product>();
        //public List<Product> Pr { get { return products; } }

        public Recipe()
        { }

        private void recipe(object sender, EventArgs e)
        {
           
            List<Product> productR1 = new List<Product>();
            productR1.Add(new Product("popato", "plant", 120, 200, 9, 5, 40, 23, 36));
            productR1.Add(new Product("oil", "plant", 99, 10, 1, 87, 15, 34, 35));
            List<Product> productR2 = new List<Product>();
            productR2.Add(new Product("meat", "animal", 250, 500, 89, 45, 12, 23, 65));
            productR2.Add(new Product("oil", "plant", 99, 20, 1, 87, 15, 34, 35));
            productR2.Add(new Product("apple", "plant", 10, 0, 3, 5, 13, 65, 44));
            List<Product> productR3 = new List<Product>();
            productR3.Add(new Product("fish", "animal", 55, 435, 46, 67, 23, 66, 32));
            productR3.Add(new Product("oil", "plant", 99, 10, 1, 87, 15, 34, 35));
            productR3.Add(new Product("banana", "plant", 29, 120, 6, 2, 56, 88, 45));

            dB.AllRecipes.Add(new Recipe() { NameR = "Potato", products = productR1 });
            dB.AllRecipes.Add(new Recipe() { NameR = "Meat", products = productR2 });
            dB.AllRecipes.Add(new Recipe() { NameR = "Salate", products = productR3 });


        }

    }
}
