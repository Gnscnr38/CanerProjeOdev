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
    public partial class emanet_ara : Form
    {
        public emanet_ara()
        {
            InitializeComponent();
        }
        static string vbbaglantı = @"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(vbbaglantı);
        SqlDataAdapter da;
        DataSet ds;
        private void emanet_ara_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
            button1.Visible = true;
            button2.Visible = false;
            this.emanet_kitaplarTableAdapter.Fill(this.kutuphaneodevDataSet11.emanet_kitaplar);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from emanet_kitaplar where kitapno like '%" + textBox1.Text + "%'";
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
            cu = "select * from emanet_kitaplar where uye_no like '%" + textBox2.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from emanet_kitaplar where kitap_teslim_tarihi like '%" + textBox3.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from emanet_kitaplar where kitap_alınacak_tarih like '%" + textBox4.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
            
        }

        private void kitapNoİleAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
            button2.Visible = true;
        }

        private void üyeNoİleAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
            button2.Visible = true;
        }

        private void kitapTeslimTarihiİleAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = false;
            textBox4.Visible = false;
            button2.Visible = true;
        }

        private void kitapAlıncakTarihİleAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = true;
            textBox4.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
            da = new SqlDataAdapter("Select*From emanet_kitaplar", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "emanet_kitaplar");
            dataGridView1.DataSource = ds.Tables["emanet_kitaplar"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emanetler emanetlerr = new emanetler();
            emanetlerr.Show();
            this.Hide();
        }
        SqlCommand komut;
        private void gecikenEmanetleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM emanet_kitaplar WHERE kitap_alınacak_tarih < @tarih1";
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Value);                      
            baglanti.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
