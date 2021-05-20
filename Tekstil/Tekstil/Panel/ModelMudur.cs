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
    public partial class ModelMudur : Form
    {
        public ModelMudur()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
       
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
     
        DataSet ds;
        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ModelMudur_Load(object sender, EventArgs e)
        {
            Doldur();
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

        private void Doldur()
        {
            da = new SqlDataAdapter("Select model_id,model_isim,model_barkod From Model where visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Model");
            dataGridView_Model.DataSource = ds.Tables["Model"];
            con.Close();
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
