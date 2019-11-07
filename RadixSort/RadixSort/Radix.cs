using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadixSort
{
    public partial class Radix : Form
    {
        public Radix()
        {
            InitializeComponent();
            fill(arr2);
            show(arr2);

        }
        Random r = new Random();
        int[] arr = { 1000000000, 2, 3333, 4765, 155, 165, 92,  255000, 75000, 785403, 63, 3524,1029387, 537629,1526378,
        18273546, 126347589};

        int[] arr2 = new int[100];
        
        private void bSort_Click(object sender, EventArgs e)
        {
            int[] arr3 = Sort(arr2);
            
        }
        struct KVEntry
        {
            int key;
            int value;
            public int Key
            {
                get { return key; }
                set
                {
                    if (key >= 0)
                        key = value;
                    else
                        throw new Exception("Invalid key value");
                }
            }
            public int Value
            {
                get { return value; }
                set { this.value = value; }
            }
        }
        public int[] Sort(int[] array)
        {
            return RadixSortAux(array, 1);
        }
        int[] RadixSortAux(int[] array, int digit)
        {
            bool Empty = true;
            //array that holds the digits;
            KVEntry[] digits = new KVEntry[array.Length];
            //Hold the sorted array
            int[] SortedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                digits[i] = new KVEntry();
                digits[i].Key = i;
                digits[i].Value = (array[i] / digit) % 10;
                if (array[i] / digit != 0)
                    Empty = false;
            }
            show(array);
            Application.DoEvents();
            Thread.Sleep(250);
            if (Empty)
                return array;
            KVEntry[] SortedDigits = CountingSort(digits);
            for (int i = 0; i < SortedArray.Length; i++)
                SortedArray[i] = array[SortedDigits[i].Key];
            return RadixSortAux(SortedArray, digit * 10);
        }
        KVEntry[] CountingSort(KVEntry[] ArrayA)
        {
            int[] ArrayB = new int[MaxValue(ArrayA) + 1];
            KVEntry[] ArrayC = new KVEntry[ArrayA.Length];
            for (int i = 0; i < ArrayB.Length; i++)
                ArrayB[i] = 0;
            for (int i = 0; i < ArrayA.Length; i++)
                ArrayB[ArrayA[i].Value]++;
            for (int i = 1; i < ArrayB.Length; i++)
                ArrayB[i] += ArrayB[i - 1];
            for (int i = ArrayA.Length - 1; i >= 0; i--)
            {
                int value = ArrayA[i].Value;
                int index = ArrayB[value];
                ArrayB[value]--;
                ArrayC[index - 1] = new KVEntry();
                ArrayC[index - 1].Key = i;
                ArrayC[index - 1].Value = value;
            }

            return ArrayC;
        }
        int MaxValue(KVEntry[] arr)
        {
            int Max = arr[0].Value;
            for (int i = 1; i < arr.Length; i++)
                if (arr[i].Value > Max)
                    Max = arr[i].Value;
            return Max;
        }

        public void show(int[] a)
        {
            listB.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                listB.Items.Add(a[i]);
            }

        }
        public void fill(int[] a2)
        {
            for(int i=0; i<a2.Length; i++)
            {
                a2[i] = r.Next();
            }
        }
    }
}
