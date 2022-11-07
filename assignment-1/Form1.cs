using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görselProg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Hesapla(object sender, EventArgs e)
        {
            try
            {
                double sayi1, sayi2,ortalama;
                sayi1 = Convert.ToDouble(numericUpDown1.Value);
                sayi2 = Convert.ToDouble(numericUpDown2.Value);

                ortalama = (sayi1 * 0.4 + sayi2 * 0.6);
                label3.Visible = true;
                label3.Text = ortalama.ToString();

                var kullanicilar = new Dictionary<int, string>();
                kullanicilar.Add(0, "FF");
                kullanicilar.Add(30, "FD");
                kullanicilar.Add(40, "DD");
                kullanicilar.Add(50, "DC");
                kullanicilar.Add(60, "CC");
                kullanicilar.Add(70, "CB");
                kullanicilar.Add(75, "BB");
                kullanicilar.Add(80, "BA");
                kullanicilar.Add(90, "AA");
                
                
                
                
                
                string not="";

                string renk="";

                    foreach (var item in kullanicilar.Keys)
                    {
                        if (ortalama >= item)
                        {
                            not = kullanicilar[item];
                        }
                        else
                        {
                            break;
                        }
                    }

                    label4.Text = not;

                    if (not == "FD" || not == "FF" || sayi2<50)
                    {
                    label4.ForeColor = Color.Red;
                    label5.Text = "KALDI";
                    label5.BackColor = Color.Red;
                }
                else {
                    label4.ForeColor = Color.Green;
                    label5.Text = "GEÇTİ";
                    label5.BackColor = Color.Green;
                }

                label4.Visible = true;
                label5.Visible = true;


            }
           catch(Exception ex)
            {
                if(numericUpDown1.ToString() != "" && numericUpDown2.ToString() != "")
                {
                    MessageBox.Show("HATA MEVCUT");
                }
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }
    }
}
