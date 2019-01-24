using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u7_idealKiloHesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double ideal, katSayi=0, yas;

            if (txtCins.Text == "k" || txtCins.Text == "K")
            {
                katSayi = 0.8;
            }
            else if (txtCins.Text == "e" || txtCins.Text == "E")
            {
                katSayi = 0.9;
            }
            yas = DateTime.Now.Year - Convert.ToDouble(txtDYil.Text);
            ideal = (Convert.ToDouble(txtBoy.Text) - 100 + yas / 10) * katSayi;
            if (ideal == Convert.ToDouble(txtGKilo.Text))
            {
                MessageBox.Show("TEBRİKLER. İdeal kilodasınız.... İdeal kilonuz "+ ideal + " dır.");
            }
            else if (ideal > Convert.ToDouble(txtGKilo.Text))
            {
                MessageBox.Show("Zayıfsınız.... İdeal Kilonuz " + ideal +" olmalıdır." );
            }
            else
            {
                MessageBox.Show("Kilolusunuz....İdeal Kilonuz " + ideal + " olmalıdır.");
            }
            txtCins.Clear();
            txtBoy.Clear();
            txtGKilo.Clear();
            txtDYil.Clear();
        }
    }
}
