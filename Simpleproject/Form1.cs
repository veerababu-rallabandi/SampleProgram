using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simpleproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(first.Text);
            int b = int.Parse(second.Text);
            int result = a * b;
            MessageBox.Show($"Multiplication of two number is {result}");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            EventHandler es = delegate(object sender, EventArgs e)
            {
                MessageBox.Show("hello");
            };
        }

        private void first_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
