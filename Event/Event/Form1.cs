using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Kdx: Programatically added the event handler
            //this.button1.Click += new System.EventHandler(this.CustomerMethod);      OR (OLD C# CODE)
            this.button1.Click += this.CustomerMethod;
        }

        private void CustomerMethod(object sender, EventArgs e)
        {
            MessageBox.Show("aaaaa");
        }
    }
}