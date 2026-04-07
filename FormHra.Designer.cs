namespace Projekt_T3A
{
    partial class FormHra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHra));
            menuStrip1 = new MenuStrip();
            nováHraToolStripMenuItem = new ToolStripMenuItem();
            menuNovaHra = new ToolStripMenuItem();
            menuZpet = new ToolStripMenuItem();
            menuKonec = new ToolStripMenuItem();
            nápovědaToolStripMenuItem = new ToolStripMenuItem();
            menuOaplikaci = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            nastrojNovaHra = new ToolStripButton();
            nastrojHadej = new ToolStripButton();
            nastrojZpet = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            stavovyText = new ToolStripStatusLabel();
            labelSlovo = new Label();
            pictureSibenice = new PictureBox();
            textPismeno = new TextBox();
            tlacitkoHadej = new Button();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSibenice).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nováHraToolStripMenuItem, nápovědaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nováHraToolStripMenuItem
            // 
            nováHraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNovaHra, menuZpet, menuKonec });
            nováHraToolStripMenuItem.Name = "nováHraToolStripMenuItem";
            nováHraToolStripMenuItem.Size = new Size(38, 20);
            nováHraToolStripMenuItem.Text = "Hra";
            // 
            // menuNovaHra
            // 
            menuNovaHra.Name = "menuNovaHra";
            menuNovaHra.Size = new Size(180, 22);
            menuNovaHra.Text = "Nová hra";
            menuNovaHra.Click += menuNovaHra_Click;
            // 
            // menuZpet
            // 
            menuZpet.Name = "menuZpet";
            menuZpet.Size = new Size(180, 22);
            menuZpet.Text = "Zpět do menu";
            menuZpet.Click += menuZpet_Click;
            // 
            // menuKonec
            // 
            menuKonec.Name = "menuKonec";
            menuKonec.Size = new Size(180, 22);
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
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { nastrojNovaHra, nastrojHadej, nastrojZpet });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(984, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // nastrojNovaHra
            // 
            nastrojNovaHra.DisplayStyle = ToolStripItemDisplayStyle.Image;
            nastrojNovaHra.Image = (Image)resources.GetObject("nastrojNovaHra.Image");
            nastrojNovaHra.ImageTransparentColor = Color.Magenta;
            nastrojNovaHra.Name = "nastrojNovaHra";
            nastrojNovaHra.Size = new Size(23, 22);
            nastrojNovaHra.Text = "Nová hra";
            nastrojNovaHra.Click += nastrojNovaHra_Click;
            // 
            // nastrojHadej
            // 
            nastrojHadej.DisplayStyle = ToolStripItemDisplayStyle.Image;
            nastrojHadej.Image = (Image)resources.GetObject("nastrojHadej.Image");
            nastrojHadej.ImageTransparentColor = Color.Magenta;
            nastrojHadej.Name = "nastrojHadej";
            nastrojHadej.Size = new Size(23, 22);
            nastrojHadej.Text = "Hádej";
            // 
            // nastrojZpet
            // 
            nastrojZpet.DisplayStyle = ToolStripItemDisplayStyle.Image;
            nastrojZpet.Image = (Image)resources.GetObject("nastrojZpet.Image");
            nastrojZpet.ImageTransparentColor = Color.Magenta;
            nastrojZpet.Name = "nastrojZpet";
            nastrojZpet.Size = new Size(23, 22);
            nastrojZpet.Text = "Zpět";
            nastrojZpet.Click += nastrojZpet_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { stavovyText });
            statusStrip1.Location = new Point(0, 639);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // stavovyText
            // 
            stavovyText.Name = "stavovyText";
            stavovyText.Size = new Size(57, 17);
            stavovyText.Text = "Připraven";
            stavovyText.Click += toolStripStatusLabel1_Click;
            // 
            // labelSlovo
            // 
            labelSlovo.Dock = DockStyle.Top;
            labelSlovo.Font = new Font("Segoe UI", 26F);
            labelSlovo.Location = new Point(0, 49);
            labelSlovo.Name = "labelSlovo";
            labelSlovo.Size = new Size(984, 120);
            labelSlovo.TabIndex = 3;
            labelSlovo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureSibenice
            // 
            pictureSibenice.BackColor = Color.White;
            pictureSibenice.BorderStyle = BorderStyle.FixedSingle;
            pictureSibenice.Location = new Point(300, 172);
            pictureSibenice.Name = "pictureSibenice";
            pictureSibenice.Size = new Size(300, 300);
            pictureSibenice.TabIndex = 4;
            pictureSibenice.TabStop = false;
            // 
            // textPismeno
            // 
            textPismeno.Font = new Font("Segoe UI", 18F);
            textPismeno.Location = new Point(300, 478);
            textPismeno.MaxLength = 1;
            textPismeno.Name = "textPismeno";
            textPismeno.Size = new Size(50, 39);
            textPismeno.TabIndex = 5;
            // 
            // tlacitkoHadej
            // 
            tlacitkoHadej.Font = new Font("Segoe UI", 14F);
            tlacitkoHadej.Location = new Point(500, 479);
            tlacitkoHadej.Name = "tlacitkoHadej";
            tlacitkoHadej.Size = new Size(100, 40);
            tlacitkoHadej.TabIndex = 6;
            tlacitkoHadej.Text = "Hádej";
            tlacitkoHadej.UseVisualStyleBackColor = true;
            tlacitkoHadej.Click += tlacitkoHadej_Click;
            // 
            // FormHra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(tlacitkoHadej);
            Controls.Add(textPismeno);
            Controls.Add(pictureSibenice);
            Controls.Add(labelSlovo);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormHra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Šibenice - Hra";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSibenice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nováHraToolStripMenuItem;
        private ToolStripMenuItem menuNovaHra;
        private ToolStripMenuItem menuZpet;
        private ToolStripMenuItem menuKonec;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private ToolStripMenuItem menuOaplikaci;
        private ToolStrip toolStrip1;
        private ToolStripButton nastrojNovaHra;
        private ToolStripButton nastrojHadej;
        private ToolStripButton nastrojZpet;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stavovyText;
        private Label labelSlovo;
        private PictureBox pictureSibenice;
        private TextBox textPismeno;
        private Button tlacitkoHadej;
    }
}