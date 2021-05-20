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
    public partial class Renk : Form
    {
        public Renk()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd,cmd2;
        DataSet ds;

        private void Renk_Load(object sender, EventArgs e)
        {
            Doldur();
           
        }
        private void Doldur()
        {
            da = new SqlDataAdapter("Select renk_id,renk_kod,renk_isim From Renk where visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Renk");
            dataGridView_Renk.DataSource = ds.Tables["Renk"];
            con.Close();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (tB_ekle.Text == "" || tB_RenkKodu.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }
            else
            {
                con.Open();
                string kayit = "insert into Renk(renk_kod,renk_isim,visible) values (@kod,@ad,1)";
                cmd = new SqlCommand(kayit, con);
                cmd.Parameters.AddWithValue("@ad", tB_ekle.Text);
                cmd.Parameters.AddWithValue("@kod", tB_RenkKodu.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Doldur();
                tB_ekle.Text = "";
                tB_RenkKodu.Text = "";
            }
            
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            /*con.Open();
            string kayit = "update Renk set renk_isim=@ad,renk_kod=@kod where renk_id=@id";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
            cmd.Parameters.AddWithValue("@ad", tB_YeniAd.Text);
            cmd.Parameters.AddWithValue("@kod", tb_YeniKod.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Doldur();
            tB_Guncellenecek.Text = "";
            tB_YeniAd.Text = "";
            tb_YeniKod.Text = "";*/

            if (tB_YeniAd.Text == "" || tb_YeniKod.Text == "" || tB_Guncellenecek.Text == "")
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
                string kayit1 = "Select * from Renk where visible=1 and renk_id=@id";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    string kayit = "update Renk set renk_isim=@ad,renk_kod=@kod where renk_id=@id";
                    cmd2 = new SqlCommand(kayit, con);
                    cmd2.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                    cmd2.Parameters.AddWithValue("@ad", tB_YeniAd.Text);
                    cmd2.Parameters.AddWithValue("@kod", tb_YeniKod.Text);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    Doldur();
                    tB_Guncellenecek.Text = "";
                    tB_YeniAd.Text = "";
                    tb_YeniKod.Text = "";
                }
                else
                {
                    MessageBox.Show("renk bulunamadı.");
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
                string kayit = "Select renk_id,renk_kod,renk_isim From Renk where visible=1 and renk_isim LIKE '%" + tB_Ara.Text + "%'";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Renk");
                dataGridView_Renk.DataSource = ds.Tables["Renk"];
                con.Close();
                tB_Ara.Text = "";
            }

        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void tB_RenkKodu_TextChanged(object sender, EventArgs e)
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
