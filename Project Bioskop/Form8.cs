using System;
using System.Windows.Forms;

namespace Project_Bioskop
{
    public partial class FormBioskop : Form
    {
        public FormBioskop()
        {
            InitializeComponent();
        }

        private void btnpilihtiket_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCinema Form1 = new FormCinema();  
            Form1.Show();
        }

        private void btnpilihsnack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKasirSnack formKasirSnack = new FormKasirSnack();
            formKasirSnack.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
