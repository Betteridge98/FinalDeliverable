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

namespace PBBackOffice
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Int32 DisplaySaleItems()
        {
            //create an instance of the sale collection
            clsSaleCollection MySales = new clsSaleCollection();
            //find all sale items
            MySales.FindAllSaleItems();

            //set the data source of the SaleID list box
            lstSaleID.DataSource = MySales.SaleItems;
            //set the text to be displayed
            lstSaleID.DisplayMember = "SaleID";
            //set the primary key value
            lstSaleID.ValueMember = "ItemID";

            //set the data source of the SaleID list box
            lstItemID.DataSource = MySales.SaleItems;
            //set the text to be displayed
            lstItemID.DisplayMember = "ItemID";
            //set the primary key value
            lstItemID.ValueMember = "ItemID";

            //set the data source of the SaleID list box
            lstItemPrice.DataSource = MySales.SaleItems;
            //set the text to be displayed
            lstItemPrice.DisplayMember = "ItemPrice";
            //set the primary key value
            lstItemPrice.ValueMember = "ItemID";

            //set the data source of the SaleID list box
            lstQuantity.DataSource = MySales.SaleItems;
            //set the text to be displayed
            lstQuantity.DisplayMember = "Quantity";
            //set the primary key value
            lstQuantity.ValueMember = "ItemID";

            //set the data source of the SaleID list box
            lstDateAdded.DataSource = MySales.SaleItems;
            //set the text to be displayed
            lstDateAdded.DisplayMember = "DateAdded";
            //set the primary key value
            lstDateAdded.ValueMember = "ItemID";

            //return the count of records in the list
            return MySales.Count;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //call the display sale items function
            lblError.Text = DisplaySaleItems() + " found";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this sale?", "Are you sure?", MessageBoxButtons.YesNo);
        }

        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to remove this item?", "Are you sure?", MessageBoxButtons.YesNo);
        }
    }
}
