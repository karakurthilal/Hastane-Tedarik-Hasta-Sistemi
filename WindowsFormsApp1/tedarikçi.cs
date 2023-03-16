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
    public partial class tedarikçi : Form
    {
        public tedarikçi()
        {
            InitializeComponent();
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hastanessDataSet);

        }

        private void tedarikçi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastanessDataSet.supplier' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.supplierTableAdapter.Fill(this.hastanessDataSet.supplier);

        }
    }
}
