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
    public partial class Form4 : Form
    {
        private Form1 formazzz1 = new Form1();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formazzz1.difficulty = "1";

            Form7 formazzz7 = new Form7();
            formazzz7.Show();

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formazzz1.difficulty = "2";

            Form7 formazzz7 = new Form7();
            formazzz7.Show();

            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formazzz1.difficulty = "3";

            Form7 formazzz7 = new Form7();
            formazzz7.Show();

            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formazzz1.difficulty = "4";

            Form7 formazzz7 = new Form7();
            formazzz7.Show();

            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 formazzz3 = new Form3();
            formazzz3.Show();

            Hide();
        }
    }
}
