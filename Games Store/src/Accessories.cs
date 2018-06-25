using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Store
{
    class Accessories : Item
    {
        private string platform;

        public Accessories() { }

        public Accessories(string id, string desc, int stock, double cost, string platform)
        {
            prodId = id;
            description = desc;
            stockQty = stock;
            this.cost = cost;
            this.platform = platform;
        }

        public string gsPlatform
        {
            get { return platform; }
            set { platform = value; }
        }
        public override string ToString()
        {
            return "a" + this.gsProdId + "," + this.gsDescription + "," + this.gsStock +
                "," + gsCost + "," + this.gsPlatform;
        }
    }
}
