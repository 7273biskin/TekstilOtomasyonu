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
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }

        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd;
       

        string[] idler = new string[5];

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            tB_TC.MaxLength = 11;
            tB_telefon.MaxLength = 11;
            DepDoldur();
            Getir();
        }

        private void Getir()
        {
            string kayit = "Select * from Personel inner join Departman on Departman.departman_id = Personel.departman_id where personel_id="+Personel.personel_ID+"";
            cmd = new SqlCommand(kayit, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                tB_TC.Text = dr["tckimlik"].ToString();
                tB_isim.Text = dr["isim"].ToString();
                tB_soyisim.Text = dr["soyisim"].ToString();
                tB_kad.Text= dr["kullaniciadi"].ToString(); ;
                tB_sifre.Text = dr["sifre"].ToString();
                tB_eposta.Text = dr["eposta"].ToString();
                tB_Adres.Text= dr["adres"].ToString();
                tB_telefon.Text = dr["telefon_numarasi"].ToString();
                tB_Gsoru.Text= dr["guvenlik_sorusu"].ToString();
                tB_GCevap.Text= dr["guvenlik_sorusu_cevap"].ToString();
                cB_Cinsiyet.SelectedItem = dr["cinsiyet"].ToString();
                cB_Departman.SelectedItem = dr["departman_isim"].ToString();
            }

            con.Close();

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
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

                int indx = cB_Departman.SelectedIndex;
                con.Open();

                    string kayit = "update Personel set tckimlik=@tc,isim=@isim,soyisim=@soy,kullaniciadi=@kad,sifre=@sifre,eposta=@eposta,telefon_numarasi=@tel,adres=@adres,departman_id=@dep,guvenlik_sorusu=@soru,cinsiyet=@cinsiyet,guvenlik_sorusu_cevap=@cevap,visible=1 where personel_id=@id";
                    cmd = new SqlCommand(kayit, con);
                    cmd.Parameters.AddWithValue("@id", Personel.personel_ID);
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
                    MessageBox.Show("Personel güncellendi.");

                    this.Close();
            }

        }

        private void tB_eposta_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(tB_eposta.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.tB_eposta, "Email doğru giriniz.");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
