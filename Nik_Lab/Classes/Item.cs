using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_Nikiforov.Classes
{
    class Item
    {
        public string Name;
        public int Quantity;
        public Item()
        { }
        public Item(string Name, int Quantity)
        {
            this.Name = Name;
            this.Quantity = Quantity;
        }
    }
}
