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
            DataTable dtStudio = new DataTable();
            sqlQuery = "select ID_STUDIO, JENIS_STUDIO from STUDIO_BIOSKOP";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStudio);
            cbStudio.DataSource = dtStudio;
            cbStudio.DisplayMember = "JENIS_STUDIO";
            cbStudio.ValueMember = "ID_STUDIO";

            DataTable dtFilm = new DataTable();
            sqlQuery = "select ID_FILM, JUDUL_FILM from FILM";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtFilm);
            cbFilm.DataSource = dtFilm;
            cbFilm.DisplayMember = "JUDUL_FILM";
            cbFilm.ValueMember = "ID_FILM";

            DataTable dtJam = new DataTable();
            sqlQuery = "select ID_JADWAL, JAM_TAYANG from JADWAL_TAYANG group by 2";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtJam);
            cbJamTayang.DataSource = dtJam;
            cbJamTayang.DisplayMember = "JAM_TAYANG";
            cbJamTayang.ValueMember = "JAM_TAYANG";
        }
    }
}
