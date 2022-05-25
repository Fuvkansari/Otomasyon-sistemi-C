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
    public partial class FSatisYap : Form
    {
        public FSatisYap()
        {
            InitializeComponent();
        }
        void UrunListe()
        {
            dataGridView1.DataSource = (from c in Baglanti.db.TUrun select new { c.UrunKodu, c.UrunAd, c.SatisFiyat, c.AlisFiyat, c.Stok }).ToList();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void FSatisYap_Load(object sender, EventArgs e)
        {
            UrunListe();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TSatis t = new TSatis();
            t.Urun = textBox2.Text;
            int adet = Convert.ToInt32(textBox4.Text);
            var urunucret = Baglanti.db.TUrun.Where(b => b.UrunKodu == t.Urun).Select(n => n.SatisFiyat).FirstOrDefault();
            t.Ucret = adet * urunucret;
            t.Adet = adet;
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());

            var urunstok = Baglanti.db.TUrun.Where(b => b.UrunKodu == t.Urun).FirstOrDefault();
            urunstok.Stok -= adet;


            Baglanti.db.TSatis.Add(t);
            Baglanti.db.SaveChanges();
            MessageBox.Show("Satış Başarıyla Oluşturuldu");
            UrunListe();
        }
    }
}
