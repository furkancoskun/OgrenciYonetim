using OgrenciOtomasyon.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    public partial class frmYoklama : Form
    {
   

    public frmYoklama()
        {
            InitializeComponent();
        }

    private void frmYoklama_Load(object sender, EventArgs e)
    {
        for (int i = 1; i <= Degerler.Sure; i++)
        {
            cmbSure.Items.Add(i);
        }
        lblEgtmAdi.Text = Degerler.EgitimAdi;
        var listOgrenciId = new List<int> ();
        var list = Ogrenciler.GetRecords();

        for (int i = 0; i < list.Count; i++)
        {   CheckBox chbBox = new CheckBox();
            chbBox.Name = "chbBox" + i;
            flowLayoutPanel1.Controls.Add(chbBox);
            chbBox.Text= list[i].Adi+ " " +list[i].Soyadi;
            listOgrenciId.Add(list[i].OgrenciId);
        }
      
    }

    private void btnYoklamaAl_Click(object sender, EventArgs e)
    {
        var list = Ogrenciler.GetRecords();
        var list2 = Egitimler.GetRecords();
        for (int i = 0; i < list.Count; i++) {
            CheckBox chbBox = new CheckBox();
            if (chbBox.Checked == true)
            {
                KatılımID katilim = new KatılımID();
                katilim.OgrenciID = list[i].OgrenciId;
                katilim.EgitimID = list2[i].EgitimID;
                katilim.Hafta = (int)cmbSure.SelectedItem;
                katilim.KatilimDurumu = true;
                KatılımID.Insert(katilim);
            }
            else  continue;         
       }
        MessageBox.Show("Yoklama Alındı");
    }
}
