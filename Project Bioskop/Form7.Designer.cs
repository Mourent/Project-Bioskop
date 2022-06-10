namespace Project_Bioskop
{
    partial class FormKasirSnack
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
            this.labelidstaff = new System.Windows.Forms.Label();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.piro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bykbrg = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelIDSnack = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.labelchange = new System.Windows.Forms.Label();
            this.textBoxcash = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPembayaran = new System.Windows.Forms.ComboBox();
            this.labelpay = new System.Windows.Forms.Label();
            this.tbNamaCust = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.dateTimePickerSnack = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bykbrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelidstaff
            // 
            this.labelidstaff.AutoSize = true;
            this.labelidstaff.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelidstaff.Location = new System.Drawing.Point(314, 20);
            this.labelidstaff.Name = "labelidstaff";
            this.labelidstaff.Size = new System.Drawing.Size(24, 20);
            this.labelidstaff.TabIndex = 62;
            this.labelidstaff.Text = "---";
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Location = new System.Drawing.Point(102, 16);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(191, 28);
            this.comboBoxStaff.TabIndex = 61;
            this.comboBoxStaff.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(993, 349);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(114, 68);
            this.buttonReset.TabIndex = 60;
            this.buttonReset.Text = "Reset Order";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Staff: ";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(870, 350);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 66);
            this.buttonDelete.TabIndex = 58;
            this.buttonDelete.Text = "Delete Item";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(748, 348);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 68);
            this.buttonAdd.TabIndex = 57;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // piro
            // 
            this.piro.AutoSize = true;
            this.piro.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piro.Location = new System.Drawing.Point(878, 288);
            this.piro.Name = "piro";
            this.piro.Size = new System.Drawing.Size(31, 21);
            this.piro.TabIndex = 56;
            this.piro.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(753, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Qty: ";
            // 
            // bykbrg
            // 
            this.bykbrg.Location = new System.Drawing.Point(882, 223);
            this.bykbrg.Name = "bykbrg";
            this.bykbrg.Size = new System.Drawing.Size(177, 26);
            this.bykbrg.TabIndex = 54;
            this.bykbrg.ValueChanged += new System.EventHandler(this.bykbrg_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1265, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(749, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Price /pc:";
            // 
            // labelIDSnack
            // 
            this.labelIDSnack.AutoSize = true;
            this.labelIDSnack.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDSnack.Location = new System.Drawing.Point(878, 180);
            this.labelIDSnack.Name = "labelIDSnack";
            this.labelIDSnack.Size = new System.Drawing.Size(31, 21);
            this.labelIDSnack.TabIndex = 51;
            this.labelIDSnack.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "ID Snack: ";
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvMenu.Location = new System.Drawing.Point(12, 63);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 62;
            this.dgvMenu.RowTemplate.Height = 28;
            this.dgvMenu.Size = new System.Drawing.Size(692, 598);
            this.dgvMenu.TabIndex = 49;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nama Snack";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qty";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // cbMenu
            // 
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(882, 129);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(353, 28);
            this.cbMenu.TabIndex = 48;
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Menu: ";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.Location = new System.Drawing.Point(1155, 734);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(110, 52);
            this.buttonFinish.TabIndex = 72;
            this.buttonFinish.Text = "Finish ";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelchange
            // 
            this.labelchange.AutoSize = true;
            this.labelchange.Location = new System.Drawing.Point(826, 601);
            this.labelchange.Name = "labelchange";
            this.labelchange.Size = new System.Drawing.Size(24, 20);
            this.labelchange.TabIndex = 71;
            this.labelchange.Text = "---";
            // 
            // textBoxcash
            // 
            this.textBoxcash.Location = new System.Drawing.Point(830, 556);
            this.textBoxcash.Name = "textBoxcash";
            this.textBoxcash.Size = new System.Drawing.Size(237, 26);
            this.textBoxcash.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(744, 556);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "Amount:";
            // 
            // buttonPay
            // 
            this.buttonPay.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.Location = new System.Drawing.Point(1110, 516);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(114, 66);
            this.buttonPay.TabIndex = 68;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 601);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Change:";
            // 
            // comboBoxPembayaran
            // 
            this.comboBoxPembayaran.FormattingEnabled = true;
            this.comboBoxPembayaran.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.comboBoxPembayaran.Location = new System.Drawing.Point(830, 511);
            this.comboBoxPembayaran.Name = "comboBoxPembayaran";
            this.comboBoxPembayaran.Size = new System.Drawing.Size(237, 28);
            this.comboBoxPembayaran.TabIndex = 66;
            // 
            // labelpay
            // 
            this.labelpay.AutoSize = true;
            this.labelpay.Location = new System.Drawing.Point(744, 511);
            this.labelpay.Name = "labelpay";
            this.labelpay.Size = new System.Drawing.Size(66, 20);
            this.labelpay.TabIndex = 65;
            this.labelpay.Text = "Paid By:";
            // 
            // tbNamaCust
            // 
            this.tbNamaCust.Location = new System.Drawing.Point(873, 459);
            this.tbNamaCust.Name = "tbNamaCust";
            this.tbNamaCust.Size = new System.Drawing.Size(293, 26);
            this.tbNamaCust.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(744, 462);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "Customer Name:";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(30, 761);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(110, 52);
            this.buttonBack.TabIndex = 75;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(461, 681);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 29);
            this.label9.TabIndex = 74;
            this.label9.Text = "Total: ";
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.AutoSize = true;
            this.labelTotalHarga.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHarga.Location = new System.Drawing.Point(578, 678);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(40, 30);
            this.labelTotalHarga.TabIndex = 73;
            this.labelTotalHarga.Text = "---";
            // 
            // dateTimePickerSnack
            // 
            this.dateTimePickerSnack.Location = new System.Drawing.Point(967, 22);
            this.dateTimePickerSnack.Name = "dateTimePickerSnack";
            this.dateTimePickerSnack.Size = new System.Drawing.Size(323, 26);
            this.dateTimePickerSnack.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(876, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 77;
            this.label11.Text = "Tanggal: ";
            // 
            // FormKasirSnack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1317, 825);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePickerSnack);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.labelchange);
            this.Controls.Add(this.textBoxcash);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxPembayaran);
            this.Controls.Add(this.labelpay);
            this.Controls.Add(this.tbNamaCust);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelidstaff);
            this.Controls.Add(this.comboBoxStaff);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.piro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bykbrg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelIDSnack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.cbMenu);
            this.Controls.Add(this.label1);
            this.Name = "FormKasirSnack";
            this.Text = "Kasir Snack";
            this.Load += new System.EventHandler(this.FormKasirSnack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bykbrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelidstaff;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label piro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown bykbrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelIDSnack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Label labelchange;
        private System.Windows.Forms.TextBox textBoxcash;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPembayaran;
        private System.Windows.Forms.Label labelpay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.DateTimePicker dateTimePickerSnack;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tbNamaCust;
    }
}