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

namespace ProjekApp.UC
{
    public partial class UC_rezerwacja : UserControl
    {
        public UC_rezerwacja()
        {
            InitializeComponent();
        }

        private void b_spr_Click(object sender, EventArgs e)
        {
            try
            {
                string marka = marka_rez.Text;
                string poczatek = poczatek_rez.Text;
                string koniec = koniec_rez.Text;
                string query = "SELECT nr_rezerwacji,data_pocz,data_konc,Marka,Model FROM Wypozyczenia INNER JOIN Pojazdy ON Wypozyczenia.id_pojazd=Pojazdy.id_pojazd WHERE Marka = @wartosc1;";
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                {
                    conn.Open();

                    using (SqlCommand search = new SqlCommand(query, conn))
                    {
                        search.Parameters.AddWithValue("@wartosc1", marka);
                        search.Parameters.AddWithValue("@wartosc2", poczatek);
                        search.Parameters.AddWithValue("@wartosc3", koniec);
                        SqlDataAdapter adapter = new SqlDataAdapter(search);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        adapter.Dispose();
                        data_re.DataSource = dt;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                string error = string.Format("Błąd połączenia z bazą danych", ex.Message);
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rezerwuj_rez_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int length = 8;
                string markBase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                StringBuilder sb = new StringBuilder();
                for(int i = 0;i < length; i++)
                {
                    int temp = random.Next(markBase.Length);
                    sb.Append(markBase[temp]);
                }
                string rezerwacja = sb.ToString();

                string marka = marka_rez.Text;
                string model = model_rez.Text;
                string poczatek = poczatek_rez.Text;
                string koniec = koniec_rez.Text;
                string imie = imie_rez.Text;
                string nazwisko = nazwisko_rez.Text;
                string telefon = telefon_rez.Text;
                string query = "INSERT INTO Wypozyczenia (nr_rezerwacji, data_pocz, data_konc, imie, nazwisko, nr_tel, id_pojazd) VALUES (@war0, @war1, @war2, @war3, @war4, @war5, (SELECT id_pojazd FROM Pojazdy WHERE Marka = @war6 AND Model = @war7));";
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                {
                    conn.Open();

                    using (SqlCommand insert = new SqlCommand(query, conn))
                    {
                        insert.Parameters.AddWithValue("@war0", rezerwacja);
                        insert.Parameters.AddWithValue("@war1", poczatek);
                        insert.Parameters.AddWithValue("@war2", koniec);
                        insert.Parameters.AddWithValue("@war3", imie);
                        insert.Parameters.AddWithValue("@war4", nazwisko);
                        insert.Parameters.AddWithValue("@war5", telefon);
                        insert.Parameters.AddWithValue("@war6", marka);
                        insert.Parameters.AddWithValue("@war7", model);
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Rezerwacja numer: "+ rezerwacja +" została pomyślnie dodana do bazy danych.","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
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
