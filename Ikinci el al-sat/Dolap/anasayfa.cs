using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Dolap
{
    public partial class AnaSayfa : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-HSC6FH3Q\SQLEXPRESS;Initial Catalog=Dolap;Integrated Security=True");

        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            UrunleriYukle();
        }

        private void UrunleriYukle(string aramaKriteri = "")
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                baglanti.Open();
                string query = @"
                    SELECT u.UrunAdi, u.UrunFiyati, u.UrunResmi, k.KullaniciAdi
                    FROM Urunler u
                    JOIN kullanicil k ON u.UserId = k.KullaniciID";

                if (!string.IsNullOrEmpty(aramaKriteri))
                {
                    query += " WHERE u.UrunAdi LIKE @AramaKriteri";
                }

                query += " ORDER BY u.UrunFiyati";  // Ürünleri fiyatına göre sıralar

                SqlCommand komut = new SqlCommand(query, baglanti);
                if (!string.IsNullOrEmpty(aramaKriteri))
                {
                    komut.Parameters.AddWithValue("@AramaKriteri", "%" + aramaKriteri + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Panel panel = new Panel
                    {
                        Width = 200,
                        Height = 300,
                        Margin = new Padding(10)
                    };

                    PictureBox pb = new PictureBox
                    {
                        Width = 180,
                        Height = 180,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Image = ByteArrayToImage((byte[])row["UrunResmi"])
                    };

                    Label lblAd = new Label
                    {
                        Text = row["UrunAdi"].ToString(),
                        AutoSize = true,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    Label lblFiyat = new Label
                    {
                        Text = string.Format("{0:C2}", row["UrunFiyati"]),
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    pb.Top = 10;
                    pb.Left = (panel.Width - pb.Width) / 2;

                    lblAd.Top = pb.Bottom + 10;
                    lblAd.Left = (panel.Width - lblAd.Width) / 2;

                    lblFiyat.Top = lblAd.Bottom + 5;
                    lblFiyat.Left = (panel.Width - lblFiyat.Width) / 2;

                    panel.Controls.Add(pb);
                    panel.Controls.Add(lblAd);
                    panel.Controls.Add(lblFiyat);

                    flowLayoutPanel1.Controls.Add(panel);
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

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaKriteri = txtArama.Text.Trim();
            UrunleriYukle(aramaKriteri);
        }

        private void btnYenile_Click_1(object sender, EventArgs e)
        {
            UrunleriYukle();
        }

        private void hesabım_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hesap hsb = new hesap();
            hsb.Show();
            this.Hide();
        }
    }
}
