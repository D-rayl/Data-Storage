using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fill();
        }
        static int max = 30;
        int[] arr = new int[max];

        private void sortBtn_Click(object sender, EventArgs e)
        {
            for(int outer = 0; outer < max; outer++)
            {
                for(int inner = 0; inner < max-1; inner++)
                {
                    if(arr[inner] > arr[inner + 1])
                    {
                        swap(inner);
                    }
                    show();
                    Application.DoEvents();
                    Thread.Sleep(100);
                    textOutF.Text = outer.ToString();
                    textInnerF.Text = inner.ToString();
                }
            }
        }

        public void show()
        {
            listRes.Items.Clear();
            for(int i =0; i < max; i++)
            {
                listRes.Items.Add(arr[i]);
            } 
            
        }
        public void swap(int index)
        {
            int temp = arr[index];
            arr[index] = arr[index + 1];
            arr[index + 1] = temp;
        }
        public void fill()
        {
            Random ran = new Random();
            listRes.Items.Clear();
            for(int i = 0; i < max; i++)
            {
                arr[i] = ran.Next(1,31);
                for(int j = 0; j<i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        i--;
                    }
                }
            }
        }
    }
}
