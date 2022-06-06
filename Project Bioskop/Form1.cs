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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_05_BIOSKOP";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;
        DataTable dtStudio = new DataTable();
        DataTable dtJamTayang = new DataTable();

        private void btnGoStudio_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataTable dtStudioPremiere = new DataTable();
            sqlQuery = "select ID_STUDIO from STUDIO_BIOSKOP where ID_STUDIO = 'STD01' and ID_STUDIO = '"+cbStudio.SelectedValue.ToString()+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStudioPremiere);

            DataTable dtStudioImax = new DataTable();
            sqlQuery = "select ID_STUDIO from STUDIO_BIOSKOP where ID_STUDIO = 'STD02' and ID_STUDIO = '" + cbStudio.SelectedValue.ToString() + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStudioImax);

            DataTable dtStudioDolby = new DataTable();
            sqlQuery = "select ID_STUDIO from STUDIO_BIOSKOP where ID_STUDIO = 'STD03' and ID_STUDIO = '" + cbStudio.SelectedValue.ToString() + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStudioDolby);

            DataTable dtStudioRegular = new DataTable();
            sqlQuery = "select ID_STUDIO from STUDIO_BIOSKOP where (ID_STUDIO = 'STD04' or ID_STUDIO = 'STD05' or ID_STUDIO = 'STD06' or ID_STUDIO = 'STD07') and ID_STUDIO = '" + cbStudio.SelectedValue.ToString() + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStudioRegular);

            if (dtStudioPremiere.Rows.Count > 0)
            {
                FormThePremiere formPremiere = new FormThePremiere();
                formPremiere.Show();
            }
            else if (dtStudioImax.Rows.Count > 0)
            {
                FormImax formImax = new FormImax();
                formImax.Show();
            }
            else if(dtStudioDolby.Rows.Count > 0)
            {
                FormDolbyAtmos formDolby = new FormDolbyAtmos();
                formDolby.Show();
            }
            else if(dtStudioRegular.Rows.Count > 0)
            {
                FormRegular formRegular = new FormRegular();
                formRegular.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {
            DataTable dtFilm = new DataTable();
            sqlQuery = "select ID_FILM, JUDUL_FILM from FILM";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtFilm);
            cbFilm.DataSource = dtFilm;
            cbFilm.DisplayMember = "JUDUL_FILM";
            cbFilm.ValueMember = "ID_FILM";
        }

        private void cbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtStudio = new DataTable();
            sqlQuery = "select sb.ID_STUDIO, sb.JENIS_STUDIO from STUDIO_BIOSKOP sb, JADWAL_TAYANG jy, FILM f where sb.ID_STUDIO = jy.ID_STUDIO and f.ID_FILM = jy.ID_FILM and f.ID_FILM = '"+cbFilm.SelectedValue.ToString()+ "' and jy.TANGGAL_TAYANG = '" + dtpTanggal.Value.ToString("yyyy-MM-dd") + "' group by 1 order by 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStudio);
            cbStudio.DataSource = dtStudio;
            cbStudio.DisplayMember = "JENIS_STUDIO";
            cbStudio.ValueMember = "ID_STUDIO";
        }

        private void cbStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtJamTayang = new DataTable();
            sqlQuery = "select jy.ID_JADWAL, jy.JAM_TAYANG from STUDIO_BIOSKOP sb, JADWAL_TAYANG jy, FILM f where sb.ID_STUDIO = jy.ID_STUDIO and f.ID_FILM = jy.ID_FILM and f.ID_FILM = '" + cbFilm.SelectedValue.ToString() + "' and sb.ID_STUDIO = '"+cbStudio.SelectedValue.ToString()+"' and jy.TANGGAL_TAYANG = '"+ dtpTanggal.Value.ToString("yyyy-MM-dd") + "' group by 1 order by 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtJamTayang);
            cbJamTayang.DataSource = dtJamTayang;
            cbJamTayang.DisplayMember = "JAM_TAYANG";
            cbJamTayang.ValueMember = "ID_JADWAL";
        }
    }
}
