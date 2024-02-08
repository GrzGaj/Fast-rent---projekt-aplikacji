namespace ProjekApp.UC
{
    partial class UC_sprawdz
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
            nrrez_spr = new TextBox();
            label3 = new Label();
            marka_spr = new TextBox();
            label2 = new Label();
            data_spr = new DataGridView();
            rezerwacja_spr = new Guna.UI2.WinForms.Guna2Button();
            dokumenty_spr = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_spr).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(335, 3);
            label1.Name = "label1";
            label1.Size = new Size(135, 34);
            label1.TabIndex = 0;
            label1.Text = "Sprawdź";
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
            panel2.Controls.Add(nrrez_spr);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(marka_spr);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(data_spr);
            panel2.Controls.Add(rezerwacja_spr);
            panel2.Controls.Add(dokumenty_spr);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 350);
            panel2.TabIndex = 2;
            // 
            // nrrez_spr
            // 
            nrrez_spr.BorderStyle = BorderStyle.None;
            nrrez_spr.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nrrez_spr.Location = new Point(438, 28);
            nrrez_spr.Name = "nrrez_spr";
            nrrez_spr.Size = new Size(180, 19);
            nrrez_spr.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 3);
            label3.Name = "label3";
            label3.Size = new Size(188, 22);
            label3.TabIndex = 5;
            label3.Text = "Podaj nr rezerwacji";
            // 
            // marka_spr
            // 
            marka_spr.BorderStyle = BorderStyle.None;
            marka_spr.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            marka_spr.Location = new Point(28, 28);
            marka_spr.Name = "marka_spr";
            marka_spr.Size = new Size(180, 19);
            marka_spr.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 3);
            label2.Name = "label2";
            label2.Size = new Size(126, 22);
            label2.TabIndex = 3;
            label2.Text = "Podaj markę";
            // 
            // data_spr
            // 
            data_spr.BackgroundColor = Color.WhiteSmoke;
            data_spr.BorderStyle = BorderStyle.None;
            data_spr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_spr.Location = new Point(7, 63);
            data_spr.Name = "data_spr";
            data_spr.Size = new Size(791, 280);
            data_spr.TabIndex = 2;
            // 
            // rezerwacja_spr
            // 
            rezerwacja_spr.CustomizableEdges = customizableEdges1;
            rezerwacja_spr.DisabledState.BorderColor = Color.DarkGray;
            rezerwacja_spr.DisabledState.CustomBorderColor = Color.DarkGray;
            rezerwacja_spr.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            rezerwacja_spr.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            rezerwacja_spr.FillColor = Color.WhiteSmoke;
            rezerwacja_spr.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            rezerwacja_spr.ForeColor = Color.Black;
            rezerwacja_spr.Location = new Point(632, 3);
            rezerwacja_spr.Name = "rezerwacja_spr";
            rezerwacja_spr.ShadowDecoration.CustomizableEdges = customizableEdges2;
            rezerwacja_spr.Size = new Size(145, 54);
            rezerwacja_spr.TabIndex = 1;
            rezerwacja_spr.Text = "Sprawdź rezerwacje";
            rezerwacja_spr.Click += rezerwacja_spr_Click;
            // 
            // dokumenty_spr
            // 
            dokumenty_spr.CustomizableEdges = customizableEdges3;
            dokumenty_spr.DisabledState.BorderColor = Color.DarkGray;
            dokumenty_spr.DisabledState.CustomBorderColor = Color.DarkGray;
            dokumenty_spr.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dokumenty_spr.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dokumenty_spr.FillColor = Color.WhiteSmoke;
            dokumenty_spr.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dokumenty_spr.ForeColor = Color.Black;
            dokumenty_spr.Location = new Point(214, 3);
            dokumenty_spr.Name = "dokumenty_spr";
            dokumenty_spr.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dokumenty_spr.Size = new Size(145, 54);
            dokumenty_spr.TabIndex = 0;
            dokumenty_spr.Text = "Sprawdź dokumenty";
            dokumenty_spr.Click += dokumenty_spr_Click;
            // 
            // UC_sprawdz
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Name = "UC_sprawdz";
            Size = new Size(804, 390);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_spr).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView data_spr;
        private Guna.UI2.WinForms.Guna2Button rezerwacja_spr;
        private Guna.UI2.WinForms.Guna2Button dokumenty_spr;
        private TextBox marka_spr;
        private Label label2;
        private Label label3;
        private TextBox nrrez_spr;
    }
}
