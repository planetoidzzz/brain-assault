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
    public partial class Form3 : Form
    {
        private Form1 formazzz1 = new Form1();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_g.txt") &&
                !File.Exists(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_b.txt") &&
                !File.Exists(Application.LocalUserAppDataPath + "/" + textBox1.Text + "_u.txt"))
            {
                MessageBox.Show("Такого пользователя не существует!");
                textBox1.Text = "";
                //использовать StreamWriter и StreamReader

                //чтение и запись в файлы
                //https://docs.microsoft.com/ru-ru/troubleshoot/dotnet/csharp/file-io-operation
            }
            else
            {
                Form4 formazzz4 = new Form4();
                formazzz4.Show();

                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formazzz1.username = textBox1.Text;

            formazzz1.Show();

            Hide();
        }
    }
}
