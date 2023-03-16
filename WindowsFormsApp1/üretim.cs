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
    public partial class üretim : Form
    {
        public üretim()
        {
            InitializeComponent();
        }

        private void productionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hastanessDataSet);

        }

        private void üretim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastanessDataSet.production' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.productionTableAdapter.Fill(this.hastanessDataSet.production);

        }
    }
}
