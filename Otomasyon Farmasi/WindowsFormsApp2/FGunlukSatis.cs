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
    public partial class FGunlukSatis : Form
    {
        public FGunlukSatis()
        {
            InitializeComponent();
        }
        void GunlukSatis()
        {
            dataGridView1.DataSource = Baglanti.db.GunlukSatis();
        }
        void AylikSatis()
        {
            
            dataGridView1.DataSource = Baglanti.db.AylikSatis();
        }
        void YillikSatis()
        {
            dataGridView1.DataSource = Baglanti.db.YillikSatis();
        }
        private void FGunlukSatis_Load(object sender, EventArgs e)
        {
            GunlukSatis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GunlukSatis();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AylikSatis();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YillikSatis();
        }
    }
}
