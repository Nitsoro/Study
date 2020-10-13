using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ostatokchisla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a, b, n;
            a = Convert.ToInt32(textBox1.Text);//считываем переменные
            b = Convert.ToInt32(textBox2.Text);//считываем переменные
            n = a;

            if ((b < 0) | (a < 0))
                MessageBox.Show("Error!!!Incorrect!");//проверка на дурачка

            else
            {
                while //деление (без использования самого деления или умножения)
                     (n >= 0)
                    n = n - b;
                
                MessageBox.Show(Convert.ToString(n+b), "Ostatok raven = ");//вывод данных =)
            }
            
            
        }
    }
}
