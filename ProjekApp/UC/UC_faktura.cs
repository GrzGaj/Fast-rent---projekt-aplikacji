using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjekApp.UC
{
    public partial class UC_faktura : UserControl
    {
        public UC_faktura()
        {
            InitializeComponent();

            listaPlatnosc();
        }
        private void listaPlatnosc()
        {

            List<string> elementsPlatnosc = new List<string>
            {
                "Przelew",
                "Gotówka"
            };

            platnosc_fa.Items.AddRange(elementsPlatnosc.ToArray());
        }

        private void zapisz_fa_Click(object sender, EventArgs e)
        {
            string nazwa = nazwa_fa.Text;
            string adres = adres_fa.Text;
            string nip = nip_fa.Text;
            string platnosc = platnosc_fa.Text;
            string kwota = kwota_fa.Text;

            double.TryParse(kwota, out double vat);
            double podatek = vat * 0.23;
            double cost = vat + podatek;

            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFD.Title = "Wybierz miejsce do zapisu pliku";
            string exitText;

            Random random = new Random();
            int length = 5;
            string markBase = "0123456789";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int temp = random.Next(markBase.Length);
                sb.Append(markBase[temp]);
            }

            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;
            string shortDate = currentDate.ToShortDateString();
            DateTime plus14 = currentDate.AddDays(14);
            string shortDate14 = plus14.ToShortDateString();

            string faktura = "Faktura NR " + sb.ToString() + "R" + year.ToString();

            string exitPrzelew = 
                    "Data wystawienia: "+shortDate + "\n"+ 
                    "Termin płatności: "+shortDate14 + "\n"+
                    "Data sprzedaży: "+shortDate + "\n"+
                    "\n"+
                    faktura + "\n" +
                    "\n" +
                    "Sprzedawca:"+"\n"+
                    "Fast rent" + "\n" +
                    "Adres:"+"\n"+
                    "ul. Polna 16" + "\n" +
                    "35-011 Rzeszów" + "\n" +
                    "NIP: 123 564 87 22" + "\n" +
                    "\n" +
                    "Sposób płatności: "+platnosc + "\n" +
                    "Nazwa banku: Narodowy Bank Polski odział Rzeszów" + "\n" +
                    "Numer konta: Pl 87 1256 6531 0000 4895 2156 5588" + "\n" +
                    "\n" +
                    "Nabywca:" + "\n" +
                    nazwa + "\n" +
                    "Adres:"+ "\n" + 
                    adres + "\n" +
                    "NIP: "+nip + "\n" +
                    "\n" +
                    "Faktura za usługę wynajęcia pojazdu." + "\n" +
                    "\n" +
                    "Wartość netto: "+kwota +"zł"+ "\n" +
                    "VAT:"+podatek +"zł"+ "\n" +
                    "Razem do zapłaty: "+cost + "zł"+ "\n";

            string exitGotowka =
                    "Data wystawienia: " + shortDate + "\n" +
                    "Termin płatności: " + shortDate14 + "\n" +
                    "Data sprzedaży: " + shortDate + "\n" +
                    "\n" +
                    faktura + "\n" +
                    "\n" +
                    "Sprzedawca:" + "\n" +
                    "Fast rent" + "\n" +
                    "Adres:" + "\n" +
                    "ul. Polna 16" + "\n" +
                    "35-011 Rzeszów" + "\n" +
                    "NIP: 123 564 87 22" + "\n" +
                    "\n" +
                    "Sposób płatności: " + platnosc + "\n" +
                    "\n" +
                    "Nabywca:" + "\n" +
                    nazwa + "\n" +
                    "Adres:" + "\n" +
                    adres + "\n" +
                    "NIP: " + nip + "\n" +
                    "\n" +
                    "Faktura za usługę wynajęcia pojazdu." + "\n" +
                    "\n" +
                    "Wartość netto: " + kwota + "zł" + "\n" +
                    "VAT:" + podatek + "zł" + "\n" +
                    "Razem do zapłaty: " + cost + "zł" + "\n";

            if (platnosc == "Gotówka")
            {
                exitText = exitGotowka;
            }
            else
            {
                exitText = exitPrzelew;
            }


            saveFD.FileName = faktura;

            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string source = saveFD.FileName;


                string textIn = exitText;

                try
                {
                    File.WriteAllText(source, textIn);
                    MessageBox.Show("Dane zostały pomyślnie zapisane do pliku.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas zapisu do pliku: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
