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
    public partial class AksesuarGoruntule : Form
    {
        public AksesuarGoruntule()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        
        DataSet ds;
        private void AksesuarGoruntule_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            da = new SqlDataAdapter("Select aksesuar_id,aksesuar_isim,aksesuar_miktar From Aksesuar where visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Aksesuar");
            dataGridView_Aksesuar.DataSource = ds.Tables["Aksesuar"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doldur();
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

        private void dataGridView_Aksesuar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
