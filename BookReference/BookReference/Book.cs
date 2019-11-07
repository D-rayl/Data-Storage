using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Daryl Crosbie
 * ID: P453055
 * Task AT1.2
 * */
namespace BookReference
{
    class Book
    {
        //Declared properties set private
        private string bookAuthor;
        private string bookDate;
        private string bookTitle;
        private string bookPublisher;

        //Methods, getters and setter declared public for accessing the properties
        public string GetBookAuthor
        {
            get { return bookAuthor; }
        }
        public string SetBookAuthor
        {
            set { bookAuthor = value; }
        }
        public string GetBookDate
        {
            get { return bookDate; }
        }
        public string SetBookDate
        {
            set { bookDate = value; }
        }
        public string GetBookTitle
        {
            get { return bookTitle; }
        }
        public string SetBookTitle
        {
            set { bookTitle = value; }
        }
        public string GetBookPublisher
        {
            get { return bookPublisher; }
        }
        public string SetBookPublisher
        {
            set { bookPublisher = value; }
        }
    }
}
