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
    public partial class emanet_düzenle : Form
    {
        public emanet_düzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds;
        private void emanet_düzenle_Load(object sender, EventArgs e)
        {
            
            this.emanet_kitaplarTableAdapter1.Fill(this.kutuphaneodevDataSet10.emanet_kitaplar);
            
            this.emanet_kitaplarTableAdapter.Fill(this.kutuphaneodevDataSet9.emanet_kitaplar);
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            comboBox3.Enabled = false;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from emanet_kitaplar where uye_no like '" + comboBox1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read["emanetno"].ToString());               

            }
            baglanti.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from emanet_kitaplar where emanetno like '" + comboBox2.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            comboBox3.Enabled = false;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            while (read.Read())
            {
                comboBox3.Text = read["kitapno"].ToString();
                dateTimePicker1.Text = read["kitap_teslim_tarihi"].ToString();
                dateTimePicker1.Text = read["kitap_alınacak_tarih"].ToString();
                

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Update emanet_kitaplar set kitap_teslim_tarihi=@kitap_teslim_tarihi,kitap_alınacak_tarih=@kitap_alınacak_tarih where emanetno=@emanetno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@emanetno", comboBox2.Text);
            komut.Parameters.AddWithValue("@kitap_teslim_tarihi", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@kitap_alınacak_tarih", dateTimePicker2.Value);    
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();

            MessageBox.Show("Başarıyla Verilen Emanet Tarihleri Güncellendi...");
            emanetler emanetlerr = new emanetler();
            emanetlerr.Show();
            this.Hide();
        }
        void griddoldur()
        {
            baglanti = new SqlConnection(@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
            da = new SqlDataAdapter("Select*From emanet_kitaplar", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "emanet_kitaplar");
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emanetler emanetlerr = new emanetler();
            emanetlerr.Show();
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
