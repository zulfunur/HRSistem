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
    public partial class frm_hasta_kayıt : Form
    {
        public frm_hasta_kayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=ZULFU-SONY\\SQL_2014;Initial Catalog=HastaneSistemi;Integrated Security=True");

        private void frm_hasta_kayıt_Load(object sender, EventArgs e)
        {
           
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            int IDno = 0;
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_hasta (HastaAd,HastaSoyad,HastaTcno,HastaTelefon,HastaDogTarih) values(@ad,@soyad,@tcno,@tel,@dogtarih)", baglan);
            
            komut.Parameters.AddWithValue("@ad", txthad.Text);
            komut.Parameters.AddWithValue("@soyad", txthsoyad.Text);
            komut.Parameters.AddWithValue("@tcno", mskdhtc.Text);
            komut.Parameters.AddWithValue("@tel", mskdhtel.Text);
            //komut.Parameters.AddWithValue("@cinsiyet",);
            komut.Parameters.AddWithValue("@dogtarih", mskdhdogtarihi.Text);
            komut.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            SqlCommand komut3 = new SqlCommand("Select HastaID from tbl_hasta where HastaAd='"+ txthad.Text +"'", baglan);
            komut3.CommandType = new CommandType();
            SqlDataReader dr5 = komut3.ExecuteReader();
            while (dr5.Read())
            {
                IDno = Int32.Parse(dr5["HastaID"].ToString());
            }
            baglan.Close();

            baglan.Open();
            SqlCommand komut2 = new SqlCommand("insert into tbl_kullanici (KullaniciAd, KullaniciSifre, HastaID) values(@tcno, @sifre,"+ IDno +")", baglan);
            komut2.Parameters.AddWithValue("@tcno", mskdhtc.Text);
            komut2.Parameters.AddWithValue("@sifre", txtsifre.Text);
            komut2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Hasta Kaydınız Oluşturulmuştur.");
        }
    }
}
