﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public partial class frmEgitimler : Form
    {
        public frmEgitimler()
        {
            InitializeComponent();
        }

        private void Egitimler_Load(object sender, EventArgs e)
        {
        foreach (DataGridViewColumn column in dataGridView1.Columns)
        {
            column.Width = 50;
        }
        dataGridView1.DataSource = Egitimler.GetRecords();
        }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}

