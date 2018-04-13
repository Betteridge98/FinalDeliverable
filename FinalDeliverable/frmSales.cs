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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            //call the display sales function
            lblError.Text = DisplaySaleItems() + " found";
        }

        Int32 DisplaySaleItems()
        {
            //create an instance of the sale collection
            clsSaleCollection MySales = new clsSaleCollection();
            //find all sale items
            MySales.FindAllSaleItems();
            //set the data source of the list box
            lstSales.DataSource = MySales.SaleItems;
            //set the text to be displayed
            lstSales.DisplayMember = "FullDetails";
            //set the primary key value
            lstSales.ValueMember = "ItemID";
            //return the count of records in the list
            return MySales.Count;
        }

        private void frmSales_Load(object sender, EventArgs e)
        {

        }
    }
}
