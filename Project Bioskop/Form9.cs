using System;
using System.Data;
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
        private string text;
        public string Text
        {
            get { return NamaStaff; }
            set { NamaStaff = value; }
        }

        private void FormStrukSnack_Load(object sender, EventArgs e)
        {
            lblnamacust.Text = NamaCust;
            lblIdNoPesanan.Text = NoPesanan;
            lblCashier.Text = Text;
            dgvMenu1.DataSource = Pesanan;
            labelTotal.Text = TotalHarga;
            
        }

        private void FormStrukSnack_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormBioskop formBioskop = new FormBioskop();
            formBioskop.Show();
        }
    }
}
