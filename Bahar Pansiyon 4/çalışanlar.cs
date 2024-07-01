using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;

namespace Bahar_Pansiyon_4
{
    public partial class çalışanlar : Form
    {
        public çalışanlar()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Ltm\\OneDrive\\Masaüstü\\Pansiyonn.accdb");
        DataTable tablo = new DataTable();
        DataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();

        private void çalışanlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from calisanlar", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["tarih"].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Görev"].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from calisanlar where ad=@ad", baglanti);
            komut.Parameters.AddWithValue("@ad", dataGridView1.CurrentRow.Cells["ad"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme işlemi başarıyla gerçekleşmiştir");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gun = "UPDATE calisanlar SET Ad='" + textBox1.Text + "',Soyad='" + textBox2.Text + "',tarih='" + dateTimePicker1.Text + "',Telefon='" + maskedTextBox1.Text + "',Görev='" + textBox5.Text + "'   WHERE Ad='" + textBox1.Text + "'";
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand(gun, baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ltm\\OneDrive\\Masaüstü\\Pansiyonn.accdb");
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO calisanlar(ad,soyad,tarih,telefon,Görev) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + maskedTextBox1.Text + "','" + textBox5.Text + "')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
        }
    }
}
