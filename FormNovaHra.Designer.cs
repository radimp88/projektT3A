namespace Projekt_T3A
{
    partial class FormNovaHra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovaHra));
            pictureSibenice = new PictureBox();
            textPismeno = new TextBox();
            tlacitkoHadej = new Button();
            menuStrip1 = new MenuStrip();
            hraToolStripMenuItem = new ToolStripMenuItem();
            menuNovaHra = new ToolStripMenuItem();
            menuZpet = new ToolStripMenuItem();
            menuKonec = new ToolStripMenuItem();
            nápovědaToolStripMenuItem = new ToolStripMenuItem();
            menuOaplikaci = new ToolStripMenuItem();
            labelSlovo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureSibenice).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureSibenice
            // 
            pictureSibenice.BackColor = SystemColors.ControlLightLight;
            pictureSibenice.BorderStyle = BorderStyle.FixedSingle;
            pictureSibenice.Location = new Point(350, 200);
            pictureSibenice.Name = "pictureSibenice";
            pictureSibenice.Size = new Size(300, 300);
            pictureSibenice.TabIndex = 0;
            pictureSibenice.TabStop = false;
            // 
            // textPismeno
            // 
            textPismeno.BackColor = SystemColors.ControlLightLight;
            textPismeno.BorderStyle = BorderStyle.FixedSingle;
            textPismeno.Font = new Font("Snap ITC", 18F);
            textPismeno.ForeColor = SystemColors.ControlDarkDark;
            textPismeno.Location = new Point(350, 507);
            textPismeno.MaxLength = 1;
            textPismeno.Name = "textPismeno";
            textPismeno.Size = new Size(60, 38);
            textPismeno.TabIndex = 1;
            textPismeno.TextAlign = HorizontalAlignment.Center;
            // 
            // tlacitkoHadej
            // 
            tlacitkoHadej.BackColor = SystemColors.ControlLightLight;
            tlacitkoHadej.FlatStyle = FlatStyle.Flat;
            tlacitkoHadej.Font = new Font("Snap ITC", 10F);
            tlacitkoHadej.ForeColor = SystemColors.ControlDarkDark;
            tlacitkoHadej.Location = new Point(519, 507);
            tlacitkoHadej.Name = "tlacitkoHadej";
            tlacitkoHadej.Size = new Size(131, 38);
            tlacitkoHadej.TabIndex = 2;
            tlacitkoHadej.Text = "Hádej";
            tlacitkoHadej.UseVisualStyleBackColor = false;
            tlacitkoHadej.Click += tlacitkoHadej_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hraToolStripMenuItem, nápovědaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // hraToolStripMenuItem
            // 
            hraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNovaHra, menuZpet, menuKonec });
            hraToolStripMenuItem.Name = "hraToolStripMenuItem";
            hraToolStripMenuItem.Size = new Size(38, 20);
            hraToolStripMenuItem.Text = "Hra";
            // 
            // menuNovaHra
            // 
            menuNovaHra.Name = "menuNovaHra";
            menuNovaHra.Size = new Size(149, 22);
            menuNovaHra.Text = "Nová Hra";
            menuNovaHra.Click += menuNovaHra_Click;
            // 
            // menuZpet
            // 
            menuZpet.Name = "menuZpet";
            menuZpet.Size = new Size(149, 22);
            menuZpet.Text = "Zpět do menu";
            menuZpet.Click += menuZpet_Click;
            // 
            // menuKonec
            // 
            menuKonec.Name = "menuKonec";
            menuKonec.Size = new Size(149, 22);
            menuKonec.Text = "Konec";
            menuKonec.Click += menuKonec_Click;
            // 
            // nápovědaToolStripMenuItem
            // 
            nápovědaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuOaplikaci });
            nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            nápovědaToolStripMenuItem.Size = new Size(73, 20);
            nápovědaToolStripMenuItem.Text = "Nápověda";
            // 
            // menuOaplikaci
            // 
            menuOaplikaci.Name = "menuOaplikaci";
            menuOaplikaci.Size = new Size(126, 22);
            menuOaplikaci.Text = "O aplikaci";
            menuOaplikaci.Click += menuOaplikaci_Click;
            // 
            // labelSlovo
            // 
            labelSlovo.Dock = DockStyle.Top;
            labelSlovo.Font = new Font("Snap ITC", 24F);
            labelSlovo.ForeColor = SystemColors.ControlDarkDark;
            labelSlovo.Image = (Image)resources.GetObject("labelSlovo.Image");
            labelSlovo.Location = new Point(0, 24);
            labelSlovo.Name = "labelSlovo";
            labelSlovo.Size = new Size(984, 79);
            labelSlovo.TabIndex = 4;
            labelSlovo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormNovaHra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 661);
            Controls.Add(labelSlovo);
            Controls.Add(tlacitkoHadej);
            Controls.Add(textPismeno);
            Controls.Add(pictureSibenice);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormNovaHra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Šibenice -Hra";
            Load += FormNovaHra_Load;
            ((System.ComponentModel.ISupportInitialize)pictureSibenice).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureSibenice;
        private TextBox textPismeno;
        private Button tlacitkoHadej;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hraToolStripMenuItem;
        private ToolStripMenuItem menuNovaHra;
        private ToolStripMenuItem menuZpet;
        private ToolStripMenuItem menuKonec;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private ToolStripMenuItem menuOaplikaci;
        private Label labelSlovo;
    }
}