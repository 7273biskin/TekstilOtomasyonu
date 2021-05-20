using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Tekstil
{
    public partial class SiparisEkle : Form
    {
        public SiparisEkle()
        {
            InitializeComponent();
        }

        
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd,cmd2;
       

        string[] sirketidler = new string[50];
        string[] modelidler = new string[50];
        string[] aksesuaridler = new string[50];
        string[] kumasidler = new string[50];

        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            sirketDoldur();
            modelDoldur();
            aksesuarDoldur();
            kumasDoldur();
        }

        private void kumasDoldur()
        {
            int i = 0;

            string kayit = "Select * From Kumas where visible=1";
            cmd = new SqlCommand(kayit, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                kumasidler[i] = dr["kumas_id"].ToString();
                cB_Kumas.Items.Add(dr["kumas_isim"]);
                i++;
            }
            con.Close();
        }

        private void aksesuarDoldur()
        {
            int i = 0;

            string kayit = "Select * From Aksesuar where visible=1";
            cmd = new SqlCommand(kayit, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                aksesuaridler[i] = dr["aksesuar_id"].ToString();
                cB_Aksesuar.Items.Add(dr["aksesuar_isim"]);
                i++;
            }
            con.Close();
        }

        private void modelDoldur()
        {
            int i = 0;

            string kayit = "Select * From Model where visible=1";
            cmd = new SqlCommand(kayit, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                modelidler[i] = dr["model_id"].ToString();
                cB_Model.Items.Add(dr["model_isim"]);
                i++;
            }
            con.Close();
        }

        private void sirketDoldur()
        {
            int i = 0;

            string kayit = "Select * From Sirket where visible=1";
            cmd = new SqlCommand(kayit, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                sirketidler[i] = dr["musteri_id"].ToString();
                cB_Sirket.Items.Add(dr["musteri_isim"]);
                i++;
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cB_Sirket.SelectedIndex == -1 || tB_SiparisNo.Text == "")
            {
                MessageBox.Show("Boş kısım bırakmayınız.");
            }/*
            else
            {
                
                con.Open();
                string kayit = "insert into Siparis(siparis_id,siparis_tarih,musteri_id,visible) values (@id,@tarih,@sid,1)";
                cmd = new SqlCommand(kayit, con);
                cmd.Parameters.AddWithValue("@id", tB_SiparisNo.Text);
                cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@sid", sirketidler[indx]);
                cmd.ExecuteNonQuery();
                con.Close();
            }*/

            else if (SayiMi(tB_SiparisNo.Text)==false)
            {
                MessageBox.Show("Sipariş No Sayılardan oluşmalıdır.");
            }
            else
            {
                int indx = cB_Sirket.SelectedIndex;
                con.Open();
                string kayit1 = "Select * from Siparis where siparis_id=@id";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_SiparisNo.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read()==false)
                {
                    dr.Close();
                    string kayit = "insert into Siparis(siparis_id,siparis_tarih,sirket_id,visible,kesildimi,dikildimi) values (@id,@tarih,@sid,1,'Hayır','Hayır')";
                    cmd2 = new SqlCommand(kayit, con);
                    cmd2.Parameters.AddWithValue("@id", tB_SiparisNo.Text);
                    cmd2.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                    cmd2.Parameters.AddWithValue("@sid", sirketidler[indx]);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sipariş oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("sipariş no daha önce kullanılmış.");
                    tB_SiparisNo.Text = "";
                    con.Close();
                }
            }
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tB_SiparisNo.Text=="" || cB_Sezon.SelectedIndex==-1|| cB_Cinsiyet.SelectedIndex==-1||cB_Kalip.SelectedIndex==-1||tB_Adet.Text==""|cB_Model.SelectedIndex==-1||cB_Aksesuar.SelectedIndex==-1||cB_Kumas.SelectedIndex==-1)
            {
                MessageBox.Show("Boş değer bırakılmamalıdır.");
            }
            else if (SayiMi(tB_Adet.Text) == false)
            {
                MessageBox.Show("Adet Sayılardan oluşmalıdır.");
            }
            else if (SayiMi(tB_SiparisNo.Text) == false)
            {
                MessageBox.Show("Sipariş numarası sayılardan oluşmalıdır.");
            }
            else
            {
                try
                {
                    int indx = cB_Model.SelectedIndex;
                    int indx2 = cB_Aksesuar.SelectedIndex;
                    int indx3 = cB_Kumas.SelectedIndex;

                    con.Open();
                    string kayit = "insert into SiparisDetay(siparis_id,sezon,cinsiyet,kalip,adet,model_id,aksesuar_id,kumas_id,visible) values (@id,@sezon,@cinsiyet,@kalip,@adet,@model,@aksesuar,@kumas,1)";
                    cmd = new SqlCommand(kayit, con);
                    cmd.Parameters.AddWithValue("@id", tB_SiparisNo.Text);
                    cmd.Parameters.AddWithValue("@sezon", cB_Sezon.SelectedItem);
                    cmd.Parameters.AddWithValue("@cinsiyet", cB_Cinsiyet.SelectedItem);
                    cmd.Parameters.AddWithValue("@kalip", cB_Kalip.SelectedItem);
                    cmd.Parameters.AddWithValue("@adet", tB_Adet.Text);
                    cmd.Parameters.AddWithValue("@model", modelidler[indx]);
                    cmd.Parameters.AddWithValue("@aksesuar", aksesuaridler[indx2]);
                    cmd.Parameters.AddWithValue("@kumas", kumasidler[indx3]);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    string kayit2 = "insert into Urun(urun_ad,siparis_id) values (@ad,@id)";
                    string ad = cB_Sezon.SelectedItem.ToString() + " " + cB_Cinsiyet.SelectedItem.ToString() + " " + cB_Kalip.SelectedItem.ToString() + " " + cB_Model.SelectedItem.ToString() + " " + cB_Aksesuar.SelectedItem.ToString() + " " + cB_Kumas.SelectedItem.ToString() + " Adet: " + tB_Adet.Text;
                    cmd = new SqlCommand(kayit2, con);
                    cmd.Parameters.AddWithValue("@id", tB_SiparisNo.Text);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Ürün eklendi.");

                    cB_Sezon.SelectedIndex = -1;
                    cB_Cinsiyet.SelectedIndex = -1;
                    cB_Kalip.SelectedIndex = -1;
                    tB_Adet.Text = "";
                    cB_Model.SelectedIndex = -1;
                    cB_Aksesuar.SelectedIndex = -1;
                    cB_Kumas.SelectedIndex = -1;
                }
                catch (Exception)
                {
                    MessageBox.Show("sipariş oluşturulmamış.");
                    con.Close();
                }
               
            }
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
    }
}
