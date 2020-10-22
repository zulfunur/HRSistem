using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneSistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=ZULFU-SONY\\SQL_2014;Initial Catalog=HastaneSistemi;Integrated Security=True");
        public static string tcNo,hastaAd, hastaSoyad, hastaDogTarih, hastaTelefon,hastaId;

        private void lblsifre_Click(object sender, EventArgs e)
        {

        }

        private void BTNGİRİS_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_kullanici k inner join tbl_hasta h on k.HastaID = h.HastaID where k.KullaniciAd=@k1 and k.KullaniciSifre=@k2",baglan);
            komut.Parameters.AddWithValue("@k1", txttcgiriniz.Text);
            komut.Parameters.AddWithValue("@k2", txtsifregiriniz.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                tcNo = dr["HastaTcNo"].ToString();
                hastaAd = dr["HastaAd"].ToString();
                hastaSoyad = dr["HastaSoyad"].ToString();
                hastaDogTarih = dr["HastaDogTarih"].ToString();
                hastaTelefon = dr["HastaTelefon"].ToString();
                hastaId = dr["HastaTelefon"].ToString();
                tcNo = txttcgiriniz.Text;
                FrmRandevuAl rd = new FrmRandevuAl();
                rd.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adını ve Şifreyi Kontrol Ediniz.");
            }
            baglan.Close();
           

        }

        private void btnhkayıtol_Click(object sender, EventArgs e)
        {
            frm_hasta_kayıt hk = new frm_hasta_kayıt();
            hk.Show();
        }
    }
}
