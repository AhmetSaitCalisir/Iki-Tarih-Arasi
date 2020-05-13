namespace Iki_Tarih_Arasi
{
    partial class Form_Giris
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
            this.components = new System.ComponentModel.Container();
            this.dateTime_BaslangicGun = new System.Windows.Forms.DateTimePicker();
            this.dateTime_SonGun = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTime_BaslangicSaat = new System.Windows.Forms.DateTimePicker();
            this.dateTime_SonSaat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_GecenGun = new System.Windows.Forms.Label();
            this.label_KalanGun = new System.Windows.Forms.Label();
            this.label_GecenSaat = new System.Windows.Forms.Label();
            this.label_KalanSaat = new System.Windows.Forms.Label();
            this.label_GecenDakika = new System.Windows.Forms.Label();
            this.label_KalanDakika = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_KalanSaniye = new System.Windows.Forms.Label();
            this.label_GecenSaniye = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTime_BaslangicGun
            // 
            this.dateTime_BaslangicGun.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_BaslangicGun.Location = new System.Drawing.Point(187, 9);
            this.dateTime_BaslangicGun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTime_BaslangicGun.Name = "dateTime_BaslangicGun";
            this.dateTime_BaslangicGun.Size = new System.Drawing.Size(278, 28);
            this.dateTime_BaslangicGun.TabIndex = 0;
            this.dateTime_BaslangicGun.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
            this.dateTime_BaslangicGun.ValueChanged += new System.EventHandler(this.dateTime_BaslangicGun_ValueChanged);
            // 
            // dateTime_SonGun
            // 
            this.dateTime_SonGun.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_SonGun.Location = new System.Drawing.Point(187, 64);
            this.dateTime_SonGun.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTime_SonGun.Name = "dateTime_SonGun";
            this.dateTime_SonGun.Size = new System.Drawing.Size(278, 28);
            this.dateTime_SonGun.TabIndex = 1;
            this.dateTime_SonGun.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
            this.dateTime_SonGun.ValueChanged += new System.EventHandler(this.dateTime_SonGun_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Son Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Geçen Gün";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kalan Gün";
            // 
            // dateTime_BaslangicSaat
            // 
            this.dateTime_BaslangicSaat.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_BaslangicSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_BaslangicSaat.Location = new System.Drawing.Point(477, 9);
            this.dateTime_BaslangicSaat.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTime_BaslangicSaat.Name = "dateTime_BaslangicSaat";
            this.dateTime_BaslangicSaat.Size = new System.Drawing.Size(99, 28);
            this.dateTime_BaslangicSaat.TabIndex = 9;
            this.dateTime_BaslangicSaat.Value = new System.DateTime(2020, 5, 23, 0, 0, 0, 0);
            this.dateTime_BaslangicSaat.ValueChanged += new System.EventHandler(this.dateTime_BaslangicSaat_ValueChanged);
            // 
            // dateTime_SonSaat
            // 
            this.dateTime_SonSaat.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_SonSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_SonSaat.Location = new System.Drawing.Point(477, 64);
            this.dateTime_SonSaat.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTime_SonSaat.Name = "dateTime_SonSaat";
            this.dateTime_SonSaat.Size = new System.Drawing.Size(99, 28);
            this.dateTime_SonSaat.TabIndex = 10;
            this.dateTime_SonSaat.Value = new System.DateTime(2020, 5, 16, 0, 0, 0, 0);
            this.dateTime_SonSaat.ValueChanged += new System.EventHandler(this.dateTime_SonSaat_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kalan Saat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Geçen Saat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kalan Dakika";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Geçen Dakika";
            // 
            // label_GecenGun
            // 
            this.label_GecenGun.AutoSize = true;
            this.label_GecenGun.Location = new System.Drawing.Point(154, 106);
            this.label_GecenGun.Name = "label_GecenGun";
            this.label_GecenGun.Size = new System.Drawing.Size(50, 21);
            this.label_GecenGun.TabIndex = 15;
            this.label_GecenGun.Text = "1000";
            // 
            // label_KalanGun
            // 
            this.label_KalanGun.AutoSize = true;
            this.label_KalanGun.Location = new System.Drawing.Point(154, 127);
            this.label_KalanGun.Name = "label_KalanGun";
            this.label_KalanGun.Size = new System.Drawing.Size(50, 21);
            this.label_KalanGun.TabIndex = 16;
            this.label_KalanGun.Text = "1000";
            // 
            // label_GecenSaat
            // 
            this.label_GecenSaat.AutoSize = true;
            this.label_GecenSaat.Location = new System.Drawing.Point(154, 167);
            this.label_GecenSaat.Name = "label_GecenSaat";
            this.label_GecenSaat.Size = new System.Drawing.Size(50, 21);
            this.label_GecenSaat.TabIndex = 17;
            this.label_GecenSaat.Text = "1000";
            // 
            // label_KalanSaat
            // 
            this.label_KalanSaat.AutoSize = true;
            this.label_KalanSaat.Location = new System.Drawing.Point(154, 188);
            this.label_KalanSaat.Name = "label_KalanSaat";
            this.label_KalanSaat.Size = new System.Drawing.Size(50, 21);
            this.label_KalanSaat.TabIndex = 18;
            this.label_KalanSaat.Text = "1000";
            // 
            // label_GecenDakika
            // 
            this.label_GecenDakika.AutoSize = true;
            this.label_GecenDakika.Location = new System.Drawing.Point(154, 225);
            this.label_GecenDakika.Name = "label_GecenDakika";
            this.label_GecenDakika.Size = new System.Drawing.Size(50, 21);
            this.label_GecenDakika.TabIndex = 19;
            this.label_GecenDakika.Text = "1000";
            // 
            // label_KalanDakika
            // 
            this.label_KalanDakika.AutoSize = true;
            this.label_KalanDakika.Location = new System.Drawing.Point(154, 246);
            this.label_KalanDakika.Name = "label_KalanDakika";
            this.label_KalanDakika.Size = new System.Drawing.Size(50, 21);
            this.label_KalanDakika.TabIndex = 20;
            this.label_KalanDakika.Text = "1000";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label_KalanSaniye
            // 
            this.label_KalanSaniye.AutoSize = true;
            this.label_KalanSaniye.Location = new System.Drawing.Point(151, 308);
            this.label_KalanSaniye.Name = "label_KalanSaniye";
            this.label_KalanSaniye.Size = new System.Drawing.Size(50, 21);
            this.label_KalanSaniye.TabIndex = 24;
            this.label_KalanSaniye.Text = "1000";
            // 
            // label_GecenSaniye
            // 
            this.label_GecenSaniye.AutoSize = true;
            this.label_GecenSaniye.Location = new System.Drawing.Point(151, 287);
            this.label_GecenSaniye.Name = "label_GecenSaniye";
            this.label_GecenSaniye.Size = new System.Drawing.Size(50, 21);
            this.label_GecenSaniye.TabIndex = 23;
            this.label_GecenSaniye.Text = "1000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kalan Saniye";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 21);
            this.label12.TabIndex = 21;
            this.label12.Text = "Geçen Saniye";
            // 
            // button_Cikis
            // 
            this.button_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cikis.Location = new System.Drawing.Point(492, 334);
            this.button_Cikis.Name = "button_Cikis";
            this.button_Cikis.Size = new System.Drawing.Size(107, 30);
            this.button_Cikis.TabIndex = 25;
            this.button_Cikis.Text = "Çıkış";
            this.button_Cikis.UseVisualStyleBackColor = true;
            this.button_Cikis.Click += new System.EventHandler(this.button_Cikis_Click);
            // 
            // Form_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 363);
            this.Controls.Add(this.button_Cikis);
            this.Controls.Add(this.label_KalanSaniye);
            this.Controls.Add(this.label_GecenSaniye);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_KalanDakika);
            this.Controls.Add(this.label_GecenDakika);
            this.Controls.Add(this.label_KalanSaat);
            this.Controls.Add(this.label_GecenSaat);
            this.Controls.Add(this.label_KalanGun);
            this.Controls.Add(this.label_GecenGun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTime_SonSaat);
            this.Controls.Add(this.dateTime_BaslangicSaat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime_SonGun);
            this.Controls.Add(this.dateTime_BaslangicGun);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İki Tarih Arası";
            this.Load += new System.EventHandler(this.Form_Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime_BaslangicGun;
        private System.Windows.Forms.DateTimePicker dateTime_SonGun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTime_BaslangicSaat;
        private System.Windows.Forms.DateTimePicker dateTime_SonSaat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_GecenGun;
        private System.Windows.Forms.Label label_KalanGun;
        private System.Windows.Forms.Label label_GecenSaat;
        private System.Windows.Forms.Label label_KalanSaat;
        private System.Windows.Forms.Label label_GecenDakika;
        private System.Windows.Forms.Label label_KalanDakika;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_KalanSaniye;
        private System.Windows.Forms.Label label_GecenSaniye;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_Cikis;
    }
}

