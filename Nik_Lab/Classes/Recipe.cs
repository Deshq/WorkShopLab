using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_Nikiforov.Classes
{
    class Recipe
    {
        private string name;
        private List<Item> materialsForRecipe = new List<Item>();

        public string Name { get => name; set => name = value; }
        internal List<Item> MaterialsForRecipe { get => materialsForRecipe; set => materialsForRecipe = value; }

        public Recipe()
        { }
        public Recipe(string Name)
        {
            this.Name = Name;
        }
    }
}
