namespace Zaposlenik_Rok2019_07_08
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBoxZaposlenici = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBoxMjesecnePlace = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxImePrezime = new System.Windows.Forms.TextBox();
            this.txtBoxPrvaPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajZaposlenika = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxProsjecnaPlaca = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDodajPlacu = new System.Windows.Forms.TextBox();
            this.btnDodajPlacu = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxTraziIme = new System.Windows.Forms.TextBox();
            this.txtBoxTraziPlacaMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxPlacaTraziMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxProsjecnaPlaca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstBoxMjesecnePlace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstBoxZaposlenici);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz zaposlenika:";
            // 
            // lstBoxZaposlenici
            // 
            this.lstBoxZaposlenici.FormattingEnabled = true;
            this.lstBoxZaposlenici.Location = new System.Drawing.Point(6, 36);
            this.lstBoxZaposlenici.Name = "lstBoxZaposlenici";
            this.lstBoxZaposlenici.Size = new System.Drawing.Size(118, 212);
            this.lstBoxZaposlenici.TabIndex = 0;
            this.lstBoxZaposlenici.SelectedIndexChanged += new System.EventHandler(this.lstBoxZaposlenici_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zaposlenici:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mjesečne plaće:";
            // 
            // lstBoxMjesecnePlace
            // 
            this.lstBoxMjesecnePlace.FormattingEnabled = true;
            this.lstBoxMjesecnePlace.Location = new System.Drawing.Point(130, 36);
            this.lstBoxMjesecnePlace.Name = "lstBoxMjesecnePlace";
            this.lstBoxMjesecnePlace.Size = new System.Drawing.Size(118, 212);
            this.lstBoxMjesecnePlace.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajZaposlenika);
            this.groupBox2.Controls.Add(this.txtBoxPrvaPlaca);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBoxImePrezime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(277, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodavanje zaposlenika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ime i prezime:";
            // 
            // txtBoxImePrezime
            // 
            this.txtBoxImePrezime.Location = new System.Drawing.Point(83, 13);
            this.txtBoxImePrezime.Name = "txtBoxImePrezime";
            this.txtBoxImePrezime.Size = new System.Drawing.Size(190, 20);
            this.txtBoxImePrezime.TabIndex = 1;
            // 
            // txtBoxPrvaPlaca
            // 
            this.txtBoxPrvaPlaca.Location = new System.Drawing.Point(83, 42);
            this.txtBoxPrvaPlaca.Name = "txtBoxPrvaPlaca";
            this.txtBoxPrvaPlaca.Size = new System.Drawing.Size(190, 20);
            this.txtBoxPrvaPlaca.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prva plaća:";
            // 
            // btnDodajZaposlenika
            // 
            this.btnDodajZaposlenika.Location = new System.Drawing.Point(9, 68);
            this.btnDodajZaposlenika.Name = "btnDodajZaposlenika";
            this.btnDodajZaposlenika.Size = new System.Drawing.Size(264, 23);
            this.btnDodajZaposlenika.TabIndex = 4;
            this.btnDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.btnDodajZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenika.Click += new System.EventHandler(this.btnDodajZaposlenika_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prosječna plaća:";
            // 
            // txtBoxProsjecnaPlaca
            // 
            this.txtBoxProsjecnaPlaca.Location = new System.Drawing.Point(98, 258);
            this.txtBoxProsjecnaPlaca.Name = "txtBoxProsjecnaPlaca";
            this.txtBoxProsjecnaPlaca.Size = new System.Drawing.Size(150, 20);
            this.txtBoxProsjecnaPlaca.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDodajPlacu);
            this.groupBox3.Controls.Add(this.txtBoxDodajPlacu);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(277, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dodavanje plaće:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Iznos plaće:";
            // 
            // txtBoxDodajPlacu
            // 
            this.txtBoxDodajPlacu.Location = new System.Drawing.Point(83, 13);
            this.txtBoxDodajPlacu.Name = "txtBoxDodajPlacu";
            this.txtBoxDodajPlacu.Size = new System.Drawing.Size(190, 20);
            this.txtBoxDodajPlacu.TabIndex = 1;
            // 
            // btnDodajPlacu
            // 
            this.btnDodajPlacu.Location = new System.Drawing.Point(9, 39);
            this.btnDodajPlacu.Name = "btnDodajPlacu";
            this.btnDodajPlacu.Size = new System.Drawing.Size(264, 23);
            this.btnDodajPlacu.TabIndex = 2;
            this.btnDodajPlacu.Text = "Dodaj plaću";
            this.btnDodajPlacu.UseVisualStyleBackColor = true;
            this.btnDodajPlacu.Click += new System.EventHandler(this.btnDodajPlacu_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBoxPlacaTraziMax);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtBoxTraziPlacaMin);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtBoxTraziIme);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(277, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 104);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pretraživanje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Po imenu:";
            // 
            // txtBoxTraziIme
            // 
            this.txtBoxTraziIme.Location = new System.Drawing.Point(83, 13);
            this.txtBoxTraziIme.Name = "txtBoxTraziIme";
            this.txtBoxTraziIme.Size = new System.Drawing.Size(190, 20);
            this.txtBoxTraziIme.TabIndex = 1;
            this.txtBoxTraziIme.TextChanged += new System.EventHandler(this.txtBoxTraziIme_TextChanged);
            // 
            // txtBoxTraziPlacaMin
            // 
            this.txtBoxTraziPlacaMin.Location = new System.Drawing.Point(83, 41);
            this.txtBoxTraziPlacaMin.Name = "txtBoxTraziPlacaMin";
            this.txtBoxTraziPlacaMin.Size = new System.Drawing.Size(190, 20);
            this.txtBoxTraziPlacaMin.TabIndex = 3;
            this.txtBoxTraziPlacaMin.TextChanged += new System.EventHandler(this.txtBoxTraziPlacaMin_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Plaća (min):";
            // 
            // txtBoxPlacaTraziMax
            // 
            this.txtBoxPlacaTraziMax.Location = new System.Drawing.Point(83, 71);
            this.txtBoxPlacaTraziMax.Name = "txtBoxPlacaTraziMax";
            this.txtBoxPlacaTraziMax.Size = new System.Drawing.Size(190, 20);
            this.txtBoxPlacaTraziMax.TabIndex = 5;
            this.txtBoxPlacaTraziMax.TextChanged += new System.EventHandler(this.txtBoxPlacaTraziMax_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Plaća (max):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 313);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenici";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxMjesecnePlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxZaposlenici;
        private System.Windows.Forms.TextBox txtBoxProsjecnaPlaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajZaposlenika;
        private System.Windows.Forms.TextBox txtBoxPrvaPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxImePrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDodajPlacu;
        private System.Windows.Forms.TextBox txtBoxDodajPlacu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoxPlacaTraziMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxTraziPlacaMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxTraziIme;
        private System.Windows.Forms.Label label7;
    }
}

