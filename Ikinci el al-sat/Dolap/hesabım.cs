using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolap
{
    public partial class hesabım : Form
    {
        public hesabım()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-HSC6FH3Q\SQLEXPRESS;Initial Catalog=Dolap;Integrated Security=True");

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] resimBytes = null;
               

                baglanti.Open();
                SqlCommand komut = new SqlCommand("sp_UrunEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@UrunAdi", txtUrunAdi.Text.Trim());
                komut.Parameters.AddWithValue("@UrunAciklamasi", txtUrunAçiklamasi.Text.Trim());
                komut.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(txtUrunFiyat.Text.Trim()));
                komut.Parameters.AddWithValue("@Resim", (object)resimBytes ?? DBNull.Value);
                komut.Parameters.AddWithValue("@KategoriID", Convert.ToInt32(kategori));
                komut.Parameters.AddWithValue("@KullaniciID", kulalniciid); // Kullanıcı ID'sini burada belirlemelisiniz.

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
