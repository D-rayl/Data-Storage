using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Store
{
    class Transactions
    {
        public static List<Transactions> trans = new List<Transactions>();

        private string custId;
        private string prodId;
        private int quantity;
        private double costRetail;
        private double costWholesale;
        private string date;

        public Transactions()
        {
            trans.Add(this);
        }

        public Transactions(string custId, string prodId, int qty, double costR, double costW, string date)
        {
            this.custId = custId;
            this.prodId = prodId;
            quantity = qty;
            costRetail = costR;
            costWholesale = costW;
            this.date = date;
            trans.Add(this);
        }
        public string gsCustId
        {
            get { return custId; }
            set { custId = value; }
        }
        public string gsProdId
        {
            get { return prodId; }
            set { prodId = value; }
        }
        public int gsQyt
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double gsRetailPrice
        {
            get { return costRetail; }
            set { costRetail = value; }
        }
        public double gsWholesalePrice
        {
            get { return costWholesale; }
            set { costWholesale = value; }
        }
        public string gsDate
        {
            get { return date; }
            set { date = value; }
        }
        public override string ToString()
        {
            return custId + ", " + prodId + ", " + quantity.ToString() + ", "
                + costRetail.ToString() + ", " + costWholesale.ToString() + ", " + date;
        }
        
    }
    
}
