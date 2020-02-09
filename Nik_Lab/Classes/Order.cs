using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_Nikiforov.Classes
{
    class Order : Item
    {
        public static int Total;
        public static string BasketStr;
        public Recipe RecipeLink;

        public static Dictionary<string, int> Basket = new Dictionary<string, int>();

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
