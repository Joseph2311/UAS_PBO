namespace UAS_PBO
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.cbPusing = new System.Windows.Forms.CheckBox();
            this.cbPanas = new System.Windows.Forms.CheckBox();
            this.cbBatuk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbKurang3 = new System.Windows.Forms.RadioButton();
            this.rbLebih3 = new System.Windows.Forms.RadioButton();
            this.btnDiagnosa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gejala Apa yang Anda Rasakan ?";
            // 
            // cbPusing
            // 
            this.cbPusing.AutoSize = true;
            this.cbPusing.Font = new System.Drawing.Font("Roboto Thin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPusing.Location = new System.Drawing.Point(34, 89);
            this.cbPusing.Name = "cbPusing";
            this.cbPusing.Size = new System.Drawing.Size(64, 19);
            this.cbPusing.TabIndex = 1;
            this.cbPusing.Text = "Pusing";
            this.cbPusing.UseVisualStyleBackColor = true;
            this.cbPusing.CheckedChanged += new System.EventHandler(this.cbPusing_CheckedChanged);
            // 
            // cbPanas
            // 
            this.cbPanas.AutoSize = true;
            this.cbPanas.Font = new System.Drawing.Font("Roboto Thin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPanas.Location = new System.Drawing.Point(34, 116);
            this.cbPanas.Name = "cbPanas";
            this.cbPanas.Size = new System.Drawing.Size(61, 19);
            this.cbPanas.TabIndex = 2;
            this.cbPanas.Text = "Panas";
            this.cbPanas.UseVisualStyleBackColor = true;
            // 
            // cbBatuk
            // 
            this.cbBatuk.AutoSize = true;
            this.cbBatuk.Font = new System.Drawing.Font("Roboto Thin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBatuk.Location = new System.Drawing.Point(34, 143);
            this.cbBatuk.Name = "cbBatuk";
            this.cbBatuk.Size = new System.Drawing.Size(58, 19);
            this.cbBatuk.TabIndex = 3;
            this.cbBatuk.Text = "Batuk";
            this.cbBatuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sudah Berapa Lama Anda\r\nMerasakan Gejala yang Dialami ?";
            // 
            // rbKurang3
            // 
            this.rbKurang3.AutoSize = true;
            this.rbKurang3.Font = new System.Drawing.Font("Roboto Thin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKurang3.Location = new System.Drawing.Point(35, 230);
            this.rbKurang3.Name = "rbKurang3";
            this.rbKurang3.Size = new System.Drawing.Size(66, 19);
            this.rbKurang3.TabIndex = 5;
            this.rbKurang3.TabStop = true;
            this.rbKurang3.Text = "< 3 hari";
            this.rbKurang3.UseVisualStyleBackColor = true;
            // 
            // rbLebih3
            // 
            this.rbLebih3.AutoSize = true;
            this.rbLebih3.Font = new System.Drawing.Font("Roboto Thin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLebih3.Location = new System.Drawing.Point(34, 262);
            this.rbLebih3.Name = "rbLebih3";
            this.rbLebih3.Size = new System.Drawing.Size(63, 19);
            this.rbLebih3.TabIndex = 6;
            this.rbLebih3.TabStop = true;
            this.rbLebih3.Text = ">3 hari";
            this.rbLebih3.UseVisualStyleBackColor = true;
            // 
            // btnDiagnosa
            // 
            this.btnDiagnosa.FlatAppearance.BorderSize = 0;
            this.btnDiagnosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosa.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosa.Location = new System.Drawing.Point(33, 298);
            this.btnDiagnosa.Name = "btnDiagnosa";
            this.btnDiagnosa.Size = new System.Drawing.Size(210, 26);
            this.btnDiagnosa.TabIndex = 14;
            this.btnDiagnosa.Text = "DIAGNOSA PENYAKIT";
            this.btnDiagnosa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagnosa.UseVisualStyleBackColor = true;
            this.btnDiagnosa.Click += new System.EventHandler(this.btnDiagnosa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDiagnosa);
            this.panel1.Controls.Add(this.cbPusing);
            this.panel1.Controls.Add(this.rbLebih3);
            this.panel1.Controls.Add(this.cbPanas);
            this.panel1.Controls.Add(this.rbKurang3);
            this.panel1.Controls.Add(this.cbBatuk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 400);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.label7.Location = new System.Drawing.Point(462, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "2 / 3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 188);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(344, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 57);
            this.label3.TabIndex = 21;
            this.label3.Text = "MariDOK! akan segera memberitahu\r\npenyakit apa yang kira-kira anda alami\r\nsetelah" +
    " anda mengisi form kami.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(369, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 37);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sakit Apa Ya ?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(35)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Isi Gejala";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbKurang3;
        private System.Windows.Forms.RadioButton rbLebih3;
        public System.Windows.Forms.CheckBox cbPusing;
        public System.Windows.Forms.CheckBox cbPanas;
        public System.Windows.Forms.CheckBox cbBatuk;
        private System.Windows.Forms.Button btnDiagnosa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}