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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }

        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd,cmd2;
        DataSet ds;
        SqlDataAdapter da;

        public static string siparis_ID;
        string[] sirketidler = new string[50];

        private void Siparis_Load(object sender, EventArgs e)
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
            sirketDoldur();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void sirketDoldur()
        {
            int i = 0;

            string kayit = "Select * From Sirket where visible=1";
            cmd = new SqlCommand(kayit, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                sirketidler[i] = dr["musteri_id"].ToString();
                cB_Yeni_Sirket.Items.Add(dr["musteri_isim"]);
                i++;
            }
            con.Close();
        }

        private void Doldur()
        {
            da = new SqlDataAdapter("Select siparis_id,siparis_tarih,teslimat_tarih,musteri_isim,kesildimi,dikildimi From Siparis inner join Sirket on Siparis.sirket_id = Sirket.musteri_id where Siparis.visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Siparis");
            dataGridView1.DataSource = ds.Tables["Siparis"];
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                siparis_ID = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                SiparisDetay frm = new SiparisDetay();
                frm.Show();
            }
            }

        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            if (tB_Ara.Text == "")
            {
                MessageBox.Show("Arama değeri boş olamaz.");
            }
            else if (SayiMi(tB_Ara.Text) == false)
            {
                MessageBox.Show("id değeri sayısal olmalıdır.");
            }
            else
            {
                string kayit = "Select siparis_id,siparis_tarih,teslimat_tarih,musteri_isim,kesildimi,dikildimi From Siparis inner join Sirket on Siparis.sirket_id = Sirket.musteri_id where Siparis.visible=1 and siparis_id =" + tB_Ara.Text + "";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Siparis");
                dataGridView1.DataSource = ds.Tables["Siparis"];
                con.Close();
                tB_Ara.Text = "";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiparisEkle fmr = new SiparisEkle();
            fmr.Show();
            Doldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tB_SirketAra.Text == "")
            {
                MessageBox.Show("Arama değeri boş olamaz.");
            }
            else
            {
                string kayit = "Select siparis_id,siparis_tarih,teslimat_tarih,musteri_isim,kesildimi,dikildimi From Siparis inner join Sirket on Siparis.sirket_id = Sirket.musteri_id where Siparis.visible=1 and musteri_isim LIKE '%" + tB_SirketAra.Text.ToString() + "%'";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Siparis");
                dataGridView1.DataSource = ds.Tables["Siparis"];
                con.Close();
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (cB_Yeni_Sirket.SelectedIndex == -1 || tB_Guncellenecek.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }
            else if (SayiMi(tB_Guncellenecek.Text)==false)
            {
                MessageBox.Show("id değeri sayısal olmalıdır.");
            }
            else
            {
                int indx = cB_Yeni_Sirket.SelectedIndex;
                con.Open();
                string kayit1 = "Select * from Siparis where visible=1 and siparis_id=@id";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    string kayit = "update Siparis set siparis_tarih=@tarih,sirket_id=@sid where siparis_id=@id";
                    cmd2 = new SqlCommand(kayit, con);
                    cmd2.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                    cmd2.Parameters.AddWithValue("@tarih", dTP_Yeni_Tarih.Value.Date);
                    cmd2.Parameters.AddWithValue("@sid", sirketidler[indx]);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    Doldur();
                    tB_Guncellenecek.Text = "";
                }
                else
                {
                    MessageBox.Show("sipariş bulunamadı.");
                    con.Close();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
                string kayit = "Select siparis_id,siparis_tarih,teslimat_tarih,musteri_isim,kesildimi,dikildimi From Siparis inner join Sirket on Siparis.sirket_id = Sirket.musteri_id where Siparis.visible=1 and siparis_tarih =@tarih";
                da = new SqlDataAdapter(kayit, con);
                da.SelectCommand.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Siparis");
                dataGridView1.DataSource = ds.Tables["Siparis"];
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
