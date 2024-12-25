using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

   

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            string personelAdi = personelGiristxt.Text;
            string sifre = sifreGiris.Text;

            if (personelAdi == "admin" && sifre == "1234")
            {
                MessageBox.Show("Giriş Başarılı");
               
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }
        private void personelGiristxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifreGiris_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
