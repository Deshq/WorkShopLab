using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_Nikiforov.Classes
{
    class Order : Item
    {
        private static int total;
        private static string basketStr;
        private Recipe recipeLink;
        private static Dictionary<string, int> basket = new Dictionary<string, int>();

        public static int Total { get => total; set => total = value; }
        public static string BasketStr { get => basketStr; set => basketStr = value; }
        internal Recipe RecipeLink { get => recipeLink; set => recipeLink = value; }
        public static Dictionary<string, int> Basket { get => basket; set => basket = value; }

        public Order(string Name, int Quantity, Recipe RecipeLink) : base(Name, Quantity)
        {
            this.Name = Name;
            this.Quantity = Quantity;
            this.RecipeLink = RecipeLink;
        }

        public Order() { }

        public static void GenBasketOfProd(List<Order> Orders)
        {
            foreach (Order o in Orders)
            {
                foreach (Item i in o.RecipeLink.MaterialsForRecipe)
                {
                    if (Basket.ContainsKey(i.Name))
                    {
                        Basket[i.Name] += i.Quantity * o.Quantity;
                    }
                    else
                    {
                        Basket.Add(i.Name, i.Quantity * o.Quantity);
                    }
                }
            }
        }

        public static int CostСalculation(List<Materials> MaterialsInStorage)
        {
            foreach (KeyValuePair<string, int> c in Basket)
            {
                foreach (Materials i in MaterialsInStorage)
                {
                    if (c.Key == i.Name)
                    {
                        Total += i.Price * c.Value;
                    }
                }
            }
            return Total;

        }

        public static string CostСalculation(Dictionary<string, int> Basket)
        {
            foreach (KeyValuePair<string, int> c in Basket)
            {
                BasketStr += (c.Key + " - " + c.Value + "\n");
            }
            return BasketStr;
        }

        public static bool AvailabilityMaterials(List<Materials> MaterialsInStorage)
        {
            foreach (KeyValuePair<string, int> c in Basket)
            {
                foreach (Materials i in MaterialsInStorage)
                {
                    if (c.Key == i.Name)
                    {
                        if (c.Value > i.Quantity)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public static void Clear()
        {
            Basket.Clear();
            Total = 0;
            BasketStr = "";

        }

    }
}
