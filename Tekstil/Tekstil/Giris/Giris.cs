using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

namespace Tekstil
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        public static string personel_ID;

        
        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd;

        

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            string yetki;
            con.Open();
            string kayit = "Select * from Personel where kullaniciadi=@ad and sifre=@sifre";
            cmd = new SqlCommand(kayit, con);
            cmd.Parameters.AddWithValue("@ad",tB_ad.Text);
            cmd.Parameters.AddWithValue("@sifre", tB_Sifre.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                yetki = dr["departman_id"].ToString();
                personel_ID = dr["personel_id"].ToString();
                MessageBox.Show("Giriş başarılı. + Personel ID = "+personel_ID+"");

                if(yetki=="1")
                {
                    Mudur mdr = new Mudur();
                    mdr.Show();
                    this.Close();
                  
                }
                else if (yetki == "2")
                {
                    Depo frm = new Depo();
                    frm.Show();
                    this.Close();
                }
                else if (yetki == "4")
                {
                    Kesim frm = new Kesim();
                    frm.Show();
                    this.Close();
                }
                else if (yetki == "5")
                {
                    Model frm = new Model();
                    frm.Show();
                    this.Close();
                }
                else if (yetki == "6")
                {
                    Dikim frm = new Dikim();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Departmanınız uygunsuz. Yönetici ile görüşün.");
                }
            }
            else
            {
                MessageBox.Show("Hatalı giriş.");  
            }
            con.Close(); 

        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            /*foreach (Process proc in Process.GetProcessesByName("Tekstil"))
            {
                proc.Kill();
            }*/
            Application.Exit();
        }

        private void btn_unuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum ss = new SifremiUnuttum();
            ss.Show();
            this.Close();

        }

        private void tB_ad_MouseClick(object sender, MouseEventArgs e)
        {
            tB_ad.Text = "";
        }

        private void tB_Sifre_MouseClick(object sender, MouseEventArgs e)
        {
            tB_Sifre.Text = "";
        }

    }
}
