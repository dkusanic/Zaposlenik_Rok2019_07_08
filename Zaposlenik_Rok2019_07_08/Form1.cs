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
    }
}
