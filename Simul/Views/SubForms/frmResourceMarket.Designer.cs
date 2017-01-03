namespace Simul.Views.SubForms
{
    partial class frmResourceMarket
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
            this.dlvResources = new BrightIdeasSoftware.DataListView();
            this.olvResourceMarketImg = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvResourceMarketSeller = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvResourceMarketQuantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvResourceMarketPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvResourceMarketBuy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.dlvResources)).BeginInit();
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
            // dlvResources
            // 
            this.dlvResources.AllColumns.Add(this.olvResourceMarketImg);
            this.dlvResources.AllColumns.Add(this.olvResourceMarketSeller);
            this.dlvResources.AllColumns.Add(this.olvResourceMarketQuantity);
            this.dlvResources.AllColumns.Add(this.olvResourceMarketPrice);
            this.dlvResources.AllColumns.Add(this.olvResourceMarketBuy);
            this.dlvResources.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dlvResources.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.dlvResources.CellEditUseWholeCell = false;
            this.dlvResources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvResourceMarketImg,
            this.olvResourceMarketSeller,
            this.olvResourceMarketQuantity,
            this.olvResourceMarketPrice,
            this.olvResourceMarketBuy});
            this.dlvResources.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvResources.DataSource = null;
            this.dlvResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlvResources.FullRowSelect = true;
            this.dlvResources.GridLines = true;
            this.dlvResources.Location = new System.Drawing.Point(12, 52);
            this.dlvResources.Name = "dlvResources";
            this.dlvResources.Size = new System.Drawing.Size(582, 472);
            this.dlvResources.TabIndex = 5;
            this.dlvResources.UseCompatibleStateImageBehavior = false;
            this.dlvResources.View = System.Windows.Forms.View.Details;
            // 
            // olvResourceMarketImg
            // 
            this.olvResourceMarketImg.FillsFreeSpace = true;
            this.olvResourceMarketImg.Groupable = false;
            this.olvResourceMarketImg.IsEditable = false;
            this.olvResourceMarketImg.Text = "Resource";
            this.olvResourceMarketImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvResourceMarketImg.Width = 97;
            // 
            // olvResourceMarketSeller
            // 
            this.olvResourceMarketSeller.AspectName = "owner.name";
            this.olvResourceMarketSeller.FillsFreeSpace = true;
            this.olvResourceMarketSeller.Groupable = false;
            this.olvResourceMarketSeller.IsEditable = false;
            this.olvResourceMarketSeller.Text = "Seller";
            this.olvResourceMarketSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvResourceMarketQuantity
            // 
            this.olvResourceMarketQuantity.AspectName = "quantity";
            this.olvResourceMarketQuantity.FillsFreeSpace = true;
            this.olvResourceMarketQuantity.Groupable = false;
            this.olvResourceMarketQuantity.IsEditable = false;
            this.olvResourceMarketQuantity.Text = "Quantity";
            this.olvResourceMarketQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvResourceMarketQuantity.Width = 90;
            // 
            // olvResourceMarketPrice
            // 
            this.olvResourceMarketPrice.AspectName = "unitPrice";
            this.olvResourceMarketPrice.AspectToStringFormat = "{0:C}";
            this.olvResourceMarketPrice.FillsFreeSpace = true;
            this.olvResourceMarketPrice.Groupable = false;
            this.olvResourceMarketPrice.IsEditable = false;
            this.olvResourceMarketPrice.Text = "Price per unit";
            this.olvResourceMarketPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvResourceMarketPrice.Width = 120;
            // 
            // olvResourceMarketBuy
            // 
            this.olvResourceMarketBuy.AspectName = "unitPrice";
            this.olvResourceMarketBuy.AspectToStringFormat = "Buy";
            this.olvResourceMarketBuy.FillsFreeSpace = true;
            this.olvResourceMarketBuy.Groupable = false;
            this.olvResourceMarketBuy.IsButton = true;
            this.olvResourceMarketBuy.Text = "";
            this.olvResourceMarketBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmResourceMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 534);
            this.Controls.Add(this.cboResourceMarkets);
            this.Controls.Add(this.dlvResources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResourceMarket";
            this.Text = "frmResourceMarket";
            ((System.ComponentModel.ISupportInitialize)(this.dlvResources)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboResourceMarkets;
        private BrightIdeasSoftware.DataListView dlvResources;
        private BrightIdeasSoftware.OLVColumn olvResourceMarketImg;
        private BrightIdeasSoftware.OLVColumn olvResourceMarketSeller;
        private BrightIdeasSoftware.OLVColumn olvResourceMarketQuantity;
        private BrightIdeasSoftware.OLVColumn olvResourceMarketPrice;
        private BrightIdeasSoftware.OLVColumn olvResourceMarketBuy;
    }
}