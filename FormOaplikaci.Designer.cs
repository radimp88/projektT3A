namespace Projekt_T3A
{
    partial class FormOaplikaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOaplikaci));
            labelNazev1 = new Label();
            labelInfo = new Label();
            tlacitkoZpet = new Button();
            SuspendLayout();
            // 
            // labelNazev1
            // 
            labelNazev1.Dock = DockStyle.Top;
            labelNazev1.Font = new Font("Snap ITC", 24F);
            labelNazev1.ForeColor = SystemColors.ControlDarkDark;
            labelNazev1.Image = (Image)resources.GetObject("labelNazev1.Image");
            labelNazev1.Location = new Point(0, 0);
            labelNazev1.Name = "labelNazev1";
            labelNazev1.Size = new Size(584, 80);
            labelNazev1.TabIndex = 0;
            labelNazev1.Text = "ŠIBENICE";
            labelNazev1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            labelInfo.BackColor = SystemColors.ControlLightLight;
            labelInfo.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInfo.ForeColor = SystemColors.ControlDarkDark;
            labelInfo.Location = new Point(12, 80);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(560, 234);
            labelInfo.TabIndex = 1;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // tlacitkoZpet
            // 
            tlacitkoZpet.BackColor = SystemColors.ControlLightLight;
            tlacitkoZpet.FlatStyle = FlatStyle.Flat;
            tlacitkoZpet.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlacitkoZpet.ForeColor = SystemColors.ControlDarkDark;
            tlacitkoZpet.Location = new Point(469, 317);
            tlacitkoZpet.Name = "tlacitkoZpet";
            tlacitkoZpet.Size = new Size(103, 32);
            tlacitkoZpet.TabIndex = 2;
            tlacitkoZpet.Text = "Zpět";
            tlacitkoZpet.UseVisualStyleBackColor = false;
            tlacitkoZpet.Click += tlacitkoZpet_Click;
            // 
            // FormOaplikaci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(584, 361);
            Controls.Add(tlacitkoZpet);
            Controls.Add(labelInfo);
            Controls.Add(labelNazev1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormOaplikaci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "O Aplikaci";
            ResumeLayout(false);
        }

        #endregion

        private Label labelNazev1;
        private Label labelInfo;
        private Button tlacitkoZpet;
    }
}