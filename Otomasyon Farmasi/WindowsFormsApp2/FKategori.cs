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
    public partial class FKategori : Form
    {
        public FKategori()
        {
            InitializeComponent();
        }
        void Listele()
        {
            dataGridView1.DataSource = (from c in Baglanti.db.TKategori select new { c.KategoriID, c.KategoriAd }).ToList();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void FKategori_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TKategori t = new TKategori();
            t.KategoriAd = textBox2.Text;
            Baglanti.db.TKategori.Add(t);
            Baglanti.db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var x = Baglanti.db.TKategori.Find(id);
            Baglanti.db.TKategori.Remove(x);
            Baglanti.db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var x = Baglanti.db.TKategori.Find(id);
            x.KategoriAd = textBox2.Text;
            Baglanti.db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
            Listele();
        }
    }
}
