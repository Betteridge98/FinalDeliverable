namespace FinalDeliverable
{
    partial class frmSales
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
            this.lstSales = new System.Windows.Forms.ListBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblFilterSales = new System.Windows.Forms.Label();
            this.lblFilterSaleID = new System.Windows.Forms.Label();
            this.txtFilterSaleID = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnArchiveSale = new System.Windows.Forms.Button();
            this.btnDeleteSale = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnEditSale = new System.Windows.Forms.Button();
            this.txtDeleteItemID = new System.Windows.Forms.TextBox();
            this.lblDeleteItemID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSales
            // 
            this.lstSales.FormattingEnabled = true;
            this.lstSales.Location = new System.Drawing.Point(12, 95);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(344, 238);
            this.lstSales.TabIndex = 0;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(169, 26);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 367);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 2;
            // 
            // lblFilterSales
            // 
            this.lblFilterSales.AutoSize = true;
            this.lblFilterSales.Location = new System.Drawing.Point(12, 9);
            this.lblFilterSales.Name = "lblFilterSales";
            this.lblFilterSales.Size = new System.Drawing.Size(58, 13);
            this.lblFilterSales.TabIndex = 3;
            this.lblFilterSales.Text = "Filter Sales";
            // 
            // lblFilterSaleID
            // 
            this.lblFilterSaleID.AutoSize = true;
            this.lblFilterSaleID.Location = new System.Drawing.Point(12, 31);
            this.lblFilterSaleID.Name = "lblFilterSaleID";
            this.lblFilterSaleID.Size = new System.Drawing.Size(45, 13);
            this.lblFilterSaleID.TabIndex = 4;
            this.lblFilterSaleID.Text = "Sale ID:";
            // 
            // txtFilterSaleID
            // 
            this.txtFilterSaleID.Location = new System.Drawing.Point(63, 28);
            this.txtFilterSaleID.Name = "txtFilterSaleID";
            this.txtFilterSaleID.Size = new System.Drawing.Size(100, 20);
            this.txtFilterSaleID.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(88, 54);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnArchiveSale
            // 
            this.btnArchiveSale.Location = new System.Drawing.Point(113, 339);
            this.btnArchiveSale.Name = "btnArchiveSale";
            this.btnArchiveSale.Size = new System.Drawing.Size(151, 23);
            this.btnArchiveSale.TabIndex = 7;
            this.btnArchiveSale.Text = "Archive Sale";
            this.btnArchiveSale.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSale
            // 
            this.btnDeleteSale.Location = new System.Drawing.Point(293, 407);
            this.btnDeleteSale.Name = "btnDeleteSale";
            this.btnDeleteSale.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteSale.TabIndex = 8;
            this.btnDeleteSale.Text = "Delete Sale";
            this.btnDeleteSale.UseVisualStyleBackColor = true;
            this.btnDeleteSale.Click += new System.EventHandler(this.btnDeleteSale_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(362, 95);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(75, 23);
            this.btnAddSale.TabIndex = 9;
            this.btnAddSale.Text = "Add Sale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnEditSale
            // 
            this.btnEditSale.Location = new System.Drawing.Point(362, 124);
            this.btnEditSale.Name = "btnEditSale";
            this.btnEditSale.Size = new System.Drawing.Size(75, 23);
            this.btnEditSale.TabIndex = 10;
            this.btnEditSale.Text = "Edit Sale";
            this.btnEditSale.UseVisualStyleBackColor = true;
            // 
            // txtDeleteItemID
            // 
            this.txtDeleteItemID.Location = new System.Drawing.Point(187, 409);
            this.txtDeleteItemID.Name = "txtDeleteItemID";
            this.txtDeleteItemID.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteItemID.TabIndex = 11;
            // 
            // lblDeleteItemID
            // 
            this.lblDeleteItemID.AutoSize = true;
            this.lblDeleteItemID.Location = new System.Drawing.Point(93, 412);
            this.lblDeleteItemID.Name = "lblDeleteItemID";
            this.lblDeleteItemID.Size = new System.Drawing.Size(88, 13);
            this.lblDeleteItemID.TabIndex = 12;
            this.lblDeleteItemID.Text = "Item ID to delete:";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 442);
            this.Controls.Add(this.lblDeleteItemID);
            this.Controls.Add(this.txtDeleteItemID);
            this.Controls.Add(this.btnEditSale);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.btnDeleteSale);
            this.Controls.Add(this.btnArchiveSale);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtFilterSaleID);
            this.Controls.Add(this.lblFilterSaleID);
            this.Controls.Add(this.lblFilterSales);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.lstSales);
            this.Name = "frmSales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSales;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblFilterSales;
        private System.Windows.Forms.Label lblFilterSaleID;
        private System.Windows.Forms.TextBox txtFilterSaleID;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnArchiveSale;
        private System.Windows.Forms.Button btnDeleteSale;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnEditSale;
        private System.Windows.Forms.TextBox txtDeleteItemID;
        private System.Windows.Forms.Label lblDeleteItemID;
    }
}