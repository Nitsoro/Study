using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            int a;
            a = Convert.ToInt32(textBox1.Text);
            for (k=0;a<k;k++)
            {
                int b = a % 10;
                if (b==3)

            }
        }
    }
}
