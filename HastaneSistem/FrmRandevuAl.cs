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
    public partial class FrmRandevuAl : Form
    {
       
        public FrmRandevuAl()
        {
            InitializeComponent();
            cmbil.SelectedIndexChanged += cmbil_SelectedIndexChanged;
            cmbilce.SelectedIndexChanged += cmbilce_SelectedIndexChanged;
            cmbhastane.SelectedIndexChanged += cmbhastane_SelectedIndexChanged;
            cmbklinik.SelectedIndexChanged += cmbklinik_SelectedIndexChanged;
        }

        public static string vHastane, vHekim, vKlinik, vTarih, secilenRandevuSaat,hastaneId,klinikId;
        public static int doktorID;
        SqlConnection baglan = new SqlConnection("Data Source=ZULFU-SONY\\SQL_2014;Initial Catalog=HastaneSistemi;Integrated Security=True");
        void temizle()
        {
            cmbil.Text = "";
            cmbilce.Text = "";
            cmbklinik.Text = "";
            cmbhekim.Text = "";
            cmbhastane.Text = "";
            //mskdtarih.Text = "";
            cmbil.Focus();

        }

        private void FrmRandevuAl_Load(object sender, EventArgs e)
        {
            //combobox iller
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("select * from tbl_il ", baglan);

            komut1.CommandType = new CommandType();
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbil.Items.Add(dr1["Ilad"]);
            }
            baglan.Close();


        }
        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut2 = new SqlCommand("select i.Ilcead from tbl_ilce i join tbl_il l on i.Ilid = l.Ilid where Ilad = '" + cmbil.Text + "'", baglan);

            komut2.CommandType = new CommandType();

            SqlDataReader dr2 = komut2.ExecuteReader();
            cmbilce.Items.Clear();
            while (dr2.Read())
            {
                cmbilce.Items.Add(dr2["Ilcead"]);
            }
            baglan.Close();
        }
        private void cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut3 = new SqlCommand("select h.HastaneAdi from tbl_hastane h join tbl_ilce i on h.Ilceid = i.Ilceid where Ilcead = '" + cmbilce.Text + "'", baglan);

            komut3.CommandType = new CommandType();

            SqlDataReader dr3 = komut3.ExecuteReader();
            cmbhastane.Items.Clear();
            while (dr3.Read())
            {
                cmbhastane.Items.Add(dr3["HastaneAdi"]);
            }
            baglan.Close();
        }
        private void cmbhastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut4 = new SqlCommand("select k.KlinikAd from tbl_hepsi h join tbl_hastane t on h.HastaneID = t.HastaneID join tbl_klinik k on h.Klinikid= k.Klinikid where HastaneAdi = '" + cmbhastane.Text + "'", baglan);

            komut4.CommandType = new CommandType();

            SqlDataReader dr4 = komut4.ExecuteReader();
            cmbklinik.Items.Clear();
            while (dr4.Read())
            {
                cmbklinik.Items.Add(dr4["KlinikAd"]);
            }
            baglan.Close();

        }
        private void cmbklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut5 = new SqlCommand("select d.DoktorAd,d.DoktorSoyad,d.DoktorID from tbl_hepsi h join tbl_hastane t on h.HastaneID = t.HastaneID " +
                                               "join tbl_klinik k on h.Klinikid = k.Klinikid join tbl_doktor d on h.DoktorID = d.DoktorID where KlinikAd = '"
                                               + cmbklinik.Text + "'and t.HastaneAdi ='"+ cmbhastane.Text +"'", baglan);

            komut5.CommandType = new CommandType();

            SqlDataReader dr5 = komut5.ExecuteReader();
            cmbhekim.Items.Clear();
            while (dr5.Read())
            {
                doktorID = Convert.ToInt32(dr5["DoktorID"].ToString());
                string doktor = dr5["DoktorAd"] + " " + dr5["DoktorSoyad"];
                cmbhekim.Items.Add(doktor);
            }
            baglan.Close();

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnRandevuAra_Click(object sender, EventArgs e)
        {
            if((cmbil.Text=="") || (cmbil.Text=="İl Seçiniz*"))
            {
                MessageBox.Show("Lütfen İl Seçiniz. ");
                
            }
            else if ((cmbilce.Text=="") || (cmbilce.Text=="İlçe Seçiniz*"))
            {
                MessageBox.Show("Lütfen İlçe Seçiniz. ");
            }
            else if ((cmbhastane.Text=="") || (cmbhastane.Text=="Hastane*"))
            {
                MessageBox.Show("Lütfen Hastane Seçiniz. ");
            }
            else if ((cmbklinik.Text == "") || (cmbklinik.Text == "Klinik*"))
            {
                MessageBox.Show("Lütfen Klinik Seçiniz. ");
            }
             else if ((cmbhekim.Text=="") || (cmbhekim.Text=="Hekim*"))
            {
                MessageBox.Show("Lütfen Hekim Seçiniz. ");
            }
            else
                groupBox1.Show();

            vHastane =cmbhastane.Text;
            vHekim = cmbhekim.Text;
            vKlinik = cmbklinik.Text;
            vTarih = dTPtarih.Text;

            baglan.Open();

            var tarih = dTPtarih.Value.Year.ToString() + "-";
            var month = dTPtarih.Value.Month;
            if (month < 10)
                tarih += "0" + month.ToString() + "-";
            else
                tarih += month.ToString() + "-";
            var day = dTPtarih.Value.Day;
            if (day < 10)
                tarih += "0" + day.ToString();
            else
                tarih += day.ToString();

            SqlCommand komut = new SqlCommand("select * from tbl_doktor_randevu_saatleri drs inner join tbl_randevu_saat " +
                "rs on drs.RandevuSaatId = rs.Id where drs.DoktorID =" + 1 + "and drs.RandevuTarih ='" + tarih + "'", baglan);

            komut.CommandType = new CommandType();

            SqlDataReader dr = komut.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    string saat = dr["Saat"].ToString();
                    switch (saat)
                    {
                        case "09:00":
                            btn9.BackColor = Color.Red;
                            break;
                        case "10:00":
                            btn10.BackColor = Color.Red;
                            break;
                        case "11:00":
                            btn11.BackColor = Color.Red;
                            break;
                        case "12:00":
                            btn12.BackColor = Color.Red;
                            break;
                        case "13:00":
                            btn13.BackColor = Color.Red;
                            break;
                        case "14:00":
                            btn14.BackColor = Color.Red;
                            break;
                        case "15:00":
                            btn15.BackColor = Color.Red;
                            break;
                        case "16:00":
                            btn16.BackColor = Color.Red;
                            break;
                        default:
                            break;
                    }
                 }
            }
            else
            {

            }


            baglan.Close();

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.BackColor = Color.Red;
            RandeyuyuKaydet frmk = new RandeyuyuKaydet();
            frmk.Show();
        }

        private void cmbhekim_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
