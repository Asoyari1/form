using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            while (MessageBox.Show("Valitse YES jatkaaksesi tai NO lopettaaksesi", "HUOM!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if(MessageBox.Show("Valitse YES jatkaaksesi tai NO lopettaaksesi", "HUOM!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    break;
                }

                
            }

           
            
        }
    }
}
