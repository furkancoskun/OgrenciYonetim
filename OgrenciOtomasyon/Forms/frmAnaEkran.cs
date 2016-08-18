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

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void btnOgrenciEkle_Click(object sender, EventArgs e)
    {
        frmOgrenciEkle goster = new frmOgrenciEkle();
        goster.Show();


    }
}
