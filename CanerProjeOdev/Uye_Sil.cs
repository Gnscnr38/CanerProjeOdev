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
    public partial class Uye_Sil : Form
    {
        public Uye_Sil()
        {
            InitializeComponent();
        }
        static string vbbaglantı = @"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True";
        SqlConnection baglanti = new SqlConnection(vbbaglantı);
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds;
        private void Uye_Sil_Load(object sender, EventArgs e)
        {
            
            this.uyelerTableAdapter.Fill(this.kutuphaneodevDataSet.Uyeler);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            string va, cu;
            va = textBox1.Text;
            cu= "select * from Uyeler where Tc_kimlik like '%"+textBox1.Text+"%'";
            SqlDataAdapter adp = new SqlDataAdapter(cu, baglanti);
            adp.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }
        
        void KayıtSil(int numara)
        {    
            try
            {
                string sqlkomut = "Delete From Uyeler Where Uye_No=@Uye_No";
                komut = new SqlCommand(sqlkomut, baglanti);
                komut.Parameters.AddWithValue("@Uye_No", numara);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarıyla Üye Silindi...");
            } 
            catch
            {
                MessageBox.Show("Bu Üyenin Kayıtlı Emanet Kitapı Vardır!!!");
               
            }
            
        }
        void griddoldur()
        {
            baglanti = new SqlConnection(@"Data Source = HP\SQLEXPRESS;Initial Catalog = Kutuphaneodev; Integrated Security = True");
            da = new SqlDataAdapter("Select*From Uyeler", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Uyeler");
            dataGridView1.DataSource = ds.Tables["Uyeler"];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(numara);
            }
            griddoldur();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uyeler uyeslerrr = new Uyeler();
            uyeslerrr.Show();
            this.Hide();
        }
    }
}
