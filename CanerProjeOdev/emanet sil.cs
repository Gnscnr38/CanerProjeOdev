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
    public partial class emanet_sil : Form
    {
        public emanet_sil()
        {
            InitializeComponent();
        }
        static string vbbaglantı = @"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(vbbaglantı);
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds;
        void KayıtSil(int numara)
        {
            string sqlkomut = "Delete From emanet_kitaplar Where emanetno=@emanetno";
            komut = new SqlCommand(sqlkomut, baglanti);
            komut.Parameters.AddWithValue("@emanetno", numara);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        void griddoldur()
        {
            baglanti = new SqlConnection(@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
            da = new SqlDataAdapter("Select*From emanet_kitaplar", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "emanet_kitaplar");
            dataGridView1.DataSource = ds.Tables["emanet_kitaplar"];
            baglanti.Close();
        }
        private void emanet_sil_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            this.emanet_kitaplarTableAdapter.Fill(this.kutuphaneodevDataSet8.emanet_kitaplar);

        }

        private void kİTAPADIİLEARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox2.Visible = true;
            label1.Visible = false;
            textBox1.Visible = false;
        }

        private void kİTAPTÜRÜİLEARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from emanet_kitaplar where uye_no like '%" + textBox1.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from emanet_kitaplar where kitapno like '%" + textBox2.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(numara);
            }
            griddoldur();
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select kitaplar.Stok_sayısı from kitaplar where Kitap_No like '" + label3.Text + "'", baglanti);
            SqlDataReader read1 = komut1.ExecuteReader();
            while (read1.Read())
            {

                label3.Text = read1["Stok_sayısı"].ToString();
            }
            int a;
            a = Convert.ToInt32(label3.Text);
            baglanti.Close();
            if (a >= 0)
            {
                a = a + 1;
                string sorgu = "Update kitaplar set Stok_sayısı=@Stok_sayısı where Kitap_No=@Kitap_No";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Kitap_No", label4.Text);
                komut.Parameters.AddWithValue("@Stok_sayısı", a);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla Emanet Silindi Ve Stogunuza Tekrar Eklendi Kitap...");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int deger = Convert.ToInt32(dataGridView1.CurrentRow.Cells["kitapnoDataGridViewTextBoxColumn"].Value);
                label3.Text = Convert.ToString(deger);
                label4.Text = Convert.ToString(deger);
            }
            catch
            {
                MessageBox.Show("Boş Sutun Seçmeyiniz");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            emanetler emanetlerr = new emanetler();
            emanetlerr.Show();
            this.Hide();
        }
    }
}
