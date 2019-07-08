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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

