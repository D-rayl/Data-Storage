using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace AlphaSort
{
    public partial class AlphaSort : Form
    {
        public AlphaSort()
        {
            InitializeComponent();
        }
        String[] arr = new String[20];
        private void addBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (!(String.IsNullOrEmpty(nameIn.Text)))
                {
                    if (arr[i] == null)
                    {
                        arr[i] = nameIn.Text;
                        show();
                        nameIn.Clear();
                        break;
                    }
                }
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {

            String temp;

            for (int outer = 0; outer < arr.Length; outer++)
            {
                for (int inner = 0; inner < arr.Length - 1; inner++)
                {
                    if (!(String.IsNullOrEmpty(arr[inner + 1])))
                    {
                        if ((int)arr[inner][0] > (int)arr[inner + 1][0])
                        {
                            temp = arr[inner + 1];
                            arr[inner + 1] = arr[inner];
                            arr[inner] = temp;
                        }
                        if((int)arr[inner][0] == (int)arr[inner + 1][0] && (int)arr[inner][1] > (int)arr[inner + 1][1])
                        {
                            temp = arr[inner + 1];
                            arr[inner + 1] = arr[inner];
                            arr[inner] = temp;
                        }
                        show();
                        Application.DoEvents();
                        Thread.Sleep(100);
                    }
                }
            }
        }

        public void show()
        {
            listBx.Items.Clear();
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != null)
                {
                    listBx.Items.Add(arr[i]);
                }   
            }
        }
    }
}
