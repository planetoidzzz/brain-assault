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
    public partial class Form2 : Form
    {
        private Form1 formazzz1 = new Form1();

        Int64 a = 0; // first number
        Int64 b = 0; // second number
        string znak = ""; // "+" or "-"
        Int64 answer = 0; // right answer
        bool status = true;
        string total = "";

        RandomProportional randObj1 = new RandomProportional(); // first number
        RandomProportional randObj2 = new RandomProportional(); // second number

        private void Reset()
        {
            int coefficient = 100;
            if (formazzz1.difficulty == "2")
                coefficient = 200;
            else if (formazzz1.difficulty == "3")
                coefficient = 500;
            else if (formazzz1.difficulty == "4")
                coefficient = 1000;

            a = Convert.ToInt64(Math.Round(randObj1.NextDouble() * coefficient));
            b = Convert.ToInt64(Math.Round(randObj1.NextDouble() * coefficient));
            if (formazzz1.category == "1")
            {
                znak = "+";
                answer = a + b;
            }
            else if (formazzz1.category == "2")
            {
                znak = "-";
                answer = a - b;
            }
            else if (formazzz1.category == "3")
            {
                znak = "*";
                answer = a * b;
            }
            else if (formazzz1.category == "4")
            {
                znak = "/";
                answer = a / b;
            }

            total = Convert.ToString(a) + znak + Convert.ToString(b);
            label1.Text = total;
            progressBar1.Value = 0;
            status = true;
            timer1.Start();
        }

        public Form2()
        {
            InitializeComponent();
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value += 1 * Convert.ToInt16(formazzz1.difficulty);
            else
            {
                timer1.Stop();
                status = false;
                MessageBox.Show("Вы не успели решить пример!");
                Reset();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (status)
            {
                timer1.Stop();
                if (textBox1.Text == Convert.ToString(answer))
                    MessageBox.Show("Вы решили пример верно!");
                    
                else
                    MessageBox.Show("Вы решили пример неверно!");

                Reset();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

//it's class for randomizer
public class RandomProportional : Random
{
    // The Sample method generates a distribution proportional to the value
    // of the random numbers, in the range [0.0, 1.0].
    protected override double Sample()
    {
        return Math.Sqrt(base.Sample());
    }

    public override int Next()
    {
        return (int)(Sample() * int.MaxValue);
    }
}
