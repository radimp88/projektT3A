namespace Projekt_T3A
{
    partial class FormHlavniMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHlavniMenu));
            labelNazev = new Label();
            tlacitkoNovaHra = new Button();
            tlacitkoOAplikaci = new Button();
            tlacitkoKonec = new Button();
            SuspendLayout();
            // 
            // labelNazev
            // 
            labelNazev.Dock = DockStyle.Top;
            labelNazev.Font = new Font("Snap ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNazev.ForeColor = SystemColors.ControlDarkDark;
            labelNazev.Image = (Image)resources.GetObject("labelNazev.Image");
            labelNazev.Location = new Point(0, 0);
            labelNazev.Name = "labelNazev";
            labelNazev.Size = new Size(984, 120);
            labelNazev.TabIndex = 0;
            labelNazev.Text = "ŠIBENICE";
            labelNazev.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlacitkoNovaHra
            // 
            tlacitkoNovaHra.BackColor = SystemColors.ControlLightLight;
            tlacitkoNovaHra.FlatStyle = FlatStyle.Flat;
            tlacitkoNovaHra.Font = new Font("Snap ITC", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlacitkoNovaHra.ForeColor = SystemColors.ControlDarkDark;
            tlacitkoNovaHra.Location = new Point(315, 274);
            tlacitkoNovaHra.Name = "tlacitkoNovaHra";
            tlacitkoNovaHra.Size = new Size(350, 70);
            tlacitkoNovaHra.TabIndex = 2;
            tlacitkoNovaHra.Text = "Nová hra";
            tlacitkoNovaHra.UseVisualStyleBackColor = false;
            tlacitkoNovaHra.Click += tlacitkoNovaHra_Click_1;
            // 
            // tlacitkoOAplikaci
            // 
            tlacitkoOAplikaci.BackColor = SystemColors.ControlLightLight;
            tlacitkoOAplikaci.FlatStyle = FlatStyle.Flat;
            tlacitkoOAplikaci.Font = new Font("Snap ITC", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlacitkoOAplikaci.ForeColor = SystemColors.ControlDarkDark;
            tlacitkoOAplikaci.Location = new Point(315, 350);
            tlacitkoOAplikaci.Name = "tlacitkoOAplikaci";
            tlacitkoOAplikaci.Size = new Size(350, 70);
            tlacitkoOAplikaci.TabIndex = 3;
            tlacitkoOAplikaci.Text = "O aplikaci";
            tlacitkoOAplikaci.UseVisualStyleBackColor = false;
            tlacitkoOAplikaci.Click += tlacitkoOAplikaci_Click_1;
            // 
            // tlacitkoKonec
            // 
            tlacitkoKonec.BackColor = SystemColors.ControlLightLight;
            tlacitkoKonec.FlatStyle = FlatStyle.Flat;
            tlacitkoKonec.Font = new Font("Snap ITC", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlacitkoKonec.ForeColor = SystemColors.ControlDarkDark;
            tlacitkoKonec.Location = new Point(315, 426);
            tlacitkoKonec.Name = "tlacitkoKonec";
            tlacitkoKonec.Size = new Size(350, 70);
            tlacitkoKonec.TabIndex = 4;
            tlacitkoKonec.Text = "Konec";
            tlacitkoKonec.UseVisualStyleBackColor = false;
            tlacitkoKonec.Click += tlacitkoKonec_Click_1;
            // 
            // FormHlavniMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 661);
            Controls.Add(tlacitkoKonec);
            Controls.Add(tlacitkoOAplikaci);
            Controls.Add(labelNazev);
            Controls.Add(tlacitkoNovaHra);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormHlavniMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Šibenice - hlavní menu";
            ResumeLayout(false);
        }

        #endregion

        private Label labelNazev;
        private Button tlacitkoKonec;
        private Button tlacitkoOAplikaci;
        private Button tlacitkoNovaHra;
    }
}
