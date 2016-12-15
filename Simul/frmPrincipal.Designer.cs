namespace Simul
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
            this.panPersonnes = new System.Windows.Forms.Panel();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResourceMarket = new System.Windows.Forms.Button();
            this.panResourceMarket = new System.Windows.Forms.Panel();
            this.panJobMarket = new System.Windows.Forms.Panel();
            this.btnJobMarket = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtProductivity = new System.Windows.Forms.TextBox();
            this.panPersonnes.SuspendLayout();
            this.panHome.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPersonnes
            // 
            this.panPersonnes.Controls.Add(this.tllSkills);
            this.panPersonnes.Controls.Add(this.label5);
            this.panPersonnes.Controls.Add(this.label4);
            this.panPersonnes.Controls.Add(this.tllInventory);
            this.panPersonnes.Controls.Add(this.txtMoney);
            this.panPersonnes.Controls.Add(this.txtName);
            this.panPersonnes.Controls.Add(this.label3);
            this.panPersonnes.Controls.Add(this.label2);
            this.panPersonnes.Controls.Add(this.label1);
            this.panPersonnes.Controls.Add(this.lstPersons);
            this.panPersonnes.Location = new System.Drawing.Point(15, 56);
            this.panPersonnes.Name = "panPersonnes";
            this.panPersonnes.Size = new System.Drawing.Size(971, 534);
            this.panPersonnes.TabIndex = 0;
            this.panPersonnes.Visible = false;
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
            this.panHome.Controls.Add(this.button2);
            this.panHome.Controls.Add(this.button1);
            this.panHome.Location = new System.Drawing.Point(12, 56);
            this.panHome.Name = "panHome";
            this.panHome.Size = new System.Drawing.Size(971, 534);
            this.panHome.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(802, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 9;
            // 
            // btnNextDay
            // 
            this.btnNextDay.Location = new System.Drawing.Point(908, 27);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(75, 23);
            this.btnNextDay.TabIndex = 10;
            this.btnNextDay.Text = "Next day >>";
            this.btnNextDay.UseVisualStyleBackColor = true;
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
            this.panResourceMarket.Location = new System.Drawing.Point(12, 56);
            this.panResourceMarket.Name = "panResourceMarket";
            this.panResourceMarket.Size = new System.Drawing.Size(974, 534);
            this.panResourceMarket.TabIndex = 13;
            this.panResourceMarket.Visible = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Work";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Train";
            this.button2.UseVisualStyleBackColor = true;
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
            // txtStrength
            // 
            this.txtStrength.BackColor = System.Drawing.SystemColors.Control;
            this.txtStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrength.Location = new System.Drawing.Point(165, 57);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(100, 19);
            this.txtStrength.TabIndex = 11;
            this.txtStrength.Text = "---";
            // 
            // txtProductivity
            // 
            this.txtProductivity.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductivity.Location = new System.Drawing.Point(165, 409);
            this.txtProductivity.Name = "txtProductivity";
            this.txtProductivity.Size = new System.Drawing.Size(100, 19);
            this.txtProductivity.TabIndex = 12;
            this.txtProductivity.Text = "---";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 602);
            this.Controls.Add(this.btnJobMarket);
            this.Controls.Add(this.btnResourceMarket);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panPersonnes);
            this.Controls.Add(this.panHome);
            this.Controls.Add(this.panJobMarket);
            this.Controls.Add(this.panResourceMarket);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panPersonnes.ResumeLayout(false);
            this.panPersonnes.PerformLayout();
            this.panHome.ResumeLayout(false);
            this.panHome.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panPersonnes;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSimulation;
        private System.Windows.Forms.ToolStripMenuItem tsmOptions;
        private System.Windows.Forms.Button btnResourceMarket;
        private System.Windows.Forms.Panel panResourceMarket;
        private System.Windows.Forms.Button btnJobMarket;
        private System.Windows.Forms.Panel panJobMarket;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductivity;
        private System.Windows.Forms.TextBox txtStrength;
    }
}

