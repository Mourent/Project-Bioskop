
namespace Project_Bioskop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGoStudio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbStudio = new System.Windows.Forms.ComboBox();
            this.labelStudio = new System.Windows.Forms.Label();
            this.cbJamTayang = new System.Windows.Forms.ComboBox();
            this.cbFilm = new System.Windows.Forms.ComboBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.labelJamTayang = new System.Windows.Forms.Label();
            this.labelFilm = new System.Windows.Forms.Label();
            this.labelTgl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStaffTiket = new System.Windows.Forms.ComboBox();
            this.labelidstafftiket = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoStudio
            // 
            this.btnGoStudio.Location = new System.Drawing.Point(376, 522);
            this.btnGoStudio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoStudio.Name = "btnGoStudio";
            this.btnGoStudio.Size = new System.Drawing.Size(186, 52);
            this.btnGoStudio.TabIndex = 19;
            this.btnGoStudio.Text = "Go To Studio";
            this.btnGoStudio.UseVisualStyleBackColor = true;
            this.btnGoStudio.Click += new System.EventHandler(this.btnGoStudio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 115);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // cbStudio
            // 
            this.cbStudio.FormattingEnabled = true;
            this.cbStudio.Location = new System.Drawing.Point(338, 400);
            this.cbStudio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStudio.Name = "cbStudio";
            this.cbStudio.Size = new System.Drawing.Size(307, 28);
            this.cbStudio.TabIndex = 17;
            this.cbStudio.SelectedIndexChanged += new System.EventHandler(this.cbStudio_SelectedIndexChanged);
            // 
            // labelStudio
            // 
            this.labelStudio.AutoSize = true;
            this.labelStudio.Location = new System.Drawing.Point(264, 400);
            this.labelStudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudio.Name = "labelStudio";
            this.labelStudio.Size = new System.Drawing.Size(63, 20);
            this.labelStudio.TabIndex = 16;
            this.labelStudio.Text = "Studio :";
            // 
            // cbJamTayang
            // 
            this.cbJamTayang.FormattingEnabled = true;
            this.cbJamTayang.Location = new System.Drawing.Point(338, 455);
            this.cbJamTayang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbJamTayang.Name = "cbJamTayang";
            this.cbJamTayang.Size = new System.Drawing.Size(307, 28);
            this.cbJamTayang.TabIndex = 15;
            // 
            // cbFilm
            // 
            this.cbFilm.FormattingEnabled = true;
            this.cbFilm.Location = new System.Drawing.Point(338, 343);
            this.cbFilm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFilm.Name = "cbFilm";
            this.cbFilm.Size = new System.Drawing.Size(307, 28);
            this.cbFilm.TabIndex = 14;
            this.cbFilm.SelectedIndexChanged += new System.EventHandler(this.cbFilm_SelectedIndexChanged);
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(338, 289);
            this.dtpTanggal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(374, 26);
            this.dtpTanggal.TabIndex = 13;
            this.dtpTanggal.Value = new System.DateTime(2022, 6, 20, 0, 0, 0, 0);
            this.dtpTanggal.ValueChanged += new System.EventHandler(this.dtpTanggal_ValueChanged);
            // 
            // labelJamTayang
            // 
            this.labelJamTayang.AutoSize = true;
            this.labelJamTayang.Location = new System.Drawing.Point(222, 460);
            this.labelJamTayang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJamTayang.Name = "labelJamTayang";
            this.labelJamTayang.Size = new System.Drawing.Size(103, 20);
            this.labelJamTayang.TabIndex = 12;
            this.labelJamTayang.Text = "Jam Tayang :";
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Location = new System.Drawing.Point(282, 348);
            this.labelFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(46, 20);
            this.labelFilm.TabIndex = 11;
            this.labelFilm.Text = "Film :";
            // 
            // labelTgl
            // 
            this.labelTgl.AutoSize = true;
            this.labelTgl.Location = new System.Drawing.Point(250, 289);
            this.labelTgl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTgl.Name = "labelTgl";
            this.labelTgl.Size = new System.Drawing.Size(74, 20);
            this.labelTgl.TabIndex = 10;
            this.labelTgl.Text = "Tanggal :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Staff: ";
            // 
            // cbStaffTiket
            // 
            this.cbStaffTiket.FormattingEnabled = true;
            this.cbStaffTiket.Location = new System.Drawing.Point(92, 643);
            this.cbStaffTiket.Name = "cbStaffTiket";
            this.cbStaffTiket.Size = new System.Drawing.Size(194, 28);
            this.cbStaffTiket.TabIndex = 22;
            this.cbStaffTiket.SelectedIndexChanged += new System.EventHandler(this.cbStaffTiket_SelectedIndexChanged);
            // 
            // labelidstafftiket
            // 
            this.labelidstafftiket.AutoSize = true;
            this.labelidstafftiket.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelidstafftiket.Location = new System.Drawing.Point(301, 646);
            this.labelidstafftiket.Name = "labelidstafftiket";
            this.labelidstafftiket.Size = new System.Drawing.Size(24, 20);
            this.labelidstafftiket.TabIndex = 23;
            this.labelidstafftiket.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 692);
            this.Controls.Add(this.labelidstafftiket);
            this.Controls.Add(this.cbStaffTiket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoStudio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbStudio);
            this.Controls.Add(this.labelStudio);
            this.Controls.Add(this.cbJamTayang);
            this.Controls.Add(this.cbFilm);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.labelJamTayang);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.labelTgl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CINEMA XXI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoStudio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbStudio;
        private System.Windows.Forms.Label labelStudio;
        private System.Windows.Forms.ComboBox cbJamTayang;
        private System.Windows.Forms.ComboBox cbFilm;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label labelJamTayang;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.Label labelTgl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStaffTiket;
        private System.Windows.Forms.Label labelidstafftiket;
    }
}

