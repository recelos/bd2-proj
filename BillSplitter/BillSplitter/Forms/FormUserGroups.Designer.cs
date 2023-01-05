namespace BillSplitter.UI.Forms
{
    partial class FormUserGroups
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.groupsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(36, 46);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "user name";
            // 
            // groupsDataGrid
            // 
            this.groupsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsDataGrid.Location = new System.Drawing.Point(36, 102);
            this.groupsDataGrid.Name = "groupsDataGrid";
            this.groupsDataGrid.RowHeadersWidth = 51;
            this.groupsDataGrid.RowTemplate.Height = 29;
            this.groupsDataGrid.Size = new System.Drawing.Size(497, 312);
            this.groupsDataGrid.TabIndex = 1;
            // 
            // FormUserGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupsDataGrid);
            this.Controls.Add(this.usernameLabel);
            this.Name = "FormUserGroups";
            this.Text = "FormUserGroups";
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label usernameLabel;
        private DataGridView groupsDataGrid;
    }
}