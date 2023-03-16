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
    public partial class sarf_ilaç : Form
    {
        public sarf_ilaç()
        {
            InitializeComponent();
        }

        private void consumableMedicineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consumableMedicineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hastanessDataSet);

        }

        private void sarf_ilaç_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastanessDataSet.consumableMedicine' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.consumableMedicineTableAdapter.Fill(this.hastanessDataSet.consumableMedicine);

        }
    }
}
