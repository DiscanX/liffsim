namespace Simul.Views.SubForms
{
    partial class FrmBots
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
            this.lstBots = new System.Windows.Forms.ListBox();
            this.olvParameters = new BrightIdeasSoftware.ObjectListView();
            this.olvParamName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvParamValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstActionHistory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.olvParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBots
            // 
            this.lstBots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBots.FormattingEnabled = true;
            this.lstBots.ItemHeight = 16;
            this.lstBots.Location = new System.Drawing.Point(6, 17);
            this.lstBots.Name = "lstBots";
            this.lstBots.Size = new System.Drawing.Size(189, 500);
            this.lstBots.TabIndex = 14;
            this.lstBots.SelectedIndexChanged += new System.EventHandler(this.lstBots_SelectedIndexChanged);
            // 
            // olvParameters
            // 
            this.olvParameters.AllColumns.Add(this.olvParamName);
            this.olvParameters.AllColumns.Add(this.olvParamValue);
            this.olvParameters.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.olvParameters.CellEditUseWholeCell = false;
            this.olvParameters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvParamName,
            this.olvParamValue});
            this.olvParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvParameters.FullRowSelect = true;
            this.olvParameters.GridLines = true;
            this.olvParameters.Location = new System.Drawing.Point(205, 40);
            this.olvParameters.Name = "olvParameters";
            this.olvParameters.Size = new System.Drawing.Size(337, 477);
            this.olvParameters.TabIndex = 15;
            this.olvParameters.UseCompatibleStateImageBehavior = false;
            this.olvParameters.View = System.Windows.Forms.View.Details;
            // 
            // olvParamName
            // 
            this.olvParamName.AspectName = "Key";
            this.olvParamName.FillsFreeSpace = true;
            this.olvParamName.Groupable = false;
            this.olvParamName.IsEditable = false;
            this.olvParamName.Sortable = false;
            this.olvParamName.Text = "Name";
            this.olvParamName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvParamValue
            // 
            this.olvParamValue.AspectName = "Value";
            this.olvParamValue.FillsFreeSpace = true;
            this.olvParamValue.Groupable = false;
            this.olvParamValue.IsEditable = false;
            this.olvParamValue.Sortable = false;
            this.olvParamValue.Text = "Value";
            this.olvParamValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bot parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Action history";
            // 
            // lstActionHistory
            // 
            this.lstActionHistory.FormattingEnabled = true;
            this.lstActionHistory.Location = new System.Drawing.Point(551, 40);
            this.lstActionHistory.Name = "lstActionHistory";
            this.lstActionHistory.Size = new System.Drawing.Size(411, 472);
            this.lstActionHistory.TabIndex = 23;
            // 
            // frmBots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 534);
            this.Controls.Add(this.lstActionHistory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.olvParameters);
            this.Controls.Add(this.lstBots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBots";
            this.Text = "frmBots";
            ((System.ComponentModel.ISupportInitialize)(this.olvParameters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBots;
        private BrightIdeasSoftware.ObjectListView olvParameters;
        private BrightIdeasSoftware.OLVColumn olvParamName;
        private BrightIdeasSoftware.OLVColumn olvParamValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstActionHistory;
    }
}