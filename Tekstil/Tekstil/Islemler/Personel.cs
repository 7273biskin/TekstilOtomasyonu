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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        SqlDataReader dr;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString);
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter da;

        string[] idler = new string[5];

        public static string personel_ID;
        public static string detay_ID;

        private void Personel_Load(object sender, EventArgs e)
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
            DepDoldur();

        }

        private void DepDoldur()
        {
            int i = 0;

            string kayit = "Select * From Departman where visible=1";
            cmd = new SqlCommand(kayit, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                idler[i] = dr["departman_id"].ToString();
                cB_Departman.Items.Add(dr["departman_isim"]);
                i++;
            }
            con.Close();
        }

       

        private void Doldur()
        {
            da = new SqlDataAdapter("Select personel_id,isim,soyisim,departman_isim,cinsiyet,telefon_numarasi From Personel inner join Departman on Departman.departman_id=Personel.departman_id where Personel.visible=1", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personel");
            dataGridView1.DataSource = ds.Tables["Personel"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            PersonelEkle frm = new PersonelEkle();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (tB_Guncellenecek.Text == "")
            {
                MessageBox.Show("Boş değer bırakmayınız.");
            }
            else if (SayiMi(tB_Guncellenecek.Text) == false)
            {
                MessageBox.Show("id değeri sayısal olmalıdır.");
            }
            else
            {
                con.Open();
                string kayit1 = "Select * from Personel where visible=1 and personel_id=@id";
                cmd = new SqlCommand(kayit1, con);
                cmd.Parameters.AddWithValue("@id", tB_Guncellenecek.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    personel_ID = tB_Guncellenecek.Text.ToString();

                    PersonelGuncelle frm = new PersonelGuncelle();
                    frm.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("personel bulunamadı.");
                    tB_Guncellenecek.Text = "";
                    con.Close();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tB_SoyAra.Text == "")
            {
                MessageBox.Show("Aranacak soyisim değeri boş.");
            }
            else
            {
                string kayit = "Select personel_id,isim,soyisim,departman_isim,cinsiyet,telefon_numarasi From Personel inner join Departman on Departman.departman_id=Personel.departman_id where Personel.visible=1 and soyisim LIKE '%" + tB_SoyAra.Text.ToString() + "%'";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Personel");
                dataGridView1.DataSource = ds.Tables["Personel"];
                con.Close();
            }

        }

        private void btn_DepAra_Click(object sender, EventArgs e)
        {
            if (cB_Departman.SelectedIndex == -1)
            {
                MessageBox.Show("Aranacak departman seçilmedi.");
            }
            else
            {
                int indx = cB_Departman.SelectedIndex;
                string kayit = "Select personel_id,isim,soyisim,departman_isim,cinsiyet,telefon_numarasi From Personel inner join Departman on Departman.departman_id=Personel.departman_id where Personel.visible=1 and Personel.departman_id=" + idler[indx] + "";
                da = new SqlDataAdapter(kayit, con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Personel");
                dataGridView1.DataSource = ds.Tables["Personel"];
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                detay_ID = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                PersonelDetay frm = new PersonelDetay();
                frm.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tB_Guncellenecek_TextChanged(object sender, EventArgs e)
        {

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

