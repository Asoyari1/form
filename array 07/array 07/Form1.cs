using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array_07
{
    public partial class Form1 : Form
    {
        
        int[] luo;
        

        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 taulukko = Convert.ToInt32(koko.Text);
            luo = new int[taulukko];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Int32 numero = Convert.ToInt32(talletettava.Text);
                Int32 paikka = Convert.ToInt32(indeksi.Text);
                luo[paikka] = numero;
            }
            catch (Exception)
            {
                MessageBox.Show("liian suuri indeksi! suurin indeksi on" + koko.Text);
            }

            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if(paikanindeksi.Text == indeksi.Text)
            {
                label8.Text = talletettava.Text;
            }
            else
            {
                label8.Text = "virhe";
            }
            
        }
    }
}
