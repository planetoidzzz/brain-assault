using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        private Form1 formizzz1 = new Form1();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formizzz1.username = textBox1.Text;
            if (textBox1.TextLength > 0)
            {
                if (File.Exists(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_g.txt") && File.Exists(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_b.txt") && File.Exists(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_u.txt"))
                {
                    Form6 formazzz6 = new Form6();
                    formazzz6.Show();

                    Hide();
                }
                else
                {
                    File.WriteAllText(Application.LocalUserAppDataPath + "/lastuser.txt", textBox1.Text);

                    File.WriteAllText(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_g.txt", "0");
                    File.WriteAllText(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_b.txt", "0");
                    File.WriteAllText(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_u.txt", "0");

                    Form4 formazzz4 = new Form4();
                    formazzz4.Show();

                    Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 formazzz1 = new Form1();
            formazzz1.Show();

            Hide();
        }
    }
}
