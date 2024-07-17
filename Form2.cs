using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stajornek6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            string durum;
            if (txtad.Text == "" || txtno.Text == "" || txtvize.Text == "" || txtfinal.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!");
                txtad.Clear();
                txtno.Clear();
                txtvize.Clear();
                txtfinal.Clear();
            }
            else
            {
                lstad.Items.Add(txtad.Text);
                lstno.Items.Add(txtno.Text);
                lstvize.Items.Add(txtvize.Text);
                lstfinal.Items.Add(txtfinal.Text);

                vize = Convert.ToInt32(txtvize.Text);
                final = Convert.ToInt32(txtfinal.Text);
                ortalama = (vize * 0.4) + (final * 0.6);
                if (ortalama < 60)
                {
                    durum = "kaldı";
                }

                else
                {
                    durum = "geçti";
                }
                lstsonuc.Items.Add((txtad.Text + " " + "isimli ve " + txtno.Text + " " + " numaralı öğrencinin vize notu " + txtvize.Text + ", " + "final notu " + txtfinal.Text + " " + " olup " + ortalama + " " + "ortalama ile " + durum));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtno.Clear();
            txtvize.Clear();
            txtfinal.Clear();



        }
    }
}
