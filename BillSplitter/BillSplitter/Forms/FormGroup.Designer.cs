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
      this.balanceGridView.Location = new System.Drawing.Point(759, 118);
      this.balanceGridView.Name = "balanceGridView";
      this.balanceGridView.RowHeadersWidth = 51;
      this.balanceGridView.RowTemplate.Height = 29;
      this.balanceGridView.Size = new System.Drawing.Size(314, 407);
      this.balanceGridView.TabIndex = 1;
      // 
      // groupLabel
      // 
      this.groupLabel.AutoSize = true;
      this.groupLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.groupLabel.Location = new System.Drawing.Point(540, 25);
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
      this.label2.Location = new System.Drawing.Point(759, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(153, 28);
      this.label2.TabIndex = 4;
      this.label2.Text = "Your balances: ";
      // 
      // FormGroup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1101, 594);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
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
    private Label label1;
    private Label label2;
  }
}