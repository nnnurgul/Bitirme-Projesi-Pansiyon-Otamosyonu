using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Bahar_Pansiyon_4
{
    public partial class yenimusteri : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public yenimusteri()
        {
            InitializeComponent();
        }
        

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnoda1_Click(object sender, EventArgs e)
        {
           textBox5.Text = "1";
            MessageBox.Show("2 kişiliktir,Klima,İnternet,Mini bar mevcut","Oda bilgisi");
        }

        private void btnoda2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "2";
            MessageBox.Show("2 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void btnoda3_Click(object sender, EventArgs e)
        {
            textBox5.Text = "3";
            MessageBox.Show("2 kişiliktir,Klima,İnternet,Mini bar mevcutl", "Oda bilgisi");
        }

        private void btnoda4_Click(object sender, EventArgs e)
        {
            textBox5.Text = "4";
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void btnoda5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "5";
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void btnoda6_Click(object sender, EventArgs e)
        {
            textBox5.Text = "6";
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void btnoda7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "7";
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void btnoda8_Click(object sender, EventArgs e)
        {
            textBox5.Text = "8";
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void btnoda9_Click(object sender, EventArgs e)
        {
            textBox5.Text = "9";
            MessageBox.Show("3 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void btnoda10_Click(object sender, EventArgs e)
        {
            textBox5.Text = "10";
            MessageBox.Show("4 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void btnoda11_Click(object sender, EventArgs e)
        {
            textBox5.Text = "11";
            MessageBox.Show("4 kişiliktir,Klima,İnternet,Mini bar mevcut", "Oda bilgisi");
        }

        private void btnoda12_Click(object sender, EventArgs e)
        {
            textBox5.Text = "12";
            MessageBox.Show("4 kişiliktir,Klima,İnternet,Mini bar, mevcut", "Oda bilgisi");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime buyuktarih = Convert.ToDateTime(dateTimePicker2.Text);

            TimeSpan sonuc;

            sonuc = buyuktarih - kucuktarih;
            label11.Text=sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 500;
            textBox6.Text = ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ltm\\OneDrive\\Masaüstü\\Pansiyonn.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO pansiyonn(Ad,Soyad,Cinsiyet,Telefon,Email,tc,Odanumarası,Ucret,Giristarihi,Cıkıstarihi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "','" + comboBox1.Text + "','" + maskedTextBox1.Text + "','" + textBox3.Text +"','" + textBox4.Text +"','"+textBox5.Text+"','" + textBox6.Text +"','"+dateTimePicker1.Text+"','"+dateTimePicker2.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yenimusteri_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ltm\\OneDrive\\Masaüstü\\Pansiyonn.accdb");
            
            con.Open();
            OleDbCommand komut1 = new OleDbCommand("Select * from oda1", con);
            OleDbDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btnoda1.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            con.Close();
            if (btnoda1.Text != "1")
            {
                btnoda1.BackColor = Color.Red;
            }
            con.Open();
            OleDbCommand komut2 = new OleDbCommand("Select * from oda2", con);
            OleDbDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnoda2.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            con.Close();
            if (btnoda2.Text != "2")
            {
                btnoda2.BackColor = Color.Red;
            }
            con.Open();
            OleDbCommand komut3 = new OleDbCommand("Select * from oda3", con);
            OleDbDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnoda3.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            con.Close();
            if (btnoda3.Text != "3")
            {
                btnoda3.BackColor = Color.Red;
            }
            con.Open();
            OleDbCommand komut4 = new OleDbCommand("Select * from oda4", con);
            OleDbDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnoda4.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            con.Close();
            if (btnoda4.Text != "4")
            {
                btnoda4.BackColor = Color.Red;
            }
            con.Open();
            OleDbCommand komut5 = new OleDbCommand("Select * from oda5", con);
            OleDbDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnoda5.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            con.Close();
            if (btnoda5.Text != "5")
            {
                btnoda5.BackColor = Color.Red;
            }
            con.Open();
            OleDbCommand komut6 = new OleDbCommand("Select * from Oda6", con);
            OleDbDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnoda6.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            con.Close();
            if (btnoda6.Text != "6")
            {
                btnoda6.BackColor = Color.Red;
            }
            con.Open();
            OleDbCommand komut7 = new OleDbCommand("Select * from Oda7", con);
            OleDbDataReader oku7 = komut3.ExecuteReader();
            while (oku7.Read())
            {
                btnoda7.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            con.Close();
            if (btnoda7.Text != "7")
            {
                btnoda7.BackColor = Color.Red;
            }
            con.Open();
            OleDbCommand komut8 = new OleDbCommand("Select * from oda8", con);
            OleDbDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnoda8.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            con.Close();
            if (btnoda8.Text != "8")
            {
                btnoda8.BackColor = Color.Red;
            }
            con.Open();
            OleDbCommand komut9 = new OleDbCommand("Select * from oda9", con);
            OleDbDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btnoda9.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            con.Close();
            if (btnoda9.Text != "9")
            {
                btnoda9.BackColor = Color.Red;
            }
            con.Open();
            OleDbCommand komut11 = new OleDbCommand("Select * from oda11", con);
            OleDbDataReader oku11 = komut11.ExecuteReader();
            while (oku11.Read())
            {
                btnoda11.Text = oku11["Adi"].ToString() + " " + oku11["Soyadi"].ToString();
            }
            con.Close();
            if (btnoda11.Text != "11")
            {
                btnoda11.BackColor = Color.Red;
            }
            con.Open();
            OleDbCommand komut12 = new OleDbCommand("Select * from oda12", con);
            OleDbDataReader oku12 = komut12.ExecuteReader();
            while (oku12.Read())
            {
                btnoda12.Text = oku12["Adi"].ToString() + " " + oku12["Soyadi"].ToString();
            }
            con.Close();
            if (btnoda12.Text != "12")
            {
                btnoda12.BackColor = Color.Red;
            }
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToLongDateString();
            label13.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
