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
    public partial class Lobi : Form
    {
        public Lobi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uyeler uyelerr = new Uyeler();
            uyelerr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplarr = new Kitaplar();
            kitaplarr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emanetler emanetlerr = new emanetler();
            emanetlerr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
