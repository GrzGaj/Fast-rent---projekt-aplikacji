namespace ProjekApp.UC
{
    partial class UC_faktura
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            platnosc_fa = new ComboBox();
            kwota_fa = new TextBox();
            label8 = new Label();
            adres_fa = new RichTextBox();
            nip_fa = new TextBox();
            nazwa_fa = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            zapisz_fa = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(342, 3);
            label1.Name = "label1";
            label1.Size = new Size(120, 34);
            label1.TabIndex = 0;
            label1.Text = "Faktura";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 54, 70);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 40);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 350);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightBlue;
            panel3.Controls.Add(platnosc_fa);
            panel3.Controls.Add(kwota_fa);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(adres_fa);
            panel3.Controls.Add(nip_fa);
            panel3.Controls.Add(nazwa_fa);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(zapisz_fa);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(804, 350);
            panel3.TabIndex = 2;
            // 
            // platnosc_fa
            // 
            platnosc_fa.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            platnosc_fa.FormattingEnabled = true;
            platnosc_fa.Location = new Point(426, 56);
            platnosc_fa.Name = "platnosc_fa";
            platnosc_fa.Size = new Size(267, 27);
            platnosc_fa.TabIndex = 19;
            // 
            // kwota_fa
            // 
            kwota_fa.BorderStyle = BorderStyle.None;
            kwota_fa.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kwota_fa.Location = new Point(426, 127);
            kwota_fa.Name = "kwota_fa";
            kwota_fa.Size = new Size(267, 19);
            kwota_fa.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(520, 94);
            label8.Name = "label8";
            label8.Size = new Size(68, 22);
            label8.TabIndex = 16;
            label8.Text = "Kwota";
            // 
            // adres_fa
            // 
            adres_fa.BorderStyle = BorderStyle.None;
            adres_fa.Location = new Point(114, 190);
            adres_fa.Name = "adres_fa";
            adres_fa.Size = new Size(266, 129);
            adres_fa.TabIndex = 13;
            adres_fa.Text = "";
            // 
            // nip_fa
            // 
            nip_fa.BorderStyle = BorderStyle.None;
            nip_fa.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nip_fa.Location = new Point(113, 127);
            nip_fa.Name = "nip_fa";
            nip_fa.Size = new Size(267, 19);
            nip_fa.TabIndex = 12;
            // 
            // nazwa_fa
            // 
            nazwa_fa.BorderStyle = BorderStyle.None;
            nazwa_fa.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nazwa_fa.Location = new Point(111, 64);
            nazwa_fa.Name = "nazwa_fa";
            nazwa_fa.Size = new Size(267, 19);
            nazwa_fa.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 31);
            label5.Name = "label5";
            label5.Size = new Size(160, 22);
            label5.TabIndex = 10;
            label5.Text = "Forma płatności";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 157);
            label4.Name = "label4";
            label4.Size = new Size(65, 22);
            label4.TabIndex = 9;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 94);
            label3.Name = "label3";
            label3.Size = new Size(41, 22);
            label3.TabIndex = 8;
            label3.Text = "NIP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 31);
            label2.Name = "label2";
            label2.Size = new Size(267, 22);
            label2.TabIndex = 7;
            label2.Text = "Nazwa firmy / imie nazwisko";
            // 
            // zapisz_fa
            // 
            zapisz_fa.BackColor = Color.WhiteSmoke;
            zapisz_fa.CustomizableEdges = customizableEdges1;
            zapisz_fa.DisabledState.BorderColor = Color.DarkGray;
            zapisz_fa.DisabledState.CustomBorderColor = Color.DarkGray;
            zapisz_fa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            zapisz_fa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            zapisz_fa.FillColor = Color.WhiteSmoke;
            zapisz_fa.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            zapisz_fa.ForeColor = Color.Black;
            zapisz_fa.Location = new Point(466, 204);
            zapisz_fa.Name = "zapisz_fa";
            zapisz_fa.ShadowDecoration.CustomizableEdges = customizableEdges2;
            zapisz_fa.Size = new Size(180, 45);
            zapisz_fa.TabIndex = 6;
            zapisz_fa.Text = "Zapisz";
            zapisz_fa.Click += zapisz_fa_Click;
            // 
            // UC_faktura
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Name = "UC_faktura";
            Size = new Size(804, 390);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2Button zapisz_fa;
        private TextBox nip_fa;
        private TextBox nazwa_fa;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox adres_fa;
        private Label label8;
        private ComboBox platnosc_fa;
        private TextBox kwota_fa;
    }
}
