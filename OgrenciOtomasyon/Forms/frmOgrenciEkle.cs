using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    public partial class frmOgrenciEkle : Form
    {
        public frmOgrenciEkle()
        {
            InitializeComponent();
        }

    private void frmOgrenciEkle_Load(object sender, EventArgs e)
    {
        
       cmbOkul.DataSource = Okullar.GetRecords();
        cmbOkul.DisplayMember = "Adi";
        cmbOkul.ValueMember = "OkulID";

        cmbBolum.DataSource = Bolumler.GetRecords();
        cmbBolum.DisplayMember = "BolumAdi";
        cmbBolum.ValueMember = "ID";
    

    }

    internal void Showdialog()
    {
        throw new NotImplementedException();
    }

    private void txtTelefonNo_TextChanged(object sender, EventArgs e)
    {

    }

   
    private void btnKaydet_Click(object sender, EventArgs e)
    {
        Ogrenciler ogrenci = new Ogrenciler();
        ogrenci.Adi = txtAdi.Text;
        ogrenci.Soyadi = txtSoyadi.Text;
        ogrenci.TelefonNo = txtTelefonNo.Text;
        ogrenci.Mail = txtMail.Text;
        ogrenci.BolumID = Convert.ToInt32(cmbBolum.SelectedValue);
        ogrenci.OkulID = Convert.ToInt32(cmbOkul.SelectedValue);
        Ogrenciler.Insert(ogrenci);

        MessageBox.Show("kayıt yapıldı");

        txtAdi.Clear();
        txtSoyadi.Clear();
        txtTelefonNo.Clear();
        txtMail.Clear();
        txtAdi.Focus();
       
    }

    private void btnTemizle_Click(object sender, EventArgs e)
    {
         txtAdi.Clear();
        txtSoyadi.Clear();
        txtTelefonNo.Clear();
        txtMail.Clear();
        txtAdi.Focus();
    }
}
