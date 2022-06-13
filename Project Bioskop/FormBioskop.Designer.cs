namespace Project_Bioskop
{
    partial class FormBioskop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBioskop));
            this.btnpilihtiket = new System.Windows.Forms.Button();
            this.btnpilihsnack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpilihtiket
            // 
            this.btnpilihtiket.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpilihtiket.Location = new System.Drawing.Point(69, 147);
            this.btnpilihtiket.Name = "btnpilihtiket";
            this.btnpilihtiket.Size = new System.Drawing.Size(126, 76);
            this.btnpilihtiket.TabIndex = 0;
            this.btnpilihtiket.Text = "Tiket";
            this.btnpilihtiket.UseVisualStyleBackColor = true;
            this.btnpilihtiket.Click += new System.EventHandler(this.btnpilihtiket_Click);
            // 
            // btnpilihsnack
            // 
            this.btnpilihsnack.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpilihsnack.Location = new System.Drawing.Point(369, 147);
            this.btnpilihsnack.Name = "btnpilihsnack";
            this.btnpilihsnack.Size = new System.Drawing.Size(128, 77);
            this.btnpilihsnack.TabIndex = 1;
            this.btnpilihsnack.Text = "Snack";
            this.btnpilihsnack.UseVisualStyleBackColor = true;
            this.btnpilihsnack.Click += new System.EventHandler(this.btnpilihsnack_Click);
            // 
            // FormBioskop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 362);
            this.Controls.Add(this.btnpilihsnack);
            this.Controls.Add(this.btnpilihtiket);
            this.DoubleBuffered = true;
            this.Name = "FormBioskop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CINEMA 551";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpilihtiket;
        private System.Windows.Forms.Button btnpilihsnack;
    }
}