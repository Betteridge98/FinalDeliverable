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
        clsSaleCollection saleCollection;
        public frmSales()
        {
            InitializeComponent();

            //this.saleCollection = saleCollection;
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

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            //create a new instance of the frmSalesAdd class
            frmSalesAdd addSaleForm = new frmSalesAdd(saleCollection, this);
            //show the add sales form
            addSaleForm.Show();
        }

        //void DeleteSale()
        //{
        //    //function to delete the selected record

        //    //create a new instance of the sale collection
        //    clsSaleCollection SaleCollection = new clsSaleCollection();
        //    //find the record to delete
        //    SaleCollection.ThisSale.Find(ItemID);

        //}

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to remove this sale?", "Are you sure?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                //var to store the primary key value of the record to be deleted
                //Int32 ItemID;
                
                //if a record has been selected from the list
                if (lstSales.SelectedIndex != -1)
                {
                    //none of it works
                    ////create an instance of the class we want to create
                    //clsSaleCollection Sales = new clsSaleCollection();
                    ////create the thingey
                    //clsSaleItem DeletedItem = new clsSaleItem();
                    ////get the primary key value of the record to delete
                    //ItemID = Convert.ToInt32(lstSales.SelectedValue);
                    //////remove the record
                    ////saleCollection.Delete
                    //Sales.ThisSale.Find(ItemID);
                    //Sales.Delete();

                    //clsSaleCollection Sales = new clsSaleCollection();
                    //clsSaleItem DeletedItem = new clsSaleItem();
                    //ItemID = Convert.ToInt32(txtDeleteItemID.Text);
                    //Sales.ThisSale.Find(ItemID);
                    ////delete the record
                    //Sales.Delete();
                    //none of it works
                }
            }
            else if (dr == DialogResult.No)
            {

            }
        }
    }
}
