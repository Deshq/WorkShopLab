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

        

    }
}
