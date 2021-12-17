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
    public partial class Form6 : Form
    {
        private Form1 formizzz1 = new Form1();

        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 formazzz5 = new Form5();
            formazzz5.Show();

            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Application.LocalUserAppDataPath + "/lastuser.txt", formizzz1.username);
            File.WriteAllText(Application.LocalUserAppDataPath + "/" + formizzz1.username + "_g.txt", "0");
            File.WriteAllText(Application.LocalUserAppDataPath + "/" + formizzz1.username + "_b.txt", "0");
            File.WriteAllText(Application.LocalUserAppDataPath + "/" + formizzz1.username + "_u.txt", "0");

            Form4 formazzz4 = new Form4();
            formazzz4.Show();

            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
