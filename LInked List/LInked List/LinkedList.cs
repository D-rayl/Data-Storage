using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LInked_List
{
    public partial class LinkedList : Form
    {
        public LinkedList()
        {
            InitializeComponent();
        }
        LinkedList<string> myCarCollection = new LinkedList<string>();

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBx.Text))
            {
                myCarCollection.AddFirst(nameBx.Text);
                showList();
            }
        }
        private void showList()
        {
            listBx.Items.Clear();
            nameBx.Clear();
            nodePosBx.Clear();
            numNodes.Text = numberOfNodes().ToString();

            foreach(string car in myCarCollection)
            {
                listBx.Items.Add(car);
            }

        }
        private int numberOfNodes()
        {
            return myCarCollection.Count();
        }
        private void addLastBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBx.Text))
            {
                myCarCollection.AddLast(nameBx.Text);
                showList();
            }
            else MessageBox.Show("Please enter a Car name");
        }
        private void addBeforeBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBx.Text) && (!string.IsNullOrEmpty(nodePosBx.Text))){
                LinkedListNode<string> current = myCarCollection.Find(nodePosBx.Text);
                myCarCollection.AddBefore(current, nameBx.Text);
                showList();
            }
     
        }

        private void addAfterBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBx.Text) && (!string.IsNullOrEmpty(nodePosBx.Text)))
            {
                LinkedListNode<string> current = myCarCollection.Find(nodePosBx.Text);
                myCarCollection.AddAfter(current, nameBx.Text);
                showList();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBx.Text))
            {
                myCarCollection.Remove(nameBx.Text);
                showList();
            }
            else
            {
                MessageBox.Show("Please enter a car name");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            myCarCollection.Clear();
            showList();
        }

        private void listBx_MouseClick(object sender, MouseEventArgs e)
        {
            nodePosBx.Text = listBx.SelectedItem.ToString();
        }

        private void listBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
