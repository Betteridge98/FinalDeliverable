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
    public partial class frmStaffAdd : Form
    {
        clsStaffCollection staffCollection;
        frmMain formMain;
        public frmStaffAdd(clsStaffCollection staffCollection, frmMain frmMain)
        {
            InitializeComponent();

            this.staffCollection = staffCollection;
            formMain = frmMain;

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            clsStaffCollection Staff = new clsStaffCollection();
            clsStaff NewStaff = new clsStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 1;
            NewStaff.StaffNo = Convert.ToInt32(txtStaffNo.Text);
            NewStaff.FirstName = Convert.ToString(txtFirstName.Text);
            NewStaff.LastName = Convert.ToString(txtLastName.Text);
            NewStaff.Email = Convert.ToString(txtEmail.Text);
            NewStaff.PhoneNo = Convert.ToString(txtPhoneNo.Text);
            Staff.ThisStaff = NewStaff;
            //add the record
            PrimaryKey = Staff.Add();
            this.Close();
        }
    }
}
