using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form1 : Form
    {
        int[] arr = { 2, 3, 4, 5, 10, 12, 13 };

        public Form1()
        {
            InitializeComponent();
        }

        //APPROACH 1

        private void btnApproach1_Click(object sender, EventArgs e)
        {
            PrintGreaterThan5();
            PrintLessThan5();
            PrintGreaterThan10();
        }

        void PrintGreaterThan5()
        {
            foreach (var item in arr)
            {
                if (item > 5)
                    listBox1.Items.Add("Method1 - " + item);
            }
        }

        void PrintLessThan5()
        {
            foreach (var item in arr)
            {
                if (item < 5)
                    listBox1.Items.Add("Method2 - " + item);
            }
        }

        void PrintGreaterThan10()
        {
            foreach (var item in arr)
            {
                if (item > 10)
                    listBox1.Items.Add("Method3 - " + item);
            }
        }

        //APPROACH USING DELEGATES

        private void btnUsingDelegates_Click(object sender, EventArgs e)
        {
            CheckPrint(this, Method1);
            CheckPrint(this, Method2);
            CheckPrint(this, Method3);       
        }

        delegate bool MyDelegate(int x);

        static void CheckPrint(Form1 f, MyDelegate mydel)
        {
            foreach (var item in f.arr)
            {
                if (mydel(item))
                    f.listBox1.Items.Add(mydel.Method.Name + " - " + item);
            }
        }

        static bool Method1(int x)
        {
            Console.WriteLine("Method1 called.");
            return x > 5;
        }

        static bool Method2(int x)
        {
            Console.WriteLine("Method2 called.");
            return x < 5;
        }

        static bool Method3(int x)
        {
            Console.WriteLine("Method3 called.");
            return x > 10;
        }

        /// TO ADD GREATER THAN 15 OR 20 OR LIKEWISE APPROACH 1 NEEDS ANOTHER METHOD
        /// BUT WHEN USING DELEGATES
        ///         static bool Method3(int x)
        //          {
        //               return x > 15;
        //          }

        //////////////////////////////////////////////////////////////////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            MyDelegate d1 = Method1;
            //listBox1.Items.Add("is 50 Number greater than 5 - " + d1(50));

            MyDelegate d2 = Method2;
            MyDelegate d3 = Method3;

            MyDelegate test2 = d2 + d3;
            listBox1.Items.Add("is 50 Number greater than 5 - " + test2(50));  //SEE OUTPUT WINDOW FOR LOGS - BOTH METHOD 1 & 2 WILL BE CALLED
        }
    }
}