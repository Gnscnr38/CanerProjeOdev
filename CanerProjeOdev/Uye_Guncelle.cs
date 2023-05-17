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
    public partial class Uye_Guncelle : Form
    {
        public Uye_Guncelle()
        {
            InitializeComponent();
        }
         
        SqlConnection baglanti = new SqlConnection (@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds;
        private void Uye_Guncelle_Load(object sender, EventArgs e)
        {
           
            this.uyelerTableAdapter.Fill(this.kutuphaneodevDataSet1.Uyeler);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            comboBox1.Enabled = false;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBox2.Enabled = false;
            richTextBox1.Enabled = false;
            button1.Enabled = false;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
            comboBox1.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            dateTimePicker2.Enabled = true;
            comboBox2.Enabled = true;
            richTextBox1.Enabled = true;
            button1.Enabled = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Uyeler where Uye_No like '" + comboBox3.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) 
            {
                comboBox3.Text = read["Uye_No"].ToString();
                textBox1.Text = read["Tc_kimlik"].ToString();
                textBox2.Text = read["Uye_adı"].ToString();
                textBox3.Text = read["Uye_Soyad"].ToString();
                dateTimePicker1.Text = read["Dogum_tarih"].ToString();
                comboBox1.Text = read["Dogum_yeri"].ToString();
                maskedTextBox1.Text = read["Telefon"].ToString();
                maskedTextBox2.Text = read["E_posta"].ToString();
                dateTimePicker2.Text = read["Uyelik_Tarih"].ToString();
                comboBox2.Text = read["Cinsiyet"].ToString();
                richTextBox1.Text = read["Adres"].ToString();
            }
            baglanti.Close();
            
        }
        void griddoldur()
        {
            baglanti = new SqlConnection(@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
            da = new SqlDataAdapter("Select*From Uyeler", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Uyeler");            
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || richTextBox1.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "")
            {
                MessageBox.Show("Boş Bırakmayınız");

            }
            else
            {
                string sorgu = "Update Uyeler set Tc_kimlik=@Tc_kimlik,Uye_adı=@Uye_adı,Uye_Soyad=@Uye_Soyad,Dogum_tarih=@Dogum_tarih,Dogum_yeri=@Dogum_yeri,Telefon=@Telefon,E_posta=@E_posta,Uyelik_Tarih=@Uyelik_Tarih,Cinsiyet=@Cinsiyet,Adres=@Adres where Uye_No=@Uye_No";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Uye_No", comboBox3.Text);
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
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                griddoldur();
                MessageBox.Show("Başarıyla Üye Güncellendi...");
                Uyeler uyelerr = new Uyeler();
                uyelerr.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uyeler uyelerr = new Uyeler();
            uyelerr.Show();
            this.Hide();
        }
    }
}
