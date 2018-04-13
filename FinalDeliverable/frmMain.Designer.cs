namespace FinalDeliverable
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstStaffList = new System.Windows.Forms.ListBox();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAddStaffMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStaffList
            // 
            this.lstStaffList.FormattingEnabled = true;
            this.lstStaffList.Location = new System.Drawing.Point(25, 36);
            this.lstStaffList.Name = "lstStaffList";
            this.lstStaffList.Size = new System.Drawing.Size(279, 147);
            this.lstStaffList.TabIndex = 0;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(25, 210);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(68, 24);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(99, 221);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "lblError";
            // 
            // btnAddStaffMember
            // 
            this.btnAddStaffMember.Location = new System.Drawing.Point(334, 36);
            this.btnAddStaffMember.Name = "btnAddStaffMember";
            this.btnAddStaffMember.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaffMember.TabIndex = 3;
            this.btnAddStaffMember.Text = "Add Staff Member";
            this.btnAddStaffMember.UseVisualStyleBackColor = true;
            this.btnAddStaffMember.Click += new System.EventHandler(this.btnAddStaffMember_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 286);
            this.Controls.Add(this.btnAddStaffMember);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.lstStaffList);
            this.Name = "frmMain";
            this.Text = "Back Office";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStaffList;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAddStaffMember;
    }
}

