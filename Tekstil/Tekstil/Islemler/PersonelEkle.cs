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
using System.Text.RegularExpressions;
using System.Configuration;

namespace Tekstil
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd;
        

        string[] idler = new string[5];

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            tB_TC.MaxLength = 11;
            tB_telefon.MaxLength = 11;
            DepDoldur();
        }

        private void DepDoldur()
        {
            int i = 0;

            string kayit = "Select * From Departman where visible=1";
            cmd = new SqlCommand(kayit, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                idler[i] = dr["departman_id"].ToString();
                cB_Departman.Items.Add(dr["departman_isim"]);
                i++;
            }
            con.Close();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {

            if (tB_TC.Text == "" || tB_isim.Text == "" || tB_soyisim.Text == "" || tB_kad.Text == "" || tB_sifre.Text == "" || tB_eposta.Text == "" || tB_telefon.Text == "" || tB_Adres.Text == "" || cB_Departman.SelectedIndex == -1 || cB_Cinsiyet.SelectedIndex == -1 || tB_Gsoru.Text == "" || tB_GCevap.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }
            else if (SayiMi(tB_telefon.Text) == false || SayiMi(tB_TC.Text) == false)
            {
                MessageBox.Show("TC ve Telefon sayısal değer olmalıdır.");
            }
            else
            {
                /*
                int indx = cB_Departman.SelectedIndex;
                con.Open();
                string kayit = "insert into Personel(tckimlik,isim,soyisim,kullaniciadi,sifre,eposta,telefon_numarasi,adres,departman_id,guvenlik_sorusu,cinsiyet,guvenlik_sorusu_cevap,visible) values (@tc,@isim,@soy,@kad,@sifre,@eposta,@tel,@adres,@dep,@soru,@cinsiyet,@cevap,1)";
                cmd = new SqlCommand(kayit, con);
                cmd.Parameters.AddWithValue("@tc", tB_TC.Text);
                cmd.Parameters.AddWithValue("@isim", tB_isim.Text);
                cmd.Parameters.AddWithValue("@soy", tB_soyisim.Text);
                cmd.Parameters.AddWithValue("@kad", tB_kad.Text);
                cmd.Parameters.AddWithValue("@sifre", tB_sifre.Text);
                cmd.Parameters.AddWithValue("@eposta", tB_eposta.Text);
                cmd.Parameters.AddWithValue("@tel", tB_telefon.Text);
                cmd.Parameters.AddWithValue("@adres", tB_Adres.Text);
                cmd.Parameters.AddWithValue("@dep", idler[indx]);
                cmd.Parameters.AddWithValue("@soru", tB_Gsoru.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", cB_Cinsiyet.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@cevap", tB_GCevap.Text);
                cmd.ExecuteNonQuery();
                con.Close();*/

                int indx = cB_Departman.SelectedIndex;
                con.Open();
                string kayit1 = "Select * from Personel where visible=1 and kullaniciadi=@ad";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@ad", tB_kad.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read() == false)
                {
                    dr.Close();
                    string kayit = "insert into Personel(tckimlik,isim,soyisim,kullaniciadi,sifre,eposta,telefon_numarasi,adres,departman_id,guvenlik_sorusu,cinsiyet,guvenlik_sorusu_cevap,visible) values (@tc,@isim,@soy,@kad,@sifre,@eposta,@tel,@adres,@dep,@soru,@cinsiyet,@cevap,1)";
                    cmd = new SqlCommand(kayit, con);
                    cmd.Parameters.AddWithValue("@tc", tB_TC.Text);
                    cmd.Parameters.AddWithValue("@isim", tB_isim.Text);
                    cmd.Parameters.AddWithValue("@soy", tB_soyisim.Text);
                    cmd.Parameters.AddWithValue("@kad", tB_kad.Text);
                    cmd.Parameters.AddWithValue("@sifre", tB_sifre.Text);
                    cmd.Parameters.AddWithValue("@eposta", tB_eposta.Text);
                    cmd.Parameters.AddWithValue("@tel", tB_telefon.Text);
                    cmd.Parameters.AddWithValue("@adres", tB_Adres.Text);
                    cmd.Parameters.AddWithValue("@dep", idler[indx]);
                    cmd.Parameters.AddWithValue("@soru", tB_Gsoru.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", cB_Cinsiyet.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@cevap", tB_GCevap.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Personel oluşturuldu.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("kullanıcı adı daha önce kullanılmış.");
                    tB_kad.Text = "";
                    con.Close();
                }

                
            }
        }

        private void tB_eposta_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if(Regex.IsMatch(tB_eposta.Text,pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.tB_eposta,"Email doğru giriniz.");
            }
        }

        public Boolean SayiMi(String strVeri)
        {
            if (String.IsNullOrEmpty(strVeri) == true)
            {
                return false;
            }
            else
            {
                Regex desen = new Regex("^[0-9]*$");
                return desen.IsMatch(strVeri);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tB_GCevap_TextChanged(object sender, EventArgs e)
        {

        }

        private void cB_Cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tB_Gsoru_TextChanged(object sender, EventArgs e)
        {

        }

        private void cB_Departman_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tB_Adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void tB_telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void tB_eposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void tB_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tB_kad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tB_soyisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
