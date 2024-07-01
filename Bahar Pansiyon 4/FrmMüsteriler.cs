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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Bahar_Pansiyon_4
{
    public partial class musteriarama : Form
    {
        public musteriarama()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Ltm\\OneDrive\\Masaüstü\\Pansiyonn.accdb");
        DataTable tablo = new DataTable();
        DataAdapter adtr = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();
        DataSet ds=new DataSet();
        private void verilergoster()
        {
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void musteriarama_Load(object sender, EventArgs e)
        {
       
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from pansiyonn", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from pansiyonn where Ad=@Ad", baglanti);
            komut.Parameters.AddWithValue("@Ad", dataGridView1.CurrentRow.Cells["Ad"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme işlemi başarıyla gerçekleşmiştir");
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtadi.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            txtsoyadi.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["Cinsiyet"].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Odanumarası"].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells["Ucret"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["Giristarihi"].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells["Cıkıstarihi"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string gun = "UPDATE pansiyonn SET Ad='" + txtadi.Text + "',Soyad='" + txtsoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + maskedTextBox1.Text + "',Email='" + textBox3.Text + "' ,tc='" + textBox4.Text + "' ,Odanumarası='" +textBox5.Text + "' ,Ucret='" + textBox6.Text + "',Giristarihi='" + dateTimePicker1.Text + "' WHERE Ad='" + txtadi.Text + "'";
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand(gun, baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti");
            
            





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtadi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }
    }
}
//Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ltm\OneDrive\Masaüstü\Pansiyonn.accdb