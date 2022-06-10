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
    public partial class FormKasirSnack : Form
    {
        public FormKasirSnack()
        {
            InitializeComponent();
        }
        
        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_05_BIOSKOP";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;
        DataTable dtMenu = new DataTable(); // BUAT MENU
        DataTable dtPegawai = new DataTable();
        int Posisi = 0;

        private void FormKasirSnack_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT NAMA_SNACK, ID_SNACK, HARGA_SNACK FROM SNACK;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMenu);
            cbMenu.DataSource = dtMenu;
            cbMenu.DisplayMember = "NAMA_SNACK";
            cbMenu.ValueMember = "ID_SNACK";


            sqlQuery = "SELECT NAMA_STAFF, ID_STAFF FROM STAFF where JABATAN_PEGAWAI = 'PENJUAL SNACK'; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPegawai);
            comboBoxStaff.DataSource = dtPegawai;
            comboBoxStaff.DisplayMember = "NAMA_STAFF";
            comboBoxStaff.ValueMember = "ID_STAFF";

        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable snack = new DataTable();
                sqlQuery = "SELECT NAMA_SNACK, ID_SNACK,HARGA_SNACK FROM SNACK WHERE ID_SNACK = '" + cbMenu.SelectedValue.ToString() + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(snack);

                labelIDSnack.Text = snack.Rows[0][1].ToString();

                DataTable harga = new DataTable();
                sqlQuery = "SELECT NAMA_SNACK, ID_SNACK,HARGA_SNACK FROM SNACK WHERE ID_SNACK = '" + cbMenu.SelectedValue.ToString() + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(harga);

                piro.Text = harga.Rows[0][2].ToString();



            }
            catch (Exception ex)
            {


            }

        }

        private void bykbrg_ValueChanged(object sender, EventArgs e)
        {
            DataTable hargas = new DataTable();
            sqlQuery = "SELECT NAMA_SNACK, ID_SNACK,HARGA_SNACK FROM SNACK WHERE ID_SNACK = '" + cbMenu.SelectedValue.ToString() + "' ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(hargas);
            int count = Convert.ToInt32(Math.Round(bykbrg.Value, 0));

            var baru = count * Convert.ToInt32(piro.Text);
            //label5.Text = baru.ToString();

        }
        int plus = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(Math.Round(bykbrg.Value, 0));


            var makandipilih = cbMenu.SelectedValue.ToString();
            var qtyne = bykbrg.Value.ToString();
            var tothargae = sum * Convert.ToInt32(piro.Text);

            dgvMenu.Rows.Add(makandipilih, qtyne, tothargae);

            
            for (int i = 0; i < dgvMenu.Rows.Count; i++)
            {
                plus += Convert.ToInt32(dgvMenu.Rows[i].Cells[2].Value);
            }
            label3.Text = plus.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMenu.SelectedRows)
            {
                dgvMenu.Rows.RemoveAt(row.Index);
            }

            int plus = 0;
            for (int i = 0; i < dgvMenu.Rows.Count; i++)
            {
                plus += Convert.ToInt32(dgvMenu.Rows[i].Cells[2].Value);
            }
            label3.Text = plus.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPegawaiii = new DataTable();
                sqlQuery = "SELECT NAMA_STAFF, ID_STAFF FROM STAFF where JABATAN_PEGAWAI = 'PENJUAL SNACK' and ID_STAFF = '" + comboBoxStaff.SelectedValue.ToString() + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiii);

                labelidstaff.Text = dtPegawaiii.Rows[0][1].ToString();

            }
            catch (Exception ex)
            {


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvMenu.Rows.Clear();

            int plus = 0;
            for (int i = 0; i < dgvMenu.Rows.Count; i++)
            {
                plus += Convert.ToInt32(dgvMenu.Rows[i].Cells[2].Value);
            }
            label3.Text = plus.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                int value = Convert.ToInt32(textBoxcash.Text);
                int totalvalue = Convert.ToInt32(label3.Text);
                int titip;

                titip = value - totalvalue;
                labelchange.Text = titip.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBoxcash.Enabled = false;
                textBoxcash.Text = label3.Text;
                labelchange.Text = "0";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable idJualSnack = new DataTable();
            sqlQuery = "select ID_JUAL_SNACK from PENJUALAN_SNACK";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(idJualSnack);
            int count = idJualSnack.Rows.Count;
            string idAkhir = idJualSnack.Rows[count - 1][0].ToString();
            //double pisah = Math.Round(Convert.ToDouble(idAkhir.Substring(2)));
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
            int totalQty = 0;
            for (int i = 0; i < dgvMenu.Rows.Count-1; i++)
            {
                totalQty += Convert.ToInt32(dgvMenu.Rows[i].Cells[1].Value);
                sqlQuery = "insert into PENJUALAN_SNACK2 values(concat('JS','" + hitungID + "'),'" + dgvMenu.Rows[i].Cells[0].Value.ToString() + "','" + dgvMenu.Rows[i].Cells[1].Value.ToString() + "');";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            sqlQuery = "insert into PENJUALAN_SNACK values(concat('JS','" + hitungID + "'), '" + comboBoxStaff.SelectedValue.ToString() + "', '" + dateTimePickerSnack.Value.ToString("yyyy-MM-dd") + "', '" + totalQty.ToString() + "','" + plus.ToString() + "','0');";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            MessageBox.Show("Data Masuk");

            this.Hide();
            FormStrukSnack formStrukSnack = new FormStrukSnack();
            formStrukSnack.Show();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
