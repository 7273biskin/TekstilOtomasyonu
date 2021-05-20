namespace Tekstil
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.tB_ad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_guven = new System.Windows.Forms.Label();
            this.label_soru = new System.Windows.Forms.Label();
            this.label_cvp = new System.Windows.Forms.Label();
            this.tB_Cevap = new System.Windows.Forms.TextBox();
            this.btn_Ogren = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.btn_GirisEkran = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_ad
            // 
            this.tB_ad.Location = new System.Drawing.Point(141, 208);
            this.tB_ad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_ad.Name = "tB_ad";
            this.tB_ad.Size = new System.Drawing.Size(188, 22);
            this.tB_ad.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(335, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_guven
            // 
            this.label_guven.AutoSize = true;
            this.label_guven.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_guven.Location = new System.Drawing.Point(13, 270);
            this.label_guven.Name = "label_guven";
            this.label_guven.Size = new System.Drawing.Size(156, 30);
            this.label_guven.TabIndex = 3;
            this.label_guven.Text = "Güvenlik Sorusu ";
            this.label_guven.Visible = false;
            // 
            // label_soru
            // 
            this.label_soru.AutoSize = true;
            this.label_soru.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_soru.Location = new System.Drawing.Point(12, 299);
            this.label_soru.Name = "label_soru";
            this.label_soru.Size = new System.Drawing.Size(20, 35);
            this.label_soru.TabIndex = 4;
            this.label_soru.Text = ".";
            this.label_soru.Visible = false;
            this.label_soru.Click += new System.EventHandler(this.label_soru_Click);
            // 
            // label_cvp
            // 
            this.label_cvp.AutoSize = true;
            this.label_cvp.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_cvp.Location = new System.Drawing.Point(17, 357);
            this.label_cvp.Name = "label_cvp";
            this.label_cvp.Size = new System.Drawing.Size(93, 30);
            this.label_cvp.TabIndex = 5;
            this.label_cvp.Text = "Cevabınız";
            this.label_cvp.Visible = false;
            // 
            // tB_Cevap
            // 
            this.tB_Cevap.Location = new System.Drawing.Point(19, 389);
            this.tB_Cevap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_Cevap.Name = "tB_Cevap";
            this.tB_Cevap.Size = new System.Drawing.Size(392, 22);
            this.tB_Cevap.TabIndex = 6;
            this.tB_Cevap.Visible = false;
            this.tB_Cevap.TextChanged += new System.EventHandler(this.tB_Cevap_TextChanged);
            // 
            // btn_Ogren
            // 
            this.btn_Ogren.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Ogren.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ogren.Location = new System.Drawing.Point(209, 415);
            this.btn_Ogren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ogren.Name = "btn_Ogren";
            this.btn_Ogren.Size = new System.Drawing.Size(201, 52);
            this.btn_Ogren.TabIndex = 7;
            this.btn_Ogren.Text = "Şifreni Öğren";
            this.btn_Ogren.UseVisualStyleBackColor = false;
            this.btn_Ogren.Visible = false;
            this.btn_Ogren.Click += new System.EventHandler(this.btn_Ogren_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Cikis.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.Location = new System.Drawing.Point(219, 500);
            this.btn_Cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(191, 50);
            this.btn_Cikis.TabIndex = 8;
            this.btn_Cikis.Text = "ÇIKIŞ";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // btn_GirisEkran
            // 
            this.btn_GirisEkran.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_GirisEkran.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GirisEkran.Location = new System.Drawing.Point(19, 500);
            this.btn_GirisEkran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GirisEkran.Name = "btn_GirisEkran";
            this.btn_GirisEkran.Size = new System.Drawing.Size(195, 50);
            this.btn_GirisEkran.TabIndex = 9;
            this.btn_GirisEkran.Text = "GİRİŞ EKRANI";
            this.btn_GirisEkran.UseVisualStyleBackColor = false;
            this.btn_GirisEkran.Click += new System.EventHandler(this.btn_GirisEkran_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(125, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(435, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GirisEkran);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_Ogren);
            this.Controls.Add(this.tB_Cevap);
            this.Controls.Add(this.label_cvp);
            this.Controls.Add(this.label_soru);
            this.Controls.Add(this.label_guven);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tB_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SifremiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifremiUnuttum";
            this.Load += new System.EventHandler(this.SifremiUnuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_ad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_guven;
        private System.Windows.Forms.Label label_soru;
        private System.Windows.Forms.Label label_cvp;
        private System.Windows.Forms.TextBox tB_Cevap;
        private System.Windows.Forms.Button btn_Ogren;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Button btn_GirisEkran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}