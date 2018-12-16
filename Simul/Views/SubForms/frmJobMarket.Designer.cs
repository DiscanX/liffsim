namespace Simul.Views.SubForms
{
    partial class FrmJobMarket
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
            this.olvApply = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cboJobMarkets = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.olvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // olvJobs
            // 
            this.olvJobs.AllColumns.Add(this.olvResourceImg);
            this.olvJobs.AllColumns.Add(this.olvCompany);
            this.olvJobs.AllColumns.Add(this.olvSalary);
            this.olvJobs.AllColumns.Add(this.olvApply);
            this.olvJobs.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvJobs.CellEditUseWholeCell = false;
            this.olvJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvResourceImg,
            this.olvCompany,
            this.olvSalary,
            this.olvApply});
            this.olvJobs.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvJobs.FullRowSelect = true;
            this.olvJobs.GridLines = true;
            this.olvJobs.Location = new System.Drawing.Point(12, 52);
            this.olvJobs.Name = "olvJobs";
            this.olvJobs.Size = new System.Drawing.Size(950, 470);
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
            this.olvCompany.AspectName = "Employer.Name";
            this.olvCompany.FillsFreeSpace = true;
            this.olvCompany.Groupable = false;
            this.olvCompany.IsEditable = false;
            this.olvCompany.Text = "Employer";
            this.olvCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvSalary
            // 
            this.olvSalary.AspectName = "Salary";
            this.olvSalary.AspectToStringFormat = "{0:C}";
            this.olvSalary.FillsFreeSpace = true;
            this.olvSalary.Groupable = false;
            this.olvSalary.IsEditable = false;
            this.olvSalary.Text = "Salary";
            this.olvSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvApply
            // 
            this.olvApply.FillsFreeSpace = true;
            this.olvApply.Groupable = false;
            this.olvApply.IsButton = true;
            this.olvApply.Text = "";
            this.olvApply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboJobMarkets
            // 
            this.cboJobMarkets.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboJobMarkets.FormattingEnabled = true;
            this.cboJobMarkets.Location = new System.Drawing.Point(12, 9);
            this.cboJobMarkets.Name = "cboJobMarkets";
            this.cboJobMarkets.Size = new System.Drawing.Size(393, 37);
            this.cboJobMarkets.TabIndex = 9;
            this.cboJobMarkets.SelectedIndexChanged += new System.EventHandler(this.cboJobMarkets_SelectedIndexChanged);
            // 
            // frmJobMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 534);
            this.Controls.Add(this.cboJobMarkets);
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
        private BrightIdeasSoftware.OLVColumn olvApply;
        private System.Windows.Forms.ComboBox cboJobMarkets;
    }
}