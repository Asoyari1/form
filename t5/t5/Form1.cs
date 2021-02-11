using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace t5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Int32 num = Convert.ToInt32(textBox1.Text);
            for(Int32 i =0; i<num; i++)
            {
                string number = (i + 1).ToString();
                label1.Text = number;
                label1.Update();
                Thread.Sleep(100);
            }
        }

       
    }
}
