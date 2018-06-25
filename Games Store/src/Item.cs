using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Store
{
    class Item
    {
        public static List<Item> items = new List<Item>();

        protected string prodId;
        protected string description;
        protected int stockQty;
        protected double cost;

        public Item()
        {
            items.Add(this);
        }
 
        public string gsProdId
        {
            get { return prodId; }
            set { prodId = value; }
        }
        public string gsDescription
        {
            get { return description; }
            set { description = value; }
        }
        public int gsStock
        {
            get { return stockQty; }
            set { stockQty = value; }
        }
        public double gsCost
        {
            get { return cost; }
            set { cost = value; }
        }
        public static List<Item> getList
        {
            get { return items; }
        }
    }
}
