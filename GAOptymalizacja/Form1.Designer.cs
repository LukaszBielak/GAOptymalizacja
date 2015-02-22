namespace GAOptymalizacja
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
            this.dlugoscChromosomu = new System.Windows.Forms.TextBox();
            this.mutacjaProp = new System.Windows.Forms.TextBox();
            this.wielkośćPopulacji = new System.Windows.Forms.TextBox();
            this.krzyżowanieProp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Epoki = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.funkcja = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.X1Dif = new System.Windows.Forms.TextBox();
            this.X1Min = new System.Windows.Forms.TextBox();
            this.X1Max = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.X2Dif = new System.Windows.Forms.TextBox();
            this.X2Min = new System.Windows.Forms.TextBox();
            this.X2Max = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.oblicz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlugoscChromosomu
            // 
            this.dlugoscChromosomu.Enabled = false;
            this.dlugoscChromosomu.Location = new System.Drawing.Point(147, 12);
            this.dlugoscChromosomu.Name = "dlugoscChromosomu";
            this.dlugoscChromosomu.Size = new System.Drawing.Size(100, 20);
            this.dlugoscChromosomu.TabIndex = 0;
            // 
            // mutacjaProp
            // 
            this.mutacjaProp.Location = new System.Drawing.Point(147, 90);
            this.mutacjaProp.Name = "mutacjaProp";
            this.mutacjaProp.Size = new System.Drawing.Size(100, 20);
            this.mutacjaProp.TabIndex = 1;
            this.mutacjaProp.Text = "0.50";
            // 
            // wielkośćPopulacji
            // 
            this.wielkośćPopulacji.Location = new System.Drawing.Point(147, 38);
            this.wielkośćPopulacji.Name = "wielkośćPopulacji";
            this.wielkośćPopulacji.Size = new System.Drawing.Size(100, 20);
            this.wielkośćPopulacji.TabIndex = 2;
            this.wielkośćPopulacji.Text = "10";
            // 
            // krzyżowanieProp
            // 
            this.krzyżowanieProp.Location = new System.Drawing.Point(147, 64);
            this.krzyżowanieProp.Name = "krzyżowanieProp";
            this.krzyżowanieProp.Size = new System.Drawing.Size(100, 20);
            this.krzyżowanieProp.TabIndex = 3;
            this.krzyżowanieProp.Text = "0.25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Długość chromosomu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mutacja %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Krzyżowanie %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wielkość popoluacji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Epoki";
            // 
            // Epoki
            // 
            this.Epoki.Location = new System.Drawing.Point(147, 116);
            this.Epoki.Name = "Epoki";
            this.Epoki.Size = new System.Drawing.Size(100, 20);
            this.Epoki.TabIndex = 9;
            this.Epoki.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(59, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(633, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Algorytm genetyczny dla optymalizacji funkcji";
            // 
            // wynik
            // 
            this.wynik.Enabled = false;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(105, 493);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(500, 30);
            this.wynik.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.funkcja);
            this.groupBox1.Location = new System.Drawing.Point(530, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 47);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funckja do optymalizacji";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Funkcja";
            // 
            // funkcja
            // 
            this.funkcja.FormattingEnabled = true;
            this.funkcja.Items.AddRange(new object[] {
            "Rastrigin",
            "Michalewicz"});
            this.funkcja.Location = new System.Drawing.Point(126, 20);
            this.funkcja.Name = "funkcja";
            this.funkcja.Size = new System.Drawing.Size(121, 21);
            this.funkcja.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Wynik: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.X1Dif);
            this.groupBox2.Controls.Add(this.X1Min);
            this.groupBox2.Controls.Add(this.X1Max);
            this.groupBox2.Location = new System.Drawing.Point(530, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 102);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ograniczenia na osi X1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Przedział zmienności";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Dolne";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Górne";
            // 
            // X1Dif
            // 
            this.X1Dif.Enabled = false;
            this.X1Dif.Location = new System.Drawing.Point(147, 71);
            this.X1Dif.Name = "X1Dif";
            this.X1Dif.Size = new System.Drawing.Size(100, 20);
            this.X1Dif.TabIndex = 2;
            // 
            // X1Min
            // 
            this.X1Min.Location = new System.Drawing.Point(147, 45);
            this.X1Min.Name = "X1Min";
            this.X1Min.Size = new System.Drawing.Size(100, 20);
            this.X1Min.TabIndex = 1;
            this.X1Min.Text = "-3";
            // 
            // X1Max
            // 
            this.X1Max.Location = new System.Drawing.Point(147, 19);
            this.X1Max.Name = "X1Max";
            this.X1Max.Size = new System.Drawing.Size(100, 20);
            this.X1Max.TabIndex = 0;
            this.X1Max.Text = "12.1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.X2Dif);
            this.groupBox3.Controls.Add(this.X2Min);
            this.groupBox3.Controls.Add(this.X2Max);
            this.groupBox3.Location = new System.Drawing.Point(530, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 107);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ograniczenia a osi X2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Przedział zmienności";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Dolne";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Górne";
            // 
            // X2Dif
            // 
            this.X2Dif.Enabled = false;
            this.X2Dif.Location = new System.Drawing.Point(147, 74);
            this.X2Dif.Name = "X2Dif";
            this.X2Dif.Size = new System.Drawing.Size(100, 20);
            this.X2Dif.TabIndex = 2;
            // 
            // X2Min
            // 
            this.X2Min.Location = new System.Drawing.Point(147, 46);
            this.X2Min.Name = "X2Min";
            this.X2Min.Size = new System.Drawing.Size(100, 20);
            this.X2Min.TabIndex = 1;
            this.X2Min.Text = "4.1";
            // 
            // X2Max
            // 
            this.X2Max.Location = new System.Drawing.Point(147, 20);
            this.X2Max.Name = "X2Max";
            this.X2Max.Size = new System.Drawing.Size(100, 20);
            this.X2Max.TabIndex = 0;
            this.X2Max.Text = "5.8";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dlugoscChromosomu);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.wielkośćPopulacji);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.krzyżowanieProp);
            this.groupBox4.Controls.Add(this.Epoki);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.mutacjaProp);
            this.groupBox4.Location = new System.Drawing.Point(530, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 150);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parametry ewolucji";
            // 
            // plot1
            // 
            this.plot1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.plot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plot1.Location = new System.Drawing.Point(12, 66);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(500, 419);
            this.plot1.TabIndex = 0;
            this.plot1.Text = "plot1";
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // oblicz
            // 
            this.oblicz.Location = new System.Drawing.Point(639, 488);
            this.oblicz.Name = "oblicz";
            this.oblicz.Size = new System.Drawing.Size(100, 35);
            this.oblicz.TabIndex = 17;
            this.oblicz.Text = "Oblicz";
            this.oblicz.UseVisualStyleBackColor = true;
            this.oblicz.Click += new System.EventHandler(this.oblicz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 531);
            this.Controls.Add(this.oblicz);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.plot1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plot1;
        private System.Windows.Forms.TextBox dlugoscChromosomu;
        private System.Windows.Forms.TextBox mutacjaProp;
        private System.Windows.Forms.TextBox wielkośćPopulacji;
        private System.Windows.Forms.TextBox krzyżowanieProp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Epoki;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox funkcja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox X1Dif;
        private System.Windows.Forms.TextBox X1Min;
        private System.Windows.Forms.TextBox X1Max;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox X2Dif;
        private System.Windows.Forms.TextBox X2Min;
        private System.Windows.Forms.TextBox X2Max;
        private System.Windows.Forms.Button oblicz;
        
    }
}


