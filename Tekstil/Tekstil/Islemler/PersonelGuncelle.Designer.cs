namespace Tekstil
{
    partial class PersonelGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGuncelle));
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.cB_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_GCevap = new System.Windows.Forms.TextBox();
            this.tB_Gsoru = new System.Windows.Forms.TextBox();
            this.cB_Departman = new System.Windows.Forms.ComboBox();
            this.tB_Adres = new System.Windows.Forms.TextBox();
            this.tB_telefon = new System.Windows.Forms.TextBox();
            this.tB_eposta = new System.Windows.Forms.TextBox();
            this.tB_sifre = new System.Windows.Forms.TextBox();
            this.tB_kad = new System.Windows.Forms.TextBox();
            this.tB_soyisim = new System.Windows.Forms.TextBox();
            this.tB_isim = new System.Windows.Forms.TextBox();
            this.tB_TC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Guncelle.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(103, 734);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(157, 48);
            this.btn_Guncelle.TabIndex = 52;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // cB_Cinsiyet
            // 
            this.cB_Cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Cinsiyet.FormattingEnabled = true;
            this.cB_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cB_Cinsiyet.Location = new System.Drawing.Point(219, 481);
            this.cB_Cinsiyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cB_Cinsiyet.Name = "cB_Cinsiyet";
            this.cB_Cinsiyet.Size = new System.Drawing.Size(231, 24);
            this.cB_Cinsiyet.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(53, 636);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 30);
            this.label12.TabIndex = 50;
            this.label12.Text = "Adres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(27, 570);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 30);
            this.label11.TabIndex = 49;
            this.label11.Text = "G. Sorusu Cevabı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 30);
            this.label6.TabIndex = 48;
            this.label6.Text = "Güvenlik Sorusu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(35, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 30);
            this.label7.TabIndex = 47;
            this.label7.Text = "Cinsiyet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(35, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 30);
            this.label8.TabIndex = 46;
            this.label8.Text = "Departman";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(27, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 30);
            this.label9.TabIndex = 45;
            this.label9.Text = "Telefon Numarası";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(35, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 30);
            this.label10.TabIndex = 44;
            this.label10.Text = "Eposta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(35, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 30);
            this.label5.TabIndex = 43;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 30);
            this.label4.TabIndex = 42;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 41;
            this.label3.Text = "Soyisim";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 30);
            this.label2.TabIndex = 40;
            this.label2.Text = "İsim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 39;
            this.label1.Text = "TC Kimlik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tB_GCevap
            // 
            this.tB_GCevap.BackColor = System.Drawing.Color.LightBlue;
            this.tB_GCevap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_GCevap.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tB_GCevap.Location = new System.Drawing.Point(219, 561);
            this.tB_GCevap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_GCevap.Name = "tB_GCevap";
            this.tB_GCevap.Size = new System.Drawing.Size(231, 22);
            this.tB_GCevap.TabIndex = 38;
            // 
            // tB_Gsoru
            // 
            this.tB_Gsoru.BackColor = System.Drawing.Color.LightBlue;
            this.tB_Gsoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Gsoru.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tB_Gsoru.Location = new System.Drawing.Point(219, 523);
            this.tB_Gsoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_Gsoru.Name = "tB_Gsoru";
            this.tB_Gsoru.Size = new System.Drawing.Size(231, 22);
            this.tB_Gsoru.TabIndex = 37;
            // 
            // cB_Departman
            // 
            this.cB_Departman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Departman.FormattingEnabled = true;
            this.cB_Departman.Location = new System.Drawing.Point(219, 449);
            this.cB_Departman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cB_Departman.Name = "cB_Departman";
            this.cB_Departman.Size = new System.Drawing.Size(231, 24);
            this.cB_Departman.TabIndex = 36;
            // 
            // tB_Adres
            // 
            this.tB_Adres.BackColor = System.Drawing.Color.LightBlue;
            this.tB_Adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Adres.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tB_Adres.Location = new System.Drawing.Point(217, 597);
            this.tB_Adres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_Adres.Multiline = true;
            this.tB_Adres.Name = "tB_Adres";
            this.tB_Adres.Size = new System.Drawing.Size(231, 114);
            this.tB_Adres.TabIndex = 35;
            // 
            // tB_telefon
            // 
            this.tB_telefon.BackColor = System.Drawing.Color.LightBlue;
            this.tB_telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_telefon.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tB_telefon.Location = new System.Drawing.Point(219, 409);
            this.tB_telefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_telefon.Name = "tB_telefon";
            this.tB_telefon.Size = new System.Drawing.Size(231, 22);
            this.tB_telefon.TabIndex = 34;
            // 
            // tB_eposta
            // 
            this.tB_eposta.BackColor = System.Drawing.Color.LightBlue;
            this.tB_eposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_eposta.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tB_eposta.Location = new System.Drawing.Point(219, 367);
            this.tB_eposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_eposta.Name = "tB_eposta";
            this.tB_eposta.Size = new System.Drawing.Size(231, 22);
            this.tB_eposta.TabIndex = 33;
            this.tB_eposta.Leave += new System.EventHandler(this.tB_eposta_Leave);
            // 
            // tB_sifre
            // 
            this.tB_sifre.BackColor = System.Drawing.Color.LightBlue;
            this.tB_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_sifre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tB_sifre.Location = new System.Drawing.Point(219, 326);
            this.tB_sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_sifre.Name = "tB_sifre";
            this.tB_sifre.PasswordChar = '*';
            this.tB_sifre.Size = new System.Drawing.Size(231, 22);
            this.tB_sifre.TabIndex = 32;
            // 
            // tB_kad
            // 
            this.tB_kad.BackColor = System.Drawing.Color.LightBlue;
            this.tB_kad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_kad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tB_kad.Location = new System.Drawing.Point(219, 286);
            this.tB_kad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_kad.Name = "tB_kad";
            this.tB_kad.Size = new System.Drawing.Size(231, 22);
            this.tB_kad.TabIndex = 31;
            // 
            // tB_soyisim
            // 
            this.tB_soyisim.BackColor = System.Drawing.Color.LightBlue;
            this.tB_soyisim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_soyisim.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tB_soyisim.Location = new System.Drawing.Point(219, 244);
            this.tB_soyisim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_soyisim.Name = "tB_soyisim";
            this.tB_soyisim.Size = new System.Drawing.Size(231, 22);
            this.tB_soyisim.TabIndex = 30;
            // 
            // tB_isim
            // 
            this.tB_isim.BackColor = System.Drawing.Color.LightBlue;
            this.tB_isim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_isim.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tB_isim.Location = new System.Drawing.Point(219, 203);
            this.tB_isim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_isim.Name = "tB_isim";
            this.tB_isim.Size = new System.Drawing.Size(231, 22);
            this.tB_isim.TabIndex = 29;
            // 
            // tB_TC
            // 
            this.tB_TC.BackColor = System.Drawing.Color.LightBlue;
            this.tB_TC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_TC.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tB_TC.Location = new System.Drawing.Point(219, 162);
            this.tB_TC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_TC.Name = "tB_TC";
            this.tB_TC.Size = new System.Drawing.Size(231, 22);
            this.tB_TC.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(304, 734);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 48);
            this.button1.TabIndex = 27;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // PersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(581, 820);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Guncelle);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelGuncelle";
            this.Load += new System.EventHandler(this.PersonelGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.ComboBox cB_Cinsiyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_GCevap;
        private System.Windows.Forms.TextBox tB_Gsoru;
        private System.Windows.Forms.ComboBox cB_Departman;
        private System.Windows.Forms.TextBox tB_Adres;
        private System.Windows.Forms.TextBox tB_telefon;
        private System.Windows.Forms.TextBox tB_eposta;
        private System.Windows.Forms.TextBox tB_sifre;
        private System.Windows.Forms.TextBox tB_kad;
        private System.Windows.Forms.TextBox tB_soyisim;
        private System.Windows.Forms.TextBox tB_isim;
        private System.Windows.Forms.TextBox tB_TC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}