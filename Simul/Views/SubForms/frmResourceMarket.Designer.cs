namespace Simul.Views.SubForms
{
    partial class FrmResourceMarket
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
            this.cboResourceMarkets = new System.Windows.Forms.ComboBox();
            this.olvResources = new BrightIdeasSoftware.ObjectListView();
            this.olvResourceImg = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSeller = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvQuantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPricePerUnit = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvBuy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvResources)).BeginInit();
            this.SuspendLayout();
            // 
            // cboResourceMarkets
            // 
            this.cboResourceMarkets.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboResourceMarkets.FormattingEnabled = true;
            this.cboResourceMarkets.Location = new System.Drawing.Point(12, 9);
            this.cboResourceMarkets.Name = "cboResourceMarkets";
            this.cboResourceMarkets.Size = new System.Drawing.Size(393, 37);
            this.cboResourceMarkets.TabIndex = 6;
            this.cboResourceMarkets.SelectedIndexChanged += new System.EventHandler(this.cboResourceMarkets_SelectedIndexChanged);
            // 
            // olvResources
            // 
            this.olvResources.AllColumns.Add(this.olvResourceImg);
            this.olvResources.AllColumns.Add(this.olvSeller);
            this.olvResources.AllColumns.Add(this.olvQuantity);
            this.olvResources.AllColumns.Add(this.olvPricePerUnit);
            this.olvResources.AllColumns.Add(this.olvBuy);
            this.olvResources.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvResources.CellEditUseWholeCell = false;
            this.olvResources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvResourceImg,
            this.olvSeller,
            this.olvQuantity,
            this.olvPricePerUnit,
            this.olvBuy});
            this.olvResources.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvResources.FullRowSelect = true;
            this.olvResources.GridLines = true;
            this.olvResources.Location = new System.Drawing.Point(12, 52);
            this.olvResources.Name = "olvResources";
            this.olvResources.Size = new System.Drawing.Size(950, 470);
            this.olvResources.TabIndex = 7;
            this.olvResources.UseCompatibleStateImageBehavior = false;
            this.olvResources.View = System.Windows.Forms.View.Details;
            // 
            // olvResourceImg
            // 
            this.olvResourceImg.FillsFreeSpace = true;
            this.olvResourceImg.Groupable = false;
            this.olvResourceImg.IsEditable = false;
            this.olvResourceImg.Text = "Resource";
            this.olvResourceImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvSeller
            // 
            this.olvSeller.AspectName = "Owner.Name";
            this.olvSeller.FillsFreeSpace = true;
            this.olvSeller.Groupable = false;
            this.olvSeller.IsEditable = false;
            this.olvSeller.Text = "Seller";
            this.olvSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvQuantity
            // 
            this.olvQuantity.AspectName = "Quantity";
            this.olvQuantity.FillsFreeSpace = true;
            this.olvQuantity.Groupable = false;
            this.olvQuantity.IsEditable = false;
            this.olvQuantity.Text = "Quantity";
            this.olvQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvPricePerUnit
            // 
            this.olvPricePerUnit.AspectName = "UnitPrice";
            this.olvPricePerUnit.AspectToStringFormat = "{0:C}";
            this.olvPricePerUnit.FillsFreeSpace = true;
            this.olvPricePerUnit.Groupable = false;
            this.olvPricePerUnit.IsEditable = false;
            this.olvPricePerUnit.Text = "Price per unit";
            this.olvPricePerUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvBuy
            // 
            this.olvBuy.FillsFreeSpace = true;
            this.olvBuy.Groupable = false;
            this.olvBuy.IsButton = true;
            this.olvBuy.Text = "";
            this.olvBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmResourceMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 534);
            this.Controls.Add(this.olvResources);
            this.Controls.Add(this.cboResourceMarkets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResourceMarket";
            this.Text = "frmResourceMarket";
            ((System.ComponentModel.ISupportInitialize)(this.olvResources)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboResourceMarkets;
        private BrightIdeasSoftware.ObjectListView olvResources;
        private BrightIdeasSoftware.OLVColumn olvResourceImg;
        private BrightIdeasSoftware.OLVColumn olvSeller;
        private BrightIdeasSoftware.OLVColumn olvQuantity;
        private BrightIdeasSoftware.OLVColumn olvPricePerUnit;
        private BrightIdeasSoftware.OLVColumn olvBuy;
    }
}