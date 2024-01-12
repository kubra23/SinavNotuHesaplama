using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavNotuHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txbAd.Text;
            string soyad = txbSoyad.Text;
            double sinav1=Convert.ToDouble(txbSinav1.Text);
            double sinav2 = Convert.ToDouble(txbSinav2.Text);
            double proje = Convert.ToDouble(txbProje.Text);
            double ort = (sinav1 + sinav2 + proje)/3;
            listBox1.Items.Add(ad+" "+soyad+" "+"Ortalama= "+ort);
        }
    }
}
