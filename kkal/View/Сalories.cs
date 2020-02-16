using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kkal
{
    public partial class Form1 : Form
    {
        RecipeDAY dAY = new RecipeDAY();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // dAY.AllIngredient.Add(new Product("popato", "plant", 120, 0, 0, 0, 0, 0, 0));
            //dAY.AllIngredient.Add(new Product("meat", "animal", 250, 0, 0, 0, 0, 0, 0));
            //dAY.AllIngredient.Add(new Product("apple", "plant", 10, 0, 0, 0, 0, 0, 0));
            //dAY.AllIngredient.Add(new Product("fish", "animal", 55, 0, 0, 0, 0, 0, 0));
            //dAY.AllIngredient.Add(new Product("oil", "plant", 99, 0, 0, 0, 0, 0, 0));
            //dAY.AllIngredient.Add(new Product("banana", "plant", 29, 0, 0, 0, 0, 0, 0));

            //List<Product> productR1 = new List<Product>();
            //productR1.Add(new Product("popato", "plant", 120, 200, 9, 5, 40, 23, 36));
            //productR1.Add(new Product("oil", "plant", 99, 10, 1, 87, 15, 34, 35));
            //List<Product> productR2 = new List<Product>();
            //productR2.Add(new Product("meat", "animal", 250, 500, 89, 45, 12, 23, 65));
            //productR2.Add(new Product("oil", "plant", 99, 20, 1, 87, 15, 34, 35));
            //productR2.Add(new Product("apple", "plant", 10, 0, 3, 5, 13, 65, 44));
            List<Product> productR3 = new List<Product>();
            productR3.Add(new Product("fish", "animal", 55, 435, 46, 67, 23, 66, 32));
            productR3.Add(new Product("oil", "plant", 99, 10, 1, 87, 15, 34, 35));
            productR3.Add(new Product("banana", "plant", 29, 120, 6, 2, 56, 88, 45));

            dAY.AllRecipes.Add(new Recipe() { NameR = "Potato", products = productR1 });
            dAY.AllRecipes.Add(new Recipe() { NameR = "Meat", products = productR2 });
            dAY.AllRecipes.Add(new Recipe() { NameR = "Salate", products = productR3 });


            foreach (Recipe recipe in dAY.AllRecipes)
            {
                CbRecipe.Items.Add(recipe.NameR);
            }


        }

        private void CbRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = CbRecipe.SelectedItem.ToString();
            LbChosenRecipe.Items.Add("Обрано:");
            LbChosenRecipe.Items.Add(selectedState);
            //db.ChosenRecipe.Add(selectedState);
        }

        private void BtKkal_Click(object sender, EventArgs e)
        {
            LbSumCal.Items.Clear();

            foreach (Recipe recipe in dAY.AllRecipes)
            {
                if (recipe.NameR == CbRecipe.Text)
                {
                    dAY.ChosenRecipe.Add(recipe);
                }
            }

            int[] suma = new int[2];
            suma = dAY.SumCalories();
            LbSumCal.Items.Add("Калорійність обраних страв");
            // LbSumCal.Items.Add("Калорійність страви" + suma[0]);
            LbSumCal.Items.Add("Загальна калорійність" + suma[1]);
            LbSumCal.Items.Add("Загальна к-ть білків" + suma[3]);
            LbSumCal.Items.Add("Загальна к-ть жирів" + suma[5]);
            LbSumCal.Items.Add("Загальна к-ть вуглеводів" + suma[7]);
            LbSumCal.Items.Add("Загальна к-ть вітамінв" + suma[9]);
            LbSumCal.Items.Add("Загальна к-ть мінералів" + suma[11]);


        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            LbChosenRecipe.Items.Clear();
            LbSumCal.Items.Clear();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
