using System;
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
    public partial class hastane : Form
    {
        public hastane()
        {
            InitializeComponent();
        }

        private void hospitalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hospitalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hastanessDataSet);

        }

        private void hastane_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastanessDataSet.hospital' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hospitalTableAdapter.Fill(this.hastanessDataSet.hospital);

        }
    }
}
