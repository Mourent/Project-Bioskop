namespace Project_Bioskop
{
    partial class FormStrukSnack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStrukSnack));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelcust = new System.Windows.Forms.Label();
            this.lblnamacust = new System.Windows.Forms.Label();
            this.labelbill = new System.Windows.Forms.Label();
            this.lblIdNoPesanan = new System.Windows.Forms.Label();
            this.labelkasir = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.dgvMenu1 = new System.Windows.Forms.DataGridView();
            this.labeltot = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelcust
            // 
            this.labelcust.AutoSize = true;
            this.labelcust.Location = new System.Drawing.Point(40, 241);
            this.labelcust.Name = "labelcust";
            this.labelcust.Size = new System.Drawing.Size(86, 20);
            this.labelcust.TabIndex = 1;
            this.labelcust.Text = "Customer: ";
            // 
            // lblnamacust
            // 
            this.lblnamacust.AutoSize = true;
            this.lblnamacust.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamacust.Location = new System.Drawing.Point(194, 241);
            this.lblnamacust.Name = "lblnamacust";
            this.lblnamacust.Size = new System.Drawing.Size(30, 19);
            this.lblnamacust.TabIndex = 2;
            this.lblnamacust.Text = "---";
            // 
            // labelbill
            // 
            this.labelbill.AutoSize = true;
            this.labelbill.Location = new System.Drawing.Point(40, 284);
            this.labelbill.Name = "labelbill";
            this.labelbill.Size = new System.Drawing.Size(108, 20);
            this.labelbill.TabIndex = 3;
            this.labelbill.Text = "No. Pesanan: ";
            // 
            // lblIdNoPesanan
            // 
            this.lblIdNoPesanan.AutoSize = true;
            this.lblIdNoPesanan.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNoPesanan.Location = new System.Drawing.Point(194, 284);
            this.lblIdNoPesanan.Name = "lblIdNoPesanan";
            this.lblIdNoPesanan.Size = new System.Drawing.Size(30, 19);
            this.lblIdNoPesanan.TabIndex = 4;
            this.lblIdNoPesanan.Text = "---";
            // 
            // labelkasir
            // 
            this.labelkasir.AutoSize = true;
            this.labelkasir.Location = new System.Drawing.Point(40, 329);
            this.labelkasir.Name = "labelkasir";
            this.labelkasir.Size = new System.Drawing.Size(67, 20);
            this.labelkasir.TabIndex = 5;
            this.labelkasir.Text = "Cashier:";
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashier.Location = new System.Drawing.Point(194, 329);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(30, 19);
            this.lblCashier.TabIndex = 6;
            this.lblCashier.Text = "---";
            // 
            // dgvMenu1
            // 
            this.dgvMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu1.Location = new System.Drawing.Point(24, 371);
            this.dgvMenu1.Name = "dgvMenu1";
            this.dgvMenu1.RowHeadersWidth = 62;
            this.dgvMenu1.RowTemplate.Height = 28;
            this.dgvMenu1.Size = new System.Drawing.Size(532, 301);
            this.dgvMenu1.TabIndex = 50;
            // 
            // labeltot
            // 
            this.labeltot.AutoSize = true;
            this.labeltot.Location = new System.Drawing.Point(335, 698);
            this.labeltot.Name = "labeltot";
            this.labeltot.Size = new System.Drawing.Size(52, 20);
            this.labeltot.TabIndex = 51;
            this.labeltot.Text = "Total: ";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(455, 690);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(42, 32);
            this.labelTotal.TabIndex = 74;
            this.labelTotal.Text = "---";
            // 
            // labelty
            // 
            this.labelty.AutoSize = true;
            this.labelty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelty.Location = new System.Drawing.Point(110, 881);
            this.labelty.Name = "labelty";
            this.labelty.Size = new System.Drawing.Size(370, 29);
            this.labelty.TabIndex = 75;
            this.labelty.Text = "Thank You For Your Purchase!";
            // 
            // FormStrukSnack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 938);
            this.Controls.Add(this.labelty);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labeltot);
            this.Controls.Add(this.dgvMenu1);
            this.Controls.Add(this.lblCashier);
            this.Controls.Add(this.labelkasir);
            this.Controls.Add(this.lblIdNoPesanan);
            this.Controls.Add(this.labelbill);
            this.Controls.Add(this.lblnamacust);
            this.Controls.Add(this.labelcust);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormStrukSnack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Struk Pembelian";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStrukSnack_FormClosed);
            this.Load += new System.EventHandler(this.FormStrukSnack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelcust;
        private System.Windows.Forms.Label lblnamacust;
        private System.Windows.Forms.Label labelbill;
        private System.Windows.Forms.Label lblIdNoPesanan;
        private System.Windows.Forms.Label labelkasir;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.DataGridView dgvMenu1;
        private System.Windows.Forms.Label labeltot;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelty;
    }
}