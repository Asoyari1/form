using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Button painettuNappi = sender as Button;
            string s = painettuNappi.Text;
            switch (s)
            {
                case "Valinta 1":
                    MessageBox.Show("Valinta 1", "huom");
                    break;
                case "Valinta 2":
                    MessageBox.Show("Valinta 2", "huom");
                    break;
                case "Valinta 3":
                    MessageBox.Show("Valinta 3", "huom");
                    break;
                case "Valinta 4":
                    MessageBox.Show("Valinta 4", "huom");
                    break;
                case "Default":
                    MessageBox.Show("Default", "huom");
                    break;
            }

        }

        
    }
}
