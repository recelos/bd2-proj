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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.addReceiptButton = new System.Windows.Forms.Button();
      this.userLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.billsGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.balanceGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // billsGridView
      // 
      this.billsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.billsGridView.Location = new System.Drawing.Point(68, 118);
      this.billsGridView.MultiSelect = false;
      this.billsGridView.Name = "billsGridView";
      this.billsGridView.ReadOnly = true;
      this.billsGridView.RowHeadersWidth = 51;
      this.billsGridView.RowTemplate.Height = 29;
      this.billsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.billsGridView.Size = new System.Drawing.Size(555, 407);
      this.billsGridView.TabIndex = 0;
      this.billsGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billsGridView_CellContentDoubleClick);
      // 
      // balanceGridView
      // 
      this.balanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.balanceGridView.Location = new System.Drawing.Point(875, 118);
      this.balanceGridView.Name = "balanceGridView";
      this.balanceGridView.ReadOnly = true;
      this.balanceGridView.RowHeadersWidth = 51;
      this.balanceGridView.RowTemplate.Height = 29;
      this.balanceGridView.Size = new System.Drawing.Size(314, 407);
      this.balanceGridView.TabIndex = 1;
      // 
      // groupLabel
      // 
      this.groupLabel.AutoSize = true;
      this.groupLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.groupLabel.Location = new System.Drawing.Point(68, 19);
      this.groupLabel.Name = "groupLabel";
      this.groupLabel.Size = new System.Drawing.Size(126, 28);
      this.groupLabel.TabIndex = 2;
      this.groupLabel.Text = "group name";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(68, 84);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 28);
      this.label1.TabIndex = 3;
      this.label1.Text = "Receipts: ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(875, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(153, 28);
      this.label2.TabIndex = 4;
      this.label2.Text = "Your balances: ";
      // 
      // addReceiptButton
      // 
      this.addReceiptButton.Location = new System.Drawing.Point(679, 147);
      this.addReceiptButton.Name = "addReceiptButton";
      this.addReceiptButton.Size = new System.Drawing.Size(144, 33);
      this.addReceiptButton.TabIndex = 5;
      this.addReceiptButton.Text = "Add receipt";
      this.addReceiptButton.UseVisualStyleBackColor = true;
      this.addReceiptButton.Click += new System.EventHandler(this.addReceiptButton_Click);
      // 
      // userLabel
      // 
      this.userLabel.AutoSize = true;
      this.userLabel.Location = new System.Drawing.Point(68, 64);
      this.userLabel.Name = "userLabel";
      this.userLabel.Size = new System.Drawing.Size(77, 20);
      this.userLabel.TabIndex = 6;
      this.userLabel.Text = "user name";
      // 
      // FormGroup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1228, 560);
      this.Controls.Add(this.userLabel);
      this.Controls.Add(this.addReceiptButton);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.groupLabel);
      this.Controls.Add(this.balanceGridView);
      this.Controls.Add(this.billsGridView);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "FormGroup";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Bill Splitter";
      ((System.ComponentModel.ISupportInitialize)(this.billsGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.balanceGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DataGridView billsGridView;
    private DataGridView balanceGridView;
    private Label groupLabel;
    private Label label1;
    private Label label2;
    private Button addReceiptButton;
    private Label userLabel;
  }
}