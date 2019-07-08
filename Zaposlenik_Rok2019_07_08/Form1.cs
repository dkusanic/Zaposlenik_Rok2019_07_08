using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaposlenik_Rok2019_07_08
{
    public partial class Form1 : Form
    {
        List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            if (txtBoxPrvaPlaca.Text.Equals(""))
            {
                Zaposlenik novi = new Zaposlenik(txtBoxImePrezime.Text);
                listaZaposlenika.Add(novi);
            }
            else
            {
                Zaposlenik novi = new Zaposlenik(txtBoxImePrezime.Text, double.Parse(txtBoxPrvaPlaca.Text));
                listaZaposlenika.Add(novi);
            }
            txtBoxImePrezime.Clear();
            txtBoxPrvaPlaca.Clear();
            OsvjeziPrikaz();
        }
        private void OsvjeziPrikaz()
        {
            lstBoxZaposlenici.Items.Clear();
            foreach (Zaposlenik z in listaZaposlenika)
                lstBoxZaposlenici.Items.Add(z.ImePrezime);
        }
        private void OsvjeziPrikaz(string odabrani)
        {
            lstBoxMjesecnePlace.Items.Clear();
            foreach(Zaposlenik z in listaZaposlenika)
            {
                if (lstBoxZaposlenici.SelectedItem.ToString() == z.ImePrezime)
                {
                    foreach (double placa in z.MjesecnePlace)
                        lstBoxMjesecnePlace.Items.Add(placa);
                }
                    
            }
        }

        private void lstBoxZaposlenici_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Zaposlenik z in listaZaposlenika)
            {
                if(lstBoxZaposlenici.SelectedItem.ToString() == z.ImePrezime)
                    txtBoxProsjecnaPlaca.Text = z.IzracunajProsjecnuPlacu().ToString();
            }
            OsvjeziPrikaz(lstBoxZaposlenici.SelectedItem.ToString());
        }

        private void btnDodajPlacu_Click(object sender, EventArgs e)
        {
            if (lstBoxZaposlenici.SelectedItem == null)
                MessageBox.Show("Nije odabran zaposlenik!");
            else
            {
                foreach (Zaposlenik z in listaZaposlenika)
                {
                    if (lstBoxZaposlenici.SelectedItem.ToString() == z.ImePrezime)
                        z.DodajPlacu(double.Parse(txtBoxDodajPlacu.Text));
                }
            }
            OsvjeziPrikaz(lstBoxZaposlenici.SelectedItem.ToString());
            foreach (Zaposlenik z in listaZaposlenika)
            {
                if (lstBoxZaposlenici.SelectedItem.ToString() == z.ImePrezime)
                    txtBoxProsjecnaPlaca.Text = z.IzracunajProsjecnuPlacu().ToString();
            }
        }

        private void txtBoxTraziIme_TextChanged(object sender, EventArgs e)
        {
            List<Zaposlenik> traziIme = new List<Zaposlenik>();
            if (txtBoxTraziIme.Text == "")
                OsvjeziPrikaz();
            else
            {
                lstBoxZaposlenici.Items.Clear();
                foreach(Zaposlenik z in listaZaposlenika)
                {
                    if (z.ImePrezime.Contains(txtBoxTraziIme.Text))
                        traziIme.Add(z);
                }
                foreach (Zaposlenik z in traziIme)
                    lstBoxZaposlenici.Items.Add(z.ImePrezime);
            }
        }

        private void txtBoxTraziPlacaMin_TextChanged(object sender, EventArgs e)
        {
            List<Zaposlenik> traziMin = new List<Zaposlenik>();
            if (txtBoxTraziPlacaMin.Text == "")
                OsvjeziPrikaz();
            else
            {
                lstBoxZaposlenici.Items.Clear();
                foreach(Zaposlenik z in listaZaposlenika)
                {
                    bool vecaPlaca = false;
                    foreach (double placa in z.MjesecnePlace)
                    {
                        if (placa > double.Parse(txtBoxTraziPlacaMin.Text))
                            vecaPlaca = true;
                    }
                    if (vecaPlaca)
                        traziMin.Add(z);
                }
                foreach (Zaposlenik z in traziMin)
                    lstBoxZaposlenici.Items.Add(z.ImePrezime);
            }
        }

        private void txtBoxPlacaTraziMax_TextChanged(object sender, EventArgs e)
        {
            List<Zaposlenik> traziMax = new List<Zaposlenik>();
            if (txtBoxPlacaTraziMax.Text == "")
                OsvjeziPrikaz();
            else
            {
                lstBoxZaposlenici.Items.Clear();
                foreach (Zaposlenik z in listaZaposlenika)
                {
                    bool manjaPlaca = false;
                    foreach (double placa in z.MjesecnePlace)
                    {
                        if (placa > double.Parse(txtBoxPlacaTraziMax.Text))
                            manjaPlaca = true;
                    }
                    if (manjaPlaca)
                        traziMax.Add(z);
                }
                foreach (Zaposlenik z in traziMax)
                    lstBoxZaposlenici.Items.Add(z.ImePrezime);
            }
        }
    }
}
