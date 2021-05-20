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
    public partial class Depo : Form
    {
        public Depo()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd,cmd2;
        DataSet ds;

        private void Depo_Load(object sender, EventArgs e)
        {
            Kimsin();
        }

        private void Doldur()
        {
            da = new SqlDataAdapter("Select kumas_id,kumas_isim,kumas_miktar From Kumas where visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kumas");
            dataGridView_Kumas.DataSource = ds.Tables["Kumas"];
            con.Close();
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

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KumasGoruntule frm = new KumasGoruntule();
            frm.Show();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (tB_Eklenecek.Text == "" || tB_Miktar.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }
            else if (SayiMi(tB_Miktar.Text) == false)
            {
                MessageBox.Show("Miktar sayısal değer olmalıdır.");
            }
            else if (SayiMi(tB_Eklenecek.Text)==false)
            {
                MessageBox.Show("id değeri sayısal olmalıdır.");
            }
            else
            {/*
                con.Open();
                string kayit = "update Kumas set kumas_miktar=kumas_miktar+@miktar where kumas_id=@id";
                cmd = new SqlCommand(kayit, con);
                cmd.Parameters.AddWithValue("@id", tB_Eklenecek.Text);
                cmd.Parameters.AddWithValue("@miktar", Convert.ToInt32(tB_Miktar.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                Doldur();
                tB_Eklenecek.Text = "";
                tB_Miktar.Text = "";*/

                con.Open();
                string kayit1 = "Select * from Kumas where visible=1 and kumas_id=@id";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_Eklenecek.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    string kayit = "update Kumas set kumas_miktar=kumas_miktar+@miktar where kumas_id=@id";
                    cmd2 = new SqlCommand(kayit, con);
                    cmd2.Parameters.AddWithValue("@id", tB_Eklenecek.Text);
                    cmd2.Parameters.AddWithValue("@miktar", Convert.ToInt32(tB_Miktar.Text));
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    Doldur(); 
                    tB_Eklenecek.Text = "";
                    tB_Miktar.Text = "";

                }
                else
                {
                    MessageBox.Show("kumaş bulunamadı.");
                    con.Close();
                }
            }
            
        }

        private void btn_KumasDoldur_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btn_AksesuarDoldur_Click(object sender, EventArgs e)
        {
            AksesuarGetir();
        }

        private void AksesuarGetir()
        {
            da = new SqlDataAdapter("Select aksesuar_id,aksesuar_isim,aksesuar_miktar From Aksesuar where visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Aksesuar");
            dataGridView_Kumas.DataSource = ds.Tables["Aksesuar"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tB_Aks_Id.Text == "" || tB_Aks_Miktar.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }
            else if (SayiMi(tB_Aks_Miktar.Text) == false)
            {
                MessageBox.Show("Miktar sayısal değer olmalıdır.");
            }
            else if (SayiMi(tB_Aks_Id.Text) == false)
            {
                MessageBox.Show("id değeri sayısal olmalıdır.");
            }
            else
            {/*
                con.Open();
                string kayit = "update Aksesuar set aksesuar_miktar=aksesuar_miktar+@miktar where aksesuar_id=@id";
                cmd = new SqlCommand(kayit, con);
                cmd.Parameters.AddWithValue("@id", tB_Aks_Id.Text);
                cmd.Parameters.AddWithValue("@miktar", Convert.ToInt32(tB_Aks_Miktar.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                AksesuarGetir();
                tB_Aks_Id.Text = "";
                tB_Aks_Miktar.Text = "";*/

                con.Open();
                string kayit1 = "Select * from Aksesuar where visible=1 and aksesuar_id=@id";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_Aks_Id.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    string kayit = "update Aksesuar set aksesuar_miktar=aksesuar_miktar+@miktar where aksesuar_id=@id";
                    cmd2 = new SqlCommand(kayit, con);
                    cmd2.Parameters.AddWithValue("@id", tB_Aks_Id.Text);
                    cmd2.Parameters.AddWithValue("@miktar", Convert.ToInt32(tB_Aks_Miktar.Text));
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    AksesuarGetir();
                    tB_Aks_Id.Text = "";
                    tB_Aks_Miktar.Text = "";

                }
                else
                {
                    MessageBox.Show("aksesuar bulunamadı.");
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AksesuarGoruntule frm = new AksesuarGoruntule();
            frm.Show();
        }

        private void dataGridView_Kumas_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
