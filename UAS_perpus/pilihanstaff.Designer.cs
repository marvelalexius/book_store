namespace UAS_perpus
{
    partial class pilihanstaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pilihanstaff));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datapinjam = new System.Windows.Forms.Button();
            this.databuku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "MAGIC SHOP";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-3, -25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 89);
            this.panel1.TabIndex = 17;
            // 
            // datapinjam
            // 
            this.datapinjam.BackColor = System.Drawing.Color.MidnightBlue;
            this.datapinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.datapinjam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datapinjam.Location = new System.Drawing.Point(64, 197);
            this.datapinjam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datapinjam.Name = "datapinjam";
            this.datapinjam.Size = new System.Drawing.Size(133, 53);
            this.datapinjam.TabIndex = 22;
            this.datapinjam.Text = "Data Transaksi";
            this.datapinjam.UseVisualStyleBackColor = false;
            this.datapinjam.Click += new System.EventHandler(this.datapinjam_Click);
            // 
            // databuku
            // 
            this.databuku.BackColor = System.Drawing.Color.MidnightBlue;
            this.databuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databuku.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.databuku.Location = new System.Drawing.Point(64, 108);
            this.databuku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.databuku.Name = "databuku";
            this.databuku.Size = new System.Drawing.Size(133, 53);
            this.databuku.TabIndex = 23;
            this.databuku.Text = "Data Buku";
            this.databuku.UseVisualStyleBackColor = false;
            this.databuku.Click += new System.EventHandler(this.databuku_Click);
            // 
            // pilihanstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(275, 295);
            this.Controls.Add(this.databuku);
            this.Controls.Add(this.datapinjam);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "pilihanstaff";
            this.Text = "pilihanstaff";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button datapinjam;
        private System.Windows.Forms.Button databuku;
    }
}