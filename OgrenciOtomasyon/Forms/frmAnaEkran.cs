using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




public partial class frmAnaEkran : Form
{
    public frmAnaEkran()
    {
        InitializeComponent();
    }

   
    private void btnOgrenciEkle_Click(object sender, EventArgs e)
    {
        frmOgrenciEkle goster = new frmOgrenciEkle();
        goster.ShowDialog();
    }

    private void btnEtkinlikEkle_Click(object sender, EventArgs e)
    {
        frmEgitimler goster = new frmEgitimler();
        goster.ShowDialog();
    }

    private void btnYoklamaAl_Click(object sender, EventArgs e)
    {
        frmEgitimler goster = new frmEgitimler();
        goster.ShowDialog();
    }

    private void frmAnaEkran_Load(object sender, EventArgs e)
    {

    }
}
