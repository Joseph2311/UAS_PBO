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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void tambahData()
        {
            if(tbNama.Text !="" && tbUsia.Text !="" && rbLaki.Checked)
            {
                using (var db = new akunModel())
                {
                    Akun newAkun = new Akun
                    {
                        Nama = tbNama.Text,
                        Usia = Int32.Parse(tbUsia.Text),
                        JenisKelamin = true,
                    };
                    db.Tables.Add(newAkun);
                    db.SaveChanges();
                }
            }
            else if(tbNama.Text != "" && tbUsia.Text != "" && rbPerempuan.Checked)
            {
                using (var db = new akunModel())
                {
                    Akun newAkun = new Akun
                    {
                        Nama = tbNama.Text,
                        Usia = Int32.Parse(tbUsia.Text),
                        JenisKelamin = false,
                    };
                    db.Tables.Add(newAkun);
                    db.SaveChanges();
                }
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            if(tbNama.Text!="" && tbUsia.Text!="" && (rbLaki.Checked || rbPerempuan.Checked))
            {
                tambahData();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mohon Melengkapi Data");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
