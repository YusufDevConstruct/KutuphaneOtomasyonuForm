using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace KutuphaneOtomasyonuForm
{
    public partial class Form2 : Form
    {
        KutuphaneOtomasyonuEntities1 db = new KutuphaneOtomasyonuEntities1();
        IslemPaneli panel = (IslemPaneli)System.Windows.Forms.Application.OpenForms["IslemPaneli"];
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dataload();
        }

        public void dataload()
        {
            
            if (panel.panelsecim)
            {
                dataGridView1.ClearSelection();
                var kullanicilar = db.Kullanicilar.ToList();
                dataGridView1.DataSource = kullanicilar.ToList();
            }
            else {
                dataGridView1.ClearSelection();
                var Kitaplar = db.Kitaplar.ToList();
                dataGridView1.DataSource = Kitaplar.ToList();
            }
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (panel.panelsecim)
            {
                if (e.RowIndex >= 0) // Başlık hücresine tıklanmasını önler
                {
                    // Tıklanan satırı al
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // TextBox'lara verileri aktar
                    panel.id = Convert.ToInt32(row.Cells["kullanici_id"].Value.ToString());
                    panel.nameTxt.Text = row.Cells["kullanici_ad"].Value.ToString();
                    panel.sNameTxt.Text = row.Cells["kullanici_soyad"].Value.ToString();
                    panel.telTxt.Text = row.Cells["kullanici_tel"].Value.ToString();
                    panel.mailTxt.Text = row.Cells["kullanici_mail"].Value.ToString();
                    panel.tcTxt.Text = row.Cells["kullanici_tc"].Value.ToString();
                    panel.cezaTxt.Text = row.Cells["kullanici_ceza"].Value.ToString();
                }
            }
            else
            {
                if (e.RowIndex >= 0) // Başlık hücresine tıklanmasını önler
                {
                    // Tıklanan satırı al
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // TextBox'lara verileri aktar
                    panel.id = Convert.ToInt32(row.Cells["k_id"].Value.ToString());
                    panel.kitapAdTxt.Text = row.Cells["k_ad"].Value.ToString();
                    panel.yazarTxt.Text = row.Cells["k_yazar"].Value.ToString();
                    panel.kategoriCbox.Text = row.Cells["k_kategori"].Value?.ToString();
                }
            }
            
        }
    }
}
