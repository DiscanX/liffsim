namespace Simul.Views.SubForms
{
    partial class frmJobMarket
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
            this.olvJobs = new BrightIdeasSoftware.ObjectListView();
            this.olvResourceImg = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvCompany = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSalary = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvBuy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cboResourceMarkets = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.olvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // olvJobs
            // 
            this.olvJobs.AllColumns.Add(this.olvResourceImg);
            this.olvJobs.AllColumns.Add(this.olvCompany);
            this.olvJobs.AllColumns.Add(this.olvSalary);
            this.olvJobs.AllColumns.Add(this.olvBuy);
            this.olvJobs.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvJobs.CellEditUseWholeCell = false;
            this.olvJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvResourceImg,
            this.olvCompany,
            this.olvSalary,
            this.olvBuy});
            this.olvJobs.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvJobs.FullRowSelect = true;
            this.olvJobs.GridLines = true;
            this.olvJobs.Location = new System.Drawing.Point(12, 52);
            this.olvJobs.Name = "olvJobs";
            this.olvJobs.Size = new System.Drawing.Size(567, 470);
            this.olvJobs.TabIndex = 8;
            this.olvJobs.UseCompatibleStateImageBehavior = false;
            this.olvJobs.View = System.Windows.Forms.View.Details;
            // 
            // olvResourceImg
            // 
            this.olvResourceImg.FillsFreeSpace = true;
            this.olvResourceImg.Groupable = false;
            this.olvResourceImg.IsEditable = false;
            this.olvResourceImg.Text = "Resource";
            this.olvResourceImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvCompany
            // 
            this.olvCompany.AspectName = "owner.name";
            this.olvCompany.FillsFreeSpace = true;
            this.olvCompany.Groupable = false;
            this.olvCompany.IsEditable = false;
            this.olvCompany.Text = "Employer";
            this.olvCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvSalary
            // 
            this.olvSalary.AspectName = "quantity";
            this.olvSalary.FillsFreeSpace = true;
            this.olvSalary.Groupable = false;
            this.olvSalary.IsEditable = false;
            this.olvSalary.Text = "Salary";
            this.olvSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvBuy
            // 
            this.olvBuy.Groupable = false;
            this.olvBuy.IsButton = true;
            this.olvBuy.MaximumWidth = 60;
            this.olvBuy.MinimumWidth = 60;
            this.olvBuy.Text = "";
            this.olvBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboResourceMarkets
            // 
            this.cboResourceMarkets.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboResourceMarkets.FormattingEnabled = true;
            this.cboResourceMarkets.Location = new System.Drawing.Point(12, 9);
            this.cboResourceMarkets.Name = "cboResourceMarkets";
            this.cboResourceMarkets.Size = new System.Drawing.Size(393, 37);
            this.cboResourceMarkets.TabIndex = 9;
            // 
            // frmJobMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 534);
            this.Controls.Add(this.cboResourceMarkets);
            this.Controls.Add(this.olvJobs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJobMarket";
            this.Text = "frmJobMarket";
            ((System.ComponentModel.ISupportInitialize)(this.olvJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvJobs;
        private BrightIdeasSoftware.OLVColumn olvResourceImg;
        private BrightIdeasSoftware.OLVColumn olvCompany;
        private BrightIdeasSoftware.OLVColumn olvSalary;
        private BrightIdeasSoftware.OLVColumn olvBuy;
        private System.Windows.Forms.ComboBox cboResourceMarkets;
    }
}