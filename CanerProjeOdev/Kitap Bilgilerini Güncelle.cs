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
    public partial class Kitap_Bilgilerini_Güncelle : Form
    {
        public Kitap_Bilgilerini_Güncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds;
        private void Kitap_Bilgilerini_Güncelle_Load(object sender, EventArgs e)
        {
            
            this.kitaplarTableAdapter.Fill(this.kutuphaneodevDataSet4.kitaplar);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            comboBox1.Enabled = false;         
            button1.Enabled = false;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox1.Enabled = true;           
            button1.Enabled = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from kitaplar where Kitap_No like '" + comboBox3.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox3.Text = read["Kitap_No"].ToString();
                textBox1.Text = read["Kitap_adi"].ToString();
                textBox2.Text = read["Kitap_yazari"].ToString();
                textBox3.Text = read["Kitap_turu"].ToString();              
                comboBox1.Text = read["Yayın_evi"].ToString();
                textBox4.Text = read["Stok_sayısı"].ToString();
            }
            baglanti.Close();
        }
        void griddoldur()
        {
            baglanti = new SqlConnection(@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
            da = new SqlDataAdapter("Select*From kitaplar", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kitaplar");
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız");

            }
            else
            {
                int sayı;
            sayı = Convert.ToInt32(textBox4.Text);
                if (sayı < 1)
                {
                    MessageBox.Show("Stok Sayısı (-) Girilemez Kontrol Ediniz !!!");
                }
                else
                {
                    string sorgu = "Update kitaplar set Kitap_adi=@Kitap_adi,Kitap_yazari=@Kitap_yazari,Kitap_turu=@Kitap_turu,Yayın_evi=@Yayın_evi,Stok_sayısı=@Stok_sayısı where Kitap_No=@Kitap_No";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@Kitap_No", comboBox3.Text);
                    komut.Parameters.AddWithValue("@Kitap_adi", textBox1.Text);
                    komut.Parameters.AddWithValue("@Kitap_yazari", textBox2.Text);
                    komut.Parameters.AddWithValue("@Kitap_turu", comboBox1.Text);
                    komut.Parameters.AddWithValue("@Yayın_evi", textBox3.Text);
                    komut.Parameters.AddWithValue("@Stok_sayısı", textBox4.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    griddoldur();

                    MessageBox.Show("Başarıyla Kitap Güncellendi...");
                    Kitaplar Kitaplarr = new Kitaplar();
                    Kitaplarr.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitaplar Kitaplarr = new Kitaplar();
            Kitaplarr.Show();
            this.Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
