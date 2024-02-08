namespace ProjekApp.UC
{
    partial class UC_rezerwacja
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            koniec_rez = new DateTimePicker();
            poczatek_rez = new DateTimePicker();
            label9 = new Label();
            data_re = new DataGridView();
            telefon_rez = new TextBox();
            imie_rez = new TextBox();
            model_rez = new TextBox();
            nazwisko_rez = new TextBox();
            marka_rez = new TextBox();
            rezerwuj_rez = new Guna.UI2.WinForms.Guna2Button();
            sprawdz_rez = new Guna.UI2.WinForms.Guna2Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_re).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(313, 3);
            label1.Name = "label1";
            label1.Size = new Size(173, 34);
            label1.TabIndex = 0;
            label1.Text = "Rezerwacja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 58);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 1;
            label2.Text = "Marka:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Controls.Add(koniec_rez);
            panel1.Controls.Add(poczatek_rez);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(data_re);
            panel1.Controls.Add(telefon_rez);
            panel1.Controls.Add(imie_rez);
            panel1.Controls.Add(model_rez);
            panel1.Controls.Add(nazwisko_rez);
            panel1.Controls.Add(marka_rez);
            panel1.Controls.Add(rezerwuj_rez);
            panel1.Controls.Add(sprawdz_rez);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 390);
            panel1.TabIndex = 2;
            // 
            // koniec_rez
            // 
            koniec_rez.CustomFormat = "yyyy-MM-dd";
            koniec_rez.Format = DateTimePickerFormat.Custom;
            koniec_rez.Location = new Point(131, 181);
            koniec_rez.Name = "koniec_rez";
            koniec_rez.Size = new Size(166, 29);
            koniec_rez.TabIndex = 20;
            // 
            // poczatek_rez
            // 
            poczatek_rez.CustomFormat = "yyyy-MM-dd";
            poczatek_rez.Format = DateTimePickerFormat.Custom;
            poczatek_rez.Location = new Point(131, 135);
            poczatek_rez.Name = "poczatek_rez";
            poczatek_rez.Size = new Size(166, 29);
            poczatek_rez.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.Location = new Point(118, 83);
            label9.Name = "label9";
            label9.Size = new Size(183, 16);
            label9.TabIndex = 18;
            label9.Text = "Podaj marke aby sprawdzić";
            // 
            // data_re
            // 
            data_re.BackgroundColor = Color.WhiteSmoke;
            data_re.BorderStyle = BorderStyle.None;
            data_re.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_re.Location = new Point(326, 61);
            data_re.Name = "data_re";
            data_re.Size = new Size(458, 310);
            data_re.TabIndex = 17;
            // 
            // telefon_rez
            // 
            telefon_rez.BackColor = Color.WhiteSmoke;
            telefon_rez.BorderStyle = BorderStyle.None;
            telefon_rez.Font = new Font("Arial", 12F, FontStyle.Bold);
            telefon_rez.Location = new Point(131, 307);
            telefon_rez.Name = "telefon_rez";
            telefon_rez.Size = new Size(166, 19);
            telefon_rez.TabIndex = 16;
            // 
            // imie_rez
            // 
            imie_rez.BackColor = Color.WhiteSmoke;
            imie_rez.BorderStyle = BorderStyle.None;
            imie_rez.Font = new Font("Arial", 12F, FontStyle.Bold);
            imie_rez.Location = new Point(131, 225);
            imie_rez.Name = "imie_rez";
            imie_rez.Size = new Size(166, 19);
            imie_rez.TabIndex = 15;
            // 
            // model_rez
            // 
            model_rez.BackColor = Color.WhiteSmoke;
            model_rez.BorderStyle = BorderStyle.None;
            model_rez.Font = new Font("Arial", 12F, FontStyle.Bold);
            model_rez.Location = new Point(131, 102);
            model_rez.Name = "model_rez";
            model_rez.Size = new Size(166, 19);
            model_rez.TabIndex = 12;
            // 
            // nazwisko_rez
            // 
            nazwisko_rez.BackColor = Color.WhiteSmoke;
            nazwisko_rez.BorderStyle = BorderStyle.None;
            nazwisko_rez.Font = new Font("Arial", 12F, FontStyle.Bold);
            nazwisko_rez.Location = new Point(131, 266);
            nazwisko_rez.Name = "nazwisko_rez";
            nazwisko_rez.Size = new Size(166, 19);
            nazwisko_rez.TabIndex = 11;
            // 
            // marka_rez
            // 
            marka_rez.BackColor = Color.WhiteSmoke;
            marka_rez.BorderStyle = BorderStyle.None;
            marka_rez.Font = new Font("Arial", 12F, FontStyle.Bold);
            marka_rez.Location = new Point(131, 61);
            marka_rez.Name = "marka_rez";
            marka_rez.Size = new Size(166, 19);
            marka_rez.TabIndex = 10;
            // 
            // rezerwuj_rez
            // 
            rezerwuj_rez.CustomizableEdges = customizableEdges1;
            rezerwuj_rez.DisabledState.BorderColor = Color.DarkGray;
            rezerwuj_rez.DisabledState.CustomBorderColor = Color.DarkGray;
            rezerwuj_rez.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            rezerwuj_rez.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            rezerwuj_rez.FillColor = Color.WhiteSmoke;
            rezerwuj_rez.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            rezerwuj_rez.ForeColor = Color.Black;
            rezerwuj_rez.Location = new Point(180, 343);
            rezerwuj_rez.Name = "rezerwuj_rez";
            rezerwuj_rez.ShadowDecoration.CustomizableEdges = customizableEdges2;
            rezerwuj_rez.Size = new Size(117, 28);
            rezerwuj_rez.TabIndex = 9;
            rezerwuj_rez.Text = "Rezerwuj";
            rezerwuj_rez.Click += rezerwuj_rez_Click;
            // 
            // sprawdz_rez
            // 
            sprawdz_rez.CustomizableEdges = customizableEdges3;
            sprawdz_rez.DisabledState.BorderColor = Color.DarkGray;
            sprawdz_rez.DisabledState.CustomBorderColor = Color.DarkGray;
            sprawdz_rez.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sprawdz_rez.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sprawdz_rez.FillColor = Color.WhiteSmoke;
            sprawdz_rez.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            sprawdz_rez.ForeColor = Color.Black;
            sprawdz_rez.Location = new Point(38, 343);
            sprawdz_rez.Name = "sprawdz_rez";
            sprawdz_rez.ShadowDecoration.CustomizableEdges = customizableEdges4;
            sprawdz_rez.Size = new Size(115, 28);
            sprawdz_rez.TabIndex = 8;
            sprawdz_rez.Text = "Sprawdź";
            sprawdz_rez.Click += b_spr_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 304);
            label8.Name = "label8";
            label8.Size = new Size(86, 22);
            label8.TabIndex = 7;
            label8.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 222);
            label7.Name = "label7";
            label7.Size = new Size(55, 22);
            label7.TabIndex = 6;
            label7.Text = "Imię:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 263);
            label6.Name = "label6";
            label6.Size = new Size(105, 22);
            label6.TabIndex = 5;
            label6.Text = "Nazwisko:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 181);
            label5.Name = "label5";
            label5.Size = new Size(82, 22);
            label5.TabIndex = 4;
            label5.Text = "Koniec:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 140);
            label4.Name = "label4";
            label4.Size = new Size(102, 22);
            label4.TabIndex = 3;
            label4.Text = "Początek:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 99);
            label3.Name = "label3";
            label3.Size = new Size(74, 22);
            label3.TabIndex = 2;
            label3.Text = "Model:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(57, 54, 70);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 40);
            panel2.TabIndex = 3;
            // 
            // UC_rezerwacja
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Name = "UC_rezerwacja";
            Size = new Size(804, 390);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_re).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button sprawdz_rez;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button rezerwuj_rez;
        private TextBox telefon_rez;
        private TextBox imie_rez;
        private TextBox model_rez;
        private TextBox nazwisko_rez;
        private TextBox marka_rez;
        private DataGridView data_re;
        private Label label9;
        private DateTimePicker poczatek_rez;
        private DateTimePicker koniec_rez;
    }
}
