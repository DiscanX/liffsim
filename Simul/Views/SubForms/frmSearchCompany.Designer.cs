namespace Simul.Views.SubForms
{
    partial class FrmSearchCompany
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
            this.lstCompanies = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dlvEmployees = new BrightIdeasSoftware.DataListView();
            this.olvName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSkill = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvInventory = new BrightIdeasSoftware.ObjectListView();
            this.olvResourceImg = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvQuantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.picResource = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dlvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCompanies
            // 
            this.lstCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCompanies.FormattingEnabled = true;
            this.lstCompanies.ItemHeight = 16;
            this.lstCompanies.Location = new System.Drawing.Point(6, 17);
            this.lstCompanies.Name = "lstCompanies";
            this.lstCompanies.Size = new System.Drawing.Size(189, 500);
            this.lstCompanies.TabIndex = 13;
            this.lstCompanies.SelectedIndexChanged += new System.EventHandler(this.lstCompanies_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(235, 17);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(727, 28);
            this.txtName.TabIndex = 15;
            this.txtName.Text = "---";
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.Control;
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(206, 91);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(100, 19);
            this.txtMoney.TabIndex = 17;
            this.txtMoney.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Money";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Employees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(558, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Inventory";
            // 
            // dlvEmployees
            // 
            this.dlvEmployees.AllColumns.Add(this.olvName);
            this.dlvEmployees.AllColumns.Add(this.olvSkill);
            this.dlvEmployees.CellEditUseWholeCell = false;
            this.dlvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvName,
            this.olvSkill});
            this.dlvEmployees.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvEmployees.DataSource = null;
            this.dlvEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dlvEmployees.Location = new System.Drawing.Point(206, 180);
            this.dlvEmployees.Name = "dlvEmployees";
            this.dlvEmployees.Size = new System.Drawing.Size(346, 337);
            this.dlvEmployees.TabIndex = 22;
            this.dlvEmployees.UseCompatibleStateImageBehavior = false;
            this.dlvEmployees.View = System.Windows.Forms.View.Details;
            // 
            // olvName
            // 
            this.olvName.AspectName = "Name";
            this.olvName.FillsFreeSpace = true;
            this.olvName.Groupable = false;
            this.olvName.Sortable = false;
            this.olvName.Text = "Name";
            this.olvName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvSkill
            // 
            this.olvSkill.AspectName = "GetCurrentUsedSkillLevel";
            this.olvSkill.FillsFreeSpace = true;
            this.olvSkill.Groupable = false;
            this.olvSkill.Sortable = false;
            this.olvSkill.Text = "Skill level";
            this.olvSkill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvSkill.Width = 105;
            // 
            // olvInventory
            // 
            this.olvInventory.AllColumns.Add(this.olvResourceImg);
            this.olvInventory.AllColumns.Add(this.olvQuantity);
            this.olvInventory.CellEditUseWholeCell = false;
            this.olvInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvResourceImg,
            this.olvQuantity});
            this.olvInventory.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvInventory.FullRowSelect = true;
            this.olvInventory.GridLines = true;
            this.olvInventory.Location = new System.Drawing.Point(558, 180);
            this.olvInventory.Name = "olvInventory";
            this.olvInventory.Size = new System.Drawing.Size(404, 337);
            this.olvInventory.TabIndex = 23;
            this.olvInventory.UseCompatibleStateImageBehavior = false;
            this.olvInventory.View = System.Windows.Forms.View.Details;
            // 
            // olvResourceImg
            // 
            this.olvResourceImg.FillsFreeSpace = true;
            this.olvResourceImg.Groupable = false;
            this.olvResourceImg.IsEditable = false;
            this.olvResourceImg.Text = "Resource";
            this.olvResourceImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvQuantity
            // 
            this.olvQuantity.AspectName = "Value";
            this.olvQuantity.FillsFreeSpace = true;
            this.olvQuantity.Groupable = false;
            this.olvQuantity.IsEditable = false;
            this.olvQuantity.Text = "Quantity";
            this.olvQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picResource
            // 
            this.picResource.Location = new System.Drawing.Point(201, 17);
            this.picResource.Name = "picResource";
            this.picResource.Size = new System.Drawing.Size(28, 28);
            this.picResource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResource.TabIndex = 24;
            this.picResource.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Current object progress ";
            // 
            // txtProgress
            // 
            this.txtProgress.BackColor = System.Drawing.SystemColors.Control;
            this.txtProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgress.Location = new System.Drawing.Point(316, 91);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ReadOnly = true;
            this.txtProgress.Size = new System.Drawing.Size(100, 19);
            this.txtProgress.TabIndex = 26;
            this.txtProgress.Text = "---";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.Control;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(558, 91);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(100, 19);
            this.txtCountry.TabIndex = 28;
            this.txtCountry.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Country ";
            // 
            // frmSearchCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 534);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picResource);
            this.Controls.Add(this.olvInventory);
            this.Controls.Add(this.dlvEmployees);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstCompanies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchCompany";
            this.Text = "frmSearchCompany";
            ((System.ComponentModel.ISupportInitialize)(this.dlvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCompanies;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private BrightIdeasSoftware.DataListView dlvEmployees;
        private BrightIdeasSoftware.OLVColumn olvName;
        private BrightIdeasSoftware.OLVColumn olvSkill;
        private BrightIdeasSoftware.ObjectListView olvInventory;
        private BrightIdeasSoftware.OLVColumn olvResourceImg;
        private BrightIdeasSoftware.OLVColumn olvQuantity;
        private System.Windows.Forms.PictureBox picResource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
    }
}