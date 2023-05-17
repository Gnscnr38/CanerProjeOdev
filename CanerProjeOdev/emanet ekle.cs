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
    public partial class emanet_ekle : Form
    {
        public emanet_ekle()
        {
            InitializeComponent();
        }
        static string vbbaglantı = @"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(vbbaglantı);      
        SqlCommand komut;       
        private void emanet_ekle_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            this.uyelerTableAdapter.Fill(this.kutuphaneodevDataSet7.Uyeler);         
            this.kitaplarTableAdapter.Fill(this.kutuphaneodevDataSet6.kitaplar);

        }
        void stokeksiltme()
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select kitaplar.Stok_sayısı from kitaplar where Kitap_No like '" + comboBox1.Text + "'", baglanti);
            SqlDataReader read1 = komut1.ExecuteReader();
            while (read1.Read())
            {

                label5.Text = read1["Stok_sayısı"].ToString();
            }
            int a;
            a = Convert.ToInt32(label5.Text);
            baglanti.Close();
            if (a>0)
            {
                a = a - 1;
                string sorgu = "Update kitaplar set Stok_sayısı=@Stok_sayısı where Kitap_No=@Kitap_No";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Kitap_No", comboBox1.Text);
                komut.Parameters.AddWithValue("@Stok_sayısı", a);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Boş Bırakmayınız");

                }
                else
                {

                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                        string kayit = "insert into emanet_kitaplar(kitapno,uye_no,kitap_teslim_tarihi,kitap_alınacak_tarih) values (@kitapno,@uye_no,@kitap_teslim_tarihi,@kitap_alınacak_tarih)";
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        komut.Parameters.AddWithValue("@kitapno", comboBox1.Text);
                        komut.Parameters.AddWithValue("@uye_no", comboBox2.Text);
                        komut.Parameters.AddWithValue("@kitap_teslim_tarihi", dateTimePicker1.Value);
                        komut.Parameters.AddWithValue("@kitap_alınacak_tarih", dateTimePicker2.Value);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Emanet Başarıyla Eklendi");
                        emanetler emanetlerr = new emanetler();
                        emanetlerr.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Stok Sayısını Kontrol Ediniz");

            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stokeksiltme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emanetler emanetlerr = new emanetler();
            emanetlerr.Show();
            this.Hide();
        }
    }
}
