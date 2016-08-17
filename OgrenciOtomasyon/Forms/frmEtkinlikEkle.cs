using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public partial class frmEtkinlikEkle : Form
    {
        public frmEtkinlikEkle()
        {
            InitializeComponent();
        }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
        Egitimler egitim = new Egitimler()
        {
            Baslangic = dateBaslangic.Value,
            EgitimAdi = txtEgitimAdi.Text,
            Egitmen = txtEgitmen.Text,
            EgitimKonu = txtEgtmKonu.Text,
            Sure = (int)numDers.Value,
            Turu = cmbTuru.SelectedItem.ToString()
        };
        Egitimler.Insert(egitim);
    }
}
