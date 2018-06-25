using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games_Store
{
    public partial class GameStore : Form
    {
        public GameStore()
        {
            InitializeComponent();
            loadFiles();
        }

        public void loadFiles()
        {
            loadProducts();
            loadCustomers();
            loadTransactions();
            listItems();
            listCustomers();
            listTransactions();
        }

        public void saveCustomers()
        {
            BinaryWriter bw;
            try
            {
                bw = new BinaryWriter(new FileStream("customers.bin", FileMode.Create));
                foreach(Customers c in Customers.customers)
                {
                    try
                    {
                        bw.Write(c.ToString());
                    }
                    catch(Exception fe)
                    {
                        return;
                    }
                }
            }
            catch(Exception fe)
            {
                MessageBox.Show(fe.Message + " Cannot save customers to file");
                return;
            }
            bw.Close();
        }

        public void saveProducts()
        {
            BinaryWriter bw;
            try
            {   
                bw = new BinaryWriter(new FileStream("product.bin", FileMode.Create));
                foreach (Item i in Item.items)
                {
                    try
                    {
                        if (i.GetType() == typeof(Games))
                        {
                            Games g = (Games)i;
                            bw.Write(g.ToString());
                        }
                        else if (i.GetType() == typeof(Platform))
                        {
                            Platform p = (Platform)i;
                            bw.Write(p.ToString());
                        }
                        else
                        {
                            Accessories a = (Accessories)i;
                            bw.Write(a.ToString());
                        }
                    }
                    catch (Exception fe)
                    {
                        return;
                    }
                }
            }
            catch(Exception fe)
            {
                MessageBox.Show(fe.Message + "\n Cannot save products to file");
                return;
            }
            bw.Close();
        }

        public void saveTransactions()
        {
            BinaryWriter bw;
            try
            {
                bw = new BinaryWriter(new FileStream("transactions.bin", FileMode.Create));
                foreach (Transactions t in Transactions.trans)
                {
                    bw.Write(t.ToString());
                }
            }
            catch(Exception fe)
            {
                MessageBox.Show(fe.Message + "\n Cannot write transactions to file");
                return;
            }
            bw.Close();
        }

        public void loadProducts()
        {
            BinaryReader br;

            try
            {
                br = new BinaryReader(new FileStream("product.bin", FileMode.Open));
            }
            catch(Exception fe)
            {
                MessageBox.Show(fe.Message + "\n Cannot open products file");
                return;
            }
            while (true)
            {
                try
                {
                    string item = br.ReadString();
                    if (item[0] == 'g')
                    {
                        itemToList(item, "g");  
                    }
                    else if(item[0] == 'p')
                    {
                        itemToList(item, "p");
                    }
                    else
                    {
                        itemToList(item, "whatever");
                    }
                }
                catch(Exception fe)
                {
                    break;
                }
            }
            br.Close();
        }

        public void loadCustomers()
        {
            string next, id, fam, fir, em, mob;
            int pos;
            BinaryReader br;
            try
            {
                br = new BinaryReader(new FileStream("customers.bin", FileMode.Open));  
            }
            catch(Exception fe)
            {
                MessageBox.Show(fe.Message + "\n Cannot read customers file");
                return;
            }
            while (true)
            {
                try
                {
                    next = br.ReadString();
                    pos = next.IndexOf(',');
                    id = next.Substring(0, pos);
                    next = next.Substring(pos +1);
                    pos = next.IndexOf(',');
                    fam = next.Substring(0, pos);
                    next = next.Substring(pos + 1);
                    pos = next.IndexOf(',');
                    fir = next.Substring(0, pos);
                    next = next.Substring(pos + 1);
                    pos = next.IndexOf(',');
                    em = next.Substring(0, pos);
                    mob = next.Substring(pos + 1);
                    Customers c = new Customers(id, fam, fir, em, mob);
                }
                catch(Exception fe)
                {
                    break;
                }
            }
            br.Close();
        }

        public void loadTransactions()
        {
            string next, id, pid, date;
            int pos, qty;
            double rp, wp;
            BinaryReader br;
            try
            {
                br = new BinaryReader(new FileStream("transactions.bin", FileMode.Open));
            }
            catch(Exception fe)
            {
                MessageBox.Show(fe.Message + "\n Problem loading transactions from file");
                return;
            }
            while (true)
            {
                try
                {
                    next = br.ReadString();
                    pos = next.IndexOf(',');
                    id = next.Substring(0, pos);
                    next = next.Substring(pos + 2);
                    pos = next.IndexOf(',');
                    pid = next.Substring(0, pos);
                    next = next.Substring(pos+1);
                    pos = next.IndexOf(',');
                    qty = int.Parse(next.Substring(0, pos));
                    next = next.Substring(pos+1);
                    pos = next.IndexOf(',');
                    rp = double.Parse(next.Substring(0, pos));
                    next = next.Substring(pos + 1);
                    pos = next.IndexOf(',');
                    wp = double.Parse(next.Substring(0, pos));
                    date = next.Substring(pos+2);
                    Transactions t = new Transactions(id, pid, qty, rp, wp, date);
                }
                catch(Exception fe)
                {
                    break;
                }
            }
            br.Close();
        }

        public void itemToList(string i,string type)
        {
            string next, id, desc, pub, med, mod, pla;
            int pos, sto;
            double co;
            
            pos = i.IndexOf(',');
            id = i.Substring(1, pos-1);
            
            next = i.Substring(pos+1);
            pos = next.IndexOf(',');
            desc = next.Substring(0,pos);
            
            next = next.Substring(pos+1);
            pos = next.IndexOf(',');
            sto = int.Parse(next.Substring(0, pos));
            
            next = next.Substring(pos + 1);
            pos = next.IndexOf(',');
            co = double.Parse(next.Substring(0, pos));

            next = next.Substring(pos + 1);
            pos = next.IndexOf(',');

            if (type == "g")
            {
                pub = next.Substring(0, pos);

                next = next.Substring(pos+1);
                med = next;

                Games ga = new Games(id, desc, sto, co, pub, med);
            }
            else if(type == "p")
            {
                mod = next;

                Platform pl = new Platform(id, desc, sto, co, mod);
            }
            else
            {
                pla = next;
                Accessories ac = new Accessories(id, desc, sto, co, pla);
            }
          
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            string type = prodFieldCheck();
            if(type == "n"){ return; }
            if(type == "pub")
            {
                Games pr = new Games(prodIdBx.Text,descBx.Text,int.Parse(stockQtyBx.Text),
                    double.Parse(retailPriceBx.Text),publisherBx.Text,mediaTypeBx.Text);
            }
            else if(type == "mod")
            {
                Platform mo = new Platform(prodIdBx.Text, descBx.Text, int.Parse(stockQtyBx.Text),
                    double.Parse(retailPriceBx.Text), modelNumBx.Text);
            }
            else
            {
                Accessories pl = new Accessories(prodIdBx.Text, descBx.Text, int.Parse(stockQtyBx.Text),
                    double.Parse(retailPriceBx.Text), platformTypeBx.Text);
            }
            productLbx.Items.Clear();
            listItems();
            clearProdFields();
        }

        public void listItems()
        {
            foreach (Item i in Item.items)
            {
                productLbx.Items.Add(i.gsProdId + ", " + i.gsDescription);
            }
        }

        public void listCustomers()
        {
            foreach(Customers c in Customers.customers)
            {
                custLbx.Items.Add(c.gsCustId);
            }
        }

        public void listTransactions()
        {
            foreach(Transactions t in Transactions.trans)
            {
                transLbx.Items.Add(t);
            }
        }

        public string prodFieldCheck()
        {
            bool pub =true;
            bool mod = true;
            bool plat = true;
            int stock;
            double a;

            if (String.IsNullOrEmpty(prodIdBx.Text))
            {
                MessageBox.Show("Please enter an ID");
                return "n";
            }
            if (String.IsNullOrEmpty(descBx.Text))
            {
                MessageBox.Show("Please enter the descriptition");
                return "n";
            }
            if (!(int.TryParse(stockQtyBx.Text, out stock)) || (int.Parse(stockQtyBx.Text) <= 0))
            {
                MessageBox.Show("Please enter a valid stock quantity");
                return "n";
            }
            if (!(double.TryParse(retailPriceBx.Text, out a)) || (double.Parse(retailPriceBx.Text) <= 0)) 
            {
                MessageBox.Show("Please enter the retail price");
                return "n";
            }
            if (String.IsNullOrEmpty(publisherBx.Text))
            {
                pub = false;  
            }
            if (String.IsNullOrEmpty(modelNumBx.Text))
            {
                mod = false;
            }
            if (String.IsNullOrEmpty(platformTypeBx.Text))
            {
                plat = false;
            }
            if(!pub && !mod && !plat)
            {
                MessageBox.Show("Missing Information");
                return "n";
            }
            if(pub && !(mod || plat))
            {
                return "pub";
            }
            if(mod && !(pub || plat))
            {
                return "mod";
            }
            if(plat && !(mod || pub))
            {
                return "plat";
            }
            if(pub && (mod || plat))
            {
                MessageBox.Show("To many data fields entered");
                return "n";
            }
            if (mod && (pub || plat))
            {
                MessageBox.Show("To many data fields entered");
                return "n";
            }
            if (plat && (pub || mod))
            {
                MessageBox.Show("To many data fields entered");
                return "n";
            }
            return "n";
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Save customer details?", "Viranda Games", MessageBoxButtons.YesNo);
            if(ans == DialogResult.Yes)
            {
                if (custFieldCheck())
                {
                    Customers c = new Customers(custIdBx.Text, famNameBx.Text, firstNameBx.Text,
                        emailBx.Text, mobileBx.Text);
                }
                else
                {
                    MessageBox.Show("Missing information");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Anonymous");
                Customers c = new Customers();
            }
            custLbx.Items.Clear();
            clearCustFields();
            listCustomers();
        }

        public bool custFieldCheck()
        {

            if (String.IsNullOrEmpty(custIdBx.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(famNameBx.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(firstNameBx.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(emailBx.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(mobileBx.Text))
            {
                return false;
            }
            return true;
        }

        private void addTransBtn_Click(object sender, EventArgs e)
        {
            if (transFieldCheck())
            {
                Transactions t = new Transactions(tCustIdBx.Text, tProdIdBx.Text,
                    int.Parse(tQtyBx.Text), double.Parse(tRetailPriceBx.Text),
                    double.Parse(tWholesalePriceBx.Text), tDateBx.Text);
            }
            transLbx.Items.Clear();
            clearTransFields();
            listTransactions();
        }

        public bool transFieldCheck()
        {
            int a;
            double b;
            if (String.IsNullOrEmpty(tCustIdBx.Text))
            {
                MessageBox.Show("Please enter a customer ID");
                return false;
            }
            if (String.IsNullOrEmpty(tProdIdBx.Text))
            {
                MessageBox.Show("Please enter a product ID");
                return false;
            }
            if(!(int.TryParse(tQtyBx.Text, out a)) || (int.Parse(tQtyBx.Text) <= 0))
            {
                MessageBox.Show("Please enter a valid quantity");
                return false;
            }
            if(!(double.TryParse(tRetailPriceBx.Text, out b)) || (double.Parse(tRetailPriceBx.Text) <= 0))
            {
                MessageBox.Show("Please enter a valid retail price");
                return false;
            }
            if(!(double.TryParse(tWholesalePriceBx.Text, out b)) || (double.Parse(tWholesalePriceBx.Text) <= 0))
            {
                MessageBox.Show("Please enter a valid wholesale price");
                return false;
            }
            if (String.IsNullOrEmpty(tDateBx.Text))
            {
                MessageBox.Show("Please enter the date");
                return false;
            }
            return true;
        }

        public void showProductDetails()
        {
            if (productLbx.SelectedIndex == -1)
            {
            }
            else
            {
                string curItem = productLbx.SelectedItem.ToString();
                int indx = productLbx.FindString(curItem);
                prodIdBx.Text = Item.items[indx].gsProdId;
                descBx.Text = Item.items[indx].gsDescription;
                stockQtyBx.Text = Item.items[indx].gsStock.ToString();
                retailPriceBx.Text = Item.items[indx].gsCost.ToString();
                if (Item.items[indx].GetType() == typeof(Games))
                {
                    Games g = (Games)Item.items[indx];
                    publisherBx.Text = g.gsPublisher;
                    mediaTypeBx.Text = g.gsMediaType;
                }
                else if (Item.items[indx].GetType() == typeof(Platform))
                {
                    Platform p = (Platform)Item.items[indx];
                    modelNumBx.Text = p.gsModel;
                }
                else
                {
                    Accessories a = (Accessories)Item.items[indx];
                    platformTypeBx.Text = a.gsPlatform;
                }
            }
        }

        public void showCustDetails()
        {
            if (custLbx.SelectedIndex == -1)
            {

            }
            else
            {
                string curIndx = custLbx.SelectedItem.ToString();
                int indx = custLbx.FindString(curIndx);
                custIdBx.Text = Customers.customers[indx].gsCustId;
                famNameBx.Text = Customers.customers[indx].gsSurname;
                firstNameBx.Text = Customers.customers[indx].gsFirst;
                emailBx.Text = Customers.customers[indx].gsEmail;
                mobileBx.Text = Customers.customers[indx].gsMobile;
            }
        }

        public void showTransDetails()
        {
            string curIndx = transLbx.SelectedItem.ToString();
            int indx = transLbx.FindString(curIndx);
            tCustIdBx.Text = Transactions.trans[indx].gsCustId;
            tProdIdBx.Text = Transactions.trans[indx].gsProdId;
            tQtyBx.Text = Transactions.trans[indx].gsQyt.ToString();
            tRetailPriceBx.Text = Transactions.trans[indx].gsRetailPrice.ToString();
            tWholesalePriceBx.Text = Transactions.trans[indx].gsWholesalePrice.ToString();
            tDateBx.Text = Transactions.trans[indx].gsDate;

            productLbx.SelectedIndex = productLbx.FindString(tProdIdBx.Text);
            custLbx.SelectedIndex = custLbx.FindString(tCustIdBx.Text); 
            showProductDetails();
            showCustDetails();
        }

        private void productLbx_MouseClick(object sender, MouseEventArgs e)
        {
            clearCustFields();
            clearProdFields();
            clearTransFields();
            if(productLbx.SelectedIndex >= 0)
            showProductDetails();
        }

        public void clearCustFields()
        {
            custIdBx.Clear();
            famNameBx.Clear();
            firstNameBx.Clear();
            emailBx.Clear();
            mobileBx.Clear();
        }

        public void clearTransFields()
        {
            tCustIdBx.Clear();
            tProdIdBx.Clear();
            tQtyBx.Clear();
            tRetailPriceBx.Clear();
            tWholesalePriceBx.Clear();
            tDateBx.Clear();
        }

        public void clearProdFields()
        {
            prodIdBx.Clear();
            descBx.Clear();
            stockQtyBx.Clear();
            retailPriceBx.Clear();
            publisherBx.Clear();
            mediaTypeBx.Clear();
            modelNumBx.Clear();
            platformTypeBx.Clear();
        }

        private void custLbx_MouseClick(object sender, MouseEventArgs e)
        {
            clearCustFields();
            clearProdFields();
            clearTransFields();
            if(custLbx.SelectedIndex >=0 )
            showCustDetails();
        }

        private void transLbx_MouseClick(object sender, MouseEventArgs e)
        {
            clearCustFields();
            clearProdFields();
            clearTransFields();
            if(transLbx.SelectedIndex >=0)
            showTransDetails();
        }

        private void GameStore_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveProducts();
            saveCustomers();
            saveTransactions();
        }
    }
}
