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
    public partial class Giris : Form
    {
        SqlConnection baglanti;
        SqlCommand cmd;
        SqlDataReader dr;
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM giris where Kullanıcı_adi=@Kullanıcı_adi AND sifre=@sifre";
            baglanti = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=Kutuphaneodev;Integrated Security=True");
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@Kullanıcı_adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@sifre", maskedTextBox1.Text);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Başarılı Bir Şekilde Giriş Yaptınız");
                Lobi lbi = new Lobi();
                lbi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalıdır Kontrol Ediniz!!!");
            }
            baglanti.Close();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
