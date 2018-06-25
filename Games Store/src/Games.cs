using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Store
{
    class Games : Item
    {
        private string publisher;
        private string mediaType;

        public Games(){ }

        public Games(string id, string desc, int stock, double cost, string pub, string media)
        {
            prodId = id;
            description = desc;
            stockQty = stock;
            this.cost = cost;
            publisher = pub;
            mediaType = media;
        }

        public string gsPublisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public string gsMediaType
        {
            get { return mediaType; }
            set { mediaType = value; }
        }
        public override string ToString()
        {
            return "g" + this.gsProdId + "," + this.gsDescription + "," + this.gsStock + "," +
                this.gsCost + "," + this.gsPublisher + "," + this.gsMediaType;
        }
    }
}
