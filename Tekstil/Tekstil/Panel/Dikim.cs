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
    public partial class Dikim : Form
    {
        public Dikim()
        {
            InitializeComponent();
        }

        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;

        public static string siparis_ID;
        private void Dikim_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn dgvBtn = new DataGridViewButtonColumn();
            dgvBtn.HeaderText = "Detay";
            dgvBtn.Text = "Detay";
            dgvBtn.UseColumnTextForButtonValue = true;
            dgvBtn.DefaultCellStyle.BackColor = Color.Blue;
            dgvBtn.DefaultCellStyle.SelectionBackColor = Color.Red;
            dgvBtn.Width = 70;
            dataGridView1.Columns.Add(dgvBtn);

            Doldur();
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
                label_isim.Text = dr["isim"].ToString() + " " + dr["soyisim"].ToString();

            }
            con.Close();
        }

        private void Doldur()
        {
            da = new SqlDataAdapter("Select siparis_id,siparis_tarih,teslimat_tarih,musteri_isim,dikildimi From Siparis inner join Sirket on Siparis.sirket_id = Sirket.musteri_id where Siparis.visible=1 and Siparis.dikildimi='Hayır' and Siparis.kesildimi='Evet'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Siparis");
            dataGridView1.DataSource = ds.Tables["Siparis"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                siparis_ID = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                SiparisDetay3 frm = new SiparisDetay3();
                frm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tB_SiparisID.Text == "" || tB_Miktar.Text == "")
            {
                MessageBox.Show("Değerler boş olmamalıdır.");
            }
            else if (SayiMi(tB_SiparisID.Text) == false || SayiMi(tB_Miktar.Text) == false)
            {
                MessageBox.Show("Değerler sayısal olmalıdır.");
            }
            else
            {
                con.Open();
                string kayit1 = "Select * from Siparis where visible=1 and siparis_id=@id and dikildimi='Hayır' and kesildimi='Evet'";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_SiparisID.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();

                    string kayit = "insert into Dikim(siparis_id,tarih,kullanilanaksesuar,visible,personel_id) values (@id,@tarih,@aksesuar,1,@pers)";
                    cmd = new SqlCommand(kayit, con);
                    cmd.Parameters.AddWithValue("@id", tB_SiparisID.Text);
                    cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@aksesuar", tB_Miktar.Text);
                    cmd.Parameters.AddWithValue("@pers", Giris.personel_ID);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    string kayit2 = "update Siparis set dikildimi='Evet' , teslimat_tarih=@tarih where siparis_id=@id";
                    cmd = new SqlCommand(kayit2, con);
                    cmd.Parameters.AddWithValue("@id", tB_SiparisID.Text);
                    cmd.Parameters.AddWithValue("@tarih", dateTimePicker2.Value.Date);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    string kayit4 = "update Urun set teslimat_tarih=@tarih where siparis_id=@id";
                    cmd = new SqlCommand(kayit4, con);
                    cmd.Parameters.AddWithValue("@id", tB_SiparisID.Text);
                    cmd.Parameters.AddWithValue("@tarih", dateTimePicker2.Value.Date);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    con.Open();
                    string kayit3 = "update Aksesuar set aksesuar_miktar=aksesuar_miktar-@aksesuar from Aksesuar inner join SiparisDetay on SiparisDetay.aksesuar_id = Aksesuar.aksesuar_id where SiparisDetay.siparis_id=@id";
                    cmd = new SqlCommand(kayit3, con);
                    cmd.Parameters.AddWithValue("@id", tB_SiparisID.Text);
                    cmd.Parameters.AddWithValue("@aksesuar", tB_Miktar.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Doldur();
                }
                else
                {
                    MessageBox.Show("sipariş bulunamadı veya daha önce dikim işlemi yapılmış.");
                    con.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DikilmisSiparis frm = new DikilmisSiparis();
            frm.Show();
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
