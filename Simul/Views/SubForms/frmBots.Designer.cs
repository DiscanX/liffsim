namespace Simul.Views.SubForms
{
    partial class frmBots
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
            this.lstBots = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBots
            // 
            this.lstBots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBots.FormattingEnabled = true;
            this.lstBots.ItemHeight = 16;
            this.lstBots.Location = new System.Drawing.Point(6, 17);
            this.lstBots.Name = "lstBots";
            this.lstBots.Size = new System.Drawing.Size(189, 500);
            this.lstBots.TabIndex = 14;
            // 
            // frmBots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 534);
            this.Controls.Add(this.lstBots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBots";
            this.Text = "frmBots";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBots;
    }
}