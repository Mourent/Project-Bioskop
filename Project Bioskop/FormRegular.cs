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
using System.Collections;

namespace Project_Bioskop
{
    public partial class FormRegular : Form
    {
        public string idFilm { get; set; }
        public string idStudio { get; set; }
        public string tgl { get; set; }
        public string Studio { get; set; }
        public string Film { get; set; }
        public string JamTayang { get; set; }
        public string IdJadwal { get; set; }
        public string IdStaff { get; set; }
        public FormRegular()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_05_BIOSKOP";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;

        private void FormRegular_Load(object sender, EventArgs e)
        {
            labelOutputTgl.Text = tgl;
            labelOutputFilm.Text = Film;
            labelOutputStudio.Text = Studio;
            labelOutputJamTayang.Text = JamTayang;

            DataTable kursiTerisi = new DataTable(); // buat kursi yg udh dibeli
            sqlQuery = "select p.NOMOR_KURSI from PENJUALAN_TIKET p,JADWAL_TAYANG j where p.ID_JADWAL = j.ID_JADWAL and j.ID_STUDIO = '" + idStudio + "' and j.TANGGAL_TAYANG = '" + tgl + "' and j.ID_FILM = '" + idFilm + "' and j.JAM_TAYANG = '"+JamTayang+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(kursiTerisi);
            var arlistKursi = new ArrayList(); // buat nampung yg udh dipisah ; nya

            for (int i = 0; i < kursiTerisi.Rows.Count; i++)
            {
                string[] subs = kursiTerisi.Rows[i][0].ToString().Split(';');
                foreach (var arr in subs)
                {
                    arlistKursi.Add(arr);
                }
            }
            foreach (var button in this.Controls.OfType<Button>())
            {
                foreach (var kursi in arlistKursi)
                {
                    if (button.Text == kursi.ToString())
                    {
                        button.Enabled = false;
                        button.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCinema formCinema = new FormCinema();
            formCinema.Show();
        }
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string kursi = "";// catet kursi yg dibeli
            int hitungKursi = 0; // total kursi yg dibeli (buat catet di database)
            int cekKuning = 0;
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.BackColor == Color.Yellow)
                {
                    hitungKursi += 1;
                    kursi += button.Text + ";" ;
                    cekKuning += 1;
                }
            }
            if(cekKuning == 0)
            {
                MessageBox.Show("Pilih Kursi!");
            }
            else
            {
                this.Hide();
                DataTable totalHarga = new DataTable();
                sqlQuery = "select HARGA_TIKET * '" + hitungKursi + "' , HARGA_TIKET from JADWAL_TAYANG  where ID_STUDIO = '" + idStudio + "' and ID_FILM = '" + idFilm + "' and TANGGAL_TAYANG = '" + tgl + "' and JAM_TAYANG = '" + JamTayang + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(totalHarga);

                FormKonfirmasi formKonfirmasi = new FormKonfirmasi();
                formKonfirmasi.Film = labelOutputFilm.Text;
                formKonfirmasi.tgl = labelOutputTgl.Text;
                formKonfirmasi.JamTayang = labelOutputJamTayang.Text;
                formKonfirmasi.Studio = labelOutputStudio.Text;
                formKonfirmasi.Kursi = kursi;
                formKonfirmasi.TotalHarga = totalHarga.Rows[0][0].ToString();
                formKonfirmasi.Harga = totalHarga.Rows[0][1].ToString();
                formKonfirmasi.BanyakKursi = hitungKursi.ToString();
                formKonfirmasi.IdJadwal = IdJadwal;
                formKonfirmasi.IdStaff = IdStaff;

                formKonfirmasi.Show();
            }
            
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            if (btnA1.BackColor == Color.Yellow)
            {
                btnA1.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA1.BackColor = Color.Yellow;
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if (btnA2.BackColor == Color.Yellow)
            {
                btnA2.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA2.BackColor = Color.Yellow;
            }
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (btnA3.BackColor == Color.Yellow)
            {
                btnA3.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA3.BackColor = Color.Yellow;
            }
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            if (btnA4.BackColor == Color.Yellow)
            {
                btnA4.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA4.BackColor = Color.Yellow;
            }
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            if (btnA5.BackColor == Color.Yellow)
            {
                btnA5.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA5.BackColor = Color.Yellow;
            }
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            if (btnA6.BackColor == Color.Yellow)
            {
                btnA6.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA6.BackColor = Color.Yellow;
            }
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            if (btnA7.BackColor == Color.Yellow)
            {
                btnA7.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA7.BackColor = Color.Yellow;
            }
        }

        private void btnA8_Click(object sender, EventArgs e)
        {
            if (btnA8.BackColor == Color.Yellow)
            {
                btnA8.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA8.BackColor = Color.Yellow;
            }
        }

        private void btnA9_Click(object sender, EventArgs e)
        {
            if (btnA9.BackColor == Color.Yellow)
            {
                btnA9.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA9.BackColor = Color.Yellow;
            }
        }

        private void btnA10_Click(object sender, EventArgs e)
        {
            if (btnA10.BackColor == Color.Yellow)
            {
                btnA10.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA10.BackColor = Color.Yellow;
            }
        }

        private void btnA11_Click(object sender, EventArgs e)
        {
            if (btnA11.BackColor == Color.Yellow)
            {
                btnA11.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA11.BackColor = Color.Yellow;
            }
        }

        private void btnA12_Click(object sender, EventArgs e)
        {
            if (btnA12.BackColor == Color.Yellow)
            {
                btnA12.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA12.BackColor = Color.Yellow;
            }
        }

        private void btnA13_Click(object sender, EventArgs e)
        {
            if (btnA13.BackColor == Color.Yellow)
            {
                btnA13.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA13.BackColor = Color.Yellow;
            }
        }

        private void btnA14_Click(object sender, EventArgs e)
        {
            if (btnA14.BackColor == Color.Yellow)
            {
                btnA14.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA14.BackColor = Color.Yellow;
            }
        }

        private void btnA15_Click(object sender, EventArgs e)
        {
            if (btnA15.BackColor == Color.Yellow)
            {
                btnA15.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA15.BackColor = Color.Yellow;
            }
        }

        private void btnA16_Click(object sender, EventArgs e)
        {
            if (btnA16.BackColor == Color.Yellow)
            {
                btnA16.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA16.BackColor = Color.Yellow;
            }
        }

        private void btnA17_Click(object sender, EventArgs e)
        {
            if (btnA17.BackColor == Color.Yellow)
            {
                btnA17.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA17.BackColor = Color.Yellow;
            }
        }

        private void btnA18_Click(object sender, EventArgs e)
        {
            if (btnA18.BackColor == Color.Yellow)
            {
                btnA18.BackColor = Color.PaleGreen;
            }
            else
            {
                btnA18.BackColor = Color.Yellow;
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            if (btnB1.BackColor == Color.Yellow)
            {
                btnB1.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB1.BackColor = Color.Yellow;
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (btnB2.BackColor == Color.Yellow)
            {
                btnB2.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB2.BackColor = Color.Yellow;
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (btnB3.BackColor == Color.Yellow)
            {
                btnB3.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB3.BackColor = Color.Yellow;
            }
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if (btnB4.BackColor == Color.Yellow)
            {
                btnB4.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB4.BackColor = Color.Yellow;
            }
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if (btnB5.BackColor == Color.Yellow)
            {
                btnB5.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB5.BackColor = Color.Yellow;
            }
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            if (btnB6.BackColor == Color.Yellow)
            {
                btnB6.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB6.BackColor = Color.Yellow;
            }
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            if (btnB7.BackColor == Color.Yellow)
            {
                btnB7.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB7.BackColor = Color.Yellow;
            }
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            if (btnB8.BackColor == Color.Yellow)
            {
                btnB8.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB8.BackColor = Color.Yellow;
            }
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            if (btnB9.BackColor == Color.Yellow)
            {
                btnB9.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB9.BackColor = Color.Yellow;
            }
        }

        private void btnB10_Click(object sender, EventArgs e)
        {
            if (btnB10.BackColor == Color.Yellow)
            {
                btnB10.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB10.BackColor = Color.Yellow;
            }
        }

        private void btnB11_Click(object sender, EventArgs e)
        {
            if (btnB11.BackColor == Color.Yellow)
            {
                btnB11.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB11.BackColor = Color.Yellow;
            }
        }

        private void btnB12_Click(object sender, EventArgs e)
        {
            if (btnB12.BackColor == Color.Yellow)
            {
                btnB12.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB12.BackColor = Color.Yellow;
            }
        }

        private void btnB13_Click(object sender, EventArgs e)
        {
            if (btnB13.BackColor == Color.Yellow)
            {
                btnB13.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB13.BackColor = Color.Yellow;
            }
        }

        private void btnB14_Click(object sender, EventArgs e)
        {
            if (btnB14.BackColor == Color.Yellow)
            {
                btnB14.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB14.BackColor = Color.Yellow;
            }
        }

        private void btnB15_Click(object sender, EventArgs e)
        {
            if (btnB15.BackColor == Color.Yellow)
            {
                btnB15.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB15.BackColor = Color.Yellow;
            }
        }

        private void btnB16_Click(object sender, EventArgs e)
        {
            if (btnB16.BackColor == Color.Yellow)
            {
                btnB16.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB16.BackColor = Color.Yellow;
            }
        }

        private void btnB17_Click(object sender, EventArgs e)
        {
            if (btnB17.BackColor == Color.Yellow)
            {
                btnB17.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB17.BackColor = Color.Yellow;
            }
        }

        private void btnB18_Click(object sender, EventArgs e)
        {
            if (btnB18.BackColor == Color.Yellow)
            {
                btnB18.BackColor = Color.PaleGreen;
            }
            else
            {
                btnB18.BackColor = Color.Yellow;
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (btnC1.BackColor == Color.Yellow)
            {
                btnC1.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC1.BackColor = Color.Yellow;
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (btnC2.BackColor == Color.Yellow)
            {
                btnC2.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC2.BackColor = Color.Yellow;
            }
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (btnC3.BackColor == Color.Yellow)
            {
                btnC3.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC3.BackColor = Color.Yellow;
            }
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            if (btnC4.BackColor == Color.Yellow)
            {
                btnC4.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC4.BackColor = Color.Yellow;
            }
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            if (btnC5.BackColor == Color.Yellow)
            {
                btnC5.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC5.BackColor = Color.Yellow;
            }
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            if (btnC6.BackColor == Color.Yellow)
            {
                btnC6.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC6.BackColor = Color.Yellow;
            }
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            if (btnC7.BackColor == Color.Yellow)
            {
                btnC7.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC7.BackColor = Color.Yellow;
            }
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            if (btnC8.BackColor == Color.Yellow)
            {
                btnC8.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC8.BackColor = Color.Yellow;
            }
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            if (btnC9.BackColor == Color.Yellow)
            {
                btnC9.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC9.BackColor = Color.Yellow;
            }
        }

        private void btnC10_Click(object sender, EventArgs e)
        {
            if (btnC10.BackColor == Color.Yellow)
            {
                btnC10.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC10.BackColor = Color.Yellow;
            }
        }

        private void btnC11_Click(object sender, EventArgs e)
        {
            if (btnC11.BackColor == Color.Yellow)
            {
                btnC11.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC11.BackColor = Color.Yellow;
            }
        }

        private void btnC12_Click(object sender, EventArgs e)
        {
            if (btnC12.BackColor == Color.Yellow)
            {
                btnC12.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC12.BackColor = Color.Yellow;
            }
        }

        private void btnC13_Click(object sender, EventArgs e)
        {
            if (btnC13.BackColor == Color.Yellow)
            {
                btnC13.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC13.BackColor = Color.Yellow;
            }
        }

        private void btnC14_Click(object sender, EventArgs e)
        {
            if (btnC14.BackColor == Color.Yellow)
            {
                btnC14.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC14.BackColor = Color.Yellow;
            }
        }

        private void btnC15_Click(object sender, EventArgs e)
        {
            if (btnC15.BackColor == Color.Yellow)
            {
                btnC15.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC15.BackColor = Color.Yellow;
            }
        }

        private void btnC16_Click(object sender, EventArgs e)
        {
            if (btnC16.BackColor == Color.Yellow)
            {
                btnC16.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC16.BackColor = Color.Yellow;
            }
        }

        private void btnC17_Click(object sender, EventArgs e)
        {
            if (btnC17.BackColor == Color.Yellow)
            {
                btnC17.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC17.BackColor = Color.Yellow;
            }
        }

        private void btnC18_Click(object sender, EventArgs e)
        {
            if (btnC18.BackColor == Color.Yellow)
            {
                btnC18.BackColor = Color.PaleGreen;
            }
            else
            {
                btnC18.BackColor = Color.Yellow;
            }
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            if (btnD1.BackColor == Color.Yellow)
            {
                btnD1.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD1.BackColor = Color.Yellow;
            }
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            if (btnD2.BackColor == Color.Yellow)
            {
                btnD2.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD2.BackColor = Color.Yellow;
            }
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            if (btnD3.BackColor == Color.Yellow)
            {
                btnD3.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD3.BackColor = Color.Yellow;
            }
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            if (btnD4.BackColor == Color.Yellow)
            {
                btnD4.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD4.BackColor = Color.Yellow;
            }
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            if (btnD5.BackColor == Color.Yellow)
            {
                btnD5.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD5.BackColor = Color.Yellow;
            }
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            if (btnD6.BackColor == Color.Yellow)
            {
                btnD6.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD6.BackColor = Color.Yellow;
            }
        }

        private void btnD7_Click(object sender, EventArgs e)
        {
            if (btnD7.BackColor == Color.Yellow)
            {
                btnD7.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD7.BackColor = Color.Yellow;
            }
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            if (btnD8.BackColor == Color.Yellow)
            {
                btnD8.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD8.BackColor = Color.Yellow;
            }
        }

        private void btnD9_Click(object sender, EventArgs e)
        {
            if (btnD9.BackColor == Color.Yellow)
            {
                btnD9.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD9.BackColor = Color.Yellow;
            }
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            if (btnD10.BackColor == Color.Yellow)
            {
                btnD10.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD10.BackColor = Color.Yellow;
            }
        }

        private void btnD11_Click(object sender, EventArgs e)
        {
            if (btnD11.BackColor == Color.Yellow)
            {
                btnD11.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD11.BackColor = Color.Yellow;
            }
        }

        private void btnD12_Click(object sender, EventArgs e)
        {
            if (btnD12.BackColor == Color.Yellow)
            {
                btnD12.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD12.BackColor = Color.Yellow;
            }
        }

        private void btnD13_Click(object sender, EventArgs e)
        {
            if (btnD13.BackColor == Color.Yellow)
            {
                btnD13.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD13.BackColor = Color.Yellow;
            }
        }

        private void btnD14_Click(object sender, EventArgs e)
        {
            if (btnD14.BackColor == Color.Yellow)
            {
                btnD14.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD14.BackColor = Color.Yellow;
            }
        }

        private void btnD15_Click(object sender, EventArgs e)
        {
            if (btnD15.BackColor == Color.Yellow)
            {
                btnD15.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD15.BackColor = Color.Yellow;
            }
        }

        private void btnD16_Click(object sender, EventArgs e)
        {
            if (btnD16.BackColor == Color.Yellow)
            {
                btnD16.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD16.BackColor = Color.Yellow;
            }
        }

        private void btnD17_Click(object sender, EventArgs e)
        {
            if (btnD17.BackColor == Color.Yellow)
            {
                btnD17.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD17.BackColor = Color.Yellow;
            }
        }

        private void btnD18_Click(object sender, EventArgs e)
        {
            if (btnD18.BackColor == Color.Yellow)
            {
                btnD18.BackColor = Color.PaleGreen;
            }
            else
            {
                btnD18.BackColor = Color.Yellow;
            }
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            if (btnE1.BackColor == Color.Yellow)
            {
                btnE1.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE1.BackColor = Color.Yellow;
            }
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            if (btnE2.BackColor == Color.Yellow)
            {
                btnE2.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE2.BackColor = Color.Yellow;
            }
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            if (btnE2.BackColor == Color.Yellow)
            {
                btnE2.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE2.BackColor = Color.Yellow;
            }
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            if (btnE4.BackColor == Color.Yellow)
            {
                btnE4.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE4.BackColor = Color.Yellow;
            }
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            if (btnE5.BackColor == Color.Yellow)
            {
                btnE5.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE5.BackColor = Color.Yellow;
            }
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            if (btnE6.BackColor == Color.Yellow)
            {
                btnE6.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE6.BackColor = Color.Yellow;
            }
        }

        private void btnE7_Click(object sender, EventArgs e)
        {
            if (btnE7.BackColor == Color.Yellow)
            {
                btnE7.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE7.BackColor = Color.Yellow;
            }
        }

        private void btnE8_Click(object sender, EventArgs e)
        {
            if (btnE8.BackColor == Color.Yellow)
            {
                btnE8.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE8.BackColor = Color.Yellow;
            }
        }

        private void btnE9_Click(object sender, EventArgs e)
        {
            if (btnE9.BackColor == Color.Yellow)
            {
                btnE9.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE9.BackColor = Color.Yellow;
            }
        }

        private void btnE10_Click(object sender, EventArgs e)
        {
            if (btnE10.BackColor == Color.Yellow)
            {
                btnE10.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE10.BackColor = Color.Yellow;
            }
        }

        private void btnE11_Click(object sender, EventArgs e)
        {
            if (btnE11.BackColor == Color.Yellow)
            {
                btnE11.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE11.BackColor = Color.Yellow;
            }
        }

        private void btnE12_Click(object sender, EventArgs e)
        {
            if (btnE12.BackColor == Color.Yellow)
            {
                btnE12.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE12.BackColor = Color.Yellow;
            }
        }

        private void btnE13_Click(object sender, EventArgs e)
        {
            if (btnE13.BackColor == Color.Yellow)
            {
                btnE13.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE13.BackColor = Color.Yellow;
            }
        }

        private void btnE14_Click(object sender, EventArgs e)
        {
            if (btnE14.BackColor == Color.Yellow)
            {
                btnE14.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE14.BackColor = Color.Yellow;
            }
        }

        private void btnE15_Click(object sender, EventArgs e)
        {
            if (btnE15.BackColor == Color.Yellow)
            {
                btnE15.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE15.BackColor = Color.Yellow;
            }
        }

        private void btnE16_Click(object sender, EventArgs e)
        {
            if (btnE16.BackColor == Color.Yellow)
            {
                btnE16.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE16.BackColor = Color.Yellow;
            }
        }

        private void btnE17_Click(object sender, EventArgs e)
        {
            if (btnE17.BackColor == Color.Yellow)
            {
                btnE17.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE17.BackColor = Color.Yellow;
            }
        }

        private void btnE18_Click(object sender, EventArgs e)
        {
            if (btnE18.BackColor == Color.Yellow)
            {
                btnE18.BackColor = Color.PaleGreen;
            }
            else
            {
                btnE18.BackColor = Color.Yellow;
            }
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            if (btnF1.BackColor == Color.Yellow)
            {
                btnF1.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF1.BackColor = Color.Yellow;
            }
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            if (btnF2.BackColor == Color.Yellow)
            {
                btnF2.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF2.BackColor = Color.Yellow;
            }
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            if (btnF3.BackColor == Color.Yellow)
            {
                btnF3.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF3.BackColor = Color.Yellow;
            }
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            if (btnF4.BackColor == Color.Yellow)
            {
                btnF4.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF4.BackColor = Color.Yellow;
            }
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            if (btnF5.BackColor == Color.Yellow)
            {
                btnF5.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF5.BackColor = Color.Yellow;
            }
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            if (btnF6.BackColor == Color.Yellow)
            {
                btnF6.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF6.BackColor = Color.Yellow;
            }
        }

        private void btnF7_Click(object sender, EventArgs e)
        {
            if (btnF7.BackColor == Color.Yellow)
            {
                btnF7.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF7.BackColor = Color.Yellow;
            }
        }

        private void btnF8_Click(object sender, EventArgs e)
        {
            if (btnF8.BackColor == Color.Yellow)
            {
                btnF8.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF8.BackColor = Color.Yellow;
            }
        }

        private void btnF9_Click(object sender, EventArgs e)
        {
            if (btnF9.BackColor == Color.Yellow)
            {
                btnF9.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF9.BackColor = Color.Yellow;
            }
        }

        private void btnF10_Click(object sender, EventArgs e)
        {
            if (btnF10.BackColor == Color.Yellow)
            {
                btnF10.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF10.BackColor = Color.Yellow;
            }
        }

        private void btnF11_Click(object sender, EventArgs e)
        {
            if (btnF11.BackColor == Color.Yellow)
            {
                btnF11.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF11.BackColor = Color.Yellow;
            }
        }

        private void btnF12_Click(object sender, EventArgs e)
        {
            if (btnF12.BackColor == Color.Yellow)
            {
                btnF12.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF12.BackColor = Color.Yellow;
            }
        }

        private void btnF13_Click(object sender, EventArgs e)
        {
            if (btnF13.BackColor == Color.Yellow)
            {
                btnF13.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF13.BackColor = Color.Yellow;
            }
        }

        private void btnF14_Click(object sender, EventArgs e)
        {
            if (btnF14.BackColor == Color.Yellow)
            {
                btnF14.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF14.BackColor = Color.Yellow;
            }
        }

        private void btnF15_Click(object sender, EventArgs e)
        {
            if (btnF15.BackColor == Color.Yellow)
            {
                btnF15.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF15.BackColor = Color.Yellow;
            }
        }

        private void btnF16_Click(object sender, EventArgs e)
        {
            if (btnF16.BackColor == Color.Yellow)
            {
                btnF16.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF16.BackColor = Color.Yellow;
            }
        }

        private void btnF17_Click(object sender, EventArgs e)
        {
            if (btnF17.BackColor == Color.Yellow)
            {
                btnF17.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF17.BackColor = Color.Yellow;
            }
        }

        private void btnF18_Click(object sender, EventArgs e)
        {
            if (btnF18.BackColor == Color.Yellow)
            {
                btnF18.BackColor = Color.PaleGreen;
            }
            else
            {
                btnF18.BackColor = Color.Yellow;
            }
        }

        private void btnG1_Click(object sender, EventArgs e)
        {
            if (btnG1.BackColor == Color.Yellow)
            {
                btnG1.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG1.BackColor = Color.Yellow;
            }
        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            if (btnG2.BackColor == Color.Yellow)
            {
                btnG2.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG2.BackColor = Color.Yellow;
            }
        }

        private void btnG3_Click(object sender, EventArgs e)
        {
            if (btnG3.BackColor == Color.Yellow)
            {
                btnG3.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG3.BackColor = Color.Yellow;
            }
        }

        private void btnG4_Click(object sender, EventArgs e)
        {
            if (btnG4.BackColor == Color.Yellow)
            {
                btnG4.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG4.BackColor = Color.Yellow;
            }
        }

        private void btnG5_Click(object sender, EventArgs e)
        {
            if (btnG5.BackColor == Color.Yellow)
            {
                btnG5.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG5.BackColor = Color.Yellow;
            }
        }

        private void btnG6_Click(object sender, EventArgs e)
        {
            if (btnG6.BackColor == Color.Yellow)
            {
                btnG6.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG6.BackColor = Color.Yellow;
            }
        }

        private void btnG7_Click(object sender, EventArgs e)
        {
            if (btnG7.BackColor == Color.Yellow)
            {
                btnG7.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG7.BackColor = Color.Yellow;
            }
        }

        private void btnG8_Click(object sender, EventArgs e)
        {
            if (btnG8.BackColor == Color.Yellow)
            {
                btnG8.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG8.BackColor = Color.Yellow;
            }
        }

        private void btnG9_Click(object sender, EventArgs e)
        {
            if (btnG9.BackColor == Color.Yellow)
            {
                btnG9.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG9.BackColor = Color.Yellow;
            }
        }

        private void btnG10_Click(object sender, EventArgs e)
        {
            if (btnG10.BackColor == Color.Yellow)
            {
                btnG10.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG10.BackColor = Color.Yellow;
            }
        }

        private void btnG11_Click(object sender, EventArgs e)
        {
            if (btnG11.BackColor == Color.Yellow)
            {
                btnG11.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG11.BackColor = Color.Yellow;
            }
        }

        private void btnG12_Click(object sender, EventArgs e)
        {
            if (btnG12.BackColor == Color.Yellow)
            {
                btnG12.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG12.BackColor = Color.Yellow;
            }
        }

        private void btnG13_Click(object sender, EventArgs e)
        {
            if (btnG13.BackColor == Color.Yellow)
            {
                btnG13.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG13.BackColor = Color.Yellow;
            }
        }

        private void btnG14_Click(object sender, EventArgs e)
        {
            if (btnG14.BackColor == Color.Yellow)
            {
                btnG14.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG14.BackColor = Color.Yellow;
            }
        }

        private void btnG15_Click(object sender, EventArgs e)
        {
            if (btnG15.BackColor == Color.Yellow)
            {
                btnG15.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG15.BackColor = Color.Yellow;
            }
        }

        private void btnG16_Click(object sender, EventArgs e)
        {
            if (btnG16.BackColor == Color.Yellow)
            {
                btnG16.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG16.BackColor = Color.Yellow;
            }
        }

        private void btnG17_Click(object sender, EventArgs e)
        {
            if (btnG17.BackColor == Color.Yellow)
            {
                btnG17.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG17.BackColor = Color.Yellow;
            }
        }

        private void btnG18_Click(object sender, EventArgs e)
        {
            if (btnG18.BackColor == Color.Yellow)
            {
                btnG18.BackColor = Color.PaleGreen;
            }
            else
            {
                btnG18.BackColor = Color.Yellow;
            }
        }
    }
}