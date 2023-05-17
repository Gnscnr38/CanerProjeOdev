using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CanerProjeOdev
{
    public partial class kitap_ekle : Form
    {
        public kitap_ekle()
        {
            InitializeComponent();
        }
        static string vbbaglantı = @"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(vbbaglantı);
        private void kitap_ekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;
            sayı = Convert.ToInt32(textBox4.Text);                     
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız");

            }
            else
            {
                if (sayı<0)         
               {
                    MessageBox.Show("Stok Sayısı (-) Girilemez Kontrol Ediniz !!!");
                }
                else
                {

                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                            string kayit = "insert into kitaplar(Kitap_adi,Kitap_yazari,Kitap_turu,Yayın_evi,Stok_sayısı) values (@Kitap_adi,@Kitap_yazari,@Kitap_turu,@Yayın_evi,@Stok_sayısı)";
                            SqlCommand komut1 = new SqlCommand(kayit, baglanti);
                            komut1.Parameters.AddWithValue("@Kitap_adi", textBox1.Text);
                            komut1.Parameters.AddWithValue("@Kitap_yazari", textBox2.Text);
                            komut1.Parameters.AddWithValue("@Kitap_turu", comboBox1.Text);
                            komut1.Parameters.AddWithValue("@Yayın_evi", textBox3.Text);
                            komut1.Parameters.AddWithValue("@Stok_sayısı", textBox4.Text);
                            komut1.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("Kitap Başarı Bir Şekilde Eklendi... ");
                            Kitaplar kitaplarr = new Kitaplar();
                            kitaplarr.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("hata" + hata);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplarr = new Kitaplar();
            kitaplarr.Show();
            this.Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
