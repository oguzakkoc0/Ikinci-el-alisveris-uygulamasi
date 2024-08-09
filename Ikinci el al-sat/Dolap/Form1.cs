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
    public partial class Form1 : Form
    {
        public static int UserId;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-HSC6FH3Q\SQLEXPRESS;Initial Catalog=Dolap;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("sp_KullaniciGiris", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text.Trim());
                komut.Parameters.AddWithValue("@Sifre", txtSifre.Text.Trim());

                SqlDataReader dr = komut.ExecuteReader(); // Sorguyu çalıştır
                if (dr.Read()) // Eğer kayıt varsa
                {
                    UserId = dr.GetInt32(0);
                    AnaSayfa fr = new AnaSayfa();
                    fr.Show();
                    this.Hide(); // Giriş ekranını gizle
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş");
                }
                dr.Close(); // DataReader'ı kapat
                baglanti.Close(); // Bağlantıyı kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayit kt = new kayit();
            kt.Show();
            this.Hide();
        }
    }
}
