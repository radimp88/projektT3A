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
    public partial class FormOaplikaci : Form
    {
        public FormOaplikaci()
        {
            InitializeComponent();
        }

        private void tlacitkoZpet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
