using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Store
{
    class Customers
    {
        public static List<Customers> customers = new List<Customers>();

        private string custId;
        private string surname;
        private string firstName;
        private string email;
        private string mobile;
 
        public Customers()
        {
            custId = "C000";
            surname = "Unknown";
            firstName = "Unknown";
            email = "NUll";
            mobile = "NULL";
            customers.Add(this);
        }

        public Customers(string id, string surname, string first, string email, string mobile)
        {
            custId = id;
            this.surname = surname;
            firstName = first;
            this.email = email;
            this.mobile = mobile;
            customers.Add(this);
        }

        public string gsCustId
        {
            get { return custId; }
            set { custId = value; }
        }
        public string gsSurname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string gsFirst
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string gsEmail
        {
            get { return email; }
            set { email = value; }
        }
        public string gsMobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        public List<Customers> getCustList
        {
            get { return customers; }
        }
        public override string ToString()
        {
            return gsCustId + "," + gsSurname + "," + gsFirst + "," + gsEmail + "," + gsMobile;
        }
    }
}
