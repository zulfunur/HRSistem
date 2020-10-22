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
    public partial class RandeyuyuKaydet : Form
    {
        
        public RandeyuyuKaydet()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=ZULFU-SONY\\SQL_2014;Initial Catalog=HastaneSistemi;Integrated Security=True");

        private void btnRandevuyuKaydet_Click(object sender, EventArgs e)
        {
            //insert işlemini buraya
        }

        private void RandeyuyuKaydet_Load(object sender, EventArgs e)
        {
            int HidNo = 0;
            lblRhastane.Text = FrmRandevuAl.vHastane;
            lblRhekim.Text = FrmRandevuAl.vHekim;
            lblRklinik.Text = FrmRandevuAl.vKlinik;
            lblRzaman.Text = FrmRandevuAl.vTarih;
            lblRtcno.Text = Form1.tcNo;
            lblRhastaadi.Text = Form1.hastaAd;
            lblRhastasoyadı.Text = Form1.hastaSoyad;
            lblRhastadogtarihi.Text = Form1.hastaDogTarih;
            lblRhastaTel.Text = Form1.hastaTelefon;
            lblRsaat.Text = FrmRandevuAl.secilenRandevuSaat;

            //baglan.Open();
            //SqlCommand komut1 = new SqlCommand("select h.* from tbl_hasta h join tbl_kullanici k where k.kullaniciAd ='" + tc + "'", baglan);


           /* baglan.Open();
            SqlCommand komut0 = new SqlCommand("Select h.* from tbl_hasta h join tbl_kullanici k on h.HastaID = k.HastaID where KullaniciAd='" + txthad.Text + "'", baglan);
            komut0.CommandType = new CommandType();
            SqlDataReader dr5 = komut0.ExecuteReader();
            while (dr5.Read())
            {
                HidNo = Int32.Parse(dr5["HastaID"].ToString());
            }
            baglan.Close();*/

        }
    }
}
