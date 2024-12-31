using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace KutuphaneOtomasyonuForm
{
    public partial class Giris : Form


    {

        SqlConnection baglanti = new SqlConnection("Data Source=Yusuf\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;TrustServerCertificate=True;");
        SqlCommand komut = new SqlCommand();
        SqlDataReader dr;
        public Giris()
        {
            InitializeComponent();
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            string personelAdi = personelGiristxt.Text;
            string sifre = sifreGiris.Text;

            try
            {
                baglanti.Open();

                string query = "SELECT * FROM Personeller WHERE personel_kullaniciAd='" + personelAdi + "' AND personel_sifre='" + sifre + "'";
                komut = new SqlCommand(query, baglanti);

                dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı");
                    IslemPaneli panel = new IslemPaneli();
                    panel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata form 1: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
//Data Source=Yusuf\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;Trust Server Certificate=True;Context Connection=False