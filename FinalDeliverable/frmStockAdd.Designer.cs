namespace FinalDeliverable
{
    partial class frmStockAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtAgeRate = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblInStock = new System.Windows.Forms.Label();
            this.chkInStock = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Location = new System.Drawing.Point(12, 45);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(44, 13);
            this.lblItemNo.TabIndex = 1;
            this.lblItemNo.Text = "ItemNo:";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(72, 42);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(100, 20);
            this.txtItemNo.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 26);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(72, 120);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 4;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(72, 146);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(100, 20);
            this.txtCondition.TabIndex = 5;
            // 
            // txtAgeRate
            // 
            this.txtAgeRate.Location = new System.Drawing.Point(72, 94);
            this.txtAgeRate.Name = "txtAgeRate";
            this.txtAgeRate.Size = new System.Drawing.Size(100, 20);
            this.txtAgeRate.TabIndex = 6;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(72, 68);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 7;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(12, 71);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 8;
            this.lblItemName.Text = "ItemName:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 97);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(60, 13);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "AgeRating:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 123);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(39, 13);
            this.lblGenre.TabIndex = 10;
            this.lblGenre.Text = "Genre:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(12, 149);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(54, 13);
            this.lblCondition.TabIndex = 11;
            this.lblCondition.Text = "Condition:";
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Location = new System.Drawing.Point(12, 174);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(50, 13);
            this.lblInStock.TabIndex = 12;
            this.lblInStock.Text = "InStock?";
            // 
            // chkInStock
            // 
            this.chkInStock.AutoSize = true;
            this.chkInStock.Location = new System.Drawing.Point(72, 174);
            this.chkInStock.Name = "chkInStock";
            this.chkInStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkInStock.Size = new System.Drawing.Size(15, 14);
            this.chkInStock.TabIndex = 13;
            this.chkInStock.UseVisualStyleBackColor = true;
            // 
            // frmStockAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 256);
            this.Controls.Add(this.chkInStock);
            this.Controls.Add(this.lblInStock);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtAgeRate);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.lblItemNo);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmStockAdd";
            this.Text = "frmStockAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtAgeRate;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.CheckBox chkInStock;
    }
}