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
    public partial class Sirket : Form
    {
        public Sirket()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd,cmd2;
        DataSet ds;
        private void musteri_Load(object sender, EventArgs e)
        {
            Doldur();
            tB_Ekle_Tel.MaxLength = 11;
            tB_Yeni_Tel.MaxLength = 11;
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

        private void Doldur()
        {
            da = new SqlDataAdapter("Select musteri_id,musteri_isim,musteri_telefon,musteri_adres From Sirket where visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Sirket");
            dataGridView_Sirket.DataSource = ds.Tables["Sirket"];
            con.Close();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (tB_Ekle_İsim.Text == "" || tB_Ekle_Adres.Text == "" || tB_Ekle_Tel.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }

            else if (SayiMi(tB_Ekle_Tel.Text) == false)
            {
                MessageBox.Show("Telefon değerini doğru giriniz.");
            }
            else
            {

                con.Open();
                string kayit = "insert into Sirket(musteri_isim,musteri_telefon,musteri_adres,visible) values (@ad,@tel,@adres,1)";
                cmd = new SqlCommand(kayit, con);
                cmd.Parameters.AddWithValue("@ad", tB_Ekle_İsim.Text);
                cmd.Parameters.AddWithValue("@tel", tB_Ekle_Tel.Text);
                cmd.Parameters.AddWithValue("@adres", tB_Ekle_Adres.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Doldur();
                tB_Ekle_İsim.Text = "";
                tB_Ekle_Tel.Text = "";
                tB_Ekle_Adres.Text = "";

            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            /*
            con.Open();
            string kayit = "update Sirket set musteri_isim=@ad,musteri_telefon=@tel,musteri_adres=@adres where musteri_id=@id";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
            cmd.Parameters.AddWithValue("@ad", tB_Yeni_İsim.Text);
            cmd.Parameters.AddWithValue("@tel", tB_Yeni_Tel.Text);
            cmd.Parameters.AddWithValue("@adres", tB_Yeni_Adres.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Doldur();
            tB_Yeni_Tel.Text = "";
            tB_Yeni_İsim.Text = "";
            tB_Yeni_Adres.Text = "";*/
            if (tB_Yeni_İsim.Text == "" || tB_Yeni_Tel.Text == "" || tB_Guncellenecek.Text == "" || tB_Yeni_Adres.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }

            else if (SayiMi(tB_Yeni_Tel.Text) == false)
            {
                MessageBox.Show("Telefon değerini doğru giriniz.");
            }
            else if (SayiMi(tB_Guncellenecek.Text) == false)
            {
                MessageBox.Show("id değeri sayısal olmalıdır.");
            }
            else
            {
                con.Open();
                string kayit1 = "Select * from Sirket where visible=1 and musteri_id=@id";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    string kayit = "update Sirket set musteri_isim=@ad,musteri_telefon=@tel,musteri_adres=@adres where musteri_id=@id";
                    cmd2 = new SqlCommand(kayit, con);
                    cmd2.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                    cmd2.Parameters.AddWithValue("@ad", tB_Yeni_İsim.Text);
                    cmd2.Parameters.AddWithValue("@tel", tB_Yeni_Tel.Text);
                    cmd2.Parameters.AddWithValue("@adres", tB_Yeni_Adres.Text);

                    cmd2.ExecuteNonQuery();
                    con.Close();
                    Doldur();
                    tB_Guncellenecek.Text = "";
                    tB_Yeni_İsim.Text = "";
                    tB_Yeni_Tel.Text = "";
                }
                else
                {
                    MessageBox.Show("müşteri bulunamadı.");
                    tB_Guncellenecek.Text = "";
                    con.Close();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tB_Ara.Text == "")
            {
                MessageBox.Show("Aranacak isim değeri boş.");
            }
            else
            {
                string kayit = "Select musteri_id,musteri_isim,musteri_telefon,musteri_adres From Sirket where visible=1 and musteri_isim LIKE '%" + tB_Ara.Text + "%'";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Sirket");
                dataGridView_Sirket.DataSource = ds.Tables["Sirket"];
                con.Close();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Doldur();
        }



    }
}
