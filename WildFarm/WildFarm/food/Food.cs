using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.food
{
    public abstract class Food : IFood
    {

        protected Food(int qty)
        {
            Qty = qty;
        }
        public int Qty { get; set; }
    }
}
