
    partial class frmEtkinlikEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEgitimAdi = new System.Windows.Forms.TextBox();
            this.txtEgtmKonu = new System.Windows.Forms.TextBox();
            this.txtEgitmen = new System.Windows.Forms.TextBox();
            this.numDers = new System.Windows.Forms.NumericUpDown();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Egitim Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Egitim Konu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Egitmen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ders Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Başlangıç Tarihi";
            // 
            // txtEgitimAdi
            // 
            this.txtEgitimAdi.Location = new System.Drawing.Point(110, 29);
            this.txtEgitimAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtEgitimAdi.Name = "txtEgitimAdi";
            this.txtEgitimAdi.Size = new System.Drawing.Size(102, 20);
            this.txtEgitimAdi.TabIndex = 0;
            // 
            // txtEgtmKonu
            // 
            this.txtEgtmKonu.Location = new System.Drawing.Point(110, 54);
            this.txtEgtmKonu.Margin = new System.Windows.Forms.Padding(2);
            this.txtEgtmKonu.Name = "txtEgtmKonu";
            this.txtEgtmKonu.Size = new System.Drawing.Size(102, 20);
            this.txtEgtmKonu.TabIndex = 1;
            // 
            // txtEgitmen
            // 
            this.txtEgitmen.Location = new System.Drawing.Point(110, 83);
            this.txtEgitmen.Margin = new System.Windows.Forms.Padding(2);
            this.txtEgitmen.Name = "txtEgitmen";
            this.txtEgitmen.Size = new System.Drawing.Size(102, 20);
            this.txtEgitmen.TabIndex = 2;
            // 
            // numDers
            // 
            this.numDers.Location = new System.Drawing.Point(110, 111);
            this.numDers.Margin = new System.Windows.Forms.Padding(2);
            this.numDers.Name = "numDers";
            this.numDers.Size = new System.Drawing.Size(100, 20);
            this.numDers.TabIndex = 3;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Location = new System.Drawing.Point(110, 139);
            this.dateBaslangic.Margin = new System.Windows.Forms.Padding(2);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(102, 20);
            this.dateBaslangic.TabIndex = 4;
            // 
            // cmbTuru
            // 
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.ItemHeight = 13;
            this.cmbTuru.Items.AddRange(new object[] {
            "",
            "Seminer",
            "Eğitim"});
            this.cmbTuru.Location = new System.Drawing.Point(110, 173);
            this.cmbTuru.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(102, 21);
            this.cmbTuru.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Türü";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(272, 207);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 43);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(170, 207);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(99, 43);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmEtkinlikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 256);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbTuru);
            this.Controls.Add(this.dateBaslangic);
            this.Controls.Add(this.numDers);
            this.Controls.Add(this.txtEgitmen);
            this.Controls.Add(this.txtEgtmKonu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEgitimAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEtkinlikEkle";
            this.Text = "frmEgitimEkle";
            ((System.ComponentModel.ISupportInitialize)(this.numDers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEgitimAdi;
        private System.Windows.Forms.TextBox txtEgtmKonu;
        private System.Windows.Forms.TextBox txtEgitmen;
        private System.Windows.Forms.NumericUpDown numDers;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
    }