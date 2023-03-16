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
    public partial class ilaç : Form
    {
        public ilaç()
        {
            InitializeComponent();
        }

        private void medicineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hastanessDataSet);

        }

        private void ilaç_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastanessDataSet.medicine' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.medicineTableAdapter.Fill(this.hastanessDataSet.medicine);

        }
    }
}
