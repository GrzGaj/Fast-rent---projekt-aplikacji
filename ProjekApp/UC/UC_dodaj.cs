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
    public partial class UC_dodaj : UserControl
    {
        public UC_dodaj()
        {
            InitializeComponent();
        }

        private void dodaj_dokuemnt_do_Click(object sender, EventArgs e)
        {
            try
            {
                string numer_rej = nrrej_do.Text;
                string numer_vin = nrvin_do.Text;
                string przeglad = przeglad_do.Text;
                string ubezpieczenie = ubezpieczenie_do.Text;

                string query = "INSERT INTO Dokumenty_pojazdu (Numer_rej, Numer_vin, Przegląd_data, Ubezpieczenie_data) VALUES (@war1, @war2, @war3, @war4);";
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                {
                    conn.Open();

                    using (SqlCommand insert = new SqlCommand(query, conn))
                    {
                        insert.Parameters.AddWithValue("@war1", numer_rej);
                        insert.Parameters.AddWithValue("@war2", numer_vin);
                        insert.Parameters.AddWithValue("@war3", przeglad);
                        insert.Parameters.AddWithValue("@war4", ubezpieczenie);
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Dokumenty zostały pomyślnie dodana do bazy danych.","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dodaj_pojazd_do_Click(object sender, EventArgs e)
        {
            try
            {
                string numer_rej = nrrej_do.Text;
                string marka = marka_do.Text;
                string model = model_do.Text;
                string przebieg = przebieg_do.Text;
                string rok = rok_do.Text;
                string uwagi = uwagi_do.Text;

                string query = "INSERT INTO Pojazdy (Marka, Model, Przebieg, Rok_produkcji, Uwagi, id_dokument) VALUES (@war5, @war6, @war7, @war8, @war9,(SELECT id_dokument FROM Dokumenty_pojazdu WHERE Numer_rej= @war1)); ";
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                {
                    conn.Open();

                    using (SqlCommand insert = new SqlCommand(query, conn))
                    {
                        insert.Parameters.AddWithValue("@war1", numer_rej);
                        insert.Parameters.AddWithValue("@war5", marka);
                        insert.Parameters.AddWithValue("@war6", model);
                        insert.Parameters.AddWithValue("@war7", przebieg);
                        insert.Parameters.AddWithValue("@war8", rok);
                        insert.Parameters.AddWithValue("@war9", uwagi);
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Pojazd została pomyślnie dodana do bazy danych.","Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
