using ProjekApp.UC;

namespace ProjekApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UC_main uc = new UC_main();
            addUC(uc);
        }

        private void addUC(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            main_panel.Controls.Clear();
            main_panel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void button_rezerwacja_Click(object sender, EventArgs e)
        {
            UC_rezerwacja uc = new UC_rezerwacja();
            addUC(uc);
        }

        private void button_faktura_Click(object sender, EventArgs e)
        {
            UC_faktura uc = new UC_faktura();
            addUC(uc);
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            UC_dodaj uc = new UC_dodaj();
            addUC(uc);
        }

        private void button_sprawdz_Click(object sender, EventArgs e)
        {
            UC_sprawdz uc = new UC_sprawdz();
            addUC(uc);
        }

        private void button_stworz_Click(object sender, EventArgs e)
        {
            UC_stworz uc = new UC_stworz();
            addUC(uc);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_main uc = new UC_main();
            addUC(uc);
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            UC_help uc = new UC_help();
            addUC(uc);
        }
    }
}
