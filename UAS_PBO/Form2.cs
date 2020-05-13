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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       

        private void cbPusing_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDiagnosa_Click(object sender, EventArgs e)
        {

            klasifikasiPenyakit range = new klasifikasiPenyakit((bool)cbPusing.Checked, cbPanas.Checked, cbBatuk.Checked);
            diagnosaPenyakit choose = new diagnosaPenyakit();
            choose.inputpenyakit((bool)cbPusing.Checked, cbPanas.Checked, cbBatuk.Checked);

            Penyakit diagnosa = new Penyakit();
            deskripsiPenyakit deskripsi = new deskripsiPenyakit();

            Form3 penyakit = new Form3();
           

            penyakit.tbPenyakit.Text = diagnosa.hasil(choose);
            penyakit.tbDeskripsi.Text = deskripsi.isi(choose);



            if (rbKurang3.Checked)
            {
                penyakit.lbLamaSakit.Text = "Gejala diderita kurang dari 3 hari";
            }
            else if (rbLebih3.Checked)
            {
                penyakit.lbLamaSakit.Text = "Gejala diderita lebih dari 3 hari";
            }


            if ((cbPusing.Checked || cbPanas.Checked || cbBatuk.Checked))
            {
                penyakit.Show();
                if (cbPusing.Checked == true && cbPanas.Checked == false && cbBatuk.Checked == false)
                {
                    penyakit.lbGejala1.Text = "Pusing";
                }
                else if (cbPusing.Checked == false && cbPanas.Checked == true && cbBatuk.Checked == false)
                {
                    penyakit.lbGejala1.Text = "Panas";
                }
                else if (cbPusing.Checked == false && cbPanas.Checked == false && cbBatuk.Checked == true)
                {
                    penyakit.lbGejala1.Text = "Batuk";
                }
                else if (cbPusing.Checked == true && cbPanas.Checked == true && cbBatuk.Checked == false)
                {
                    penyakit.lbGejala1.Text = "Pusing";
                    penyakit.lbGejala2.Text = "Panas";
                }
                else if (cbPusing.Checked == true && cbPanas.Checked == false && cbBatuk.Checked == true)
                {
                    penyakit.lbGejala1.Text = "Pusing";
                    penyakit.lbGejala2.Text = "Batuk";
                }
                else if (cbPusing.Checked == false && cbPanas.Checked == true && cbBatuk.Checked == true)
                {
                    penyakit.lbGejala1.Text = "Panas";
                    penyakit.lbGejala2.Text = "Batuk";
                }
                else if (cbPusing.Checked == true && cbPanas.Checked == true && cbBatuk.Checked == true)
                {
                    penyakit.lbGejala1.Text = "Pusing";
                    penyakit.lbGejala2.Text = "Panas";
                    penyakit.lbGejala3.Text = "Batuk";
                }
            }
            else
            {
                MessageBox.Show("Mohon Melengkapi Data");
            }


            this.Hide();

        }
    }
}
