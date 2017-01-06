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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.txtEnergy = new System.Windows.Forms.TextBox();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResourceMarket = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.btnJobMarket = new System.Windows.Forms.Button();
            this.txtCurrentDay = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // txtEnergy
            // 
            this.txtEnergy.BackColor = System.Drawing.SystemColors.Control;
            this.txtEnergy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnergy.Location = new System.Drawing.Point(440, 27);
            this.txtEnergy.Multiline = true;
            this.txtEnergy.Name = "txtEnergy";
            this.txtEnergy.ReadOnly = true;
            this.txtEnergy.Size = new System.Drawing.Size(175, 23);
            this.txtEnergy.TabIndex = 9;
            this.txtEnergy.Text = "---";
            this.txtEnergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // panMain
            // 
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Location = new System.Drawing.Point(12, 56);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(974, 534);
            this.panMain.TabIndex = 13;
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
            // txtCurrentDay
            // 
            this.txtCurrentDay.BackColor = System.Drawing.SystemColors.Control;
            this.txtCurrentDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentDay.Location = new System.Drawing.Point(802, 27);
            this.txtCurrentDay.Multiline = true;
            this.txtCurrentDay.Name = "txtCurrentDay";
            this.txtCurrentDay.ReadOnly = true;
            this.txtCurrentDay.Size = new System.Drawing.Size(100, 23);
            this.txtCurrentDay.TabIndex = 15;
            this.txtCurrentDay.Text = "---";
            this.txtCurrentDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.Control;
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(621, 27);
            this.txtMoney.Multiline = true;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(175, 23);
            this.txtMoney.TabIndex = 16;
            this.txtMoney.Text = "---";
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 602);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtCurrentDay);
            this.Controls.Add(this.btnJobMarket);
            this.Controls.Add(this.btnResourceMarket);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.txtEnergy);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liff Sim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.TextBox txtEnergy;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSimulation;
        private System.Windows.Forms.ToolStripMenuItem tsmOptions;
        private System.Windows.Forms.Button btnResourceMarket;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Button btnJobMarket;
        private System.Windows.Forms.TextBox txtCurrentDay;
        private System.Windows.Forms.TextBox txtMoney;
    }
}

