﻿using System;
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
    public partial class FormKonfirmasi : Form
    {
        public string tgl { get; set; }
        public string Studio { get; set; }
        public string Film { get; set; }
        public string JamTayang { get; set; }
        public string Kursi { get; set; }

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
        }
    }
}