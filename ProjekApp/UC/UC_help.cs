using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekApp.UC
{
    public partial class UC_help : UserControl
    {
        public UC_help()
        {
            InitializeComponent();
        }

        private void rezerwacja_po_Click(object sender, EventArgs e)
        {
            string exitText =
                "1.Sprawdź" + "\n" +
                "Wpisujemy w pole 'Marka' marke pojazdu którego rezerwacje chcemy sprawdzić." + "\n" +
                "2.Rezerwuj" + "\n" +
                "Uzupełniemy wszystkie pola odpowiednimi danymi." + "\n" +
                "Po naciścięciu przycisku 'Rezerwuj' wyświetli nam się komunikat z numerem rezerwacji."
                ;
            MessageBox.Show(exitText, "Pomoc rezerwacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void faktura_po_Click(object sender, EventArgs e)
        {
            string exitText =
                "1.Zapisz" + "\n" +
                "Wpisujemy w pola odpowiednie dane klikamy przycisk 'Zapisz'," + "\n" +
                "następnie program nas poprosi o wybranie lokalizacji gdzie zapiszemy plik." + "\n"
                ;
            MessageBox.Show(exitText, "Pomoc faktura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dodaj_po_Click(object sender, EventArgs e)
        {
            string exitText =
                "1.Dodaj" + "\n" +
                "W pierwszej kolejności podajemy dane dotyczące dokumentów pojazdu i samego pojazdu," + "\n" +
                "następnie zatwierdzamy przyciskiem 'Dodaj dokument'," + "\n" +
                "a na samym końcu naciskamy przycisk 'Dodaj pojazd'."
                ;
            MessageBox.Show(exitText, "Pomoc dodaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sprawdz_po_Click(object sender, EventArgs e)
        {
            string exitText =
                "1.Sprawdź dokumenty" + "\n" +
                "Możemy wyświetlić wszystkie rekord poprzez kliknięcie przycisku 'Sprawdź dokumenty' lub" + "\n" +
                "podając markę wyświetli nam rekordy dotyczące konkretnej marki." + "\n" +
                "2.Sprawdź rezerwacje" + "\n" +
                "Dokładnie tak samo należy postępować jak w powyższym." + "\n"
                ;
            MessageBox.Show(exitText, "Pomoc sprawdź", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void stworz_po_Click(object sender, EventArgs e)
        {
            string exitText =
                "1.Wydanie" + "\n" +
                "Podajemy dane do pól po lewej stronie, następnie klikamy przycisk 'Wydanie'," + "\n" +
                "wyświetli nam się okno, w którym wybieramy miejsce zapisu pliku." + "\n" +
                "2.Zwrot" + "\n" +
                "Dokładnie tak samo należy postępować jak w powyższym." + "\n" +
                "3.Zapisz uwagi" + "\n" +
                "Podajemy wszystkie dane oprócz przebiegu pojazdu," + "\n" +
                "następnie klikamy przycisk 'Zapisz uwagi'" + "\n" +
                "i wybieramy miejsce zapisu pliku."
                ;
            MessageBox.Show(exitText, "Pomoc stwórz", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void save_po_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFD.Title = "Wybierz miejsce do zapisu pliku";

            
            string name = "Pomoc do aplikacji.";

            string exitText =
                "--- Rezerwacja ---" + "\n" +
                "1.Sprawdź" + "\n" +
                "Wpisujemy w pole 'Marka' marke pojazdu którego rezerwacje chcemy sprawdzić." + "\n" +
                "2.Rezerwuj" + "\n" +
                "Uzupełniemy wszystkie pola odpowiednimi danymi." + "\n" +
                "Po naciścięciu przycisku 'Rezerwuj' wyświetli nam się komunikat z numerem rezerwacji." + "\n" +
                 "\n" +
                "--- Faktura ---" + "\n" +
                "1.Zapisz" + "\n" +
                "Wpisujemy w pola odpowiednie dane klikamy przycisk 'Zapisz'," + "\n" +
                "następnie program nas poprosi o wybranie lokalizacji gdzie zapiszemy plik." + "\n"+
                "\n" +
                "--- Dodaj ---" + "\n" +
                "1.Dodaj" + "\n" +
                "W pierwszej kolejności podajemy dane dotyczące dokumentów pojazdu i samego pojazdu," + "\n" +
                "następnie zatwierdzamy przyciskiem 'Dodaj dokument'," + "\n" +
                "a na samym końcu naciskamy przycisk 'Dodaj pojazd'." + "\n" +
                "\n" +
                "--- Sprawdź ---" + "\n" +
                "1.Sprawdź dokumenty" + "\n" +
                "Możemy wyświetlić wszystkie rekord poprzez kliknięcie przycisku 'Sprawdź dokumenty' lub" + "\n" +
                "podając markę wyświetli nam rekordy dotyczące konkretnej marki." + "\n" +
                "2.Sprawdź rezerwacje" + "\n" +
                "Dokładnie tak samo należy postępować jak w powyższym." + "\n"+
                "\n" +
                "--- Stworz ---" + "\n" +
                "1.Wydanie" + "\n" +
                "Podajemy dane do pól po lewej stronie, następnie klikamy przycisk 'Wydanie'," + "\n" +
                "wyświetli nam się okno, w którym wybieramy miejsce zapisu pliku." + "\n" +
                "2.Zwrot" + "\n" +
                "Dokładnie tak samo należy postępować jak w powyższym." + "\n" +
                "3.Zapisz uwagi" + "\n" +
                "Podajemy wszystkie dane oprócz przebiegu pojazdu," + "\n" +
                "następnie klikamy przycisk 'Zapisz uwagi'" + "\n" +
                "i wybieramy miejsce zapisu pliku."
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
