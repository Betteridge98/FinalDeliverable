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

        }
    }
}
