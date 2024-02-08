using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Security.Cryptography.X509Certificates;

namespace ProjekApp.UC
{
    public partial class UC_stworz : UserControl
    {
        public UC_stworz()
        {
            InitializeComponent();
        }

        private void wydanie_st_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFD.Title = "Wybierz miejsce do zapisu pliku";

            string exitText;
            string nr_vin = "";
            string nr_rezerwacji = nrrez_st.Text;
            string przebieg = przebieg_st.Text;
            string imie = imie_st.Text;
            string nazwisko = nazwisko_st.Text;
            string nr_dowodu = nrdow_st.Text;

            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;
            string shortDate = currentDate.ToShortDateString();
            string name = "WYD " + nr_rezerwacji + "R" + year;

            try
            {

                string query = "SELECT Numer_vin FROM Dokumenty_pojazdu WHERE id_dokument=(SELECT id_dokument FROM Pojazdy WHERE id_pojazd=(SELECT id_pojazd FROM Wypozyczenia WHERE nr_rezerwacji=@war1));";
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                {
                    conn.Open();

                    using (SqlCommand search = new SqlCommand(query, conn))
                    {
                        search.Parameters.AddWithValue("@war1", nr_rezerwacji);

                        object wynik = search.ExecuteScalar();
                        nr_vin = wynik.ToString();

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                string error = string.Format("Błąd połączenia z bazą danych", ex.Message);
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            exitText =
                "Data wydania: " + shortDate + "\n" +
                "\n" +
                "Dokument potwierdzający wydanie pojazdu o numerze VIN: " + nr_vin + "\n" +
                "na podstawie rezerwacji numer: " + nr_rezerwacji + "." + "\n" +
                "Pojazd jest wydawany w pełni zatankowany oraz posiada przebieg " + przebieg + "km" + "\n" +
                "\n" +
                "Osoba odbierająca pojazd:" + "\n" +
                "Imię: " + imie + "\n" +
                "Nazwisko: " + nazwisko + "\n" +
                "Numer dowodu: " + nr_dowodu + "\n"
                ;

            saveFD.FileName = name;

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

        private void odbior_st_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFD.Title = "Wybierz miejsce do zapisu pliku";

            string exitText;
            string nr_vin = "";
            string nr_rezerwacji = nrrez_st.Text;
            string przebieg = przebieg_st.Text;
            string imie = imie_st.Text;
            string nazwisko = nazwisko_st.Text;
            string nr_dowodu = nrdow_st.Text;

            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;
            string shortDate = currentDate.ToShortDateString();
            string name = "ZWR " + nr_rezerwacji + "R" + year;

            try
            {

                string query = "SELECT Numer_vin FROM Dokumenty_pojazdu WHERE id_dokument=(SELECT id_dokument FROM Pojazdy WHERE id_pojazd=(SELECT id_pojazd FROM Wypozyczenia WHERE nr_rezerwacji=@war1));";
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                {
                    conn.Open();

                    using (SqlCommand search = new SqlCommand(query, conn))
                    {
                        search.Parameters.AddWithValue("@war1", nr_rezerwacji);

                        object wynik = search.ExecuteScalar();
                        nr_vin = wynik.ToString();

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                string error = string.Format("Błąd połączenia z bazą danych", ex.Message);
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            exitText =
                "Data zwrotu: " + shortDate + "\n" +
                "\n" +
                "Dokument potwierdzający zwrócenie pojazdu o numerze VIN: " + nr_vin + "\n" +
                "na podstawie rezerwacji numer: " + nr_rezerwacji + "." + "\n" +
                "Pojazd jest zwracany w pełni zatankowany oraz posiada przebieg " + przebieg + "km" + "\n" +
                "\n" +
                "Osoba oddająca pojazd:" + "\n" +
                "Imię: " + imie + "\n" +
                "Nazwisko: " + nazwisko + "\n" +
                "Numer dowodu: " + nr_dowodu + "\n"
                ;

            saveFD.FileName = name;

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

        private void uwagi_st_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFD.Title = "Wybierz miejsce do zapisu pliku";

            string exitText;
            string nr_vin = "";
            string krotki = krotki_st.Text;
            string kwota = kwota_st.Text;
            string pelny = pelny_st.Text;
            string nr_rezerwacji = nrrez_st.Text;
            string imie = imie_st.Text;
            string nazwisko = nazwisko_st.Text;
            string nr_dowodu = nrdow_st.Text;

            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;
            string shortDate = currentDate.ToShortDateString();

            string name = krotki+" - " + nr_rezerwacji + "R" + year;

            try
            {

                string query = "SELECT Numer_vin FROM Dokumenty_pojazdu WHERE id_dokument=(SELECT id_dokument FROM Pojazdy WHERE id_pojazd=(SELECT id_pojazd FROM Wypozyczenia WHERE nr_rezerwacji=@war1));";
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                {
                    conn.Open();

                    using (SqlCommand search = new SqlCommand(query, conn))
                    {
                        search.Parameters.AddWithValue("@war1", nr_rezerwacji);

                        object wynik = search.ExecuteScalar();
                        nr_vin = wynik.ToString();

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                string error = string.Format("Błąd połączenia z bazą danych", ex.Message);
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            exitText =
                "Data: " + shortDate + "\n" +
                "\n" +
                "Pojazd o numerze VIN: "+nr_vin +" wynajmowany na podstawie rezerwacji o numerze: "+ nr_rezerwacji+ "\n" +
                "został uszkodzony przez:"+"\n" +
                "Imię: " + imie + "\n" +
                "Nazwisko: " + nazwisko + "\n" +
                "Numer dowodu: " + nr_dowodu + "\n"+
                "\n" +
                "Opis uszkodzeń:" + "\n" +
                pelny + "\n" +
                "\n" +
                "Uszkodzenia wyceniono na kwotę: "+kwota+" zł."
                ;

            saveFD.FileName = name;

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
