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
    public partial class sarf_cihaz : Form
    {
        public sarf_cihaz()
        {
            InitializeComponent();
        }

        private void consumableDeviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consumableDeviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hastanessDataSet);

        }

        private void sarf_cihaz_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastanessDataSet.consumableDevice' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.consumableDeviceTableAdapter.Fill(this.hastanessDataSet.consumableDevice);

        }
    }
}
