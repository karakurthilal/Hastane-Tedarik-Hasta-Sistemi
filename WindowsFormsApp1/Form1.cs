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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tıbbi_cihaz f = new tıbbi_cihaz();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hasta f = new hasta();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastane f = new hastane();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tedarikçi f = new tedarikçi();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            üretim f = new üretim();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bölümler f = new bölümler();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ilaç f = new ilaç();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sarf_ilaç f = new sarf_ilaç();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sarf_cihaz f = new sarf_cihaz();
            f.Show();
        }
    }
}
