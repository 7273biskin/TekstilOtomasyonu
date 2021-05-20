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
using System.Configuration;
using System.Diagnostics;

namespace Tekstil
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd;
        string soru;
        string sifre;

        private void button1_Click(object sender, EventArgs e)
        {

            label_guven.Visible = true;
            label_cvp.Visible = true;
            label_soru.Visible = true;
            tB_Cevap.Visible = true;
            btn_Ogren.Visible = true;

            
            
            con.Open();
            string kayit = "Select * from Personel where kullaniciadi=@ad";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@ad", tB_ad.Text);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                soru = dr["guvenlik_sorusu"].ToString();
            }
            

            con.Close();

            label_soru.Text = soru;

            if(label_soru.Text=="")
            {
                
                label_guven.Visible = false;
                label_cvp.Visible = false;
                label_soru.Visible = false;
                tB_Cevap.Visible = false;
                btn_Ogren.Visible = false;
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Ogren_Click(object sender, EventArgs e)
        {
            con.Open();
            string kayit = "Select * from Personel where kullaniciadi=@ad and guvenlik_sorusu_cevap=@cevap";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@ad", tB_ad.Text);
            cmd.Parameters.AddWithValue("@cevap", tB_Cevap.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                sifre = dr["sifre"].ToString();

                MessageBox.Show(sifre);

                tB_ad.Text = "";
                tB_Cevap.Text = "";
                label_guven.Visible = false;
                label_cvp.Visible = false;
                label_soru.Visible = false;
                tB_Cevap.Visible = false;
                btn_Ogren.Visible = false;
            }
            else
            {
                MessageBox.Show("Hatalı giriş.");
            }
            con.Close();

        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_GirisEkran_Click(object sender, EventArgs e)
        {
            Giris ss = new Giris();
            ss.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tB_Cevap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_soru_Click(object sender, EventArgs e)
        {

        }
    }
}
