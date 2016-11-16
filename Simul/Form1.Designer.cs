namespace Simul
{
    partial class Form1
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
            this.panPersonnes.SuspendLayout();
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
            this.panPersonnes.Location = new System.Drawing.Point(12, 12);
            this.panPersonnes.Name = "panPersonnes";
            this.panPersonnes.Size = new System.Drawing.Size(971, 585);
            this.panPersonnes.TabIndex = 0;
            // 
            // tllCompetences
            // 
            this.tllCompetences.ColumnCount = 1;
            this.tllCompetences.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tllCompetences.Location = new System.Drawing.Point(222, 365);
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
            this.label5.Location = new System.Drawing.Point(218, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Compétences : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inventaire : ";
            // 
            // tllInventaire
            // 
            this.tllInventaire.ColumnCount = 1;
            this.tllInventaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tllInventaire.Location = new System.Drawing.Point(222, 167);
            this.tllInventaire.Name = "tllInventaire";
            this.tllInventaire.RowCount = 1;
            this.tllInventaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tllInventaire.Size = new System.Drawing.Size(739, 148);
            this.tllInventaire.TabIndex = 6;
            // 
            // txtMonnaie
            // 
            this.txtMonnaie.Location = new System.Drawing.Point(306, 97);
            this.txtMonnaie.Name = "txtMonnaie";
            this.txtMonnaie.Size = new System.Drawing.Size(100, 20);
            this.txtMonnaie.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(306, 58);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
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
            this.lstPersonnes.Size = new System.Drawing.Size(189, 580);
            this.lstPersonnes.TabIndex = 0;
            this.lstPersonnes.SelectedIndexChanged += new System.EventHandler(this.lstPersonnes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 609);
            this.Controls.Add(this.panPersonnes);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panPersonnes.ResumeLayout(false);
            this.panPersonnes.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

