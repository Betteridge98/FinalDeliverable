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
    public partial class frmMain : Form
    {
        clsStaffCollection staffCollection;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            //call the display staff function
            lblError.Text = DisplayStaff() + "found";
        }

        Int32 DisplayStaff()
        {
            //create an instance of the staff collection
            clsStaffCollection MyList = new clsStaffCollection();
            //find all staff 
            MyList.FindAllStaff();
            //set the data source of the list box
            lstStaffList.DataSource = MyList.StaffList;
            //set the text to be displayed
            lstStaffList.DisplayMember = "FirstName";
            //set the primary key value
            lstStaffList.ValueMember = "StaffNo";
            //return the count of records in the list
            return MyList.Count;

        }

        private void btnAddStaffMember_Click(object sender, EventArgs e)
        {
            //create a new instance of the Staff Add class
            frmStaffAdd addStaffFrom = new frmStaffAdd(staffCollection, this);
            addStaffFrom.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
