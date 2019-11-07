using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] a = new string[10];    
        


        private void s_Click(object sender, EventArgs e)
        {
            int startIndex = -1;
            int finalIndex = a.Length;
            int foundIndex = -1;
            bool found = false;

            while (!found && !((finalIndex - startIndex) <= 1))
            {
                int newIndex = (finalIndex + startIndex) / 2;

                if (string.Compare(a[newIndex], tB.Text, true) == 0)
                {
                    foundIndex = newIndex;
                    found = true;
                    break;
                }
                else
                {
                    if (string.Compare(a[newIndex], tB.Text, true) == 1)
                        finalIndex = newIndex;
                    else
                        startIndex = newIndex;
                }
            }
            if (found)
            {
                MessageBox.Show("Yes");

            }
            else
            {
                MessageBox.Show("No match");
            }
        }
    

        private void p_Click(object sender, EventArgs e)
        {
            a[0] = "aa";
            a[1] = "bb";
            a[2] = "cc";
            a[3] = "dd";
            a[4] = "ee";
            a[5] = "ff";
            a[6] = "gg";
            a[7] = "hh";
            a[8] = "ii";
            a[9] = "jj";
        }
    }
}
