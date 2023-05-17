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
    public partial class Kitap_Ara : Form
    {
        public Kitap_Ara()
        {
            InitializeComponent();
        }
        static string vbbaglantı = @"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(vbbaglantı);
        SqlDataAdapter da;
        DataSet ds;
        private void kİTAPADIİLEARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            textBox2.Visible = false;
            label2.Visible = false;
            textBox3.Visible = false;
            label3.Visible = false;
            textBox4.Visible = false;
            label4.Visible = false;
            button2.Visible = true;
        }

        private void kİTAPTÜRÜİLEARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
            textBox2.Visible = true;
            label2.Visible = true;
            textBox3.Visible = false;
            label3.Visible = false;
            textBox4.Visible = false;
            label4.Visible = false;
            button2.Visible = true;
        }

        private void kİTAPTÜRÜİLEARAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
            textBox2.Visible = false;
            label2.Visible = false;
            textBox3.Visible = true;
            label3.Visible = true;
            textBox4.Visible = false;
            label4.Visible = false;
            button2.Visible = true;
        }

        private void yAYİNEVİİLEARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
            textBox2.Visible = false;
            label2.Visible = false;
            textBox3.Visible = false;
            label3.Visible = false;
            textBox4.Visible = true;
            label4.Visible = true;
            button2.Visible = true;
        }

        private void Kitap_Ara_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneodevDataSet5.kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitaplarTableAdapter.Fill(this.kutuphaneodevDataSet5.kitaplar);
            textBox1.Visible = false;
            label1.Visible = false;
            textBox2.Visible = false;
            label2.Visible = false;
            textBox3.Visible = false;
            label3.Visible = false;
            textBox4.Visible = false;
            label4.Visible = false;
            button2.Visible = false;
        }
             

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
            da = new SqlDataAdapter("Select*From kitaplar", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kitaplar");
            dataGridView1.DataSource = ds.Tables["kitaplar"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitaplar Kitaplarr = new Kitaplar();
            Kitaplarr.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from kitaplar where Kitap_adi like '%" + textBox1.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from kitaplar where Kitap_yazari like '%" + textBox2.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from kitaplar where Kitap_turu like '%" + textBox3.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from kitaplar where Yayın_evi like '%" + textBox4.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }
    }
}
