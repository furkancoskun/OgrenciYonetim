
    partial class frmOgrenciEkle
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
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.cmbOkul = new System.Windows.Forms.ComboBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.Okul = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(149, 38);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(251, 31);
            this.txtAdi.TabIndex = 1;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(149, 98);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(251, 31);
            this.txtSoyadi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cep No";            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(149, 272);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(251, 31);
            this.txtTelefonNo.TabIndex = 1;
            this.txtTelefonNo.TextChanged += new System.EventHandler(this.txtTelefonNo_TextChanged);
            // 
            // cmbOkul
            // 
            this.cmbOkul.FormattingEnabled = true;
            this.cmbOkul.Location = new System.Drawing.Point(149, 148);
            this.cmbOkul.Name = "cmbOkul";
            this.cmbOkul.Size = new System.Drawing.Size(251, 33);
            this.cmbOkul.TabIndex = 2;
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(149, 209);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(251, 33);
            this.cmbBolum.TabIndex = 2;
            // 
            // Okul
            // 
            this.Okul.AutoSize = true;
            this.Okul.Location = new System.Drawing.Point(42, 151);
            this.Okul.Name = "Okul";
            this.Okul.Size = new System.Drawing.Size(56, 25);
            this.Okul.TabIndex = 0;
            this.Okul.Text = "Okul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mail";            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(149, 349);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(251, 31);
            this.txtMail.TabIndex = 1;
            this.txtMail.TextChanged += new System.EventHandler(this.txtTelefonNo_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(300, 441);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 60);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(194, 441);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(100, 60);
            this.btnVazgec.TabIndex = 3;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            // 
            // frmOgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 533);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.cmbOkul);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Okul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOgrenciEkle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmOgrenciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtAdi;
    private System.Windows.Forms.TextBox txtSoyadi;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtTelefonNo;
    private System.Windows.Forms.ComboBox cmbOkul;
    private System.Windows.Forms.ComboBox cmbBolum;
    private System.Windows.Forms.Label Okul;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtMail;
    private System.Windows.Forms.Button btnKaydet;
    private System.Windows.Forms.Button btnVazgec;
}

