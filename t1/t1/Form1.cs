using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t1
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void testaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Elokuvantiedot_Click(object sender, EventArgs e)
        {

        }

        private void Kesto_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tämän soveluksen tehnyt on Aso Yari", "Ilmoitus");
        }

        private void Uusitietue_Click(object sender, EventArgs e)
        {
            textBox2.Text = "{syötä elokuvan nimi}";
            vuosi.Text = DateTime.Now.Year.ToString();
            vuosi.Text = vuosi.Text;
            textBox4.Text = "0";
            textBox5.Text = "{Kirjoita tähän arvio}";
            numericUpDown1.Value = 5;

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void vuosi_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text.Trim() == "{syötä elokuvan nimi}")
            {
                textBox2.Clear();
            }


        }

        private void vuosi_Click(object sender, EventArgs e)
        {
            //vuosi.Text = DateTime.Now.Year.ToString();
            //if (vuosi.Text.Trim() == vuosi.Text)
            //{
            //    vuosi.Clear();
            //}
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim() == "0")
            {
                textBox4.Clear();
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Trim() == "{Kirjoita tähän arvio}")
            {
                textBox5.Clear();
            }
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void textBox2_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Move(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            //if (textBox2.Text == "")
            //{
            //    textBox2.Text = "{syötä elokuvan nimi}";
            //}
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            //if (textBox4.Text == "")
            //{
            //    textBox4.Text = "0";
            //}
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            //if (textBox5.Text == "")
            //{
            //    textBox5.Text = "{Kirjoita tähän arvio}";
            //}
        }

        private void Tallenna_Click(object sender, EventArgs e)
        {


            int num;
            if (!int.TryParse(vuosi.Text, out num))
            {
                MessageBox.Show("julkaisuvuosi ei ole vain numeroita");

            }
            else if (!int.TryParse(textBox4.Text, out num))
            {
                MessageBox.Show("kesto ei ole vain numeroita");

            }
            else if (vuosi.Text == "")
            {
                MessageBox.Show("et ole syöttänyt mitään julkaisuvuosi-kentttään");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("et ole syöttänyt mitään kesto-kentttään");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("et ole syöttänyt mitään nimi-kentttään");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("et ole syöttänyt mitään arvio-kentttään");
            }
            else
            {
                MessageBox.Show("check OK");
            }

        }

        private void vuosi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char number = e.KeyChar;
            //if (!char.IsDigit(number))
            //{
            //    MessageBox.Show("vain numeroita");
            //}
        }
    }
}
