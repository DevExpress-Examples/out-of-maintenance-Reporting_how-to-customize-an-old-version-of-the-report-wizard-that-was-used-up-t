namespace RepWizardCustomQuery
{
    partial class WizPageQuery
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
            this.Query_memoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.Test_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.headerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Query_memoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(15, 8);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Size = new System.Drawing.Size(308, 11);
            this.titleLabel.Text = "Query Setup";
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.Location = new System.Drawing.Point(31, 20);
            this.subtitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subtitleLabel.Size = new System.Drawing.Size(292, 21);
            this.subtitleLabel.Text = "Enter your database query";
            // 
            // headerPanel
            // 
            this.headerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.headerPanel.Size = new System.Drawing.Size(497, 47);
            // 
            // headerPicture
            // 
            this.headerPicture.Location = new System.Drawing.Point(456, 4);
            this.headerPicture.Margin = new System.Windows.Forms.Padding(2);
            this.headerPicture.Size = new System.Drawing.Size(37, 40);
            // 
            // headerSeparator
            // 
            this.headerSeparator.Location = new System.Drawing.Point(0, 47);
            this.headerSeparator.Margin = new System.Windows.Forms.Padding(2);
            this.headerSeparator.Padding = new System.Windows.Forms.Padding(2);
            this.headerSeparator.Size = new System.Drawing.Size(492, 2);
            // 
            // Query_memoEdit
            // 
            this.Query_memoEdit.EditValue = "SELECT ProductName, UnitPrice FROM Products";
            this.Query_memoEdit.Location = new System.Drawing.Point(12, 54);
            this.Query_memoEdit.Margin = new System.Windows.Forms.Padding(2);
            this.Query_memoEdit.Name = "Query_memoEdit";
            this.Query_memoEdit.Size = new System.Drawing.Size(471, 50);
            this.Query_memoEdit.TabIndex = 5;
            // 
            // Test_simpleButton
            // 
            this.Test_simpleButton.Location = new System.Drawing.Point(12, 108);
            this.Test_simpleButton.Margin = new System.Windows.Forms.Padding(2);
            this.Test_simpleButton.Name = "Test_simpleButton";
            this.Test_simpleButton.Size = new System.Drawing.Size(75, 25);
            this.Test_simpleButton.TabIndex = 6;
            this.Test_simpleButton.Text = "&Apply";
            this.Test_simpleButton.Click += new System.EventHandler(this.Test_simpleButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 162);
            this.dataGridView1.TabIndex = 7;
            // 
            // WizPageQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Query_memoEdit);
            this.Controls.Add(this.Test_simpleButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WizPageQuery";
            this.Size = new System.Drawing.Size(497, 303);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.Test_simpleButton, 0);
            this.Controls.SetChildIndex(this.Query_memoEdit, 0);
            this.Controls.SetChildIndex(this.headerPanel, 0);
            this.Controls.SetChildIndex(this.headerSeparator, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.Controls.SetChildIndex(this.subtitleLabel, 0);
            this.Controls.SetChildIndex(this.headerPicture, 0);
            ((System.ComponentModel.ISupportInitialize)(this.headerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Query_memoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit Query_memoEdit;
        private DevExpress.XtraEditors.SimpleButton Test_simpleButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}