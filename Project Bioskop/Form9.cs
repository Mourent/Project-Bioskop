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
    public partial class FormStrukSnack : Form
    {
        public string NamaCust { get; set; }
        public string NoPesanan { get; set;}
        public string NamaStaff { get; set; }
        public DataTable Pesanan { get; set; }
        public string TotalHarga { get; set; }
        public FormStrukSnack()
        {
            InitializeComponent();
            
        }

        private void FormStrukSnack_Load(object sender, EventArgs e)
        {
            lblnamacust.Text = NamaCust;
            lblIdNoPesanan.Text = NoPesanan;
            lblCashier.Text = NamaStaff.ToString();
            dgvMenu1.DataSource = Pesanan;
            labelTotal.Text = TotalHarga;
        }
    }
}
