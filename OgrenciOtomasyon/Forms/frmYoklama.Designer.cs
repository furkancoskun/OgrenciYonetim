
    partial class frmYoklama
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
            this.lblEgtmAdi = new System.Windows.Forms.Label();
            this.cmbSure = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblEgtmAdi
            // 
            this.lblEgtmAdi.AutoSize = true;
            this.lblEgtmAdi.Location = new System.Drawing.Point(14, 108);
            this.lblEgtmAdi.Name = "lblEgtmAdi";
            this.lblEgtmAdi.Size = new System.Drawing.Size(70, 25);
            this.lblEgtmAdi.TabIndex = 0;
            this.lblEgtmAdi.Text = "label1";
            // 
            // cmbSure
            // 
            this.cmbSure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSure.FormattingEnabled = true;
            this.cmbSure.Location = new System.Drawing.Point(183, 105);
            this.cmbSure.Name = "cmbSure";
            this.cmbSure.Size = new System.Drawing.Size(121, 33);
            this.cmbSure.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(910, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "LÜTFEN YOKLAMA ALINACAK HAFTAYI SEÇİNİZ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 172);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(929, 621);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // frmYoklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 805);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSure);
            this.Controls.Add(this.lblEgtmAdi);
            this.Name = "frmYoklama";
            this.Text = "frmYoklama";
            this.Load += new System.EventHandler(this.frmYoklama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Label lblEgtmAdi;
    private System.Windows.Forms.ComboBox cmbSure;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
}