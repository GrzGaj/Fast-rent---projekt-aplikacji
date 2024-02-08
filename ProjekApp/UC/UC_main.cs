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
    public partial class UC_main : UserControl
    {
        public UC_main()
        {
            InitializeComponent();
        }

        private void show_sg_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Pojazdy;";
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Projekt_wypozyczalni;Integrated Security=True;"))
                {
                    conn.Open();

                    using (SqlCommand search = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(search);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        adapter.Dispose();
                        data_sg.DataSource = dt;
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
