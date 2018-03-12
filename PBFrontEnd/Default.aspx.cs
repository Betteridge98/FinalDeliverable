using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;//add your namespace here

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnPopulate_Click(object sender, EventArgs e)
    {
        //call the display sales function
        lblError.Text = DisplaySaleItems() + " found";
    }

    Int32 DisplaySaleItems()
    {
        //create an instance of the sales collection
        clsSaleCollection MySales = new clsSaleCollection();
        //find all sales
        MySales.FindAllSaleItems();
        //set the data source of the list box
        lstSaleItems.DataSource = MySales.SaleItems;
        //set the text, primary key to be displayed
        lstSaleItems.DataValueField = "ItemID";
        //set the text to be displayed
        lstSaleItems.DataTextField = "ItemPrice";
        //bind the data
        lstSaleItems.DataBind();
        //return the count of records in the list
        return MySales.Count;
    }
}