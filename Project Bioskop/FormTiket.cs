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
    public partial class FormTiket : Form
    {
        public string Studio { get; set; }
        public string Tgl { get; set; }
        public string Kursi { get; set; }
        public string Film { get; set; }

        public FormTiket()
        {
            InitializeComponent();
        }

        private void labelBios_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            labelTheater.Text = Studio;
            lblTanggalMain.Text = Tgl;
            lblSeat.Text = Kursi;
            lblJudulFilm.Text = Film;
        }
    }
}
