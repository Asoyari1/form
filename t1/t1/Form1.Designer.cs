
namespace t1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Toiminnallisuus = new System.Windows.Forms.GroupBox();
            this.Poista = new System.Windows.Forms.Button();
            this.Tallenna = new System.Windows.Forms.Button();
            this.Uusitietue = new System.Windows.Forms.Button();
            this.Elokuvantiedot = new System.Windows.Forms.GroupBox();
            this.Seuraava = new System.Windows.Forms.Button();
            this.Edellinen = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.vuosi = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Kesto = new System.Windows.Forms.Label();
            this.Julkaisuvuosi = new System.Windows.Forms.Label();
            this.Nimi = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Arvio = new System.Windows.Forms.GroupBox();
            this.piste = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Arvosana = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.Toiminnallisuus.SuspendLayout();
            this.Elokuvantiedot.SuspendLayout();
            this.Arvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostsoToolStripMenuItem,
            this.tietojaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostsoToolStripMenuItem
            // 
            this.tiedostsoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
            this.tiedostsoToolStripMenuItem.Name = "tiedostsoToolStripMenuItem";
            this.tiedostsoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tiedostsoToolStripMenuItem.Text = "Tiedostso";
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.poistuToolStripMenuItem.Text = "Poistu";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // tietojaToolStripMenuItem
            // 
            this.tietojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // testaaToolStripMenuItem
            // 
            this.testaaToolStripMenuItem.Name = "testaaToolStripMenuItem";
            this.testaaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.testaaToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            this.testaaToolStripMenuItem.Click += new System.EventHandler(this.testaaToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Toiminnallisuus
            // 
            this.Toiminnallisuus.Controls.Add(this.Poista);
            this.Toiminnallisuus.Controls.Add(this.Tallenna);
            this.Toiminnallisuus.Controls.Add(this.Uusitietue);
            this.Toiminnallisuus.Location = new System.Drawing.Point(396, 39);
            this.Toiminnallisuus.Name = "Toiminnallisuus";
            this.Toiminnallisuus.Size = new System.Drawing.Size(309, 504);
            this.Toiminnallisuus.TabIndex = 12;
            this.Toiminnallisuus.TabStop = false;
            this.Toiminnallisuus.Text = "Toiminnallisuus";
            this.Toiminnallisuus.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Poista
            // 
            this.Poista.BackColor = System.Drawing.Color.Firebrick;
            this.Poista.Location = new System.Drawing.Point(30, 190);
            this.Poista.Name = "Poista";
            this.Poista.Size = new System.Drawing.Size(254, 55);
            this.Poista.TabIndex = 2;
            this.Poista.Text = "Poista";
            this.Poista.UseVisualStyleBackColor = false;
            // 
            // Tallenna
            // 
            this.Tallenna.BackColor = System.Drawing.Color.LawnGreen;
            this.Tallenna.Location = new System.Drawing.Point(30, 114);
            this.Tallenna.Name = "Tallenna";
            this.Tallenna.Size = new System.Drawing.Size(254, 55);
            this.Tallenna.TabIndex = 1;
            this.Tallenna.Text = "Tallenna";
            this.Tallenna.UseVisualStyleBackColor = false;
            this.Tallenna.Click += new System.EventHandler(this.Tallenna_Click);
            // 
            // Uusitietue
            // 
            this.Uusitietue.Location = new System.Drawing.Point(30, 44);
            this.Uusitietue.Name = "Uusitietue";
            this.Uusitietue.Size = new System.Drawing.Size(254, 55);
            this.Uusitietue.TabIndex = 0;
            this.Uusitietue.Text = "Uusi tietue";
            this.Uusitietue.UseVisualStyleBackColor = true;
            this.Uusitietue.Click += new System.EventHandler(this.Uusitietue_Click);
            // 
            // Elokuvantiedot
            // 
            this.Elokuvantiedot.Controls.Add(this.Seuraava);
            this.Elokuvantiedot.Controls.Add(this.Edellinen);
            this.Elokuvantiedot.Controls.Add(this.textBox4);
            this.Elokuvantiedot.Controls.Add(this.vuosi);
            this.Elokuvantiedot.Controls.Add(this.textBox2);
            this.Elokuvantiedot.Controls.Add(this.textBox1);
            this.Elokuvantiedot.Controls.Add(this.Kesto);
            this.Elokuvantiedot.Controls.Add(this.Julkaisuvuosi);
            this.Elokuvantiedot.Controls.Add(this.Nimi);
            this.Elokuvantiedot.Controls.Add(this.ID);
            this.Elokuvantiedot.Location = new System.Drawing.Point(12, 39);
            this.Elokuvantiedot.Name = "Elokuvantiedot";
            this.Elokuvantiedot.Size = new System.Drawing.Size(378, 300);
            this.Elokuvantiedot.TabIndex = 13;
            this.Elokuvantiedot.TabStop = false;
            this.Elokuvantiedot.Text = "Elokuvan tiedot";
            // 
            // Seuraava
            // 
            this.Seuraava.Location = new System.Drawing.Point(193, 226);
            this.Seuraava.Name = "Seuraava";
            this.Seuraava.Size = new System.Drawing.Size(160, 49);
            this.Seuraava.TabIndex = 9;
            this.Seuraava.Text = "Seuraava";
            this.Seuraava.UseVisualStyleBackColor = true;
            // 
            // Edellinen
            // 
            this.Edellinen.Location = new System.Drawing.Point(10, 226);
            this.Edellinen.Name = "Edellinen";
            this.Edellinen.Size = new System.Drawing.Size(160, 49);
            this.Edellinen.TabIndex = 8;
            this.Edellinen.Text = "Edellinen";
            this.Edellinen.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 147);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // vuosi
            // 
            this.vuosi.Location = new System.Drawing.Point(103, 107);
            this.vuosi.Name = "vuosi";
            this.vuosi.Size = new System.Drawing.Size(100, 20);
            this.vuosi.TabIndex = 6;
            this.vuosi.Click += new System.EventHandler(this.vuosi_Click);
            this.vuosi.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            this.vuosi.VisibleChanged += new System.EventHandler(this.vuosi_VisibleChanged);
            this.vuosi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vuosi_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.MouseCaptureChanged += new System.EventHandler(this.textBox2_MouseCaptureChanged);
            this.textBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDown);
            this.textBox2.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            this.textBox2.Move += new System.EventHandler(this.textBox2_Move);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Kesto
            // 
            this.Kesto.AutoSize = true;
            this.Kesto.Location = new System.Drawing.Point(7, 154);
            this.Kesto.Name = "Kesto";
            this.Kesto.Size = new System.Drawing.Size(59, 13);
            this.Kesto.TabIndex = 3;
            this.Kesto.Text = "Kesto(min):";
            // 
            // Julkaisuvuosi
            // 
            this.Julkaisuvuosi.AutoSize = true;
            this.Julkaisuvuosi.Location = new System.Drawing.Point(7, 114);
            this.Julkaisuvuosi.Name = "Julkaisuvuosi";
            this.Julkaisuvuosi.Size = new System.Drawing.Size(73, 13);
            this.Julkaisuvuosi.TabIndex = 2;
            this.Julkaisuvuosi.Text = "Julkaisuvuosi:";
            this.Julkaisuvuosi.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Nimi
            // 
            this.Nimi.AutoSize = true;
            this.Nimi.Location = new System.Drawing.Point(7, 73);
            this.Nimi.Name = "Nimi";
            this.Nimi.Size = new System.Drawing.Size(30, 13);
            this.Nimi.TabIndex = 1;
            this.Nimi.Text = "Nimi:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(7, 35);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID:";
            // 
            // Arvio
            // 
            this.Arvio.Controls.Add(this.piste);
            this.Arvio.Controls.Add(this.numericUpDown2);
            this.Arvio.Controls.Add(this.numericUpDown1);
            this.Arvio.Controls.Add(this.Arvosana);
            this.Arvio.Controls.Add(this.textBox5);
            this.Arvio.Location = new System.Drawing.Point(12, 345);
            this.Arvio.Name = "Arvio";
            this.Arvio.Size = new System.Drawing.Size(378, 198);
            this.Arvio.TabIndex = 14;
            this.Arvio.TabStop = false;
            this.Arvio.Text = "Arvio";
            // 
            // piste
            // 
            this.piste.AutoSize = true;
            this.piste.Location = new System.Drawing.Point(121, 173);
            this.piste.Name = "piste";
            this.piste.Size = new System.Drawing.Size(10, 13);
            this.piste.TabIndex = 4;
            this.piste.Text = ".";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(137, 166);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(68, 166);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Click += new System.EventHandler(this.numericUpDown1_Click);
            // 
            // Arvosana
            // 
            this.Arvosana.AutoSize = true;
            this.Arvosana.Location = new System.Drawing.Point(7, 168);
            this.Arvosana.Name = "Arvosana";
            this.Arvosana.Size = new System.Drawing.Size(55, 13);
            this.Arvosana.TabIndex = 1;
            this.Arvosana.Text = "Arvosana:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(10, 30);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(294, 120);
            this.textBox5.TabIndex = 0;
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(733, 555);
            this.Controls.Add(this.Arvio);
            this.Controls.Add(this.Elokuvantiedot);
            this.Controls.Add(this.Toiminnallisuus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Elokuvan tiedot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Toiminnallisuus.ResumeLayout(false);
            this.Elokuvantiedot.ResumeLayout(false);
            this.Elokuvantiedot.PerformLayout();
            this.Arvio.ResumeLayout(false);
            this.Arvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.GroupBox Toiminnallisuus;
        private System.Windows.Forms.GroupBox Elokuvantiedot;
        private System.Windows.Forms.Label Julkaisuvuosi;
        private System.Windows.Forms.Label Nimi;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button Seuraava;
        private System.Windows.Forms.Button Edellinen;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox vuosi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Kesto;
        private System.Windows.Forms.GroupBox Arvio;
        private System.Windows.Forms.Button Poista;
        private System.Windows.Forms.Button Tallenna;
        private System.Windows.Forms.Button Uusitietue;
        private System.Windows.Forms.Label piste;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Arvosana;
        private System.Windows.Forms.TextBox textBox5;
    }
}

