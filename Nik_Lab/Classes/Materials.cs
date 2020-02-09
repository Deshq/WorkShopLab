using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_Nikiforov.Classes
{
    class Materials : Item
    {
        private int price;

        public int Price { get => price; set => price = value; }

        public Materials(string Name, int Quantity, int Price) : base(Name, Quantity)
        {
            this.Price = Price;
        }

        
    }
}
