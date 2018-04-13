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
    public partial class frmStockAdd : Form
    {
        clsStockCollection stockCollection;
        frmStock formStock;
        public frmStockAdd(clsStockCollection stockCollection, frmStock frmStock)
        {
            InitializeComponent();

            this.stockCollection = stockCollection;
            formStock = frmStock;
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
            clsStockCollection Stock = new clsStockCollection();
            clsStock AddedItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            AddedItem.ItemNo = Convert.ToInt32(txtItemNo.Text);
            AddedItem.ItemName = Convert.ToString(txtItemName.Text);
            AddedItem.AgeRating = Convert.ToInt32(txtAgeRate.Text);
            AddedItem.Genre = Convert.ToString(txtGenre.Text);
            AddedItem.Condition = Convert.ToString(txtCondition.Text);
            Stock.ThisStock = AddedItem;
            //add the record
            PrimaryKey = Stock.Add();
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            clsStockCollection Stock = new clsStockCollection();
            clsStock AddedItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 1;
            AddedItem.ItemNo = Convert.ToInt32(txtItemNo.Text);
            AddedItem.ItemName = Convert.ToString(txtItemName.Text);
            AddedItem.AgeRating = Convert.ToInt32(txtAgeRate.Text);
            AddedItem.Genre = Convert.ToString(txtGenre.Text);
            AddedItem.Condition = Convert.ToString(txtCondition.Text);
            Stock.ThisStock = AddedItem;
            //add the record
            PrimaryKey = Stock.Add();
            this.Close();
        }
    }
}