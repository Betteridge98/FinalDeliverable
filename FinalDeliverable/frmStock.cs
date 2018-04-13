using OurClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalDeliverable
{
    public partial class frmStock : Form
    {
        clsStockCollection stockCollection;
        public frmStock()
        {
            InitializeComponent();
        }

        Int32 DisplayStock()
        {
            //create an instance of the stock collection
            clsStockCollection MyList = new clsStockCollection();
            //find all staff 
            MyList.FindAllStock();
            //set the data source of the list box
            lstStockList.DataSource = MyList.AllStock;
            //set the text to be displayed
            lstStockList.DisplayMember = "AllDetails";
            //set the primary key value
            lstStockList.ValueMember = "ItemNo";
            //return the count of records in the list
            return MyList.Count;

        }

        private void btnPopulate_Click_1(object sender, EventArgs e)
        {
            //call the display staff function
            lblError.Text = DisplayStock() + " found";
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {
            //create a new instance of the stockk add class
            frmStockAdd addStockFrom = new frmStockAdd(stockCollection, this);
            addStockFrom.Show();
        }
    }
}
