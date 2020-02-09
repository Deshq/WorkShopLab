using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_Nikiforov.Classes
{
    class Recipe
    {
        public string Name;
        public List<Item> MaterialsForRecipe = new List<Item>();
        public Recipe()
        { }
        public Recipe(string Name)
        {
            this.Name = Name;
        }
    }
}
