﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class bölümler : Form
    {
        public bölümler()
        {
            InitializeComponent();
        }

        private void partBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hastanessDataSet);

        }

        private void bölümler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastanessDataSet.part' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.partTableAdapter.Fill(this.hastanessDataSet.part);

        }
    }
}
