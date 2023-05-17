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
    public partial class Uye_Ara : Form
    {
        public Uye_Ara()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
        private void Uye_Ara_Load(object sender, EventArgs e)
        {
            
            this.uyelerTableAdapter.Fill(this.kutuphaneodevDataSet2.Uyeler);
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            maskedTextBox1.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
            button2.Visible = false;
           


        }

        private void tCKİMLİKİLEARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            maskedTextBox1.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
        }

        private void üYEADIİLEARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = false;
            maskedTextBox1.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
        }

        private void tELEFONİLEARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = true;
            maskedTextBox1.Visible = true;
            label4.Visible = false;
            textBox4.Visible = false;
        }

        private void ePOSTAİLEARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            maskedTextBox1.Visible = false;
            label4.Visible = true;
            textBox4.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;         
            cu = "select * from Uyeler where Tc_kimlik like '%" + textBox1.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from Uyeler where Uye_adı like '%" + textBox2.Text + "%'";
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
            cu = "select * from Uyeler where E_posta like '%" + textBox4.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from Uyeler";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uyeler uyeslerrr = new Uyeler();
            uyeslerrr.Show();
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string cu;
            cu = "select * from Uyeler where Telefon like '" + maskedTextBox1.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
            button2.Visible = true;
        }
    }
}
