namespace Simul.Views.SubForms
{
    partial class FrmSearch
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
            this.txtStrengthPanSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dlvSkills = new BrightIdeasSoftware.DataListView();
            this.olvSkillName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSkillValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPersons = new System.Windows.Forms.ListBox();
            this.olvInventory = new BrightIdeasSoftware.ObjectListView();
            this.olvResourceImg = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvQuantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dlvSkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStrengthPanSearch
            // 
            this.txtStrengthPanSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtStrengthPanSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrengthPanSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrengthPanSearch.Location = new System.Drawing.Point(333, 111);
            this.txtStrengthPanSearch.Name = "txtStrengthPanSearch";
            this.txtStrengthPanSearch.ReadOnly = true;
            this.txtStrengthPanSearch.Size = new System.Drawing.Size(100, 19);
            this.txtStrengthPanSearch.TabIndex = 21;
            this.txtStrengthPanSearch.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Strength : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Skills ";
            // 
            // dlvSkills
            // 
            this.dlvSkills.AllColumns.Add(this.olvSkillName);
            this.dlvSkills.AllColumns.Add(this.olvSkillValue);
            this.dlvSkills.CellEditUseWholeCell = false;
            this.dlvSkills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvSkillName,
            this.olvSkillValue});
            this.dlvSkills.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvSkills.DataSource = null;
            this.dlvSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlvSkills.FullRowSelect = true;
            this.dlvSkills.GridLines = true;
            this.dlvSkills.Location = new System.Drawing.Point(206, 181);
            this.dlvSkills.Name = "dlvSkills";
            this.dlvSkills.Size = new System.Drawing.Size(286, 336);
            this.dlvSkills.TabIndex = 16;
            this.dlvSkills.UseCompatibleStateImageBehavior = false;
            this.dlvSkills.View = System.Windows.Forms.View.Details;
            // 
            // olvSkillName
            // 
            this.olvSkillName.AspectName = "Key.Name";
            this.olvSkillName.FillsFreeSpace = true;
            this.olvSkillName.Groupable = false;
            this.olvSkillName.Text = "Name";
            this.olvSkillName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvSkillValue
            // 
            this.olvSkillValue.AspectName = "Value";
            this.olvSkillValue.FillsFreeSpace = true;
            this.olvSkillValue.Groupable = false;
            this.olvSkillValue.Text = "Skill";
            this.olvSkillValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.Control;
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(333, 70);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(100, 19);
            this.txtMoney.TabIndex = 15;
            this.txtMoney.Text = "---";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(206, 17);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(756, 28);
            this.txtName.TabIndex = 14;
            this.txtName.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Money :  ";
            // 
            // lstPersons
            // 
            this.lstPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPersons.FormattingEnabled = true;
            this.lstPersons.ItemHeight = 16;
            this.lstPersons.Location = new System.Drawing.Point(6, 17);
            this.lstPersons.Name = "lstPersons";
            this.lstPersons.Size = new System.Drawing.Size(189, 500);
            this.lstPersons.TabIndex = 12;
            this.lstPersons.SelectedIndexChanged += new System.EventHandler(this.lstPersons_SelectedIndexChanged);
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
            this.olvInventory.Location = new System.Drawing.Point(498, 181);
            this.olvInventory.Name = "olvInventory";
            this.olvInventory.Size = new System.Drawing.Size(464, 336);
            this.olvInventory.TabIndex = 22;
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
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.Control;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(498, 69);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(100, 19);
            this.txtCountry.TabIndex = 24;
            this.txtCountry.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Country : ";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 534);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.olvInventory);
            this.Controls.Add(this.txtStrengthPanSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dlvSkills);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPersons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dlvSkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStrengthPanSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private BrightIdeasSoftware.DataListView dlvSkills;
        private BrightIdeasSoftware.OLVColumn olvSkillName;
        private BrightIdeasSoftware.OLVColumn olvSkillValue;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPersons;
        private BrightIdeasSoftware.ObjectListView olvInventory;
        private BrightIdeasSoftware.OLVColumn olvResourceImg;
        private BrightIdeasSoftware.OLVColumn olvQuantity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label2;
    }
}