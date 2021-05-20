using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekstil
{
    public partial class KesilmisSiparis : Form
    {
        public KesilmisSiparis()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);

        DataSet ds;
        SqlDataAdapter da;
        private void KesilmisSiparis_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            da = new SqlDataAdapter("Select kesim_id,siparis_id,kullanilankumas,Kesim.personel_id,isim,soyisim,tarih From Kesim inner join Personel on Personel.personel_id = Kesim.personel_id where Kesim.visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kesim");
            dataGridView1.DataSource = ds.Tables["Kesim"];
            con.Close();
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

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            if (tB_Ara.Text == "")
            {
                MessageBox.Show("Arama değeri boş olamaz.");
            }
            else if (SayiMi(tB_Ara.Text) == false)
            {
                MessageBox.Show("Arama değeri sayılardan oluşmalıdır.");
            }
            else
            {
                string kayit = "Select kesim_id,siparis_id,kullanilankumas,Kesim.personel_id,isim,soyisim,tarih From Kesim inner join Personel on Personel.personel_id = Kesim.personel_id where Kesim.visible=1 and siparis_id =" + tB_Ara.Text + "";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Siparis");
                dataGridView1.DataSource = ds.Tables["Siparis"];
                con.Close();
                tB_Ara.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kayit = "Select kesim_id,siparis_id,kullanilankumas,Kesim.personel_id,isim,soyisim,tarih From Kesim inner join Personel on Personel.personel_id = Kesim.personel_id where Kesim.visible=1 and tarih =@tarih";
            da = new SqlDataAdapter(kayit, con);
            da.SelectCommand.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Siparis");
            dataGridView1.DataSource = ds.Tables["Siparis"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
