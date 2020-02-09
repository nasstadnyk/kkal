using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkal
{
    class Recipe : Product
    {
        RecipeDAY dB = new RecipeDAY();
        public string NameR;
       // public string nameR { get { return NameR; } }
        public List<Product> products = new List<Product>();
        //public List<Product> Pr { get { return products; } }

        public Recipe()
        { }

    }
}
