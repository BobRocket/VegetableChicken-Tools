using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                System.Diagnostics.Process.Start("www.ghxi.com");
            }
            else if (listBox1.SelectedIndex == 1)
            {
                System.Diagnostics.Process.Start("http://next.itellyou.cn");
            }
            else if (listBox1.SelectedIndex == 2)
            {
                System.Diagnostics.Process.Start("http://g4560.cn");
            }
            else if (listBox1.SelectedIndex == 3)
            {
                System.Diagnostics.Process.Start("http://24mail.chacuo.net/");
            }
            else if (listBox1.SelectedIndex == 4)
            {
                System.Diagnostics.Process.Start("https://pc.woozooo.com/");
            }
            else if (listBox1.SelectedIndex == 5)
            {
                System.Diagnostics.Process.Start("www.csdn.com");
            }
            else if (listBox1.SelectedIndex == 6)
            {
                System.Diagnostics.Process.Start("www.github.com");
            }
            else if (listBox1.SelectedIndex == 7)
            {
                System.Diagnostics.Process.Start("www.cnblogs.com");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
