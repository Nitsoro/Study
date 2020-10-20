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
            int o = 0;
            int a;
            int f;
            
            a = Convert.ToInt32(textBox1.Text);
           
            for (int v=1;v<=a;v++)
            {
                f = v;
                while (f != 0)
                {
                    int b = f % 10;
                    f = f / 10;
                    if (b == 3)
                    {
                        o++;
                    }
                }
            }
            string z = Convert.ToString(o);
            MessageBox.Show(z);
        }

    }
}
