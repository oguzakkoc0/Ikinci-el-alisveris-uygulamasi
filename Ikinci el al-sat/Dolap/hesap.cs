using System;
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
    public partial class hesap : Form
    {
        public hesap()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-HSC6FH3Q\SQLEXPRESS;Initial Catalog=Dolap;Integrated Security=True");

        private void hesap_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM vw_UrunlerKullanicilar WHERE KullaniciID = @KullaniciID", baglanti);
                komut.Parameters.AddWithValue("@KullaniciID", Form1.UserId);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] urunResmi = File.ReadAllBytes(pictureBox1.ImageLocation);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("sp_UrunEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@UrunAdi", textBox1.Text.Trim());
                komut.Parameters.AddWithValue("@UrunAciklamasi", textBox5.Text.Trim());
                komut.Parameters.AddWithValue("@UrunFiyati", decimal.Parse(textBox2.Text.Trim()));
                komut.Parameters.AddWithValue("@UrunResmi", urunResmi);
                komut.Parameters.AddWithValue("@UrunKategorisi", textBox4.Text.Trim());
                komut.Parameters.AddWithValue("@UserId", Form1.UserId); // Kullanıcı ID'sini ekle

                int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Ürün başarıyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Ürün eklenirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            // UrunResmi'ni veritabanından çekmek için
            int urunId = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value); // UrunId sütunu
            LoadUrunResmi(urunId);
        }

        private void LoadUrunResmi(int urunId)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT UrunResmi FROM Urunler WHERE UrunId = @UrunId", baglanti);
                komut.Parameters.AddWithValue("@UrunId", urunId);

                byte[] urunResmi = (byte[])komut.ExecuteScalar();
                if (urunResmi != null && urunResmi.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(urunResmi))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void anasyfa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AnaSayfa anasyf = new AnaSayfa();
            anasyf.Show();
            this.Hide();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the existing data in the DataTable
                dataGridView1.DataSource = null;

                // Repopulate the DataTable with fresh data
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM vw_UrunlerKullanicilar WHERE KullaniciID = @KullaniciID", baglanti);
                komut.Parameters.AddWithValue("@KullaniciID", Form1.UserId);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Set the updated DataTable as the data source for the DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    // Seçilen satırın indeksini al
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    // Seçilen satırdaki UrunId'yi al
                    int urunId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

                    // Resmi byte dizisine dönüştür
                    byte[] urunResmi = File.ReadAllBytes(pictureBox1.ImageLocation);

                    // Bağlantıyı aç
                    baglanti.Open();

                    // UPDATE sorgusunu oluştur
                    SqlCommand komut = new SqlCommand("UPDATE Urunler SET UrunAdi=@UrunAdi, UrunAciklamasi=@UrunAciklamasi, UrunFiyati=@UrunFiyati, UrunResmi=@UrunResmi, UrunKategorisi=@UrunKategorisi WHERE UrunId=@UrunId", baglanti);

                    // Parametreleri ekle
                    komut.Parameters.AddWithValue("@UrunAdi", textBox1.Text.Trim());
                    komut.Parameters.AddWithValue("@UrunAciklamasi", textBox5.Text.Trim());
                    komut.Parameters.AddWithValue("@UrunFiyati", decimal.Parse(textBox2.Text.Trim()));
                    komut.Parameters.AddWithValue("@UrunResmi", urunResmi);
                    komut.Parameters.AddWithValue("@UrunKategorisi", textBox4.Text.Trim());
                    komut.Parameters.AddWithValue("@UrunId", urunId);

                    // Komutu çalıştır
                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                    // Etkilenen satır sayısını kontrol et
                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Ürün başarıyla güncellendi.");
                        // Verileri yenilemek için yenile_Click metodunu çağırabiliriz.
                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ürün güncellenirken bir hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz bir ürünü seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    // Seçilen satırın indeksini al
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    // Seçilen satırdaki UrunId'yi al
                    int urunId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

                    // Bağlantıyı aç
                    baglanti.Open();

                    // DELETE sorgusunu oluştur
                    SqlCommand komut = new SqlCommand("DELETE FROM Urunler WHERE UrunId = @UrunId", baglanti);

                    // Parametreleri ekle
                    komut.Parameters.AddWithValue("@UrunId", urunId);

                    // Komutu çalıştır
                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                    // Etkilenen satır sayısını kontrol et
                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Ürün başarıyla silindi.");
                        // Verileri yenilemek için yenile_Click metodunu çağırabiliriz.
                        yenile_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Ürün silinirken bir hata oluştu.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz bir ürünü seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hesabınızı silmek istediğinizden emin misiniz? Bu işlem geri alınamaz.", "Hesap Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM kullanicil WHERE KullaniciID = @KullaniciID", baglanti);
                    komut.Parameters.AddWithValue("@KullaniciID", Form1.UserId);

                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Hesabınız başarıyla silindi. Uygulama kapatılıyor.");
                        Application.Exit(); // Uygulamayı kapat
                    }
                    else
                    {
                        MessageBox.Show("Hesabınız silinirken bir hata oluştu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State != ConnectionState.Closed)
                    {
                        baglanti.Close();
                    }
                }
            }
        }
    }
}
