using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bahar_Pansiyon_4
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yenimusteri fr = new yenimusteri();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            musteriarama fr = new musteriarama();
            fr.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            Form frmyenimusterics = new yenimusteri();
            frmyenimusterics.Show();
            
        }

       

       

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form yardim = new yardim();
            yardim.Show();
        }

        private void müşteriEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form yenimusteri = new yenimusteri();
            yenimusteri.Show();
        }

        private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form odalar = new odalar();
            odalar.Show();
        }

        private void aramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form musteriarama = new musteriarama();
            musteriarama.Show();
        }

        private void müşteriMesajlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form musteriarama = new musteriarama();
            musteriarama.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form musteriarama = new musteriarama();
            musteriarama.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void gelirGiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form gelirgider=new gelirgider();
            gelirgider.Show();
        }

        private void stoklarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form stoklar = new stoklar();
            stoklar.Show();
        }

        private void faturalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form faturalar = new faturalar();
            faturalar.Show();

        }

        private void müşteriŞikayeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void havaDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form müsteriarama  = new musteriarama();
            müsteriarama.Show();

        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form çalışanlar = new çalışanlar();
            çalışanlar.Show();
        }
    }
}
