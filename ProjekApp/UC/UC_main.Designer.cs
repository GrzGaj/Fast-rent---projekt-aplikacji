namespace ProjekApp.UC
{
    partial class UC_main
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            show_sg = new Guna.UI2.WinForms.Guna2Button();
            data_sg = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_sg).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 54, 70);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(294, 3);
            label1.Name = "label1";
            label1.Size = new Size(216, 34);
            label1.TabIndex = 0;
            label1.Text = "Strona główna";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(show_sg);
            panel2.Controls.Add(data_sg);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 350);
            panel2.TabIndex = 1;
            // 
            // show_sg
            // 
            show_sg.CustomizableEdges = customizableEdges1;
            show_sg.DisabledState.BorderColor = Color.DarkGray;
            show_sg.DisabledState.CustomBorderColor = Color.DarkGray;
            show_sg.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            show_sg.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            show_sg.FillColor = Color.White;
            show_sg.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            show_sg.ForeColor = Color.Black;
            show_sg.Location = new Point(27, 6);
            show_sg.Name = "show_sg";
            show_sg.ShadowDecoration.CustomizableEdges = customizableEdges2;
            show_sg.Size = new Size(750, 45);
            show_sg.TabIndex = 1;
            show_sg.Text = "Pokaż pojazdy";
            show_sg.Click += show_sg_Click;
            // 
            // data_sg
            // 
            data_sg.BackgroundColor = Color.WhiteSmoke;
            data_sg.BorderStyle = BorderStyle.None;
            data_sg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_sg.Location = new Point(27, 59);
            data_sg.Name = "data_sg";
            data_sg.Size = new Size(750, 270);
            data_sg.TabIndex = 0;
            // 
            // UC_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_main";
            Size = new Size(804, 390);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)data_sg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button show_sg;
        private DataGridView data_sg;
    }
}
