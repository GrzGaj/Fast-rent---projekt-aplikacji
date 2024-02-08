namespace ProjekApp.UC
{
    partial class UC_dodaj
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
            panel1 = new Panel();
            panel2 = new Panel();
            label12 = new Label();
            label11 = new Label();
            dodaj_dokuemnt_do = new Guna.UI2.WinForms.Guna2Button();
            dodaj_pojazd_do = new Guna.UI2.WinForms.Guna2Button();
            uwagi_do = new TextBox();
            rok_do = new TextBox();
            przebieg_do = new TextBox();
            model_do = new TextBox();
            marka_do = new TextBox();
            nrrej_do = new TextBox();
            nrvin_do = new TextBox();
            przeglad_do = new DateTimePicker();
            ubezpieczenie_do = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(354, 3);
            label1.Name = "label1";
            label1.Size = new Size(96, 34);
            label1.TabIndex = 0;
            label1.Text = "Dodaj";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 54, 70);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 40);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dodaj_dokuemnt_do);
            panel2.Controls.Add(dodaj_pojazd_do);
            panel2.Controls.Add(uwagi_do);
            panel2.Controls.Add(rok_do);
            panel2.Controls.Add(przebieg_do);
            panel2.Controls.Add(model_do);
            panel2.Controls.Add(marka_do);
            panel2.Controls.Add(nrrej_do);
            panel2.Controls.Add(nrvin_do);
            panel2.Controls.Add(przeglad_do);
            panel2.Controls.Add(ubezpieczenie_do);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 350);
            panel2.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(396, 10);
            label12.Name = "label12";
            label12.Size = new Size(217, 22);
            label12.TabIndex = 22;
            label12.Text = "2.Dodaj dane pojazdu:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(57, 10);
            label11.Name = "label11";
            label11.Size = new Size(275, 22);
            label11.TabIndex = 21;
            label11.Text = "1.Dodaj dokumenty pojazdu:";
            // 
            // dodaj_dokuemnt_do
            // 
            dodaj_dokuemnt_do.CustomizableEdges = customizableEdges1;
            dodaj_dokuemnt_do.DisabledState.BorderColor = Color.DarkGray;
            dodaj_dokuemnt_do.DisabledState.CustomBorderColor = Color.DarkGray;
            dodaj_dokuemnt_do.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dodaj_dokuemnt_do.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dodaj_dokuemnt_do.FillColor = Color.WhiteSmoke;
            dodaj_dokuemnt_do.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dodaj_dokuemnt_do.ForeColor = Color.Black;
            dodaj_dokuemnt_do.Location = new Point(292, 256);
            dodaj_dokuemnt_do.Name = "dodaj_dokuemnt_do";
            dodaj_dokuemnt_do.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dodaj_dokuemnt_do.Size = new Size(158, 55);
            dodaj_dokuemnt_do.TabIndex = 20;
            dodaj_dokuemnt_do.Text = "Dodaj dokument";
            dodaj_dokuemnt_do.Click += dodaj_dokuemnt_do_Click;
            // 
            // dodaj_pojazd_do
            // 
            dodaj_pojazd_do.CustomizableEdges = customizableEdges3;
            dodaj_pojazd_do.DisabledState.BorderColor = Color.DarkGray;
            dodaj_pojazd_do.DisabledState.CustomBorderColor = Color.DarkGray;
            dodaj_pojazd_do.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dodaj_pojazd_do.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dodaj_pojazd_do.FillColor = Color.WhiteSmoke;
            dodaj_pojazd_do.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dodaj_pojazd_do.ForeColor = Color.Black;
            dodaj_pojazd_do.Location = new Point(626, 256);
            dodaj_pojazd_do.Name = "dodaj_pojazd_do";
            dodaj_pojazd_do.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dodaj_pojazd_do.Size = new Size(158, 55);
            dodaj_pojazd_do.TabIndex = 19;
            dodaj_pojazd_do.Text = "Dodaj pojazd";
            dodaj_pojazd_do.Click += dodaj_pojazd_do_Click;
            // 
            // uwagi_do
            // 
            uwagi_do.BorderStyle = BorderStyle.None;
            uwagi_do.Font = new Font("Arial", 12F, FontStyle.Bold);
            uwagi_do.Location = new Point(498, 217);
            uwagi_do.Name = "uwagi_do";
            uwagi_do.Size = new Size(145, 19);
            uwagi_do.TabIndex = 18;
            // 
            // rok_do
            // 
            rok_do.BorderStyle = BorderStyle.None;
            rok_do.Font = new Font("Arial", 12F, FontStyle.Bold);
            rok_do.Location = new Point(498, 175);
            rok_do.Name = "rok_do";
            rok_do.Size = new Size(145, 19);
            rok_do.TabIndex = 17;
            // 
            // przebieg_do
            // 
            przebieg_do.BorderStyle = BorderStyle.None;
            przebieg_do.Font = new Font("Arial", 12F, FontStyle.Bold);
            przebieg_do.Location = new Point(498, 133);
            przebieg_do.Name = "przebieg_do";
            przebieg_do.Size = new Size(145, 19);
            przebieg_do.TabIndex = 16;
            // 
            // model_do
            // 
            model_do.BorderStyle = BorderStyle.None;
            model_do.Font = new Font("Arial", 12F, FontStyle.Bold);
            model_do.Location = new Point(498, 91);
            model_do.Name = "model_do";
            model_do.Size = new Size(145, 19);
            model_do.TabIndex = 15;
            // 
            // marka_do
            // 
            marka_do.BorderStyle = BorderStyle.None;
            marka_do.Font = new Font("Arial", 12F, FontStyle.Bold);
            marka_do.Location = new Point(498, 49);
            marka_do.Name = "marka_do";
            marka_do.Size = new Size(145, 19);
            marka_do.TabIndex = 14;
            // 
            // nrrej_do
            // 
            nrrej_do.BorderStyle = BorderStyle.None;
            nrrej_do.Font = new Font("Arial", 12F, FontStyle.Bold);
            nrrej_do.Location = new Point(187, 49);
            nrrej_do.Name = "nrrej_do";
            nrrej_do.Size = new Size(145, 19);
            nrrej_do.TabIndex = 13;
            // 
            // nrvin_do
            // 
            nrvin_do.BorderStyle = BorderStyle.None;
            nrvin_do.Font = new Font("Arial", 12F, FontStyle.Bold);
            nrvin_do.Location = new Point(187, 106);
            nrvin_do.Name = "nrvin_do";
            nrvin_do.Size = new Size(145, 19);
            nrvin_do.TabIndex = 12;
            // 
            // przeglad_do
            // 
            przeglad_do.CustomFormat = "yyyy-MM-dd";
            przeglad_do.Font = new Font("Arial", 12F, FontStyle.Bold);
            przeglad_do.Format = DateTimePickerFormat.Custom;
            przeglad_do.Location = new Point(187, 158);
            przeglad_do.Name = "przeglad_do";
            przeglad_do.Size = new Size(145, 26);
            przeglad_do.TabIndex = 11;
            // 
            // ubezpieczenie_do
            // 
            ubezpieczenie_do.CustomFormat = "yyyy-MM-dd";
            ubezpieczenie_do.Font = new Font("Arial", 12F, FontStyle.Bold);
            ubezpieczenie_do.Format = DateTimePickerFormat.Custom;
            ubezpieczenie_do.Location = new Point(187, 213);
            ubezpieczenie_do.Name = "ubezpieczenie_do";
            ubezpieczenie_do.Size = new Size(145, 26);
            ubezpieczenie_do.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(396, 217);
            label10.Name = "label10";
            label10.Size = new Size(73, 22);
            label10.TabIndex = 8;
            label10.Text = "Uwagi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(416, 175);
            label9.Name = "label9";
            label9.Size = new Size(53, 22);
            label9.TabIndex = 7;
            label9.Text = "Rok:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 133);
            label8.Name = "label8";
            label8.Size = new Size(99, 22);
            label8.TabIndex = 6;
            label8.Text = "Przebieg:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 91);
            label7.Name = "label7";
            label7.Size = new Size(74, 22);
            label7.TabIndex = 5;
            label7.Text = "Model:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 49);
            label6.Name = "label6";
            label6.Size = new Size(75, 22);
            label6.TabIndex = 4;
            label6.Text = "Marka:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 220);
            label5.Name = "label5";
            label5.Size = new Size(151, 22);
            label5.TabIndex = 3;
            label5.Text = "Ubezpieczenie:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 163);
            label4.Name = "label4";
            label4.Size = new Size(99, 22);
            label4.TabIndex = 2;
            label4.Text = "Przegląd:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 106);
            label3.Name = "label3";
            label3.Size = new Size(114, 22);
            label3.TabIndex = 1;
            label3.Text = "Numer VIN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 49);
            label2.Name = "label2";
            label2.Size = new Size(112, 22);
            label2.TabIndex = 0;
            label2.Text = "Numer rej.:";
            // 
            // UC_dodaj
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Name = "UC_dodaj";
            Size = new Size(804, 390);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DateTimePicker ubezpieczenie_do;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox nrvin_do;
        private DateTimePicker przeglad_do;
        private Guna.UI2.WinForms.Guna2Button dodaj_pojazd_do;
        private TextBox uwagi_do;
        private TextBox rok_do;
        private TextBox przebieg_do;
        private TextBox model_do;
        private TextBox marka_do;
        private TextBox nrrej_do;
        private Label label11;
        private Guna.UI2.WinForms.Guna2Button dodaj_dokuemnt_do;
        private Label label12;
    }
}
