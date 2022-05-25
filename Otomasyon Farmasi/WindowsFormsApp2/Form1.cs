using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Entities;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        void UrunListe()
        {
            dataGridView1.DataSource = (from c in Baglanti.db.TUrun select new { c.UrunKodu, c.UrunAd,c.SatisFiyat, c.AlisFiyat, c.TKategori.KategoriAd, c.Stok }).ToList();


            comboBox1.DataSource = Baglanti.db.TKategori.ToList();
            comboBox1.DisplayMember = "KategoriAd";
            comboBox1.ValueMember = "KategoriID";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListe();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TUrun t = new TUrun();
            t.SatisFiyat = Convert.ToDecimal(textBox3.Text);
            t.UrunKodu = textBox2.Text;
            t.UrunAd = textBox1.Text;
            t.AlisFiyat= Convert.ToDecimal(textBox5.Text);
            t.Kategori = Convert.ToInt32(comboBox1.SelectedValue);
            t.Stok = Convert.ToInt32(textBox4.Text);
            Baglanti.db.TUrun.Add(t);
            Baglanti.db.SaveChanges();
            MessageBox.Show("Ürün Eklendi");
            UrunListe();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var x = Baglanti.db.TUrun.Find(textBox2.Text);
            Baglanti.db.TUrun.Remove(x);
            Baglanti.db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
            UrunListe();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            UrunListe();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var t = Baglanti.db.TUrun.Find(textBox2.Text);
            t.SatisFiyat = Convert.ToDecimal(textBox3.Text);
            t.UrunKodu = textBox2.Text;
            t.UrunAd = textBox1.Text;
            t.AlisFiyat = Convert.ToDecimal(textBox5.Text);
            t.Kategori = Convert.ToInt32(comboBox1.SelectedValue);
            t.Stok = Convert.ToInt32(textBox4.Text);
            Baglanti.db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
            UrunListe();
        }
        FSatisYap f;
        FGunlukSatis f2;
        FKategori f3;
        FStok f4;
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new FSatisYap();
                f.Show();
            }
            else
            {
                f.Focus();
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new FGunlukSatis();
                f2.Show();
            }
            else
            {
                f2.Focus();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (f3 == null || f3.IsDisposed)
            {
                f3 = new FKategori();
                f3.Show();
            }
            else
            {
                f3.Focus();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null || textBox2.Text != "")
            {
                dataGridView1.DataSource = (from c in Baglanti.db.TUrun where c.UrunKodu.Contains(textBox2.Text) select new { c.UrunKodu, c.UrunAd, c.SatisFiyat, c.TKategori.KategoriAd, c.Stok }).ToList();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Ürün Kodunu Giriniz");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (f4 == null || f4.IsDisposed)
            {
                f4 = new FStok();
                f4.Show();
            }
            else
            {
                f4.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
