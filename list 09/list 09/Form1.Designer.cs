
namespace list_09
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Luo = new System.Windows.Forms.Button();
            this.lisä = new System.Windows.Forms.Button();
            this.Haku = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUODAAN String-TYYPPINEN LISTA";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISÄTÄÄN LISTAN MERKKIJONO";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(58, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "HAETAAN LISTAN SISÄLTÖ";
            // 
            // Luo
            // 
            this.Luo.Location = new System.Drawing.Point(117, 98);
            this.Luo.Name = "Luo";
            this.Luo.Size = new System.Drawing.Size(75, 23);
            this.Luo.TabIndex = 3;
            this.Luo.Text = "Luo Lista";
            this.Luo.UseVisualStyleBackColor = true;
            this.Luo.Click += new System.EventHandler(this.Luo_Click);
            // 
            // lisä
            // 
            this.lisä.Location = new System.Drawing.Point(222, 215);
            this.lisä.Name = "lisä";
            this.lisä.Size = new System.Drawing.Size(75, 23);
            this.lisä.TabIndex = 4;
            this.lisä.Text = "Lisää";
            this.lisä.UseVisualStyleBackColor = true;
            this.lisä.Click += new System.EventHandler(this.lisä_Click);
            // 
            // Haku
            // 
            this.Haku.Location = new System.Drawing.Point(222, 356);
            this.Haku.Name = "Haku";
            this.Haku.Size = new System.Drawing.Size(75, 23);
            this.Haku.TabIndex = 5;
            this.Haku.Text = "Haku";
            this.Haku.UseVisualStyleBackColor = true;
            this.Haku.Click += new System.EventHandler(this.Haku_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 215);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 23);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 356);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Haku);
            this.Controls.Add(this.lisä);
            this.Controls.Add(this.Luo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Luo;
        private System.Windows.Forms.Button lisä;
        private System.Windows.Forms.Button Haku;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

