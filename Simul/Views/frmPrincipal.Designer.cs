namespace Simul.Views
{
    partial class frmPrincipal
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
            this.panPersons = new System.Windows.Forms.Panel();
            this.tllSkills = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tllInventory = new System.Windows.Forms.TableLayoutPanel();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPersons = new System.Windows.Forms.ListBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.panHome = new System.Windows.Forms.Panel();
            this.txtProductivity = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.txtControlledPerson = new System.Windows.Forms.TextBox();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResourceMarket = new System.Windows.Forms.Button();
            this.panResourceMarket = new System.Windows.Forms.Panel();
            this.dlvResources = new BrightIdeasSoftware.DataListView();
            this.olvImgResource = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvSeller = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvQuantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvBuy = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.txtJobMarketName = new System.Windows.Forms.TextBox();
            this.panJobMarket = new System.Windows.Forms.Panel();
            this.btnJobMarket = new System.Windows.Forms.Button();
            this.panPersons.SuspendLayout();
            this.panHome.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panResourceMarket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlvResources)).BeginInit();
            this.SuspendLayout();
            // 
            // panPersons
            // 
            this.panPersons.Controls.Add(this.tllSkills);
            this.panPersons.Controls.Add(this.label5);
            this.panPersons.Controls.Add(this.label4);
            this.panPersons.Controls.Add(this.tllInventory);
            this.panPersons.Controls.Add(this.txtMoney);
            this.panPersons.Controls.Add(this.txtName);
            this.panPersons.Controls.Add(this.label3);
            this.panPersons.Controls.Add(this.label2);
            this.panPersons.Controls.Add(this.label1);
            this.panPersons.Controls.Add(this.lstPersons);
            this.panPersons.Location = new System.Drawing.Point(15, 56);
            this.panPersons.Name = "panPersons";
            this.panPersons.Size = new System.Drawing.Size(971, 534);
            this.panPersons.TabIndex = 0;
            this.panPersons.Visible = false;
            // 
            // tllSkills
            // 
            this.tllSkills.ColumnCount = 1;
            this.tllSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tllSkills.Location = new System.Drawing.Point(213, 365);
            this.tllSkills.Name = "tllSkills";
            this.tllSkills.RowCount = 1;
            this.tllSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tllSkills.Size = new System.Drawing.Size(733, 142);
            this.tllSkills.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Skills :  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inventory :  ";
            // 
            // tllInventory
            // 
            this.tllInventory.ColumnCount = 1;
            this.tllInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tllInventory.Location = new System.Drawing.Point(213, 167);
            this.tllInventory.Name = "tllInventory";
            this.tllInventory.RowCount = 1;
            this.tllInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tllInventory.Size = new System.Drawing.Size(739, 148);
            this.tllInventory.TabIndex = 6;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.Control;
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(324, 95);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(100, 19);
            this.txtMoney.TabIndex = 5;
            this.txtMoney.Text = "---";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(324, 56);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 19);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Money :  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details";
            // 
            // lstPersons
            // 
            this.lstPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPersons.FormattingEnabled = true;
            this.lstPersons.ItemHeight = 16;
            this.lstPersons.Location = new System.Drawing.Point(3, 3);
            this.lstPersons.Name = "lstPersons";
            this.lstPersons.Size = new System.Drawing.Size(189, 500);
            this.lstPersons.TabIndex = 0;
            this.lstPersons.SelectedIndexChanged += new System.EventHandler(this.lstPersonnes_SelectedIndexChanged);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(15, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Location = new System.Drawing.Point(96, 27);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPerson.TabIndex = 2;
            this.btnSearchPerson.Text = "Search";
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // panHome
            // 
            this.panHome.Controls.Add(this.txtProductivity);
            this.panHome.Controls.Add(this.txtStrength);
            this.panHome.Controls.Add(this.label6);
            this.panHome.Controls.Add(this.label7);
            this.panHome.Controls.Add(this.btnTrain);
            this.panHome.Controls.Add(this.btnWork);
            this.panHome.Location = new System.Drawing.Point(12, 56);
            this.panHome.Name = "panHome";
            this.panHome.Size = new System.Drawing.Size(971, 534);
            this.panHome.TabIndex = 9;
            // 
            // txtProductivity
            // 
            this.txtProductivity.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductivity.Location = new System.Drawing.Point(165, 409);
            this.txtProductivity.Name = "txtProductivity";
            this.txtProductivity.ReadOnly = true;
            this.txtProductivity.Size = new System.Drawing.Size(100, 19);
            this.txtProductivity.TabIndex = 12;
            this.txtProductivity.Text = "---";
            // 
            // txtStrength
            // 
            this.txtStrength.BackColor = System.Drawing.SystemColors.Control;
            this.txtStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrength.Location = new System.Drawing.Point(165, 57);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.ReadOnly = true;
            this.txtStrength.Size = new System.Drawing.Size(100, 19);
            this.txtStrength.TabIndex = 11;
            this.txtStrength.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Productivity : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Strength : ";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(334, 167);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 1;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(334, 494);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(75, 23);
            this.btnWork.TabIndex = 0;
            this.btnWork.Text = "Work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // txtControlledPerson
            // 
            this.txtControlledPerson.BackColor = System.Drawing.SystemColors.Control;
            this.txtControlledPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtControlledPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtControlledPerson.Location = new System.Drawing.Point(802, 27);
            this.txtControlledPerson.Name = "txtControlledPerson";
            this.txtControlledPerson.ReadOnly = true;
            this.txtControlledPerson.Size = new System.Drawing.Size(100, 19);
            this.txtControlledPerson.TabIndex = 9;
            this.txtControlledPerson.Text = "---";
            this.txtControlledPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(908, 27);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(75, 23);
            this.btnNextDay.TabIndex = 10;
            this.btnNextDay.Text = "Next day >>";
            this.btnNextDay.UseVisualStyleBackColor = true;
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSimulation});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSimulation
            // 
            this.tsmSimulation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOptions});
            this.tsmSimulation.Name = "tsmSimulation";
            this.tsmSimulation.Size = new System.Drawing.Size(76, 20);
            this.tsmSimulation.Text = "Simulation";
            // 
            // tsmOptions
            // 
            this.tsmOptions.Name = "tsmOptions";
            this.tsmOptions.Size = new System.Drawing.Size(116, 22);
            this.tsmOptions.Text = "Options";
            this.tsmOptions.Click += new System.EventHandler(this.tsmOptions_Click);
            // 
            // btnResourceMarket
            // 
            this.btnResourceMarket.Location = new System.Drawing.Point(177, 27);
            this.btnResourceMarket.Name = "btnResourceMarket";
            this.btnResourceMarket.Size = new System.Drawing.Size(114, 23);
            this.btnResourceMarket.TabIndex = 12;
            this.btnResourceMarket.Text = "Resource market";
            this.btnResourceMarket.UseVisualStyleBackColor = true;
            this.btnResourceMarket.Click += new System.EventHandler(this.btnResourceMarket_Click);
            // 
            // panResourceMarket
            // 
            this.panResourceMarket.Controls.Add(this.dlvResources);
            this.panResourceMarket.Controls.Add(this.txtJobMarketName);
            this.panResourceMarket.Location = new System.Drawing.Point(12, 56);
            this.panResourceMarket.Name = "panResourceMarket";
            this.panResourceMarket.Size = new System.Drawing.Size(974, 534);
            this.panResourceMarket.TabIndex = 13;
            this.panResourceMarket.Visible = false;
            // 
            // dlvResources
            // 
            this.dlvResources.AllColumns.Add(this.olvImgResource);
            this.dlvResources.AllColumns.Add(this.olvSeller);
            this.dlvResources.AllColumns.Add(this.olvQuantity);
            this.dlvResources.AllColumns.Add(this.olvPrice);
            this.dlvResources.AllColumns.Add(this.olvBuy);
            this.dlvResources.CellEditUseWholeCell = false;
            this.dlvResources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvImgResource,
            this.olvSeller,
            this.olvQuantity,
            this.olvPrice,
            this.olvBuy});
            this.dlvResources.Cursor = System.Windows.Forms.Cursors.Default;
            this.dlvResources.DataSource = null;
            this.dlvResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlvResources.FullRowSelect = true;
            this.dlvResources.Location = new System.Drawing.Point(6, 82);
            this.dlvResources.Name = "dlvResources";
            this.dlvResources.Size = new System.Drawing.Size(649, 600);
            this.dlvResources.TabIndex = 3;
            this.dlvResources.UseAlternatingBackColors = true;
            this.dlvResources.UseCompatibleStateImageBehavior = false;
            this.dlvResources.View = System.Windows.Forms.View.Details;
            // 
            // olvImgResource
            // 
            this.olvImgResource.FillsFreeSpace = true;
            this.olvImgResource.Groupable = false;
            this.olvImgResource.Text = "Resource";
            this.olvImgResource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvImgResource.Width = 97;
            // 
            // olvSeller
            // 
            this.olvSeller.AspectName = "owner.name";
            this.olvSeller.FillsFreeSpace = true;
            this.olvSeller.Groupable = false;
            this.olvSeller.Text = "Seller";
            this.olvSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // olvQuantity
            // 
            this.olvQuantity.AspectName = "quantity";
            this.olvQuantity.FillsFreeSpace = true;
            this.olvQuantity.Groupable = false;
            this.olvQuantity.Text = "Quantity";
            this.olvQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvQuantity.Width = 90;
            // 
            // olvPrice
            // 
            this.olvPrice.AspectName = "unitPrice";
            this.olvPrice.FillsFreeSpace = true;
            this.olvPrice.Groupable = false;
            this.olvPrice.Text = "Price per unit";
            this.olvPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olvPrice.Width = 120;
            // 
            // olvBuy
            // 
            this.olvBuy.FillsFreeSpace = true;
            this.olvBuy.Groupable = false;
            this.olvBuy.IsButton = true;
            this.olvBuy.Text = "Buy";
            this.olvBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJobMarketName
            // 
            this.txtJobMarketName.BackColor = System.Drawing.SystemColors.Control;
            this.txtJobMarketName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJobMarketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobMarketName.Location = new System.Drawing.Point(6, 7);
            this.txtJobMarketName.Name = "txtJobMarketName";
            this.txtJobMarketName.ReadOnly = true;
            this.txtJobMarketName.Size = new System.Drawing.Size(100, 28);
            this.txtJobMarketName.TabIndex = 2;
            this.txtJobMarketName.Text = "---";
            // 
            // panJobMarket
            // 
            this.panJobMarket.Location = new System.Drawing.Point(12, 56);
            this.panJobMarket.Name = "panJobMarket";
            this.panJobMarket.Size = new System.Drawing.Size(974, 534);
            this.panJobMarket.TabIndex = 14;
            this.panJobMarket.Visible = false;
            // 
            // btnJobMarket
            // 
            this.btnJobMarket.Location = new System.Drawing.Point(297, 27);
            this.btnJobMarket.Name = "btnJobMarket";
            this.btnJobMarket.Size = new System.Drawing.Size(114, 23);
            this.btnJobMarket.TabIndex = 14;
            this.btnJobMarket.Text = "Job market";
            this.btnJobMarket.UseVisualStyleBackColor = true;
            this.btnJobMarket.Click += new System.EventHandler(this.btnJobMarket_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 602);
            this.Controls.Add(this.btnJobMarket);
            this.Controls.Add(this.btnResourceMarket);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.txtControlledPerson);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panResourceMarket);
            this.Controls.Add(this.panPersons);
            this.Controls.Add(this.panHome);
            this.Controls.Add(this.panJobMarket);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liff Sim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panPersons.ResumeLayout(false);
            this.panPersons.PerformLayout();
            this.panHome.ResumeLayout(false);
            this.panHome.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panResourceMarket.ResumeLayout(false);
            this.panResourceMarket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlvResources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panPersons;
        private System.Windows.Forms.ListBox lstPersons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tllInventory;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TableLayoutPanel tllSkills;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.Panel panHome;
        private System.Windows.Forms.TextBox txtControlledPerson;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSimulation;
        private System.Windows.Forms.ToolStripMenuItem tsmOptions;
        private System.Windows.Forms.Button btnResourceMarket;
        private System.Windows.Forms.Panel panResourceMarket;
        private System.Windows.Forms.Button btnJobMarket;
        private System.Windows.Forms.Panel panJobMarket;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductivity;
        private System.Windows.Forms.TextBox txtStrength;
        private BrightIdeasSoftware.DataListView dlvResources;
        private BrightIdeasSoftware.OLVColumn olvImgResource;
        private BrightIdeasSoftware.OLVColumn olvSeller;
        private BrightIdeasSoftware.OLVColumn olvQuantity;
        private BrightIdeasSoftware.OLVColumn olvPrice;
        private BrightIdeasSoftware.OLVColumn olvBuy;
        private System.Windows.Forms.TextBox txtJobMarketName;
    }
}

