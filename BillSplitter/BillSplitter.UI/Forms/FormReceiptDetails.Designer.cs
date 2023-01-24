namespace BillSplitter.UI.Forms
{
  partial class FormReceiptDetails
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
      this.usersDataGridView = new System.Windows.Forms.DataGridView();
      this.payerLabel = new System.Windows.Forms.Label();
      this.nameLabel = new System.Windows.Forms.Label();
      this.amountLabel = new System.Windows.Forms.Label();
      this.dateLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // usersDataGridView
      // 
      this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.usersDataGridView.Location = new System.Drawing.Point(23, 204);
      this.usersDataGridView.Name = "usersDataGridView";
      this.usersDataGridView.ReadOnly = true;
      this.usersDataGridView.RowHeadersWidth = 51;
      this.usersDataGridView.RowTemplate.Height = 29;
      this.usersDataGridView.Size = new System.Drawing.Size(748, 223);
      this.usersDataGridView.TabIndex = 0;
      // 
      // payerLabel
      // 
      this.payerLabel.AutoSize = true;
      this.payerLabel.Location = new System.Drawing.Point(23, 73);
      this.payerLabel.Name = "payerLabel";
      this.payerLabel.Size = new System.Drawing.Size(46, 20);
      this.payerLabel.TabIndex = 1;
      this.payerLabel.Text = "payer";
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(23, 26);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(46, 20);
      this.nameLabel.TabIndex = 2;
      this.nameLabel.Text = "name";
      // 
      // amountLabel
      // 
      this.amountLabel.AutoSize = true;
      this.amountLabel.Location = new System.Drawing.Point(23, 124);
      this.amountLabel.Name = "amountLabel";
      this.amountLabel.Size = new System.Drawing.Size(60, 20);
      this.amountLabel.TabIndex = 3;
      this.amountLabel.Text = "amount";
      // 
      // dateLabel
      // 
      this.dateLabel.AutoSize = true;
      this.dateLabel.Location = new System.Drawing.Point(23, 168);
      this.dateLabel.Name = "dateLabel";
      this.dateLabel.Size = new System.Drawing.Size(39, 20);
      this.dateLabel.TabIndex = 4;
      this.dateLabel.Text = "date";
      // 
      // FormReceiptDetails
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dateLabel);
      this.Controls.Add(this.amountLabel);
      this.Controls.Add(this.nameLabel);
      this.Controls.Add(this.payerLabel);
      this.Controls.Add(this.usersDataGridView);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "FormReceiptDetails";
      this.Text = "Bill Splitter";
      ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DataGridView usersDataGridView;
    private Label payerLabel;
    private Label nameLabel;
    private Label amountLabel;
    private Label dateLabel;
  }
}