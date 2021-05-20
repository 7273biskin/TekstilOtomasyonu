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

namespace Tekstil
{
    public partial class PersonelDetay : Form
    {
        public PersonelDetay()
        {
            InitializeComponent();
        }

        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd;
      
        private void PersonelDetay_Load(object sender, EventArgs e)
        {
            
            Getir();
        }

        private void Getir()
        {
            string kayit = "Select * from Personel inner join Departman on Departman.departman_id = Personel.departman_id where personel_id=" + Personel.detay_ID + "";
            cmd = new SqlCommand(kayit, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tB_TC.Text = dr["tckimlik"].ToString();
                tB_isim.Text = dr["isim"].ToString();
                tB_soyisim.Text = dr["soyisim"].ToString();
                tB_kad.Text = dr["kullaniciadi"].ToString(); ;
                tB_sifre.Text = dr["sifre"].ToString();
                tB_eposta.Text = dr["eposta"].ToString();
                tB_Adres.Text = dr["adres"].ToString();
                tB_telefon.Text = dr["telefon_numarasi"].ToString();
                tB_Gsoru.Text = dr["guvenlik_sorusu"].ToString();
                tB_GCevap.Text = dr["guvenlik_sorusu_cevap"].ToString();
                tB_Cinsiyet.Text = dr["cinsiyet"].ToString();
                tB_Departman.Text = dr["departman_isim"].ToString();
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
