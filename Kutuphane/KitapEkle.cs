using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class KitapEkle : Form
    {
        AnaEkran anaEkran;

        public KitapEkle(AnaEkran parametredenGelenAnaEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenAnaEkran;
            yazarAdlari();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap(textBox1.Text, comboBox1.Text);
            anaEkran.kitapEkle(kitap);

            anaEkran.Show();
            this.Close();
        }

        private void KitapEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            anaEkran.Show();
        }
        public void yazarAdlari()
        {
            comboBox1.Items.Add("Yusuf Akçura");
            comboBox1.Items.Add("Ziya Gökalp");
            comboBox1.Items.Add("Nihal Atsız");
            comboBox1.Items.Add("Oğuz Atay");
        }
    }
}
