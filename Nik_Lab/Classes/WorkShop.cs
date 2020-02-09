using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_Nikiforov.Classes
{
    class WorkShop
    {
        private static List<Materials> materialsInStorage = new List<Materials>();
        private static List<Recipe> recipes = new List<Recipe>();
        private static List<Order> orders = new List<Order>();

        internal static List<Materials> MaterialsInStorage { get => materialsInStorage; set => materialsInStorage = value; }
        internal static List<Recipe> Recipes { get => recipes; set => recipes = value; }
        internal static List<Order> Orders { get => orders; set => orders = value; }
    }
}
