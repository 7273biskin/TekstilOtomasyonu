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
    public partial class Model : Form
    {
        public Model()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd,cmd2;
        DataSet ds;

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Model_Load(object sender, EventArgs e)
        {
            Doldur();
            Kimsin();
        }

        private void Kimsin()
        {
            string kayit = "Select * from Personel where personel_id=@id";
            cmd = new SqlCommand(kayit, con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", Giris.personel_ID);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                label_isim.Text = dr["isim"].ToString() + " " + dr["soyisim"].ToString();

            }
            con.Close();
        }

        private void Doldur()
        {
            da = new SqlDataAdapter("Select model_id,model_isim,model_barkod From Model where visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Model");
            dataGridView_Model.DataSource = ds.Tables["Model"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (tB_Guncellenecek.Text=="" || tB_Yeni_Barkod.Text=="" || tB_Yeni_İsim.Text=="")
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
                string kayit1 = "Select * from Model where visible=1 and model_id=@id";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    string kayit = "update Model set model_isim=@ad,model_barkod=@kod where model_id=@id";
                    cmd2 = new SqlCommand(kayit, con);
                    cmd2.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                    cmd2.Parameters.AddWithValue("@ad", tB_Yeni_İsim.Text);
                    cmd2.Parameters.AddWithValue("@kod", tB_Yeni_Barkod.Text);

                    cmd2.ExecuteNonQuery();
                    con.Close();
                    Doldur();
                    tB_Guncellenecek.Text = "";
                    tB_Yeni_Barkod.Text = "";
                    tB_Yeni_İsim.Text = "";
                }
                else
                {
                    MessageBox.Show("model bulunamadı.");
                    tB_Guncellenecek.Text = "";
                    con.Close();
                }
            }
            /*con.Open();
            string kayit = "update Model set model_isim=@ad,model_barkod=@kod where model_id=@id";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
            cmd.Parameters.AddWithValue("@ad", tB_Yeni_İsim.Text);
            cmd.Parameters.AddWithValue("@kod", tB_Yeni_Barkod.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Doldur();
            tB_Guncellenecek.Text = "";
            tB_Yeni_Barkod.Text = "";
            tB_Yeni_İsim.Text = "";*/
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (tB_Ekle_isim.Text == "" || tB_Ekle_Barkod.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }
            else
            {
                con.Open();
                string kayit = "insert into Model(model_barkod,model_isim,visible) values (@kod,@ad,1)";
                cmd = new SqlCommand(kayit, con);
                cmd.Parameters.AddWithValue("@ad", tB_Ekle_isim.Text);
                cmd.Parameters.AddWithValue("@kod", tB_Ekle_Barkod.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Doldur();
                tB_Ekle_Barkod.Text = "";
                tB_Ekle_isim.Text = "";
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
                string kayit = "Select model_id,model_isim,model_barkod From Model where visible=1 and model_isim LIKE '%" + tB_Ara.Text + "%'";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Model");
                dataGridView_Model.DataSource = ds.Tables["Model"];
                con.Close();
                tB_Ara.Text = "";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tB_Ara_Barkod.Text == "")
            {
                MessageBox.Show("Aranacak barkod değeri boş.");
            }
            else
            {
                string kayit = "Select model_id,model_isim,model_barkod From Model where visible=1 and model_barkod LIKE '%" + tB_Ara_Barkod.Text + "%'";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Model");
                dataGridView_Model.DataSource = ds.Tables["Model"];
                con.Close();
                tB_Ara_Barkod.Text = "";
            }
            
        }

        private void tB_Ara_Barkod_TextChanged(object sender, EventArgs e)
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
