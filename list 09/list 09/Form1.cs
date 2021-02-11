using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> name;
        
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Luo_Click(object sender, EventArgs e)
        {
            name = new List<string>();
            

        }

        private void lisä_Click(object sender, EventArgs e)
        {
            name.Add(textBox1.Text);
            //comboBox1.Items.Add(name);
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Haku_Click(object sender, EventArgs e)
        {
            foreach (string name in name)
            {
                comboBox1.Items.Add(name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
