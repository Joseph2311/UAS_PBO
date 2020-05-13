namespace UAS_PBO
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.lbUsia = new System.Windows.Forms.Label();
            this.lbJK = new System.Windows.Forms.Label();
            this.lbLamaSakit = new System.Windows.Forms.Label();
            this.tbDeskripsi = new System.Windows.Forms.TextBox();
            this.tbPenyakit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbGejala1 = new System.Windows.Forms.Label();
            this.lbGejala2 = new System.Windows.Forms.Label();
            this.lbGejala3 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gejala yang dialami";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lama sakit";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNama.Location = new System.Drawing.Point(51, 72);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(101, 19);
            this.lbNama.TabIndex = 6;
            this.lbNama.Text = "kolom_nama";
            this.lbNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNama.Click += new System.EventHandler(this.lbNama_Click);
            // 
            // lbUsia
            // 
            this.lbUsia.AutoSize = true;
            this.lbUsia.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsia.Location = new System.Drawing.Point(51, 119);
            this.lbUsia.Name = "lbUsia";
            this.lbUsia.Size = new System.Drawing.Size(90, 19);
            this.lbUsia.TabIndex = 7;
            this.lbUsia.Text = "kolom_usia";
            this.lbUsia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbUsia.Click += new System.EventHandler(this.lbUsia_Click);
            // 
            // lbJK
            // 
            this.lbJK.AutoSize = true;
            this.lbJK.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJK.Location = new System.Drawing.Point(51, 166);
            this.lbJK.Name = "lbJK";
            this.lbJK.Size = new System.Drawing.Size(149, 19);
            this.lbJK.TabIndex = 8;
            this.lbJK.Text = "kolom_jeniskelamin";
            this.lbJK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLamaSakit
            // 
            this.lbLamaSakit.AutoSize = true;
            this.lbLamaSakit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLamaSakit.Location = new System.Drawing.Point(51, 215);
            this.lbLamaSakit.Name = "lbLamaSakit";
            this.lbLamaSakit.Size = new System.Drawing.Size(130, 19);
            this.lbLamaSakit.TabIndex = 12;
            this.lbLamaSakit.Text = "kolom_lamasakit";
            this.lbLamaSakit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLamaSakit.Click += new System.EventHandler(this.lbLamaSakit_Click);
            // 
            // tbDeskripsi
            // 
            this.tbDeskripsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.tbDeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDeskripsi.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeskripsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.tbDeskripsi.Location = new System.Drawing.Point(327, 139);
            this.tbDeskripsi.Margin = new System.Windows.Forms.Padding(2);
            this.tbDeskripsi.Multiline = true;
            this.tbDeskripsi.Name = "tbDeskripsi";
            this.tbDeskripsi.ReadOnly = true;
            this.tbDeskripsi.Size = new System.Drawing.Size(312, 159);
            this.tbDeskripsi.TabIndex = 30;
            this.tbDeskripsi.Text = resources.GetString("tbDeskripsi.Text");
            // 
            // tbPenyakit
            // 
            this.tbPenyakit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.tbPenyakit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPenyakit.Font = new System.Drawing.Font("Montserrat Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPenyakit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.tbPenyakit.Location = new System.Drawing.Point(322, 91);
            this.tbPenyakit.Margin = new System.Windows.Forms.Padding(2);
            this.tbPenyakit.Multiline = true;
            this.tbPenyakit.Name = "tbPenyakit";
            this.tbPenyakit.ReadOnly = true;
            this.tbPenyakit.Size = new System.Drawing.Size(312, 32);
            this.tbPenyakit.TabIndex = 29;
            this.tbPenyakit.Text = "test";
            this.tbPenyakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPenyakit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.label9.Location = new System.Drawing.Point(328, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(311, 29);
            this.label9.TabIndex = 26;
            this.label9.Text = "Anda Kemungkinan Terkena";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbGejala1
            // 
            this.lbGejala1.AutoSize = true;
            this.lbGejala1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGejala1.Location = new System.Drawing.Point(51, 264);
            this.lbGejala1.Name = "lbGejala1";
            this.lbGejala1.Size = new System.Drawing.Size(13, 19);
            this.lbGejala1.TabIndex = 32;
            this.lbGejala1.Text = "-";
            this.lbGejala1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbGejala1.Click += new System.EventHandler(this.lbGejala1_Click);
            // 
            // lbGejala2
            // 
            this.lbGejala2.AutoSize = true;
            this.lbGejala2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGejala2.Location = new System.Drawing.Point(51, 287);
            this.lbGejala2.Name = "lbGejala2";
            this.lbGejala2.Size = new System.Drawing.Size(13, 19);
            this.lbGejala2.TabIndex = 33;
            this.lbGejala2.Text = "-";
            this.lbGejala2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGejala3
            // 
            this.lbGejala3.AutoSize = true;
            this.lbGejala3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGejala3.Location = new System.Drawing.Point(50, 310);
            this.lbGejala3.Name = "lbGejala3";
            this.lbGejala3.Size = new System.Drawing.Size(13, 19);
            this.lbGejala3.TabIndex = 34;
            this.lbGejala3.Text = "-";
            this.lbGejala3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnKembali.FlatAppearance.BorderSize = 0;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.Location = new System.Drawing.Point(46, 333);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(2);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(210, 26);
            this.btnKembali.TabIndex = 35;
            this.btnKembali.Text = "KEMBALI";
            this.btnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnKembali);
            this.panel1.Controls.Add(this.lbGejala3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbGejala2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbGejala1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbNama);
            this.panel1.Controls.Add(this.lbUsia);
            this.panel1.Controls.Add(this.lbJK);
            this.panel1.Controls.Add(this.lbLamaSakit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 400);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.label7.Location = new System.Drawing.Point(462, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "3 / 3";
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_WOC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.button_WOC1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(376, 300);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC1.Size = new System.Drawing.Size(210, 35);
            this.button_WOC1.TabIndex = 38;
            this.button_WOC1.Text = "KELUAR";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbDeskripsi);
            this.Controls.Add(this.tbPenyakit);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Diagnosa Penyakit";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbUsia;
        private System.Windows.Forms.Label lbJK;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbDeskripsi;
        public System.Windows.Forms.TextBox tbPenyakit;
        public System.Windows.Forms.Label lbLamaSakit;
        private System.Windows.Forms.Button btnKembali;
        public System.Windows.Forms.Label lbGejala1;
        public System.Windows.Forms.Label lbGejala2;
        public System.Windows.Forms.Label lbGejala3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}