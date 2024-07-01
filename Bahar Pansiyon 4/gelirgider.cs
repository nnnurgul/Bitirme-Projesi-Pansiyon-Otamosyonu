using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bahar_Pansiyon_4
{
    public partial class gelirgider : Form
    {
        public gelirgider()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ltm\\OneDrive\\Masaüstü\\Pansiyonn.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            label4.Text = (personel * 4000).ToString();
            baglanti.Open();
            double a, b, c, d, e1, f, g, ı, sonuc;
            a = Convert.ToDouble(label3.Text);
            b = Convert.ToDouble(label4.Text);
            c = Convert.ToDouble(label6.Text);
            d = Convert.ToDouble(label13.Text);
            e1 = Convert.ToDouble(label14.Text);
            f = Convert.ToDouble(label8.Text);
            g = Convert.ToDouble(label15.Text);
            ı = Convert.ToDouble(label16.Text);
            sonuc = Convert.ToDouble(label12.Text);
            sonuc = a - (b + c + d + e1 + f + g + ı);
            label12.Text = sonuc.ToString();








            baglanti.Close();



        }

        private void gelirgider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand(" Select sum(Ucret)as toplam from pansiyonn", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label3.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //gıdalar
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand(" Select sum(gida)as toplam1 from stoklar", baglanti);
            OleDbDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                label6.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();


            //icecek
            baglanti.Open();
            OleDbCommand komut3 = new OleDbCommand(" Select sum(icecek)as toplam2 from stoklar", baglanti);
            OleDbDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                label13.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            //temizlik
            baglanti.Open();
            OleDbCommand komut4 = new OleDbCommand(" Select sum(temizlik)as toplam3 from stoklar", baglanti);
            OleDbDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                label14.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

           //elektirik
            baglanti.Open();
            OleDbCommand komut5 = new OleDbCommand(" Select sum(elektirik)as toplam4 from faturalar", baglanti);
            OleDbDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                label8.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            //su
            baglanti.Open();
            OleDbCommand komut6 = new OleDbCommand(" Select sum(su)as toplam5 from faturalar", baglanti);
            OleDbDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                label15.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();

            //internet
            baglanti.Open();
            OleDbCommand komut7 = new OleDbCommand(" Select sum(internet)as toplam6 from faturalar", baglanti);
            OleDbDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                label16.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();

           



        }
    }
}
