
partial class frmAnaEkran
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
        this.btnOgrenciEkle = new System.Windows.Forms.Button();
        this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
        this.btnEtkinlikEkle = new System.Windows.Forms.Button();
        this.btnEtkinlikGuncelle = new System.Windows.Forms.Button();
        this.btnYoklamaAl = new System.Windows.Forms.Button();
        this.btnIstatistik = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Minion Pro", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(30, 25);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(478, 379);
        this.label1.TabIndex = 0;
        this.label1.Text = "MİMCE DERNEĞİ ÖĞRENCİ OTOMASYONU";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label1.UseWaitCursor = true;
        // 
        // btnOgrenciEkle
        // 
        this.btnOgrenciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.btnOgrenciEkle.Location = new System.Drawing.Point(554, 43);
        this.btnOgrenciEkle.Name = "btnOgrenciEkle";
        this.btnOgrenciEkle.Size = new System.Drawing.Size(192, 60);
        this.btnOgrenciEkle.TabIndex = 1;
        this.btnOgrenciEkle.Text = "Öğrenci Ekle";
        this.btnOgrenciEkle.UseVisualStyleBackColor = true;
        this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
        // 
        // btnOgrenciGuncelle
        // 
        this.btnOgrenciGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.btnOgrenciGuncelle.Location = new System.Drawing.Point(554, 121);
        this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
        this.btnOgrenciGuncelle.Size = new System.Drawing.Size(192, 60);
        this.btnOgrenciGuncelle.TabIndex = 1;
        this.btnOgrenciGuncelle.Text = "Öğrenci Güncelle";
        this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
        this.btnOgrenciGuncelle.Click += new System.EventHandler(this.button1_Click);
        // 
        // btnEtkinlikEkle
        // 
        this.btnEtkinlikEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.btnEtkinlikEkle.Location = new System.Drawing.Point(554, 249);
        this.btnEtkinlikEkle.Name = "btnEtkinlikEkle";
        this.btnEtkinlikEkle.Size = new System.Drawing.Size(192, 60);
        this.btnEtkinlikEkle.TabIndex = 1;
        this.btnEtkinlikEkle.Text = "Etkinlik Ekle";
        this.btnEtkinlikEkle.UseVisualStyleBackColor = true;
        this.btnEtkinlikEkle.Click += new System.EventHandler(this.button1_Click);
        // 
        // btnEtkinlikGuncelle
        // 
        this.btnEtkinlikGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.btnEtkinlikGuncelle.Location = new System.Drawing.Point(554, 344);
        this.btnEtkinlikGuncelle.Name = "btnEtkinlikGuncelle";
        this.btnEtkinlikGuncelle.Size = new System.Drawing.Size(192, 60);
        this.btnEtkinlikGuncelle.TabIndex = 1;
        this.btnEtkinlikGuncelle.Text = "Etkinlik Güncelle";
        this.btnEtkinlikGuncelle.UseVisualStyleBackColor = true;
        this.btnEtkinlikGuncelle.Click += new System.EventHandler(this.button1_Click);
        // 
        // btnYoklamaAl
        // 
        this.btnYoklamaAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.btnYoklamaAl.Location = new System.Drawing.Point(408, 447);
        this.btnYoklamaAl.Name = "btnYoklamaAl";
        this.btnYoklamaAl.Size = new System.Drawing.Size(192, 60);
        this.btnYoklamaAl.TabIndex = 1;
        this.btnYoklamaAl.Text = "Yoklama Al";
        this.btnYoklamaAl.UseVisualStyleBackColor = true;
        this.btnYoklamaAl.Click += new System.EventHandler(this.button1_Click);
        // 
        // btnIstatistik
        // 
        this.btnIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.btnIstatistik.Location = new System.Drawing.Point(123, 447);
        this.btnIstatistik.Name = "btnIstatistik";
        this.btnIstatistik.Size = new System.Drawing.Size(192, 60);
        this.btnIstatistik.TabIndex = 1;
        this.btnIstatistik.Text = "İstatistikleri Görüntüle";
        this.btnIstatistik.UseVisualStyleBackColor = true;
        this.btnIstatistik.Click += new System.EventHandler(this.button1_Click);
        // 
        // frmAnaEkran
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 532);
        this.Controls.Add(this.btnIstatistik);
        this.Controls.Add(this.btnYoklamaAl);
        this.Controls.Add(this.btnEtkinlikGuncelle);
        this.Controls.Add(this.btnEtkinlikEkle);
        this.Controls.Add(this.btnOgrenciGuncelle);
        this.Controls.Add(this.btnOgrenciEkle);
        this.Controls.Add(this.label1);
        this.Name = "frmAnaEkran";
        this.Text = "Ana Ekran";
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnOgrenciEkle;
    private System.Windows.Forms.Button btnOgrenciGuncelle;
    private System.Windows.Forms.Button btnEtkinlikEkle;
    private System.Windows.Forms.Button btnEtkinlikGuncelle;
    private System.Windows.Forms.Button btnYoklamaAl;
    private System.Windows.Forms.Button btnIstatistik;
}
