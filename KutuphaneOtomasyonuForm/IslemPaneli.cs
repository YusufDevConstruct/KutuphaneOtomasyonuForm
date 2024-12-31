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
    public partial class IslemPaneli : Form
    {
        public int id = -1;
        private Form activeForm = null;
        public bool panelsecim = false;
        bool kullaniciButolar = true;
        bool kitapButonlar = true;

        public IslemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities1 db = new KutuphaneOtomasyonuEntities1();

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            clrBtn.Visible = false;
            kitapAdLbl.Visible = false;
            kitapAdTxt.Visible = false;
            yazarLbl.Visible = false;
            yazarTxt.Visible = false;
            kategoriLbl.Visible = false;
            kategoriCbox.Visible = false;

            adLbl.Visible = false;
            sAdLbl.Visible = false;
            telLbl.Visible = false;
            mailLbl.Visible = false;
            tcLbl.Visible = false;
            cezaLbl.Visible = false;

            nameTxt.Visible = false;
            sNameTxt.Visible = false;
            telTxt.Visible = false;
            mailTxt.Visible = false;
            tcTxt.Visible = false;
            cezaTxt.Visible = false;

            EkleKullaniciBtn.Visible = false;
            GuncelleKullaniciBtn.Visible = false;
            silKullaniciBtn.Visible = false;
            //dataGridView1.Visible = false;
        }
        public void panelEkrani(Form jokerform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = jokerform;

            jokerform.TopLevel = false;
            jokerform.FormBorderStyle = FormBorderStyle.None; //Çerçevenin olmaması
            jokerform.Dock = DockStyle.Fill;       //Formun, paneli doldurması ayarı (responsive)
            panel1.Controls.Add(jokerform);
            panel1.Tag = jokerform;
            jokerform.BringToFront();
            jokerform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelsecim = false;
            panelEkrani(new Form2());
            if (kitapButonlar)
            {

                adLbl.Visible = false;
                sAdLbl.Visible = false;
                telLbl.Visible = false;
                mailLbl.Visible = false;
                tcLbl.Visible = false;
                cezaLbl.Visible = false;

                nameTxt.Visible = false;
                sNameTxt.Visible = false;
                telTxt.Visible = false;
                mailTxt.Visible = false;
                tcTxt.Visible = false;
                cezaTxt.Visible = false;

                clrBtn.Visible = true;
                kitapAdLbl.Visible = true;
                kitapAdTxt.Visible = true;
                yazarLbl.Visible = true;
                yazarTxt.Visible = true;
                kategoriLbl.Visible = true;
                kategoriCbox.Visible = true;

                EkleKullaniciBtn.Visible = true;
                GuncelleKullaniciBtn.Visible = true;
                silKullaniciBtn.Visible = true;
                kitapButonlar = false;
                kullaniciButolar = true;
            }
            else
            {
                kitapAdLbl.Visible = false;
                kitapAdTxt.Visible = false;
                yazarLbl.Visible = false;
                yazarTxt.Visible = false;
                kategoriLbl.Visible = false;
                kategoriCbox.Visible = false;

                panel1.Controls.Clear();
                EkleKullaniciBtn.Visible = false;
                GuncelleKullaniciBtn.Visible = false;
                silKullaniciBtn.Visible = false;
                kitapButonlar = true;
                clrBtn.Visible = false;

            }
            //dataGridView1.Visible = true;
            //var kullanicilar = db.Kullanicilar.ToList();
            //dataGridView1.DataSource = kullanicilar.ToList();

        }

        private void EkleKullaniciBtn_Click(object sender, EventArgs e)
        {

            if (!kullaniciButolar)
            {
                string ad = nameTxt.Text;
                string soyad = sNameTxt.Text;
                string telefon = telTxt.Text;
                string mail = mailTxt.Text;
                string tc = tcTxt.Text;
                decimal ceza = string.IsNullOrEmpty(cezaTxt.Text) ? 0 : Convert.ToDecimal(cezaTxt.Text);

                string query = "INSERT INTO Kullanicilar (kullanici_ad, kullanici_soyad, kullanici_tel, kullanici_mail, kullanici_tc, kullanici_ceza) " +
                           "VALUES (@ad, @soyad, @telefon, @mail, @tc, @ceza)";

                // Parametrelerle SQL sorgusunu çalıştırma
                db.Database.ExecuteSqlCommand(query,
                    new System.Data.SqlClient.SqlParameter("@ad", ad),
                    new System.Data.SqlClient.SqlParameter("@soyad", soyad),
                    new System.Data.SqlClient.SqlParameter("@telefon", telefon),
                    new System.Data.SqlClient.SqlParameter("@mail", mail),
                    new System.Data.SqlClient.SqlParameter("@tc", tc),
                    new System.Data.SqlClient.SqlParameter("@ceza", ceza));

                MessageBox.Show("Kullanıcı başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK,  MessageBoxIcon.Information);

                nameTxt.Text = "";
                sNameTxt.Text = "";
                telTxt.Text = "";
                mailTxt.Text = "";
                tcTxt.Text = "";
                cezaTxt.Text = "";

            }
            else if (!kitapButonlar)
            {
                string kAd = kitapAdTxt.Text;
                string kYazar = yazarTxt.Text;
                string kategori = kategoriCbox.SelectedItem.ToString();

                MessageBox.Show("kategori = " + kategori + "\n kAD = " + kAd + "\n kyazar = " + kYazar);

                string query = "INSERT INTO Kitaplar (k_ad, k_yazar, k_kategori) " +
                           "VALUES (@kAd, @kYazar, @kKategori)";

                db.Database.ExecuteSqlCommand(query,
                    new System.Data.SqlClient.SqlParameter("@kAd", kAd),
                    new System.Data.SqlClient.SqlParameter("@kyazar", kYazar),
                    new System.Data.SqlClient.SqlParameter("@kKategori", kategori));


                MessageBox.Show("Kitap başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kitapAdTxt.Text = "";
                yazarTxt.Text = "";
                kategoriCbox.SelectedIndex = -1;
            }

            panelEkrani(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelsecim = true;
            panelEkrani(new Form2());
            if (kullaniciButolar)
            {

                kitapAdLbl.Visible = false;
                kitapAdTxt.Visible = false;
                yazarLbl.Visible = false;
                yazarTxt.Visible = false;
                kategoriLbl.Visible = false;
                kategoriCbox.Visible = false;

                adLbl.Visible = true;
                sAdLbl.Visible = true;
                telLbl.Visible = true;
                mailLbl.Visible = true;
                tcLbl.Visible = true;
                cezaLbl.Visible = true;

                clrBtn.Visible = true;
                nameTxt.Visible = true;
                sNameTxt.Visible = true;
                telTxt.Visible = true;
                mailTxt.Visible = true;
                tcTxt.Visible = true;
                cezaTxt.Visible = true;

                kullaniciButolar = false;
                kitapButonlar = true;
                EkleKullaniciBtn.Visible = true;
                GuncelleKullaniciBtn.Visible = true;
                silKullaniciBtn.Visible = true;
            }
            else
            {
                adLbl.Visible = false;
                sAdLbl.Visible = false;
                telLbl.Visible = false;
                mailLbl.Visible = false;
                tcLbl.Visible = false;
                cezaLbl.Visible = false;

                clrBtn.Visible = false;
                nameTxt.Visible = false;
                sNameTxt.Visible = false;
                telTxt.Visible = false;
                mailTxt.Visible = false;
                tcTxt.Visible = false;
                cezaTxt.Visible = false;

                panel1.Controls.Clear();
                kullaniciButolar = true;
                EkleKullaniciBtn.Visible = false;
                GuncelleKullaniciBtn.Visible = false;
                silKullaniciBtn.Visible = false;

            }
        }

        private void GuncelleKullaniciBtn_Click(object sender, EventArgs e)
        {
            if (!kullaniciButolar)
            {
                string ad = nameTxt.Text;
                string soyad = sNameTxt.Text;
                string telefon = telTxt.Text;
                string mail = mailTxt.Text;
                string tc = tcTxt.Text;
                decimal ceza = string.IsNullOrEmpty(cezaTxt.Text) ? 0 : Convert.ToDecimal(cezaTxt.Text);

                string query = "UPDATE Kullanicilar SET kullanici_ad = @ad, kullanici_soyad = @soyad, kullanici_tc = @tc, kullanici_tel = @telefon, kullanici_mail = @mail, kullanici_ceza = @ceza WHERE kullanici_id = @id";

                db.Database.ExecuteSqlCommand(query,
                    new System.Data.SqlClient.SqlParameter("@ad", ad),
                    new System.Data.SqlClient.SqlParameter("@soyad", soyad),
                    new System.Data.SqlClient.SqlParameter("@telefon", telefon),
                    new System.Data.SqlClient.SqlParameter("@mail", mail),
                    new System.Data.SqlClient.SqlParameter("@ceza", ceza),
                    new System.Data.SqlClient.SqlParameter("@tc", tc),
                new System.Data.SqlClient.SqlParameter("@id", id));

                MessageBox.Show("Kullanıcı başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nameTxt.Text = "";
                sNameTxt.Text = "";
                telTxt.Text = "";
                mailTxt.Text = "";
                tcTxt.Text = "";
                cezaTxt.Text = "";
            }
            else if (!kitapButonlar)
            {
                string kAd = kitapAdTxt.Text;
                string kYazar = yazarTxt.Text;
                 string kategori = kategoriCbox.SelectedItem.ToString();

                string query = "UPDATE Kitaplar SET k_ad = @kAd, k_yazar = @kYazar, k_kategori = @kKategori WHERE k_id = @kitapId";

                db.Database.ExecuteSqlCommand(query,
                    new System.Data.SqlClient.SqlParameter("@kAd", kAd),
                    new System.Data.SqlClient.SqlParameter("@kYazar", kYazar),
                    new System.Data.SqlClient.SqlParameter("@kKategori", kategori),
                    new System.Data.SqlClient.SqlParameter("@kitapId", id));

                MessageBox.Show("Kitap başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kitapAdTxt.Text = "";
                yazarTxt.Text = "";
                kategoriCbox.SelectedIndex = -1;
            }

            panelEkrani(new Form2());
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            if (!kullaniciButolar)
            {
                nameTxt.Text = "";
                sNameTxt.Text = "";
                telTxt.Text = "";
                mailTxt.Text = "";
                tcTxt.Text = "";
                cezaTxt.Text = "";
            }
            else if (!kitapButonlar)
            {
                kitapAdTxt.Text = "";
                yazarTxt.Text = "";
                kategoriCbox.SelectedIndex = -1;
            }
        }

        private void silKullaniciBtn_Click(object sender, EventArgs e)
        {
            if (!kullaniciButolar)
            {
                string query = "DELETE FROM Kullanicilar WHERE kullanici_id = @id";

                db.Database.ExecuteSqlCommand(query,
                    new System.Data.SqlClient.SqlParameter("@id", id));

                MessageBox.Show("Kullanıcı başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clr();
            }
            else if (!kitapButonlar)
            {

                string query = "DELETE FROM Kitaplar WHERE k_id = @kitapId";

                db.Database.ExecuteSqlCommand(query,
                    new System.Data.SqlClient.SqlParameter("@kitapId", id));

                MessageBox.Show("Kitap başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clr();
            }

            panelEkrani(new Form2());
        }

        private void clr()
        {
            if (!kullaniciButolar)
            {
                nameTxt.Text = "";
                sNameTxt.Text = "";
                telTxt.Text = "";
                mailTxt.Text = "";
                tcTxt.Text = "";
                cezaTxt.Text = "";
            }
            else if (!kitapButonlar)
            {
                kitapAdTxt.Text = "";
                yazarTxt.Text = "";
                kategoriCbox.SelectedIndex = -1;
            }
        }

        private void kategoriCbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

