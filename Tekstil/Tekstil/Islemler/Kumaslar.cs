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
    public partial class Kumaslar : Form
    {
        public Kumaslar()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd,cmd2;
        DataSet ds;

        string[] idler = new string[50];

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kumaslar_Load(object sender, EventArgs e)
        {
            Doldur();
            renkDoldur();
        }

        private void Doldur()
        {
            da = new SqlDataAdapter("Select kumas_id,kumas_isim,kumas_kod,renk_isim,kumas_miktar From Kumas inner join Renk on Renk.renk_id = Kumas.renk_id where Kumas.visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kumas");
            dataGridView_Kumaslar.DataSource = ds.Tables["Kumas"];
            con.Close();
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void renkDoldur()
        {
            int i = 0;

            string kayit = "Select * From Renk where visible=1";
            cmd = new SqlCommand(kayit, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                idler[i] = dr["renk_id"].ToString();
                cB_Ekle_Renk.Items.Add(dr["renk_isim"]);
                cB_Yeni_Renk.Items.Add(dr["renk_isim"]);
                cB_Ara_Kumas.Items.Add(dr["renk_isim"]);

                i++;
            }
            con.Close();
        }

        private void btn_Yenile_Click_1(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btn_Cikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (tB_Ekle_İsim.Text == "" || tB_Ekle_Kod.Text == "" || cB_Ekle_Renk.SelectedIndex==-1)
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }
            else
            {
                int indx = cB_Ekle_Renk.SelectedIndex;
                con.Open();
                string kayit = "insert into Kumas(kumas_isim,kumas_kod,renk_id,visible,kumas_miktar) values (@isim,@kod,@renk,1,0)";
                cmd = new SqlCommand(kayit, con);
                cmd.Parameters.AddWithValue("@isim", tB_Ekle_İsim.Text);
                cmd.Parameters.AddWithValue("@kod", tB_Ekle_Kod.Text);
                cmd.Parameters.AddWithValue("@renk", idler[indx]);
                cmd.ExecuteNonQuery();
                con.Close();
                Doldur();
                tB_Ekle_İsim.Text = "";
                tB_Ekle_Kod.Text = "";
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            /*
            int indx = cB_Yeni_Renk.SelectedIndex;
            con.Open();
            string kayit = "update Kumas set kumas_isim=@ad,kumas_kod=@kod,renk_id=@renk where kumas_id=@id";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
            cmd.Parameters.AddWithValue("@ad", tB_YeniAd.Text);
            cmd.Parameters.AddWithValue("@kod", tb_YeniKod.Text);
            cmd.Parameters.AddWithValue("@renk", idler[indx]);
            cmd.ExecuteNonQuery();
            con.Close();
            Doldur();
            tB_Guncellenecek.Text = "";
            tB_YeniAd.Text = "";
            tb_YeniKod.Text = "";
            */
            int indx = cB_Yeni_Renk.SelectedIndex;

            if (tB_YeniAd.Text == "" || tb_YeniKod.Text == "" || tB_Guncellenecek.Text == "" || cB_Yeni_Renk.SelectedIndex == -1)
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }
            else if (SayiMi(tB_Guncellenecek.Text) == false)
            {
                MessageBox.Show("id değeri sayısal olmalıdır.");
            }
            else
            {
                con.Open();
                string kayit1 = "Select * from Kumas where visible=1 and kumas_id=@id";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    string kayit = "update Kumas set kumas_isim=@ad,kumas_kod=@kod,renk_id=@renk where kumas_id=@id";
                    cmd2 = new SqlCommand(kayit, con);
                    cmd2.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                    cmd2.Parameters.AddWithValue("@ad", tB_YeniAd.Text);
                    cmd2.Parameters.AddWithValue("@kod", tb_YeniKod.Text);
                    cmd2.Parameters.AddWithValue("@renk", idler[indx]);

                    cmd2.ExecuteNonQuery();
                    con.Close();
                    Doldur();
                    tB_Guncellenecek.Text = "";
                    tB_YeniAd.Text = "";
                    tb_YeniKod.Text = "";
                }
                else
                {
                    MessageBox.Show("kumaş bulunamadı.");
                    tB_Guncellenecek.Text = "";
                    con.Close();
                }
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (cB_Ara_Kumas.SelectedIndex==-1)
            {
                MessageBox.Show("Aranacak renk seçilmedi.");
            }
            else
            {
                int indx = cB_Ara_Kumas.SelectedIndex;
                string kayit = "Select kumas_id,kumas_isim,kumas_kod,renk_isim,kumas_miktar From Kumas inner join Renk on Renk.renk_id = Kumas.renk_id where Kumas.visible=1 and Kumas.renk_id=" + idler[indx] + "";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Kumas");
                dataGridView_Kumaslar.DataSource = ds.Tables["Kumas"];
                con.Close();
            }
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            if (tB_Ara.Text == "")
            {
                MessageBox.Show("Aranacak isim değeri boş.");
            }
            else
            {
                string kayit = "Select kumas_id,kumas_isim,kumas_kod,renk_isim,kumas_miktar From Kumas inner join Renk on Renk.renk_id = Kumas.renk_id where Kumas.visible=1 and kumas_isim LIKE '%" + tB_Ara.Text + "%'";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Kumas");
                dataGridView_Kumaslar.DataSource = ds.Tables["Kumas"];
                con.Close();
                tB_Ara.Text = "";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cB_Ekle_Renk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cB_NaVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_NaVi.SelectedIndex == 0)
            {
                Siparis frm = new Siparis();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex == 1)
            {
                Personel frm = new Personel();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex == 2)
            {
                Sirket frm = new Sirket();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex == 3)
            {
                Kumaslar frm = new Kumaslar();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex == 4)
            {
                Aksesuar frm = new Aksesuar();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex == 5)
            {
                Renk frm = new Renk();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex == 6)
            {
                DikimMudur frm = new DikimMudur();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex == 7)
            {
                KesimMudur frm = new KesimMudur();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex == 8)
            {
                DepoMudur frm = new DepoMudur();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex == 9)
            {
                ModelMudur frm = new ModelMudur();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex == 10)
            {
                Urun frm = new Urun();
                frm.Show();
                this.Close();
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
    }
}
