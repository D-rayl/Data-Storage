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
/* Daryl Crosbie
 * ID: P453055
 * Task AT1.5
 * */

/*
 *   Convert the 4 arrays to a single 2d array
     Adapt the search and sort algorithms to using the 2d array
     redraw the UML activity diagrams for the click event
        implementation of the Search and Save Buttons
*/
namespace BookReference
{
    public partial class BookReference : Form
    {
        public BookReference()
        {
            InitializeComponent();
            loadFile();
        }
        static int att = 4;
        static int max = 10;
        static int numBook = 0;

        //2D array for storing book attributes
        string[,] books = new string[max, att];
        Book book;

        //Displays user input in text field as its added
        private void tbAuthor_TextChanged(object sender, EventArgs e)
        {
            book = new Book();
            //Set the book properties from the appropriate input fields
            book.SetBookAuthor = tbAuthor.Text;
            book.SetBookDate = datePick.Text;
            book.SetBookTitle = tbTitle.Text;
            book.SetBookPublisher = tbPublisher.Text;

            //Display results in text box below
            tbResult.Text = (book.GetBookAuthor+", "+book.GetBookDate+". "+book.GetBookTitle+". "+book.GetBookPublisher);
        }

        //Save user input to binary file
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(numBook == 9)
            {
                string m = "Write over?";
                string c = "Book list is full";
                MessageBoxButtons b = MessageBoxButtons.YesNo;
                DialogResult res;

                res = MessageBox.Show(this, m, c, b, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if(res == DialogResult.Yes)
                {
                    numBook = 0;
                }
            }
            else
            {
                if (String.IsNullOrEmpty(tbTitle.Text))
                {
                    MessageBox.Show("Pease enter a title");
                    return;
                }
                if(String.IsNullOrEmpty(tbAuthor.Text))
                {
                    MessageBox.Show("Please enter the author");
                    return;
                }
                if (String.IsNullOrEmpty(tbPublisher.Text))
                {
                    MessageBox.Show("Please enter the publisher");
                    return;
                }
                storeBook();
                numBook++;
                clear();
                sort();
                displayBooks();
                saveFile();      
            }
        }

        //Method, stores book attributes to the appropriate array
        public void storeBook()
        {
            books[numBook, 0] = book.GetBookTitle;
            books[numBook, 1] = book.GetBookDate;
            books[numBook, 2] = book.GetBookAuthor;
            books[numBook, 3] = book.GetBookPublisher;
        }

        //Method, saves to binary file
        public void saveFile()
        {
            BinaryWriter bw;

            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream("C:\\Temp\\Library2.0.dat", FileMode.Create));
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message + "\n Cannot.");
                return;
            }
            //writing into the file
            try
            {
                for (int i = 0; i < numBook; i++)
                {
                    bw.Write(books[i,0]);
                    bw.Write(books[i,1]);
                    bw.Write(books[i,2]);
                    bw.Write(books[i,3]);
                }
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message + "\n Cannot write data to file.");
                return;
            }
            bw.Close();
        }

        //Method, loads from binary file
        public void loadFile()
        {
            //reading from the file
            BinaryReader br;
            try
            {
                br = new BinaryReader(new FileStream("C:\\Temp\\Library2.0.dat", FileMode.Open));
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message + "\n Cannot open file for reading");
                return;
            }
            int i = 0;
            string line = "";
            // read data
            while (br.BaseStream.Position != br.BaseStream.Length)
            {
                try
                {
                    books[i,0] = br.ReadString();
                    books[i,1] = br.ReadString();
                    books[i,2] = br.ReadString();
                    books[i,3] = br.ReadString();
                    line = books[i,0] + ", " + books[i,2] + " : " + books[i,3];
                    listBx.Items.Add(line);
                    i++;   
                }
                catch (Exception) // catches the EOF
                {
                    MessageBox.Show("EOF reached, no more data.");
                    break;
                }
            }
            numBook = i;
            br.Close(); 
        }

        //Method, displays book info to listbox
        public void displayBooks()
        {
           
            for (int i = 0; i < numBook; i++)
            {
                listBx.Items.Add(books[i,0]+", "+books[i,2]+" : "+books[i,3]);
            }
        }

        //Bubble sort, sorts the books from their titles
        public void sort()
        {
            for (int outer = 0; outer < books.GetLength(0); outer++)
            {
                for (int inner = 0; inner < books.GetLength(0)-1; inner++)
                {
                    if (!(String.IsNullOrEmpty(books[inner + 1,0])))
                    {
                        if (books[inner,0].CompareTo(books[inner + 1,0]) > 0)
                        {
                            swap(inner, inner + 1);
                        }
                    }
                }
            }
        }

        //Method, clears text fields
        public void clear()
        {
            tbTitle.Text = "";
            tbAuthor.Text = "";
            tbPublisher.Text = "";
            datePick.Text = "";
            listBx.Items.Clear();
        }

        //Method, accepts two integer values and swaps the appropriate data
        public void swap(int x, int y)
        {
            string temp;
            temp = books[y,0];
            books[y,0] = books[x,0];
            books[x,0] = temp;

            temp = books[y,1];
            books[y,1] = books[x,1];
            books[x,1] = temp;

            temp = books[y, 2];
            books[y,2] = books[x,2];
            books[x,2] = temp;

            temp = books[y,3];
            books[y,3] = books[x,3];
            books[x,3] = temp;
        }

        //Button for clearing the fields
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        //Button for searching for a book
        private void searchBtn_Click(object sender, EventArgs e)
        {
            sort();
            search();
           
        }

        //Binary search algorithm for finding a book
        public void search()
        {
            int startIndex = -1;
            int finalIndex = numBook;
            int foundIndex = -1;
            bool found = false;

            while (!found && !((finalIndex - startIndex) <= 1))
            {
                int newIndex = (finalIndex + startIndex) / 2;

                if (string.Compare(books[newIndex,0], tbTitle.Text, true) == 0)
                {
                    foundIndex = newIndex;
                    found = true;
                    break;
                }
                else
                {
                    if (string.Compare(books[newIndex,0], tbTitle.Text, true) == 1)
                        finalIndex = newIndex;
                    else
                        startIndex = newIndex;
                }
            }
            if(found)
            {
                MessageBox.Show("Match found");
                tbAuthor.Text = books[foundIndex,2];
                tbPublisher.Text = books[foundIndex,3];
                datePick.Text = books[foundIndex,1];
            }
            else
            {
                MessageBox.Show("No match");
            }
        }
    }
}
