
namespace array_07
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.koko = new System.Windows.Forms.TextBox();
            this.talletettava = new System.Windows.Forms.TextBox();
            this.indeksi = new System.Windows.Forms.TextBox();
            this.paikanindeksi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(105, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAULUKON LUONTI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taulukon koko";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Luo Taulukko";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TALLENNUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Talletettava numero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Talletuspaikan indeksi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Talletuspaikan indeksi:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "Talleta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "HAKU";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 24);
            this.button3.TabIndex = 13;
            this.button3.Text = "Hae";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label8.Location = new System.Drawing.Point(135, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.MaximumSize = new System.Drawing.Size(45, 45);
            this.label8.MinimumSize = new System.Drawing.Size(2, 2);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2);
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 8;
            // 
            // koko
            // 
            this.koko.Location = new System.Drawing.Point(94, 52);
            this.koko.Name = "koko";
            this.koko.Size = new System.Drawing.Size(57, 20);
            this.koko.TabIndex = 14;
            // 
            // talletettava
            // 
            this.talletettava.Location = new System.Drawing.Point(123, 116);
            this.talletettava.Name = "talletettava";
            this.talletettava.Size = new System.Drawing.Size(57, 20);
            this.talletettava.TabIndex = 15;
            // 
            // indeksi
            // 
            this.indeksi.Location = new System.Drawing.Point(130, 163);
            this.indeksi.Name = "indeksi";
            this.indeksi.Size = new System.Drawing.Size(57, 20);
            this.indeksi.TabIndex = 16;
            // 
            // paikanindeksi
            // 
            this.paikanindeksi.Location = new System.Drawing.Point(130, 241);
            this.paikanindeksi.Name = "paikanindeksi";
            this.paikanindeksi.Size = new System.Drawing.Size(57, 20);
            this.paikanindeksi.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 333);
            this.Controls.Add(this.paikanindeksi);
            this.Controls.Add(this.indeksi);
            this.Controls.Add(this.talletettava);
            this.Controls.Add(this.koko);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinimumSize = new System.Drawing.Size(16, 39);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(22);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox koko;
        private System.Windows.Forms.TextBox talletettava;
        private System.Windows.Forms.TextBox indeksi;
        private System.Windows.Forms.TextBox paikanindeksi;
    }
}

