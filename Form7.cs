using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        private Form1 formazzz1 = new Form1();

        public Form7()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 formazzz4 = new Form4();
            formazzz4.Show();

            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formazzz1.category = "1";
            Form2 formazzz2 = new Form2();
            formazzz2.Show();

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formazzz1.category = "2";
            Form2 formazzz2 = new Form2();
            formazzz2.Show();

            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formazzz1.category = "3";
            Form2 formazzz2 = new Form2();
            formazzz2.Show();

            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formazzz1.category = "4";
            Form2 formazzz2 = new Form2();
            formazzz2.Show();

            Hide();
        }
    }
}
