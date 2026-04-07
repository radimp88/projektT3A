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
            labelNazev = new Label();
            tlacitkoNovaHra = new Button();
            tlacitkoOAplikaci = new Button();
            tlacitkoKonec = new Button();
            SuspendLayout();
            // 
            // labelNazev
            // 
            labelNazev.Dock = DockStyle.Top;
            labelNazev.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelNazev.Location = new Point(0, 0);
            labelNazev.Name = "labelNazev";
            labelNazev.Size = new Size(984, 120);
            labelNazev.TabIndex = 0;
            labelNazev.Text = "ŠIBENICE";
            labelNazev.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlacitkoNovaHra
            // 
            tlacitkoNovaHra.Font = new Font("Segoe UI", 16F);
            tlacitkoNovaHra.Location = new Point(395, 241);
            tlacitkoNovaHra.Name = "tlacitkoNovaHra";
            tlacitkoNovaHra.Size = new Size(200, 60);
            tlacitkoNovaHra.TabIndex = 1;
            tlacitkoNovaHra.Text = "Nová hra";
            tlacitkoNovaHra.UseVisualStyleBackColor = true;
            tlacitkoNovaHra.Click += tlacitkoNovaHra_Click;
            // 
            // tlacitkoOAplikaci
            // 
            tlacitkoOAplikaci.Font = new Font("Segoe UI", 16F);
            tlacitkoOAplikaci.Location = new Point(395, 318);
            tlacitkoOAplikaci.Name = "tlacitkoOAplikaci";
            tlacitkoOAplikaci.Size = new Size(200, 60);
            tlacitkoOAplikaci.TabIndex = 2;
            tlacitkoOAplikaci.Text = "O aplikaci";
            tlacitkoOAplikaci.UseVisualStyleBackColor = true;
            tlacitkoOAplikaci.Click += tlacitkoOAplikaci_Click;
            // 
            // tlacitkoKonec
            // 
            tlacitkoKonec.Font = new Font("Segoe UI", 16F);
            tlacitkoKonec.Location = new Point(395, 395);
            tlacitkoKonec.Name = "tlacitkoKonec";
            tlacitkoKonec.Size = new Size(200, 60);
            tlacitkoKonec.TabIndex = 3;
            tlacitkoKonec.Text = "Konec";
            tlacitkoKonec.UseVisualStyleBackColor = true;
            tlacitkoKonec.Click += tlacitkoKonec_Click;
            // 
            // FormHlavniMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(tlacitkoKonec);
            Controls.Add(tlacitkoOAplikaci);
            Controls.Add(tlacitkoNovaHra);
            Controls.Add(labelNazev);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormHlavniMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Šibenice - hlavní menu";
            ResumeLayout(false);
        }

        #endregion

        private Label labelNazev;
        private Button tlacitkoNovaHra;
        private Button tlacitkoOAplikaci;
        private Button tlacitkoKonec;
    }
}
