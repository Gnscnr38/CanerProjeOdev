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
    public partial class uye_ekle : Form
    {
        public uye_ekle()
        {
            InitializeComponent();
        }
        static string vbbaglantı = @"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(vbbaglantı);
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || richTextBox1.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız");

            }
            else
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    string kayit = "insert into Uyeler(Tc_kimlik,Uye_adı,Uye_Soyad,Dogum_tarih,Dogum_yeri,Telefon,E_posta,Uyelik_Tarih,Cinsiyet,Adres) values (@Tc_kimlik,@Uye_adı,@Uye_Soyad,@Dogum_tarih,@Dogum_yeri,@Telefon,@E_posta,@Uyelik_Tarih,@Cinsiyet,@Adres)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@Tc_kimlik", textBox1.Text);
                    komut.Parameters.AddWithValue("@Uye_adı", textBox2.Text);
                    komut.Parameters.AddWithValue("@Uye_Soyad", textBox3.Text);
                    komut.Parameters.AddWithValue("@Dogum_tarih", dateTimePicker1.Value);
                    komut.Parameters.AddWithValue("@Dogum_yeri", comboBox1.Text);
                    komut.Parameters.AddWithValue("@Telefon", maskedTextBox1.Text);
                    komut.Parameters.AddWithValue("@E_posta", maskedTextBox2.Text);
                    komut.Parameters.AddWithValue("@Uyelik_Tarih", dateTimePicker2.Value);
                    komut.Parameters.AddWithValue("@Cinsiyet", comboBox2.Text);
                    komut.Parameters.AddWithValue("@Adres", richTextBox1.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Üye Başarı Bir Şekilde Eklendi... ");
                    Uyeler uyelerr = new Uyeler();
                    uyelerr.Show();
                    this.Hide();
                }
            }
            }

        private void uye_ekle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uyeler uyeslerrr = new Uyeler();
            uyeslerrr.Show();
            this.Hide();
        }
    }
              }

            
            
        
    

