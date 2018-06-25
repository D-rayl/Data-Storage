using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Store
{
    class Platform : Item
    {
        private string modelNum;

        public Platform() { }

        public Platform(string id, string desc, int stock, double cost, string model)
        {
            prodId = id;
            description = desc;
            stockQty = stock;
            this.cost = cost;
            modelNum = model;
        }

        public string gsModel
        {
            get { return modelNum; }
            set { modelNum = value; }
        }
        public override string ToString()
        {
            return "p" + this.gsProdId + "," + this.gsDescription + "," + this.gsStock + ","
                + this.gsCost + "," + this.gsModel;
        }
    } 
}
