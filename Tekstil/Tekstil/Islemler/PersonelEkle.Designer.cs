namespace Tekstil
{
    partial class PersonelEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this.button1 = new System.Windows.Forms.Button();
            this.tB_TC = new System.Windows.Forms.TextBox();
            this.tB_isim = new System.Windows.Forms.TextBox();
            this.tB_soyisim = new System.Windows.Forms.TextBox();
            this.tB_kad = new System.Windows.Forms.TextBox();
            this.tB_sifre = new System.Windows.Forms.TextBox();
            this.tB_eposta = new System.Windows.Forms.TextBox();
            this.tB_telefon = new System.Windows.Forms.TextBox();
            this.tB_Adres = new System.Windows.Forms.TextBox();
            this.cB_Departman = new System.Windows.Forms.ComboBox();
            this.tB_Gsoru = new System.Windows.Forms.TextBox();
            this.tB_GCevap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cB_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(259, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB_TC
            // 
            this.tB_TC.BackColor = System.Drawing.Color.LightBlue;
            this.tB_TC.Location = new System.Drawing.Point(236, 138);
            this.tB_TC.Name = "tB_TC";
            this.tB_TC.Size = new System.Drawing.Size(231, 30);
            this.tB_TC.TabIndex = 1;
            // 
            // tB_isim
            // 
            this.tB_isim.BackColor = System.Drawing.Color.LightBlue;
            this.tB_isim.Location = new System.Drawing.Point(236, 169);
            this.tB_isim.Name = "tB_isim";
            this.tB_isim.Size = new System.Drawing.Size(231, 30);
            this.tB_isim.TabIndex = 2;
            // 
            // tB_soyisim
            // 
            this.tB_soyisim.BackColor = System.Drawing.Color.LightBlue;
            this.tB_soyisim.Location = new System.Drawing.Point(236, 200);
            this.tB_soyisim.Name = "tB_soyisim";
            this.tB_soyisim.Size = new System.Drawing.Size(231, 30);
            this.tB_soyisim.TabIndex = 3;
            this.tB_soyisim.TextChanged += new System.EventHandler(this.tB_soyisim_TextChanged);
            // 
            // tB_kad
            // 
            this.tB_kad.BackColor = System.Drawing.Color.LightBlue;
            this.tB_kad.Location = new System.Drawing.Point(236, 231);
            this.tB_kad.Name = "tB_kad";
            this.tB_kad.Size = new System.Drawing.Size(231, 30);
            this.tB_kad.TabIndex = 4;
            this.tB_kad.TextChanged += new System.EventHandler(this.tB_kad_TextChanged);
            // 
            // tB_sifre
            // 
            this.tB_sifre.BackColor = System.Drawing.Color.LightBlue;
            this.tB_sifre.Location = new System.Drawing.Point(236, 262);
            this.tB_sifre.Name = "tB_sifre";
            this.tB_sifre.PasswordChar = '*';
            this.tB_sifre.Size = new System.Drawing.Size(231, 30);
            this.tB_sifre.TabIndex = 5;
            this.tB_sifre.TextChanged += new System.EventHandler(this.tB_sifre_TextChanged);
            // 
            // tB_eposta
            // 
            this.tB_eposta.BackColor = System.Drawing.Color.LightBlue;
            this.tB_eposta.Location = new System.Drawing.Point(236, 293);
            this.tB_eposta.Name = "tB_eposta";
            this.tB_eposta.Size = new System.Drawing.Size(231, 30);
            this.tB_eposta.TabIndex = 6;
            this.tB_eposta.TextChanged += new System.EventHandler(this.tB_eposta_TextChanged);
            this.tB_eposta.Leave += new System.EventHandler(this.tB_eposta_Leave);
            // 
            // tB_telefon
            // 
            this.tB_telefon.BackColor = System.Drawing.Color.LightBlue;
            this.tB_telefon.Location = new System.Drawing.Point(236, 324);
            this.tB_telefon.Name = "tB_telefon";
            this.tB_telefon.Size = new System.Drawing.Size(231, 30);
            this.tB_telefon.TabIndex = 7;
            this.tB_telefon.TextChanged += new System.EventHandler(this.tB_telefon_TextChanged);
            // 
            // tB_Adres
            // 
            this.tB_Adres.BackColor = System.Drawing.Color.LightBlue;
            this.tB_Adres.Location = new System.Drawing.Point(236, 535);
            this.tB_Adres.Multiline = true;
            this.tB_Adres.Name = "tB_Adres";
            this.tB_Adres.Size = new System.Drawing.Size(231, 62);
            this.tB_Adres.TabIndex = 8;
            this.tB_Adres.TextChanged += new System.EventHandler(this.tB_Adres_TextChanged);
            // 
            // cB_Departman
            // 
            this.cB_Departman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Departman.FormattingEnabled = true;
            this.cB_Departman.Location = new System.Drawing.Point(236, 355);
            this.cB_Departman.Name = "cB_Departman";
            this.cB_Departman.Size = new System.Drawing.Size(231, 30);
            this.cB_Departman.TabIndex = 9;
            this.cB_Departman.SelectedIndexChanged += new System.EventHandler(this.cB_Departman_SelectedIndexChanged);
            // 
            // tB_Gsoru
            // 
            this.tB_Gsoru.BackColor = System.Drawing.Color.LightBlue;
            this.tB_Gsoru.Location = new System.Drawing.Point(236, 445);
            this.tB_Gsoru.Name = "tB_Gsoru";
            this.tB_Gsoru.Size = new System.Drawing.Size(231, 30);
            this.tB_Gsoru.TabIndex = 11;
            this.tB_Gsoru.TextChanged += new System.EventHandler(this.tB_Gsoru_TextChanged);
            // 
            // tB_GCevap
            // 
            this.tB_GCevap.BackColor = System.Drawing.Color.LightBlue;
            this.tB_GCevap.Location = new System.Drawing.Point(236, 491);
            this.tB_GCevap.Name = "tB_GCevap";
            this.tB_GCevap.Size = new System.Drawing.Size(231, 30);
            this.tB_GCevap.TabIndex = 12;
            this.tB_GCevap.TextChanged += new System.EventHandler(this.tB_GCevap_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "TC Kimlik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "İsim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Soyisim";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kullanıcı Adı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Şifre";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "Güvenlik Sorusu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(39, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cinsiyet";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(38, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Departman";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(39, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Telefon Numarası";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(39, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "Eposta";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(39, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 28);
            this.label11.TabIndex = 23;
            this.label11.Text = "G. Sorusu Cevabı";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(39, 535);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 31);
            this.label12.TabIndex = 24;
            this.label12.Text = "Adres";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cB_Cinsiyet
            // 
            this.cB_Cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Cinsiyet.FormattingEnabled = true;
            this.cB_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cB_Cinsiyet.Location = new System.Drawing.Point(236, 398);
            this.cB_Cinsiyet.Name = "cB_Cinsiyet";
            this.cB_Cinsiyet.Size = new System.Drawing.Size(231, 30);
            this.cB_Cinsiyet.TabIndex = 25;
            this.cB_Cinsiyet.SelectedIndexChanged += new System.EventHandler(this.cB_Cinsiyet_SelectedIndexChanged);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Ekle.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(108, 622);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(118, 44);
            this.btn_Ekle.TabIndex = 26;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(578, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.cB_Cinsiyet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_GCevap);
            this.Controls.Add(this.tB_Gsoru);
            this.Controls.Add(this.cB_Departman);
            this.Controls.Add(this.tB_Adres);
            this.Controls.Add(this.tB_telefon);
            this.Controls.Add(this.tB_eposta);
            this.Controls.Add(this.tB_sifre);
            this.Controls.Add(this.tB_kad);
            this.Controls.Add(this.tB_soyisim);
            this.Controls.Add(this.tB_isim);
            this.Controls.Add(this.tB_TC);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tB_TC;
        private System.Windows.Forms.TextBox tB_isim;
        private System.Windows.Forms.TextBox tB_soyisim;
        private System.Windows.Forms.TextBox tB_kad;
        private System.Windows.Forms.TextBox tB_sifre;
        private System.Windows.Forms.TextBox tB_eposta;
        private System.Windows.Forms.TextBox tB_telefon;
        private System.Windows.Forms.TextBox tB_Adres;
        private System.Windows.Forms.ComboBox cB_Departman;
        private System.Windows.Forms.TextBox tB_Gsoru;
        private System.Windows.Forms.TextBox tB_GCevap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cB_Cinsiyet;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}