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
    public partial class DepoMudur : Form
    {
        public DepoMudur()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        
        DataSet ds;

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_KumasDoldur_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select kumas_id,kumas_isim,kumas_kod,renk_isim,kumas_miktar From Kumas inner join Renk on Renk.renk_id = Kumas.renk_id where Kumas.visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kumas");
            dataGridView_Kumas.DataSource = ds.Tables["Kumas"];
            con.Close();
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
                dataGridView_Kumas.DataSource = ds.Tables["Aksesuar"];
                con.Close();
                tB_Ara.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Aranacak isim değeri boş.");
            }
            else
            {
                string kayit = "Select kumas_id,kumas_isim,kumas_kod,renk_isim,kumas_miktar From Kumas inner join Renk on Renk.renk_id = Kumas.renk_id where Kumas.visible=1 and kumas_isim LIKE '%" + textBox1.Text + "%'";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Kumas");
                dataGridView_Kumas.DataSource = ds.Tables["Kumas"];
                con.Close();
                textBox1.Text = "";
            }
        }

        private void btn_AksesuarDoldur_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select aksesuar_id,aksesuar_isim,aksesuar_miktar From Aksesuar where visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Aksesuar");
            dataGridView_Kumas.DataSource = ds.Tables["Aksesuar"];
            con.Close();
        }

        private void DepoMudur_Load(object sender, EventArgs e)
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
    }
}
