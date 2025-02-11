using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManegerInterface : Form
    {
        private Form parentForm;
        public ManegerInterface(Form parentForm)
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(ManegerInterface_FormClosed);
            this.parentForm = parentForm;
        }

        private void ManegerInterface_FormClosed(object sender, FormClosedEventArgs e)
        {

            parentForm.Close();
        }

        private void manegerProduct_Click(object sender, EventArgs e)
        {
            ManegerProduct manPro = new ManegerProduct();
            manPro.Show();
        }

        private void manegerOrderProduct_Click(object sender, EventArgs e)
        {
            ManegerOrderProduct manegerOrderProduct = new ManegerOrderProduct();
            manegerOrderProduct.Show();
        }

        private void manegerSale_Click(object sender, EventArgs e)
        {
            ManegerSale manegerSale = new ManegerSale();
            manegerSale.Show();
        }
    }
}
