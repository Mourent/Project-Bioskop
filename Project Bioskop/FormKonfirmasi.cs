using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_Bioskop
{
    public partial class FormKonfirmasi : Form
    {
        public string tgl { get; set; }
        public string Studio { get; set; }
        public string Film { get; set; }
        public string JamTayang { get; set; }
        public string Kursi { get; set; }
        public string Harga { get; set; }
        public string TotalHarga { get; set; }
        public string BanyakKursi { get; set; }
        public string IdJadwal { get; set; }
        public string IdStaff { get; set; }
        public FormKonfirmasi()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_05_BIOSKOP";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;

        private void FormKonfirmasi_Load(object sender, EventArgs e)
        {
            labelNamaFilm.Text = Film;
            labelOutputTanggal.Text = tgl;
            labelOutputJam.Text = JamTayang;
            labelOutputBioskop.Text = Studio;
            labelOutputKursi.Text = Kursi;
            labelOutputTotal.Text = TotalHarga;
            labelOutputHarga.Text = Harga;
            labelOutputBanyakKursi.Text = BanyakKursi;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            DataTable idJualTiket = new DataTable();
            sqlQuery = "select ID_JUAL_TIKET from PENJUALAN_TIKET";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(idJualTiket);
            int count = idJualTiket.Rows.Count;
            count++;
            string hitungID = "";
            if (count.ToString().Length == 1)
            {
                hitungID = "00" + count.ToString();
            }
            else if (count.ToString().Length == 2)
            {
                hitungID = "0" + count.ToString();
            }
            else
            {
                hitungID = count.ToString();
            }
            sqlQuery = "INSERT INTO PENJUALAN_TIKET VALUES (concat('IDT','" + hitungID + "'), '" + IdStaff + "', '" + IdJadwal + "', '" + tgl + "', '" + BanyakKursi + "', '" + TotalHarga + "', '" + Kursi + "', '0');";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            this.Hide();
            FormTiket formTiket = new FormTiket();
            formTiket.Studio = Studio;
            formTiket.Tgl = tgl;
            formTiket.Kursi = Kursi;
            formTiket.Film = Film;
            formTiket.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCinema formCinema = new FormCinema();
            formCinema.Show();
        }
    }
}
