using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OurClassLibrary;

namespace FinalDeliverable
{
    public partial class frmSalesAdd : Form
    {
        clsSaleCollection saleCollection;
        frmSales formSales;
        public frmSalesAdd(clsSaleCollection saleCollection, frmSales frmSales)
        {
            InitializeComponent();

            this.saleCollection = saleCollection;
            formSales = frmSales;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure you want to cancel adding this sale?", "Are you sure?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dr == DialogResult.No)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsSaleCollection Sales = new clsSaleCollection();
            clsSaleItem AddedItem = new clsSaleItem();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            AddedItem.ItemID = Convert.ToInt32(txtItemID.Text);
            AddedItem.ItemPrice = Convert.ToDecimal(txtItemPrice.Text);
            AddedItem.Quantity = Convert.ToInt32(txtQuantity.Text);
            AddedItem.SaleID = Convert.ToInt32(txtSaleID.Text);
            AddedItem.DateAdded = DateTime.Now.Date;
            Sales.ThisSale = AddedItem;
            //add the record
            PrimaryKey = Sales.Add();
            formSales.DisplaySaleItems();
            this.Close();
        }
    }
}
