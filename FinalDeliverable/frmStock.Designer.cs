namespace FinalDeliverable
{
    partial class frmStock
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
            this.btnPopulate = new System.Windows.Forms.Button();
            this.lstStockList = new System.Windows.Forms.ListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(13, 237);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(122, 39);
            this.btnPopulate.TabIndex = 0;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click_1);
            // 
            // lstStockList
            // 
            this.lstStockList.FormattingEnabled = true;
            this.lstStockList.Location = new System.Drawing.Point(13, 45);
            this.lstStockList.Name = "lstStockList";
            this.lstStockList.Size = new System.Drawing.Size(638, 186);
            this.lstStockList.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(158, 251);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 2;
            // 
            // btnAddPage
            // 
            this.btnAddPage.Location = new System.Drawing.Point(702, 45);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(117, 39);
            this.btnAddPage.TabIndex = 3;
            this.btnAddPage.Text = "Add";
            this.btnAddPage.UseVisualStyleBackColor = true;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 314);
            this.Controls.Add(this.btnAddPage);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lstStockList);
            this.Controls.Add(this.btnPopulate);
            this.Name = "frmStock";
            this.Text = "frmStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.ListBox lstStockList;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAddPage;
    }
}