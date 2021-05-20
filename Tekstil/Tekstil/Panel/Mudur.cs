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
using System.Configuration;

namespace Tekstil
{
    public partial class Mudur : Form
    {
        public Mudur()
        {
            InitializeComponent();
        }

        
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd;
       

        private void Mudur_Load(object sender, EventArgs e)
        {
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
                label_isim.Text = dr["isim"].ToString() + " "+ dr["soyisim"].ToString();
                
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renk frm = new Renk();
            frm.Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel frm = new Personel();
            frm.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sirket frm = new Sirket();
            frm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Aksesuar frm = new Aksesuar();
            frm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kumaslar frm = new Kumaslar();
            frm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Siparis frm = new Siparis();
            frm.Show();
            this.Close();

        }


        private void button8_Click(object sender, EventArgs e)
        {
            ModelMudur frm = new ModelMudur();
            frm.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DepoMudur frm = new DepoMudur();
            frm.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DikimMudur frm = new DikimMudur();
            frm.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            KesimMudur frm = new KesimMudur();
            frm.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Urun frm = new Urun();
            frm.Show();
            this.Close();
        }
    }
}
