using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Bioskop
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnpilihtiket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();  
            Form1.Show();
        }

        private void btnpilihsnack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKasirSnack formKasirSnack = new FormKasirSnack();
            formKasirSnack.Show();
        }
    }
}
