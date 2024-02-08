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

namespace ProjekApp.UC
{
    public partial class UC_sprawdz : UserControl
    {
        public UC_sprawdz()
        {
            InitializeComponent();
        }

        private void dokumenty_spr_Click(object sender, EventArgs e)
        {
            try
            {
                string marka = marka_spr.Text;
                if (marka == "")
                {
                    string query1 = "SELECT Marka, Model, Numer_rej, Numer_vin, Przegląd_data, Ubezpieczenie_data FROM Dokumenty_pojazdu INNER JOIN Pojazdy ON Dokumenty_pojazdu.id_dokument=Pojazdy.id_dokument;";
                    using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                    {
                        conn.Open();

                        using (SqlCommand search = new SqlCommand(query1, conn))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(search);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            adapter.Dispose();
                            data_spr.DataSource = dt;
                        }
                        conn.Close();
                    }
                }
                else
                {
                    string query = "SELECT Marka, Model, Numer_rej, Numer_vin, Przegląd_data, Ubezpieczenie_data FROM Dokumenty_pojazdu INNER JOIN Pojazdy ON Dokumenty_pojazdu.id_dokument=Pojazdy.id_dokument WHERE Marka = @war1;";
                    using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                    {
                        conn.Open();

                        using (SqlCommand search = new SqlCommand(query, conn))
                        {
                            search.Parameters.AddWithValue("@war1", marka);
                            SqlDataAdapter adapter = new SqlDataAdapter(search);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            adapter.Dispose();
                            data_spr.DataSource = dt;
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = string.Format("Błąd połączenia z bazą danych", ex.Message);
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rezerwacja_spr_Click(object sender, EventArgs e)
        {
            try
            {
                string rezerwacja = nrrez_spr.Text;
                if (rezerwacja == "")
                {
                    string query1 = "SELECT Marka, Model, nr_rezerwacji,data_pocz, data_konc, imie, nazwisko, nr_tel  FROM Wypozyczenia INNER JOIN Pojazdy ON Wypozyczenia.id_pojazd=Pojazdy.id_pojazd;";
                    using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                    {
                        conn.Open();

                        using (SqlCommand search = new SqlCommand(query1, conn))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(search);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            adapter.Dispose();
                            data_spr.DataSource = dt;
                        }
                        conn.Close();
                    }
                }
                else
                {
                    string query = "SELECT Marka, Model, nr_rezerwacji, data_pocz, data_konc, imie, nazwisko, nr_tel FROM Wypozyczenia INNER JOIN Pojazdy ON Wypozyczenia.id_pojazd=Pojazdy.id_pojazd WHERE nr_rezerwacji = @war2;";
                    using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                    {
                        conn.Open();

                        using (SqlCommand search = new SqlCommand(query, conn))
                        {
                            search.Parameters.AddWithValue("@war2", rezerwacja);
                            SqlDataAdapter adapter = new SqlDataAdapter(search);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            adapter.Dispose();
                            data_spr.DataSource = dt;
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                string error = string.Format("Błąd połączenia z bazą danych", ex.Message);
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
