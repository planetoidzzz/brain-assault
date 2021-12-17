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
    public partial class Form1 : Form
    {
        public string difficulty = "1"; //easy
        public string username = "";
        public string category = "1"; //+

        public Form1()
        {
            //label2.Text = Application.ProductVersion;

            InitializeComponent();

            if (!File.Exists(Application.LocalUserAppDataPath + "/lastuser.txt"))
            {
                label4.Text = "Кол-во правильных ответов: неизвестно";
                label5.Text = "Кол-во неправильных ответов: неизвестно";
                label6.Text = "Кол-во пропущенных ответов: неизвестно";
            }
            else
            {
                string user = File.ReadAllText(Application.LocalUserAppDataPath + "/lastuser.txt");
                if (user.Length > 0)
                {
                    textBox1.Text = user;
                    if (File.Exists(Application.LocalUserAppDataPath + "/" + user + "_g.txt"))
                        label4.Text = "Кол-во правильных ответов: " + File.ReadAllText(Application.LocalUserAppDataPath + "/" + user + "_g.txt");
                    else
                        label4.Text = "Кол-во правильных ответов: неизвестно";

                    if (File.Exists(Application.LocalUserAppDataPath + "/" + user + "_b.txt"))
                        label5.Text = "Кол-во неправильных ответов: " + File.ReadAllText(Application.LocalUserAppDataPath + "/" + user + "_b.txt");
                    else
                        label5.Text = "Кол-во неправильных ответов: неизвестно";

                    if (File.Exists(Application.LocalUserAppDataPath + "/" + user + "_u.txt"))
                        label6.Text = "Кол-во пропущенных ответов: " + File.ReadAllText(Application.LocalUserAppDataPath + "/" + user + "_u.txt");
                    else
                        label6.Text = "Кол-во пропущенных ответов: неизвестно";
                }
                else
                {
                    label4.Text = "Кол-во правильных ответов: неизвестно";
                    label5.Text = "Кол-во неправильных ответов: неизвестно";
                    label6.Text = "Кол-во пропущенных ответов: неизвестно";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 formazzz3 = new Form3();
            formazzz3.Show();

            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 formazzz5 = new Form5();
            formazzz5.Show();

            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", Application.LocalUserAppDataPath);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_g.txt"))
                File.Delete(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_g.txt");

            if (File.Exists(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_b.txt"))
                File.Delete(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_b.txt");

            if (File.Exists(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_u.txt"))
                File.Delete(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_u.txt");
        }
    }
}

