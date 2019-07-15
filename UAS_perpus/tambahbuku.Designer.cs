namespace UAS_perpus
{
    partial class tambahbuku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tambahbuku));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.judul = new System.Windows.Forms.TextBox();
            this.preview_cover = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deskripsi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.authorList = new System.Windows.Forms.ComboBox();
            this.harga = new System.Windows.Forms.TextBox();
            this.homebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview_cover)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.homebtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-3, -25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 89);
            this.panel1.TabIndex = 17;
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
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutbtn.Location = new System.Drawing.Point(542, 43);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(55, 33);
            this.logoutbtn.TabIndex = 21;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(164, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(164, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Judul Buku";
            // 
            // judul
            // 
            this.judul.Location = new System.Drawing.Point(167, 107);
            this.judul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.judul.Multiline = true;
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(404, 25);
            this.judul.TabIndex = 18;
            // 
            // preview_cover
            // 
            this.preview_cover.Location = new System.Drawing.Point(15, 124);
            this.preview_cover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preview_cover.Name = "preview_cover";
            this.preview_cover.Size = new System.Drawing.Size(140, 202);
            this.preview_cover.TabIndex = 22;
            this.preview_cover.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(164, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Deskripsi";
            // 
            // deskripsi
            // 
            this.deskripsi.Location = new System.Drawing.Point(167, 221);
            this.deskripsi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deskripsi.Multiline = true;
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(404, 93);
            this.deskripsi.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(164, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Harga";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(15, 96);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 27;
            this.browse.Text = "Pilih Foto";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(496, 393);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 28;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // authorList
            // 
            this.authorList.FormattingEnabled = true;
            this.authorList.Location = new System.Drawing.Point(168, 161);
            this.authorList.Name = "authorList";
            this.authorList.Size = new System.Drawing.Size(403, 21);
            this.authorList.TabIndex = 29;
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(167, 338);
            this.harga.Margin = new System.Windows.Forms.Padding(2);
            this.harga.Multiline = true;
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(404, 25);
            this.harga.TabIndex = 30;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homebtn.Location = new System.Drawing.Point(483, 43);
            this.homebtn.Margin = new System.Windows.Forms.Padding(2);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(55, 33);
            this.homebtn.TabIndex = 24;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // tambahbuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(624, 428);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.authorList);
            this.Controls.Add(this.save);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deskripsi);
            this.Controls.Add(this.preview_cover);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.judul);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "tambahbuku";
            this.Text = "tambahbuku";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview_cover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox judul;
        private System.Windows.Forms.PictureBox preview_cover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deskripsi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox authorList;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.Button homebtn;
    }
}