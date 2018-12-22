namespace Simul.Views.SubForms
{
    partial class FrmHome
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
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.txtCurrentEmployer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResign = new System.Windows.Forms.Button();
            this.btnAutoWork = new System.Windows.Forms.Button();
            this.btnAutoTrain = new System.Windows.Forms.Button();
            this.lstControlledPersonActions = new System.Windows.Forms.ListBox();
            this.btnGetBestJob = new System.Windows.Forms.Button();
            this.olvInventory = new BrightIdeasSoftware.ObjectListView();
            this.olvResourceImg = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvQuantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dlvSkills = new BrightIdeasSoftware.DataListView();
            this.olvSkillName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSkillValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnAutoEat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.olvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvSkills)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStrength
            // 
            this.txtStrength.BackColor = System.Drawing.SystemColors.Control;
            this.txtStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrength.Location = new System.Drawing.Point(101, 22);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.ReadOnly = true;
            this.txtStrength.Size = new System.Drawing.Size(100, 19);
            this.txtStrength.TabIndex = 17;
            this.txtStrength.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Strength : ";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(16, 58);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 40);
            this.btnTrain.TabIndex = 14;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(211, 58);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(75, 40);
            this.btnWork.TabIndex = 13;
            this.btnWork.Text = "Work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // txtCurrentEmployer
            // 
            this.txtCurrentEmployer.BackColor = System.Drawing.SystemColors.Control;
            this.txtCurrentEmployer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentEmployer.Location = new System.Drawing.Point(310, 22);
            this.txtCurrentEmployer.Name = "txtCurrentEmployer";
            this.txtCurrentEmployer.ReadOnly = true;
            this.txtCurrentEmployer.Size = new System.Drawing.Size(233, 19);
            this.txtCurrentEmployer.TabIndex = 19;
            this.txtCurrentEmployer.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Working at : ";
            // 
            // btnResign
            // 
            this.btnResign.Location = new System.Drawing.Point(292, 58);
            this.btnResign.Name = "btnResign";
            this.btnResign.Size = new System.Drawing.Size(75, 40);
            this.btnResign.TabIndex = 21;
            this.btnResign.Text = "Resign";
            this.btnResign.UseVisualStyleBackColor = true;
            this.btnResign.Click += new System.EventHandler(this.btnResign_Click);
            // 
            // btnAutoWork
            // 
            this.btnAutoWork.Location = new System.Drawing.Point(493, 12);
            this.btnAutoWork.Name = "btnAutoWork";
            this.btnAutoWork.Size = new System.Drawing.Size(119, 40);
            this.btnAutoWork.TabIndex = 22;
            this.btnAutoWork.Text = "Enable auto work";
            this.btnAutoWork.UseVisualStyleBackColor = true;
            this.btnAutoWork.Click += new System.EventHandler(this.btnAutoWork_Click);
            // 
            // btnAutoTrain
            // 
            this.btnAutoTrain.Location = new System.Drawing.Point(493, 58);
            this.btnAutoTrain.Name = "btnAutoTrain";
            this.btnAutoTrain.Size = new System.Drawing.Size(119, 40);
            this.btnAutoTrain.TabIndex = 23;
            this.btnAutoTrain.Text = "Enable auto train";
            this.btnAutoTrain.UseVisualStyleBackColor = true;
            this.btnAutoTrain.Click += new System.EventHandler(this.btnAutoTrain_Click);
            // 
            // lstControlledPersonActions
            // 
            this.lstControlledPersonActions.FormattingEnabled = true;
            this.lstControlledPersonActions.Location = new System.Drawing.Point(618, 12);
            this.lstControlledPersonActions.Name = "lstControlledPersonActions";
            this.lstControlledPersonActions.Size = new System.Drawing.Size(344, 511);
            this.lstControlledPersonActions.TabIndex = 24;
            // 
            // btnGetBestJob
            // 
            this.btnGetBestJob.Location = new System.Drawing.Point(211, 104);
            this.btnGetBestJob.Name = "btnGetBestJob";
            this.btnGetBestJob.Size = new System.Drawing.Size(156, 40);
            this.btnGetBestJob.TabIndex = 25;
            this.btnGetBestJob.Text = "Get best job";
            this.btnGetBestJob.UseVisualStyleBackColor = true;
            this.btnGetBestJob.Click += new System.EventHandler(this.btnGetBestJob_Click);
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
            this.olvInventory.Location = new System.Drawing.Point(12, 187);
            this.olvInventory.Name = "olvInventory";
            this.olvInventory.Size = new System.Drawing.Size(247, 336);
            this.olvInventory.TabIndex = 27;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 29;
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
            this.dlvSkills.Location = new System.Drawing.Point(265, 186);
            this.dlvSkills.Name = "dlvSkills";
            this.dlvSkills.Size = new System.Drawing.Size(286, 336);
            this.dlvSkills.TabIndex = 28;
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
            // btnAutoEat
            // 
            this.btnAutoEat.Location = new System.Drawing.Point(493, 104);
            this.btnAutoEat.Name = "btnAutoEat";
            this.btnAutoEat.Size = new System.Drawing.Size(119, 40);
            this.btnAutoEat.TabIndex = 30;
            this.btnAutoEat.Text = "Enable auto eat";
            this.btnAutoEat.UseVisualStyleBackColor = true;
            this.btnAutoEat.Click += new System.EventHandler(this.btnAutoEat_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 534);
            this.Controls.Add(this.btnAutoEat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dlvSkills);
            this.Controls.Add(this.olvInventory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGetBestJob);
            this.Controls.Add(this.lstControlledPersonActions);
            this.Controls.Add(this.btnAutoTrain);
            this.Controls.Add(this.btnAutoWork);
            this.Controls.Add(this.btnResign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurrentEmployer);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnWork);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.olvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvSkills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.TextBox txtCurrentEmployer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResign;
        private System.Windows.Forms.Button btnAutoWork;
        private System.Windows.Forms.Button btnAutoTrain;
        private System.Windows.Forms.ListBox lstControlledPersonActions;
        private System.Windows.Forms.Button btnGetBestJob;
        private BrightIdeasSoftware.ObjectListView olvInventory;
        private BrightIdeasSoftware.OLVColumn olvResourceImg;
        private BrightIdeasSoftware.OLVColumn olvQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private BrightIdeasSoftware.DataListView dlvSkills;
        private BrightIdeasSoftware.OLVColumn olvSkillName;
        private BrightIdeasSoftware.OLVColumn olvSkillValue;
        private System.Windows.Forms.Button btnAutoEat;
    }
}