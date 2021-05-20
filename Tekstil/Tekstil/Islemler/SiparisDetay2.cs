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
    public partial class SiparisDetay2 : Form
    {
        public SiparisDetay2()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        
        DataSet ds;
        private void SiparisDetay2_Load(object sender, EventArgs e)
        {
            Doldur();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Doldur()
        {
            da = new SqlDataAdapter("Select detay_id,siparis_id,sezon,cinsiyet,kalip,adet,model_isim,aksesuar_isim,kumas_isim from SiparisDetay inner join Model on SiparisDetay.model_id = Model.model_id inner join Aksesuar on SiparisDetay.aksesuar_id = Aksesuar.aksesuar_id inner join Kumas on SiparisDetay.kumas_id = Kumas.kumas_id where SiparisDetay.visible = 1 and siparis_id = " + Kesim.siparis_ID + "", con);
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
    }
}
