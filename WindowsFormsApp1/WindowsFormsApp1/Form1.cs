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
    public partial class Form1 : Form
    {
        private object b;

        public Form1()
        {
            InitializeComponent();
        }

        string a;
        string c;
        string[,] data = { { "admin", "admin123" }, { "kasir", "Kasir123" } };

        public void login()
        {
            a = textBox1.Text;
            c = textBox2.Text;


            if (a == data[0, 0] && c == data[0, 1])
            {
                MessageBox.Show("anda login sebagai admin");

            }
            else if (a == data[1, 0] && c == data[1, 1])
            {
                MessageBox.Show("anda login sebagai kasir");
            }
            else
            {
                MessageBox.Show("password atau user name salah");
            }
        }

        public void signup() {
            if (a == data[0, 0])
            {
                data[0, 1] = textBox2.Text;
                MessageBox.Show("password telah di perbaharui");
            }
            else if (b == data[1, 0])
            {
                data[1, 1] = textBox2.Text;
                MessageBox.Show("password telah di perbaharui");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            signup();
        }

        private void Button2_Click(object sender, EventArgs e)
            {
            login();
            }
        }
    }
