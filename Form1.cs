namespace Projekt_T3A
{
    public partial class FormHlavniMenu : Form
    {
        public FormHlavniMenu()
        {
            InitializeComponent();
        }

        private void tlacitkoNovaHra_Click(object sender, EventArgs e)
        {

            FormHra hra = new FormHra();
            hra.Show();
            this.Hide();

        }

        private void tlacitkoOAplikaci_Click(object sender, EventArgs e)
        {

        }

        private void tlacitkoKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
