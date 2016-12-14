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
            this.tllCompetences = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tllInventaire = new System.Windows.Forms.TableLayoutPanel();
            this.txtMonnaie = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPersonnes = new System.Windows.Forms.ListBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.panHome = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.panPersonnes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPersonnes
            // 
            this.panPersonnes.Controls.Add(this.tllCompetences);
            this.panPersonnes.Controls.Add(this.label5);
            this.panPersonnes.Controls.Add(this.label4);
            this.panPersonnes.Controls.Add(this.tllInventaire);
            this.panPersonnes.Controls.Add(this.txtMonnaie);
            this.panPersonnes.Controls.Add(this.txtNom);
            this.panPersonnes.Controls.Add(this.label3);
            this.panPersonnes.Controls.Add(this.label2);
            this.panPersonnes.Controls.Add(this.label1);
            this.panPersonnes.Controls.Add(this.lstPersonnes);
            this.panPersonnes.Location = new System.Drawing.Point(15, 56);
            this.panPersonnes.Name = "panPersonnes";
            this.panPersonnes.Size = new System.Drawing.Size(971, 534);
            this.panPersonnes.TabIndex = 0;
            // 
            // tllCompetences
            // 
            this.tllCompetences.ColumnCount = 1;
            this.tllCompetences.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tllCompetences.Location = new System.Drawing.Point(213, 365);
            this.tllCompetences.Name = "tllCompetences";
            this.tllCompetences.RowCount = 1;
            this.tllCompetences.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tllCompetences.Size = new System.Drawing.Size(733, 142);
            this.tllCompetences.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Compétences : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inventaire : ";
            // 
            // tllInventaire
            // 
            this.tllInventaire.ColumnCount = 1;
            this.tllInventaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tllInventaire.Location = new System.Drawing.Point(213, 167);
            this.tllInventaire.Name = "tllInventaire";
            this.tllInventaire.RowCount = 1;
            this.tllInventaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tllInventaire.Size = new System.Drawing.Size(739, 148);
            this.tllInventaire.TabIndex = 6;
            // 
            // txtMonnaie
            // 
            this.txtMonnaie.BackColor = System.Drawing.SystemColors.Control;
            this.txtMonnaie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonnaie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonnaie.Location = new System.Drawing.Point(306, 97);
            this.txtMonnaie.Name = "txtMonnaie";
            this.txtMonnaie.Size = new System.Drawing.Size(100, 19);
            this.txtMonnaie.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.Control;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(306, 56);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 19);
            this.txtNom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monnaie : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Détails de la personne";
            // 
            // lstPersonnes
            // 
            this.lstPersonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPersonnes.FormattingEnabled = true;
            this.lstPersonnes.ItemHeight = 16;
            this.lstPersonnes.Location = new System.Drawing.Point(3, 3);
            this.lstPersonnes.Name = "lstPersonnes";
            this.lstPersonnes.Size = new System.Drawing.Size(189, 500);
            this.lstPersonnes.TabIndex = 0;
            this.lstPersonnes.SelectedIndexChanged += new System.EventHandler(this.lstPersonnes_SelectedIndexChanged);
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
            this.tsmOptions.Size = new System.Drawing.Size(152, 22);
            this.tsmOptions.Text = "Options";
            this.tsmOptions.Click += new System.EventHandler(this.tsmOptions_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 602);
            this.Controls.Add(this.btnNextDay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panPersonnes);
            this.Controls.Add(this.panHome);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panPersonnes.ResumeLayout(false);
            this.panPersonnes.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panPersonnes;
        private System.Windows.Forms.ListBox lstPersonnes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tllInventaire;
        private System.Windows.Forms.TextBox txtMonnaie;
        private System.Windows.Forms.TableLayoutPanel tllCompetences;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.Panel panHome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNextDay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSimulation;
        private System.Windows.Forms.ToolStripMenuItem tsmOptions;
    }
}

