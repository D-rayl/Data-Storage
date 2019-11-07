using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayList2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList myList = new ArrayList();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textInput.Text)))
            {
                if(!(listResults.SelectedIndex == -1))
                {
                    string curIndex = listResults.SelectedItem.ToString();
                    int indx = listResults.FindString(curIndex);
                    myList.Insert(indx, textInput.Text);
                    ShowArrayList();
                }
            }
            else
            {
                MessageBox.Show("Select an insertion point in the ListBox");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            myList.Sort();
            int indx = -1;
            if (!(String.IsNullOrEmpty(textInput.Text)))
            {
                indx = myList.BinarySearch(textInput.Text);
                if(indx > -1)
                {
                    MessageBox.Show("Found at index " + indx);
                }
                else
                {
                    MessageBox.Show("Search did not find " + textInput.Text);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(!(listResults.SelectedIndex == -1))
            {
                string curIndex = listResults.SelectedItem.ToString();
                int indx = listResults.FindString(curIndex);
                myList.Remove(curIndex);
                ShowArrayList();
            }
            else
            {
                MessageBox.Show("Select an item for deletion from the ListBox");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myList.Add(textInput.Text);
            textInput.Clear();
            ShowArrayList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            myList.Sort();
            ShowArrayList();
        }

        private void ShowArrayList()
        {
            listResults.Items.Clear();
            for(int i=0; i < myList.Count; i++)
            {
                listResults.Items.Add(myList[i]);
            }
            textArrayListLength.Text = myList.Count.ToString();
        }
    }
}
