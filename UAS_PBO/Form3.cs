using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_PBO
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            using(var db = new akunModel())
            {
                var query = from Akun in db.Tables select Akun;
                foreach(var item in query)
                {
                    lbNama.Text = item.Nama;
                    lbUsia.Text = item.Usia.ToString()+" tahun";
                    if(item.JenisKelamin == true)
                    {
                        lbJK.Text = "Laki-laki";
                    }
                    else if (item.JenisKelamin==false)
                    {
                        lbJK.Text = "Perempuan";
                    }
                   
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDiagnosa_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lbNama_Click(object sender, EventArgs e)
        {

        }

        private void lbLamaSakit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }

        private void lbGejala1_Click(object sender, EventArgs e)
        {

        }

        private void lbUsia_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
