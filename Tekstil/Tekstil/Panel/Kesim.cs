using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekstil
{
    public partial class Kesim : Form
    {
        public Kesim()
        {
            InitializeComponent();
        }

        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;

        public static string siparis_ID;
        string[] sirketidler = new string[50];
        private void Kesim_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                siparis_ID = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                SiparisDetay2 frm = new SiparisDetay2();
                frm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tB_SiparisID.Text=="" || tB_Miktar.Text=="")
            {
                MessageBox.Show("Değerler boş olmamalıdır.");
            }
            else if (SayiMi(tB_SiparisID.Text)==false || SayiMi(tB_Miktar.Text)==false)
            {
                MessageBox.Show("Değerler sayısal olmalıdır.");
            }
            else
            {/*
                con.Open();
                string kayit = "insert into Kesim(siparis_id,tarih,kullanilankumas,visible) values (@id,@tarih,@kumas,1)";
                cmd = new SqlCommand(kayit, con);
                cmd.Parameters.AddWithValue("@id", tB_SiparisID.Text);
                cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@kumas", tB_Miktar.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                string kayit2 = "update Siparis set kesildimi='Evet' where siparis_id=@id";
                cmd = new SqlCommand(kayit2, con);
                cmd.Parameters.AddWithValue("@id", tB_SiparisID.Text);
                cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@kumas", tB_Miktar.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Doldur();*/
                con.Open();
                string kayit1 = "Select * from Siparis where visible=1 and siparis_id=@id and kesildimi='Hayır'";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_SiparisID.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    
                    string kayit = "insert into Kesim(siparis_id,tarih,kullanilankumas,visible,personel_id) values (@id,@tarih,@kumas,1,@pers)";
                    cmd = new SqlCommand(kayit, con);
                    cmd.Parameters.AddWithValue("@id", tB_SiparisID.Text);
                    cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@kumas", tB_Miktar.Text);
                    cmd.Parameters.AddWithValue("@pers", Giris.personel_ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    string kayit2 = "update Siparis set kesildimi='Evet' where siparis_id=@id";
                    cmd = new SqlCommand(kayit2, con);
                    cmd.Parameters.AddWithValue("@id", tB_SiparisID.Text);
                    cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@kumas", tB_Miktar.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    con.Open();
                    string kayit3 = "update Kumas set kumas_miktar=kumas_miktar-@kumas from Kumas inner join SiparisDetay on SiparisDetay.kumas_id = Kumas.kumas_id where SiparisDetay.siparis_id=@id";
                    cmd = new SqlCommand(kayit3, con);
                    cmd.Parameters.AddWithValue("@id", tB_SiparisID.Text);
                    cmd.Parameters.AddWithValue("@kumas", tB_Miktar.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Doldur();
                }
                else
                {
                    MessageBox.Show("sipariş bulunamadı veya daha önce kesilme işlemi yapılmış.");
                    con.Close();
                }
            }
        }

        private void Doldur()
        {
            da = new SqlDataAdapter("Select siparis_id,siparis_tarih,teslimat_tarih,musteri_isim,kesildimi From Siparis inner join Sirket on Siparis.sirket_id = Sirket.musteri_id where Siparis.visible=1 and Siparis.kesildimi='Hayır'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Siparis");
            dataGridView1.DataSource = ds.Tables["Siparis"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KesilmisSiparis frm = new KesilmisSiparis();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doldur();
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
