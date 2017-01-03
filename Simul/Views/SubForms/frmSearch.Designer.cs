namespace Simul.Views.SubForms
{
    partial class frmSearch
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
            this.dlvInventory = new BrightIdeasSoftware.DataListView();
            this.dlvSkills = new BrightIdeasSoftware.DataListView();
            this.olvSkillName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSkillValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPersons = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dlvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvSkills)).BeginInit();
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
            // dlvInventory
            // 
            this.dlvInventory.CellEditUseWholeCell = false;
            this.dlvInventory.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvInventory.DataSource = null;
            this.dlvInventory.Location = new System.Drawing.Point(498, 181);
            this.dlvInventory.Name = "dlvInventory";
            this.dlvInventory.Size = new System.Drawing.Size(470, 336);
            this.dlvInventory.TabIndex = 17;
            this.dlvInventory.UseCompatibleStateImageBehavior = false;
            this.dlvInventory.View = System.Windows.Forms.View.Details;
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
            this.dlvSkills.Location = new System.Drawing.Point(206, 181);
            this.dlvSkills.Name = "dlvSkills";
            this.dlvSkills.Size = new System.Drawing.Size(286, 336);
            this.dlvSkills.TabIndex = 16;
            this.dlvSkills.UseCompatibleStateImageBehavior = false;
            this.dlvSkills.View = System.Windows.Forms.View.Details;
            // 
            // olvSkillName
            // 
            this.olvSkillName.AspectName = "Key.name";
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
            this.txtName.Size = new System.Drawing.Size(100, 28);
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
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 534);
            this.Controls.Add(this.txtStrengthPanSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dlvInventory);
            this.Controls.Add(this.dlvSkills);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPersons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dlvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvSkills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStrengthPanSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private BrightIdeasSoftware.DataListView dlvInventory;
        private BrightIdeasSoftware.DataListView dlvSkills;
        private BrightIdeasSoftware.OLVColumn olvSkillName;
        private BrightIdeasSoftware.OLVColumn olvSkillValue;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPersons;
    }
}