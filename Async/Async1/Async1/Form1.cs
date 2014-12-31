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

namespace Async1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCallAsync_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(await GetMessage("Task 1"));
        }

        private static Task<string> GetMessage(string msg)
        {
            return Task.Run(() =>
                {
                    int i = 0;
                    while (i < 5)
                    {
                        Thread.Sleep(1000);
                        i++;
                    }
                    return msg + " Complete.";
                });
        }

        private async void btnCallAsync2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(await GetMessage("Task 2"));
        }
    }
}