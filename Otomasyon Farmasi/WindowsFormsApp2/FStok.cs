using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Entities;

namespace WindowsFormsApp2
{
    public partial class FStok : Form
    {
        public FStok()
        {
            InitializeComponent();
        }

        private void FStok_Load(object sender, EventArgs e)
        {
            label7.Text = Baglanti.db.TUrun.OrderBy(b => b.Stok).Select(b => b.UrunAd).FirstOrDefault();
            label5.Text = Baglanti.db.TUrun.Sum(b => b.Stok).ToString();

            Baglanti.bgl.Open();
            SqlCommand komut = new SqlCommand("BugunCiro", Baglanti.bgl);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (Convert.ToString(dr[0]) != "")
                {
                    label2.Text = $"{dr[0]}₺";
                }
                else
                {
                    label2.Text = "Bugün Hiç Satış Yapmadınız.";
                }
            }
            dr.Close();
            Baglanti.bgl.Close();

            Baglanti.bgl.Open();
            SqlCommand komut2 = new SqlCommand("BuAyCiro", Baglanti.bgl);
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                if (Convert.ToString(dr2[0]) != "")
                {
                    label3.Text = $"{dr2[0]}₺";
                }
                else
                {
                    label3.Text = "Bu Ay Hiç Satış Yapmadınız.";
                }
            }
            dr2.Close();
            Baglanti.bgl.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
