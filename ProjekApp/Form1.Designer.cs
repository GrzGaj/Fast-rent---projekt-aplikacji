namespace ProjekApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            button_help = new Guna.UI2.WinForms.Guna2CircleButton();
            pictureBox1 = new PictureBox();
            button_stworz = new Guna.UI2.WinForms.Guna2Button();
            button_sprawdz = new Guna.UI2.WinForms.Guna2Button();
            button_dodaj = new Guna.UI2.WinForms.Guna2Button();
            button_faktura = new Guna.UI2.WinForms.Guna2Button();
            button_rezerwacja = new Guna.UI2.WinForms.Guna2Button();
            main_panel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 54, 70);
            panel1.Controls.Add(button_help);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button_stworz);
            panel1.Controls.Add(button_sprawdz);
            panel1.Controls.Add(button_dodaj);
            panel1.Controls.Add(button_faktura);
            panel1.Controls.Add(button_rezerwacja);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 60);
            panel1.TabIndex = 0;
            // 
            // button_help
            // 
            button_help.DisabledState.BorderColor = Color.DarkGray;
            button_help.DisabledState.CustomBorderColor = Color.DarkGray;
            button_help.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_help.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_help.FillColor = Color.RoyalBlue;
            button_help.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_help.ForeColor = Color.White;
            button_help.Location = new Point(766, 14);
            button_help.Name = "button_help";
            button_help.ShadowDecoration.CustomizableEdges = customizableEdges1;
            button_help.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            button_help.Size = new Size(32, 31);
            button_help.TabIndex = 8;
            button_help.Text = "?";
            button_help.Click += button_help_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button_stworz
            // 
            button_stworz.CheckedState.CustomBorderColor = Color.Red;
            button_stworz.CustomBorderThickness = new Padding(0, 0, 0, 5);
            button_stworz.CustomizableEdges = customizableEdges2;
            button_stworz.DisabledState.BorderColor = Color.DarkGray;
            button_stworz.DisabledState.CustomBorderColor = Color.DarkGray;
            button_stworz.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_stworz.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_stworz.FillColor = Color.Transparent;
            button_stworz.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_stworz.ForeColor = Color.White;
            button_stworz.Location = new Point(653, -4);
            button_stworz.Name = "button_stworz";
            button_stworz.ShadowDecoration.CustomizableEdges = customizableEdges3;
            button_stworz.Size = new Size(100, 66);
            button_stworz.TabIndex = 6;
            button_stworz.Text = "Stwórz";
            button_stworz.Click += button_stworz_Click;
            // 
            // button_sprawdz
            // 
            button_sprawdz.CheckedState.CustomBorderColor = Color.Red;
            button_sprawdz.CustomBorderThickness = new Padding(0, 0, 0, 5);
            button_sprawdz.CustomizableEdges = customizableEdges4;
            button_sprawdz.DisabledState.BorderColor = Color.DarkGray;
            button_sprawdz.DisabledState.CustomBorderColor = Color.DarkGray;
            button_sprawdz.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_sprawdz.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_sprawdz.FillColor = Color.Transparent;
            button_sprawdz.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_sprawdz.ForeColor = Color.White;
            button_sprawdz.Location = new Point(539, -4);
            button_sprawdz.Name = "button_sprawdz";
            button_sprawdz.ShadowDecoration.CustomizableEdges = customizableEdges5;
            button_sprawdz.Size = new Size(100, 66);
            button_sprawdz.TabIndex = 5;
            button_sprawdz.Text = "Sprawdź";
            button_sprawdz.Click += button_sprawdz_Click;
            // 
            // button_dodaj
            // 
            button_dodaj.CheckedState.CustomBorderColor = Color.Red;
            button_dodaj.CustomBorderThickness = new Padding(0, 0, 0, 5);
            button_dodaj.CustomizableEdges = customizableEdges6;
            button_dodaj.DisabledState.BorderColor = Color.DarkGray;
            button_dodaj.DisabledState.CustomBorderColor = Color.DarkGray;
            button_dodaj.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_dodaj.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_dodaj.FillColor = Color.Transparent;
            button_dodaj.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_dodaj.ForeColor = Color.White;
            button_dodaj.Location = new Point(425, -4);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.ShadowDecoration.CustomizableEdges = customizableEdges7;
            button_dodaj.Size = new Size(100, 66);
            button_dodaj.TabIndex = 4;
            button_dodaj.Text = "Dodaj";
            button_dodaj.Click += button_dodaj_Click;
            // 
            // button_faktura
            // 
            button_faktura.CheckedState.CustomBorderColor = Color.Red;
            button_faktura.CheckedState.FillColor = Color.Transparent;
            button_faktura.CustomBorderThickness = new Padding(0, 0, 0, 5);
            button_faktura.CustomizableEdges = customizableEdges8;
            button_faktura.DisabledState.BorderColor = Color.DarkGray;
            button_faktura.DisabledState.CustomBorderColor = Color.DarkGray;
            button_faktura.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_faktura.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_faktura.FillColor = Color.Transparent;
            button_faktura.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_faktura.ForeColor = Color.White;
            button_faktura.Location = new Point(311, -4);
            button_faktura.Name = "button_faktura";
            button_faktura.ShadowDecoration.CustomizableEdges = customizableEdges9;
            button_faktura.Size = new Size(100, 66);
            button_faktura.TabIndex = 3;
            button_faktura.Text = "Faktura";
            button_faktura.Click += button_faktura_Click;
            // 
            // button_rezerwacja
            // 
            button_rezerwacja.CheckedState.CustomBorderColor = Color.Red;
            button_rezerwacja.CheckedState.FillColor = Color.Transparent;
            button_rezerwacja.CustomBorderThickness = new Padding(0, 0, 0, 5);
            button_rezerwacja.CustomizableEdges = customizableEdges10;
            button_rezerwacja.DisabledState.BorderColor = Color.DarkGray;
            button_rezerwacja.DisabledState.CustomBorderColor = Color.DarkGray;
            button_rezerwacja.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_rezerwacja.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_rezerwacja.FillColor = Color.Transparent;
            button_rezerwacja.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_rezerwacja.ForeColor = Color.White;
            button_rezerwacja.Location = new Point(177, -4);
            button_rezerwacja.Name = "button_rezerwacja";
            button_rezerwacja.ShadowDecoration.CustomizableEdges = customizableEdges11;
            button_rezerwacja.Size = new Size(120, 66);
            button_rezerwacja.TabIndex = 2;
            button_rezerwacja.Text = "Rezerwacja";
            button_rezerwacja.Click += button_rezerwacja_Click;
            // 
            // main_panel
            // 
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(0, 60);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(804, 390);
            main_panel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(804, 450);
            Controls.Add(main_panel);
            Controls.Add(panel1);
            Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Fast rent";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button button_rezerwacja;
        private Panel main_panel;
        private Guna.UI2.WinForms.Guna2Button button_stworz;
        private Guna.UI2.WinForms.Guna2Button button_sprawdz;
        private Guna.UI2.WinForms.Guna2Button button_dodaj;
        private Guna.UI2.WinForms.Guna2Button button_faktura;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton button_help;
    }
}
