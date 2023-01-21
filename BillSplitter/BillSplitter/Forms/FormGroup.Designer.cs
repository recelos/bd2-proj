namespace BillSplitter.UI.Forms
{
    partial class FormGroup
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
            this.billsGridView = new System.Windows.Forms.DataGridView();
            this.balanceGridView = new System.Windows.Forms.DataGridView();
            this.groupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // billsGridView
            // 
            this.billsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsGridView.Location = new System.Drawing.Point(68, 118);
            this.billsGridView.Name = "billsGridView";
            this.billsGridView.RowHeadersWidth = 51;
            this.billsGridView.RowTemplate.Height = 29;
            this.billsGridView.Size = new System.Drawing.Size(555, 407);
            this.billsGridView.TabIndex = 0;
            // 
            // balanceGridView
            // 
            this.balanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceGridView.Location = new System.Drawing.Point(836, 118);
            this.balanceGridView.Name = "balanceGridView";
            this.balanceGridView.RowHeadersWidth = 51;
            this.balanceGridView.RowTemplate.Height = 29;
            this.balanceGridView.Size = new System.Drawing.Size(237, 407);
            this.balanceGridView.TabIndex = 1;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(68, 54);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(90, 20);
            this.groupLabel.TabIndex = 2;
            this.groupLabel.Text = "group name";
            // 
            // FormGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 594);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.balanceGridView);
            this.Controls.Add(this.billsGridView);
            this.Name = "FormGroup";
            this.Text = "FormGroup";
            ((System.ComponentModel.ISupportInitialize)(this.billsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView billsGridView;
        private DataGridView balanceGridView;
        private Label groupLabel;
    }
}