using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkal
{
    class Product
    {
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

    }
}
