using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Bioskop
{
    public partial class FormDolbyAtmos : Form
    {
        public FormDolbyAtmos()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_05_BIOSKOP";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;

        private void btnG10_Click(object sender, EventArgs e)
        {

        }

        private void btnA1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnG11_Click(object sender, EventArgs e)
        {

        }

        private void btnG12_Click(object sender, EventArgs e)
        {

        }

        private void btnG13_Click(object sender, EventArgs e)
        {

        }

        private void btnG14_Click(object sender, EventArgs e)
        {

        }

        private void btnH11_Click(object sender, EventArgs e)
        {

        }

        private void btnH14_Click(object sender, EventArgs e)
        {

        }

        private void btnA10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnH1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
