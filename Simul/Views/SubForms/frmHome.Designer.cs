﻿namespace Simul.Views.SubForms
{
    partial class frmHome
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
            this.txtProductivity = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProductivity
            // 
            this.txtProductivity.BackColor = System.Drawing.SystemColors.Control;
            this.txtProductivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductivity.Location = new System.Drawing.Point(145, 375);
            this.txtProductivity.Name = "txtProductivity";
            this.txtProductivity.ReadOnly = true;
            this.txtProductivity.Size = new System.Drawing.Size(100, 19);
            this.txtProductivity.TabIndex = 18;
            this.txtProductivity.Text = "---";
            // 
            // txtStrength
            // 
            this.txtStrength.BackColor = System.Drawing.SystemColors.Control;
            this.txtStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrength.Location = new System.Drawing.Point(145, 23);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.ReadOnly = true;
            this.txtStrength.Size = new System.Drawing.Size(100, 19);
            this.txtStrength.TabIndex = 17;
            this.txtStrength.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Productivity : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Strength : ";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(314, 133);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 14;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(314, 460);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(75, 23);
            this.btnWork.TabIndex = 13;
            this.btnWork.Text = "Work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 534);
            this.Controls.Add(this.txtProductivity);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnWork);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductivity;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnWork;
    }
}