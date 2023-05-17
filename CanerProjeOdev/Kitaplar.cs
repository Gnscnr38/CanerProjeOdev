using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanerProjeOdev
{
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lobi lobii = new Lobi();
            lobii.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitap_ekle kitap_eklee = new kitap_ekle();
            kitap_eklee.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kitap_Bilgilerini_Güncelle Kitap_Bilgilerini_Güncellee = new Kitap_Bilgilerini_Güncelle();
            Kitap_Bilgilerini_Güncellee.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kitap_Ara Kitap_Araa = new Kitap_Ara();
            Kitap_Araa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap_sil Kitap_sill = new Kitap_sil();
            Kitap_sill.Show();
            this.Hide();
        }
    }
}
