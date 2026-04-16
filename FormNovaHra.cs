using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_T3A
{
    public partial class FormNovaHra : Form
    {

        int pocetChyb = 0;

        private string tajneSlovo = "";
        private char[] zobrazeneSlovo;

        private string[] databazeSlov =
        {
            "PES",
            "KOCKA",
            "SKOLA",
            "POCITAC",
            "PROGRAM",
            "KNIHA",
            "SLON",
            "MYS",
            "MONITOR",
            "TABULE"
        };
        public FormNovaHra()
        {
            InitializeComponent();
        }

        private void FormNovaHra_Load(object sender, EventArgs e)
        {

        }

        private void tlacitkoHadej_Click(object sender, EventArgs e)
        {
            if (textPismeno.Text.Length != 1)
                return;

            char pismeno = char.ToUpper(textPismeno.Text[0]);
            textPismeno.Text = "";

            bool nalezeno = false;

            for (int i = 0; i < tajneSlovo.Length; i++)
            {
                if (tajneSlovo[i] == pismeno)
                {
                    zobrazeneSlovo[i] = pismeno;
                    nalezeno = true;
                }
            }

            if (!nalezeno)
            {
                pocetChyb++;
                VykresliSibenici();

                if (pocetChyb >= 10)
                {
                    MessageBox.Show("Prohrál jsi! Slovo bylo: " + tajneSlovo);
                    VratSeDoMenu();
                    return;
                }
            }

            labelSlovo.Text = string.Join(" ", zobrazeneSlovo);

            if (!labelSlovo.Text.Contains("_"))
            {
                MessageBox.Show("Vyhrál jsi!");
                VratSeDoMenu();
            }

            textPismeno.Focus();

        }

        private void menuNovaHra_Click(object sender, EventArgs e)
        {
            NovaHra();
        }

        public void NovaHra()
        {
            Random rand = new Random();
            tajneSlovo = databazeSlov[rand.Next(databazeSlov.Length)];

            pocetChyb = 0;

            zobrazeneSlovo = new char[tajneSlovo.Length];
            for (int i = 0; i < tajneSlovo.Length; i++)
            {
                zobrazeneSlovo[i] = '_';
            }

            labelSlovo.Text = string.Join(" ", zobrazeneSlovo);
            pictureSibenice.Refresh();
            VykresliSibenici();

            textPismeno.Focus();
        }


        private void menuZpet_Click(object sender, EventArgs e)
        {
            FormHlavniMenu menu = new FormHlavniMenu();
            menu.Show();
            this.Close();
        }

        private void menuKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VykresliSibenici()
        {
            Graphics g = pictureSibenice.CreateGraphics();
            g.Clear(Color.White);

            Pen pero = new Pen(Color.Black, 3);

            // 1 – podstava
            if (pocetChyb >= 1)
                g.DrawLine(pero, 50, 250, 250, 250);

            // 2 – sloup
            if (pocetChyb >= 2)
                g.DrawLine(pero, 100, 250, 100, 50);

            // 3 – horní trám
            if (pocetChyb >= 3)
                g.DrawLine(pero, 100, 50, 200, 50);

            // 4 – provaz
            if (pocetChyb >= 4)
                g.DrawLine(pero, 200, 50, 200, 80);

            // 5 – hlava
            if (pocetChyb >= 5)
                g.DrawEllipse(pero, 180, 80, 40, 40);

            // 6 – tělo
            if (pocetChyb >= 6)
                g.DrawLine(pero, 200, 120, 200, 180);

            // 7 – levá ruka
            if (pocetChyb >= 7)
                g.DrawLine(pero, 200, 140, 170, 160);

            // 8 – pravá ruka
            if (pocetChyb >= 8)
                g.DrawLine(pero, 200, 140, 230, 160);

            // 9 – levá noha
            if (pocetChyb >= 9)
                g.DrawLine(pero, 200, 180, 170, 220);

            // 10 – pravá noha
            if (pocetChyb >= 10)
                g.DrawLine(pero, 200, 180, 230, 220);
        }

        private void menuOaplikaci_Click(object sender, EventArgs e)
        {
            FormOaplikaci oAplikaci = new FormOaplikaci();
            oAplikaci.ShowDialog();
        }

        private void VratSeDoMenu()
        {
            FormHlavniMenu menu = new FormHlavniMenu();
            menu.Show();
            this.Close();
        }
    }
}
