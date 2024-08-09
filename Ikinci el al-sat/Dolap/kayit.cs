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


namespace Dolap
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-HSC6FH3Q\SQLEXPRESS;Initial Catalog=Dolap;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("sy_kullanici", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciAdi", txtkullaniciad.Text.Trim());
                komut.Parameters.AddWithValue("@Sifre", txtsifre.Text.Trim());
                komut.Parameters.AddWithValue("@Ad", txtad.Text.Trim());
                komut.Parameters.AddWithValue("@Soyad", txtsoyad.Text.Trim());

                int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Kayıt başarıyla oluşturuldu.");
                    // Kayıt başarılı olduysa, giriş ekranına geri dön
                    this.Close(); // Kayıt formunu kapat
                }
                else
                {
                    MessageBox.Show("Kayıt oluşturulurken bir hata oluştu.");
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 gir = new Form1();
            gir.Show();
        }
    }
}
