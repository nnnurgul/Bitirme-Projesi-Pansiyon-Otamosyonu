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
    public partial class odalar : Form
    {
        public odalar()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ltm\\OneDrive\\Masaüstü\\Pansiyonn.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void odalar_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbCommand komut1 = new OleDbCommand("Select * from oda1", baglanti);
            OleDbDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                button1.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (button1.Text != "1")
            {
                button1.BackColor = Color.Red;
            }
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("Select * from oda2", baglanti);
            OleDbDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                button2.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (button2.Text != "2")
            {
                button2.BackColor = Color.Red;
            }
            baglanti.Open();
            OleDbCommand komut3 = new OleDbCommand("Select * from oda3", baglanti);
            OleDbDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                button3.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (button3.Text != "3")
            {
                button3.BackColor = Color.Red;
            }
            baglanti.Open();
            OleDbCommand komut4 = new OleDbCommand("Select * from oda4", baglanti);
            OleDbDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                button4.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (button4.Text != "4")
            {
                button4.BackColor = Color.Red;
            }
            baglanti.Open();
            OleDbCommand komut5 = new OleDbCommand("Select * from oda5", baglanti);
            OleDbDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                button5.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (button5.Text != "5")
            {
                button5.BackColor = Color.Red;
            }
            baglanti.Open();
            OleDbCommand komut6 = new OleDbCommand("Select * from Oda6", baglanti);
            OleDbDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                button6.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (button6.Text != "6")
            {
                button6.BackColor = Color.Red;
            }
            baglanti.Open();
            OleDbCommand komut7 = new OleDbCommand("Select * from Oda7", baglanti);
            OleDbDataReader oku7 = komut3.ExecuteReader();
            while (oku7.Read())
            {
                button7.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (button7.Text != "7")
            {
                button7.BackColor = Color.Red;
            }
            baglanti.Open();
            OleDbCommand komut8 = new OleDbCommand("Select * from oda8", baglanti);
            OleDbDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                button8.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (button8.Text != "8")
            {
                button8.BackColor = Color.Red;
            }
            baglanti.Open();
            OleDbCommand komut9 = new OleDbCommand("Select * from oda9", baglanti);
            OleDbDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                button9.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (button9.Text != "9")
            {
                button9.BackColor = Color.Red;
            }
            baglanti.Open();
            OleDbCommand komut11 = new OleDbCommand("Select * from oda11", baglanti);
            OleDbDataReader oku11 = komut11.ExecuteReader();
            while (oku11.Read())
            {
                button11.Text = oku11["Adi"].ToString() + " " + oku11["Soyadi"].ToString();
            }
            baglanti.Close();
            if (button11.Text != "11")
            {
                button11.BackColor = Color.Red;
            }
            baglanti.Open();
            OleDbCommand komut12 = new OleDbCommand("Select * from oda12", baglanti);
            OleDbDataReader oku12 = komut12.ExecuteReader();
            while (oku12.Read())
            {
                button12.Text = oku12["Adi"].ToString() + " " + oku12["Soyadi"].ToString();
            }
            baglanti.Close();
            if (button12.Text != "12")
            {
                button12.BackColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }
        
private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }
    }
}
//Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ltm\\OneDrive\\Masaüstü\\Pansiyonn.accdb