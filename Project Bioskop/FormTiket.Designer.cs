namespace Project_Bioskop
{
    partial class FormTiket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTiket));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblJudulFilm = new System.Windows.Forms.Label();
            this.labelteater = new System.Windows.Forms.Label();
            this.labelTheater = new System.Windows.Forms.Label();
            this.labelhari = new System.Windows.Forms.Label();
            this.lblTanggalMain = new System.Windows.Forms.Label();
            this.labelKursi = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(979, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblJudulFilm
            // 
            this.lblJudulFilm.AutoSize = true;
            this.lblJudulFilm.BackColor = System.Drawing.Color.Firebrick;
            this.lblJudulFilm.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulFilm.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJudulFilm.Location = new System.Drawing.Point(241, 62);
            this.lblJudulFilm.Name = "lblJudulFilm";
            this.lblJudulFilm.Size = new System.Drawing.Size(110, 30);
            this.lblJudulFilm.TabIndex = 1;
            this.lblJudulFilm.Text = "JUDUL";
            // 
            // labelteater
            // 
            this.labelteater.AutoSize = true;
            this.labelteater.Location = new System.Drawing.Point(270, 138);
            this.labelteater.Name = "labelteater";
            this.labelteater.Size = new System.Drawing.Size(72, 20);
            this.labelteater.TabIndex = 2;
            this.labelteater.Text = "Theater: ";
            // 
            // labelTheater
            // 
            this.labelTheater.AutoSize = true;
            this.labelTheater.Location = new System.Drawing.Point(424, 138);
            this.labelTheater.Name = "labelTheater";
            this.labelTheater.Size = new System.Drawing.Size(24, 20);
            this.labelTheater.TabIndex = 3;
            this.labelTheater.Text = "---";
            // 
            // labelhari
            // 
            this.labelhari.AutoSize = true;
            this.labelhari.Location = new System.Drawing.Point(270, 181);
            this.labelhari.Name = "labelhari";
            this.labelhari.Size = new System.Drawing.Size(52, 20);
            this.labelhari.TabIndex = 4;
            this.labelhari.Text = "Date: ";
            // 
            // lblTanggalMain
            // 
            this.lblTanggalMain.AutoSize = true;
            this.lblTanggalMain.Location = new System.Drawing.Point(424, 181);
            this.lblTanggalMain.Name = "lblTanggalMain";
            this.lblTanggalMain.Size = new System.Drawing.Size(24, 20);
            this.lblTanggalMain.TabIndex = 5;
            this.lblTanggalMain.Text = "---";
            // 
            // labelKursi
            // 
            this.labelKursi.AutoSize = true;
            this.labelKursi.Location = new System.Drawing.Point(270, 230);
            this.labelKursi.Name = "labelKursi";
            this.labelKursi.Size = new System.Drawing.Size(51, 20);
            this.labelKursi.TabIndex = 6;
            this.labelKursi.Text = "Seat: ";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(424, 230);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(24, 20);
            this.lblSeat.TabIndex = 7;
            this.lblSeat.Text = "---";
            // 
            // FormTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 425);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.labelKursi);
            this.Controls.Add(this.lblTanggalMain);
            this.Controls.Add(this.labelhari);
            this.Controls.Add(this.labelTheater);
            this.Controls.Add(this.labelteater);
            this.Controls.Add(this.lblJudulFilm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormTiket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTiket_FormClosed);
            this.Load += new System.EventHandler(this.FormTiket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblJudulFilm;
        private System.Windows.Forms.Label labelteater;
        private System.Windows.Forms.Label labelTheater;
        private System.Windows.Forms.Label labelhari;
        private System.Windows.Forms.Label lblTanggalMain;
        private System.Windows.Forms.Label labelKursi;
        private System.Windows.Forms.Label lblSeat;
    }
}