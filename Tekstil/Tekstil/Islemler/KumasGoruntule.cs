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
    public partial class KumasGoruntule : Form
    {
        public KumasGoruntule()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KumasGoruntule_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            da = new SqlDataAdapter("Select kumas_id,kumas_isim,kumas_miktar,kumas_kod,renk_isim From Kumas inner join Renk on Renk.renk_id = Kumas.renk_id where Kumas.visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kumas");
            dataGridView_Kumaslar.DataSource = ds.Tables["Kumas"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doldur();
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
                dataGridView_Kumaslar.DataSource = ds.Tables["Kumas"];
                con.Close();
                textBox1.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
