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
    public partial class Uyeler : Form
    {
        public Uyeler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uye_ekle uyeekle = new uye_ekle();
            uyeekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uye_Sil uyesill = new Uye_Sil();
            uyesill.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uye_Guncelle uyeguncelle = new Uye_Guncelle();
            uyeguncelle.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lobi lbi = new Lobi();
            lbi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Uye_Ara uye_araa = new Uye_Ara();
            uye_araa.Show();
            this.Hide();
        }
    }
}
