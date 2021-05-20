namespace Tekstil
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.tB_ad = new System.Windows.Forms.TextBox();
            this.tB_Sifre = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.btn_unuttum = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_ad
            // 
            this.tB_ad.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tB_ad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_ad.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tB_ad.Location = new System.Drawing.Point(139, 210);
            this.tB_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_ad.Multiline = true;
            this.tB_ad.Name = "tB_ad";
            this.tB_ad.Size = new System.Drawing.Size(229, 36);
            this.tB_ad.TabIndex = 0;
            this.tB_ad.Text = "Kullanıcı Adı";
            this.tB_ad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tB_ad_MouseClick);
            // 
            // tB_Sifre
            // 
            this.tB_Sifre.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tB_Sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_Sifre.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tB_Sifre.Location = new System.Drawing.Point(143, 291);
            this.tB_Sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_Sifre.Name = "tB_Sifre";
            this.tB_Sifre.PasswordChar = '*';
            this.tB_Sifre.Size = new System.Drawing.Size(229, 41);
            this.tB_Sifre.TabIndex = 1;
            this.tB_Sifre.Text = "Şifre";
            this.tB_Sifre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tB_Sifre_MouseClick);
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Giris.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Location = new System.Drawing.Point(66, 407);
            this.btn_Giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(160, 57);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "GİRİŞ";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // btn_unuttum
            // 
            this.btn_unuttum.BackColor = System.Drawing.Color.Wheat;
            this.btn_unuttum.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_unuttum.Location = new System.Drawing.Point(215, 345);
            this.btn_unuttum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_unuttum.Name = "btn_unuttum";
            this.btn_unuttum.Size = new System.Drawing.Size(183, 34);
            this.btn_unuttum.TabIndex = 3;
            this.btn_unuttum.Text = "Şifremi Unuttum";
            this.btn_unuttum.UseVisualStyleBackColor = false;
            this.btn_unuttum.Click += new System.EventHandler(this.btn_unuttum_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Cikis.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cikis.Location = new System.Drawing.Point(233, 407);
            this.btn_Cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(165, 57);
            this.btn_Cikis.TabIndex = 4;
            this.btn_Cikis.Text = "ÇIKIŞ";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 290);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(100, 211);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(101, 247);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 1);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(100, 331);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 1);
            this.panel2.TabIndex = 11;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(453, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_unuttum);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.tB_Sifre);
            this.Controls.Add(this.tB_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_ad;
        private System.Windows.Forms.TextBox tB_Sifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Button btn_unuttum;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

