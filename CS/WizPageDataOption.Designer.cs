namespace RepWizardCustomQuery
{
    partial class WizPageDataOption
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
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.headerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(15, 8);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Size = new System.Drawing.Size(308, 18);
            this.titleLabel.Text = "Choose Data Source";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.Location = new System.Drawing.Point(38, 21);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtitleLabel.Size = new System.Drawing.Size(284, 15);
            this.subtitleLabel.Text = "Select Query or Table/View";
            // 
            // headerPanel
            // 
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // headerPicture
            // 
            this.headerPicture.Location = new System.Drawing.Point(443, 4);
            this.headerPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerPicture.Size = new System.Drawing.Size(37, 40);
            // 
            // headerSeparator
            // 
            this.headerSeparator.Location = new System.Drawing.Point(0, 54);
            this.headerSeparator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerSeparator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerSeparator.Size = new System.Drawing.Size(490, 2);
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = "Query";
            this.radioGroup1.Location = new System.Drawing.Point(206, 127);
            this.radioGroup1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Query", "Query"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Table", "Table/View")});
            this.radioGroup1.Size = new System.Drawing.Size(84, 49);
            this.radioGroup1.TabIndex = 5;
            // 
            // WizPageDataOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioGroup1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WizPageDataOption";
            this.Size = new System.Drawing.Size(497, 303);
            this.Controls.SetChildIndex(this.radioGroup1, 0);
            this.Controls.SetChildIndex(this.headerPanel, 0);
            this.Controls.SetChildIndex(this.headerSeparator, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.Controls.SetChildIndex(this.subtitleLabel, 0);
            this.Controls.SetChildIndex(this.headerPicture, 0);
            ((System.ComponentModel.ISupportInitialize)(this.headerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}