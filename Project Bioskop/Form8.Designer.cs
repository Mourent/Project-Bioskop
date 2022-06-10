namespace Project_Bioskop
{
    partial class Form8
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
            this.btnpilihtiket = new System.Windows.Forms.Button();
            this.btnpilihsnack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpilihtiket
            // 
            this.btnpilihtiket.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpilihtiket.Location = new System.Drawing.Point(199, 182);
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
            this.btnpilihsnack.Location = new System.Drawing.Point(476, 181);
            this.btnpilihsnack.Name = "btnpilihsnack";
            this.btnpilihsnack.Size = new System.Drawing.Size(128, 77);
            this.btnpilihsnack.TabIndex = 1;
            this.btnpilihsnack.Text = "Snack";
            this.btnpilihsnack.UseVisualStyleBackColor = true;
            this.btnpilihsnack.Click += new System.EventHandler(this.btnpilihsnack_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 464);
            this.Controls.Add(this.btnpilihsnack);
            this.Controls.Add(this.btnpilihtiket);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpilihtiket;
        private System.Windows.Forms.Button btnpilihsnack;
    }
}