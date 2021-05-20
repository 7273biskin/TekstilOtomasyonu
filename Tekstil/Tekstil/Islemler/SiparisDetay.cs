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
    public partial class SiparisDetay : Form
    {
        public SiparisDetay()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd;
        DataSet ds;

        int numara;
        private void SiparisDetay_Load(object sender, EventArgs e)
        {
            Doldur();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Doldur()
        {
            da = new SqlDataAdapter("Select detay_id,siparis_id,sezon,cinsiyet,kalip,adet,model_isim,aksesuar_isim,kumas_isim from SiparisDetay inner join Model on SiparisDetay.model_id = Model.model_id inner join Aksesuar on SiparisDetay.aksesuar_id = Aksesuar.aksesuar_id inner join Kumas on SiparisDetay.kumas_id = Kumas.kumas_id where SiparisDetay.visible = 1 and siparis_id = "+Siparis.siparis_ID+"", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "SiparisDetay");
            dataGridView1.DataSource = ds.Tables["SiparisDetay"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
           /* foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                KayitSil(numara);
            }
            Doldur();*/
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doldur();
            Sil(numara);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                int satir = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (satir > -1) 
                {
                    dataGridView1.Rows[satir].Selected = true;
                    numara = Convert.ToInt32(dataGridView1.Rows[satir].Cells["detay_id"].Value);
                }
            }
        }

        void Sil(int numara)
        {
            string sql = "Update SiparisDetay set visible=0 where detay_id=@numara";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@numara", numara);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        /* void KayitSil(int numara)
         {
             string sql = "Update SiparisDetay set visible=0 where detay_id=@numara";
             cmd = new SqlCommand(sql, con);
             cmd.Parameters.AddWithValue("@numara", numara);
             con.Open();
             cmd.ExecuteNonQuery();
             con.Close();
         }*/
    }
}
