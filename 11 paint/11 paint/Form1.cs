﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // MainFrom:n alkuun määritellään koordinaattipiste(x,y), joka on käytössä koko lomakkeella. //Tällä pisteellä määritämme mistä aloitamme piirtämisen. Formin vasen ylänurkka on 0,0 //piste  



        Point piste = new Point(0, 0);

        Graphics Graf;

        // Talletetaan grafiikkaobjekti. Grafiikkaobjekti tarvitaan 

        // grafikan piirtämiseksi näytölle. 
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graf = e.Graphics;


            // - Pää 

            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);

            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            // - Selkä 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41, piste.X + 21, piste.Y + 131);

            // - Kädet 

            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60, piste.X + 70, piste.Y + 60);

            // - Jalat 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, piste.X - 30, piste.Y + 181);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131, piste.X + 70, piste.Y + 181);





            // Kutsutaan DrawCoordinates()-metodia. 

            //DrawCordinates(Graf);

        }

        // DrawCoordinates() -metodi PIIRTÄÄ pisteen koordinaatit lomakkeelle.  



        //private void DrawCordinates(Graphics Graf)

        //{

        //    // Piirretään piikoordinaattien arvot näytölle. 

        //    Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

        //                    new Font("Arial", 14, System.Drawing.FontStyle.Regular),

        //                    new SolidBrush(Color.Black), 8, 30);

        //}



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            

                if (e.Button == MouseButtons.Left)

                {

                    // Talletetaan hiiren klikkauskohdan koordinaatit. Piste (0, 0) 

                    // on formin työalueen vasemmassa ylä nurkassa 

                    piste = e.Location;



                    // Merkitään formin työalue epäkelvoksi, jolloin saadaan aikaiseksi 

                    // paint-eventin signalointi ja tämän jälkeen Paint()-metodin kutsu. 

                    Invalidate();

                }

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.D)
            {
                piste.X += 5;
            }
            if (e.KeyData == Keys.A)
            {
                piste.X -= 5;
            }
            if (e.KeyData == Keys.S)
            {
                piste.Y += 5;
            }
            if (e.KeyData == Keys.W)
            {
                piste.Y -= 5;
            }



        }

        private void movetimer_Tick(object sender, EventArgs e)
        {
            //tämä toimi paremmin
            Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //tehtävä anto
            Invalidate();
        }
    }
}
