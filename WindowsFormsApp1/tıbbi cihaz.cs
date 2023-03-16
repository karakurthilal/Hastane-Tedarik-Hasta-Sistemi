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
    public partial class tıbbi_cihaz : Form
    {
        public tıbbi_cihaz()
        {
            InitializeComponent();
        }

        private void deviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hastanessDataSet);

        }

        private void tıbbi_cihaz_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastanessDataSet.device' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.deviceTableAdapter.Fill(this.hastanessDataSet.device);

        }
    }
}
