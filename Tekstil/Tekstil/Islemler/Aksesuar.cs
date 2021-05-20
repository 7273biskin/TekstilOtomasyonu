using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;

namespace Tekstil
{
    public partial class Aksesuar : Form
    {
        public Aksesuar()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd,cmd2;
        DataSet ds;
        private void Aksesuar_Load(object sender, EventArgs e)
        {
            doldur();
            
        }

        private void doldur()
        {
            da = new SqlDataAdapter("Select aksesuar_id,aksesuar_isim,aksesuar_miktar From Aksesuar where visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Aksesuar");
            dataGridView_Aksesuar.DataSource = ds.Tables["Aksesuar"];
            con.Close();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (tB_Ekle_İsim.Text == "" || tB_Ekle_Adet.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }

            else if (SayiMi(tB_Ekle_Adet.Text)==false)
            {
                MessageBox.Show(" Miktarı sayısal değer giriniz.");
            }
            else
            {
                con.Open();
                string kayit = "insert into Aksesuar(aksesuar_isim,aksesuar_miktar,visible) values (@ad,@adet,1)";
                cmd = new SqlCommand(kayit, con);
                cmd.Parameters.AddWithValue("@ad", tB_Ekle_İsim.Text);
                cmd.Parameters.AddWithValue("@adet", tB_Ekle_Adet.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                doldur();
                tB_Ekle_Adet.Text = "";
                tB_Ekle_İsim.Text = "";
            }

        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            if (tB_Ara.Text == "")
            {
                MessageBox.Show("Aranacak isim değeri boş.");
            }
            else
            {
                string kayit = "Select aksesuar_id,aksesuar_isim,aksesuar_miktar From Aksesuar where visible=1 and aksesuar_isim LIKE '%" + tB_Ara.Text + "%'";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Aksesuar");
                dataGridView_Aksesuar.DataSource = ds.Tables["Aksesuar"];
                con.Close();
                tB_Ara.Text = "";
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

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (tB_YeniAd.Text == "" || tb_YeniAdet.Text == "" || tB_Guncellenecek.Text=="")
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }

            else if (SayiMi(tb_YeniAdet.Text) == false)
            {
                MessageBox.Show(" Miktarı sayısal değer giriniz.");
            }
            else if (SayiMi(tB_Guncellenecek.Text) == false)
            {
                MessageBox.Show("id değeri sayısal olmalıdır.");
            }

            else
            {
                con.Open();
                string kayit1 = "Select * from Aksesuar where visible=1 and aksesuar_id=@id";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    string kayit = "update Aksesuar set aksesuar_isim=@ad,aksesuar_miktar=@adet where aksesuar_id=@id";
                    cmd2 = new SqlCommand(kayit, con);
                    cmd2.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                    cmd2.Parameters.AddWithValue("@ad", tB_YeniAd.Text);
                    cmd2.Parameters.AddWithValue("@adet", tb_YeniAdet.Text);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    doldur();
                    tB_Guncellenecek.Text = "";
                    tB_YeniAd.Text = "";
                    tb_YeniAdet.Text = "";
                }
                else
                {
                    MessageBox.Show("aksesuar bulunamadı.");
                    con.Close();
                }
            }

        }

        private void label_Baslik_Click(object sender, EventArgs e)
        {

        }

        private void tB_Ara_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView_Aksesuar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cB_NaVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_NaVi.SelectedIndex==0)
            {
                Siparis frm = new Siparis();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex==1)
            {
                Personel frm = new Personel();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex==2)
            {
                Sirket frm = new Sirket();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex==3)
            {
                Kumaslar frm = new Kumaslar();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex==4)
            {
                Aksesuar frm = new Aksesuar();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex==5)
            {
                Renk frm = new Renk();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex==6)
            {
                DikimMudur frm = new DikimMudur();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex==7)
            {
                KesimMudur frm = new KesimMudur();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex==8)
            {
                DepoMudur frm = new DepoMudur();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex==9)
            {
                ModelMudur frm = new ModelMudur();
                frm.Show();
                this.Close();
            }
            if (cB_NaVi.SelectedIndex==10)
            {
                Urun frm = new Urun();
                frm.Show();
                this.Close();
            }
        }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            doldur();
        }
    }

}
