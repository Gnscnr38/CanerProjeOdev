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
    public partial class emanetler : Form
    {
        public emanetler()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emanet_ara emanet_araa = new emanet_ara();
            emanet_araa.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emanet_ekle emanet_eklee = new emanet_ekle();
            emanet_eklee.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            emanet_sil emanet_sill = new emanet_sil();
            emanet_sill.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emanet_düzenle emanet_düzenlee = new emanet_düzenle();
            emanet_düzenlee.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lobi Lobii = new Lobi();
            Lobii.Show();
            this.Hide();
        }
    }
}
