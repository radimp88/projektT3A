namespace Projekt_T3A
{
    public partial class FormHlavniMenu : Form
    {
        public FormHlavniMenu()
        {
            InitializeComponent();
        }

        private void tlacitkoKonec_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tlacitkoOAplikaci_Click_1(object sender, EventArgs e)
        {
            FormOaplikaci oAplikaci = new FormOaplikaci();
            oAplikaci.ShowDialog();
        }

        private void tlacitkoNovaHra_Click_1(object sender, EventArgs e)
        {

            FormNovaHra hra = new FormNovaHra();
            hra.NovaHra();      
            hra.Show();
            this.Hide();
        }
    }
}
