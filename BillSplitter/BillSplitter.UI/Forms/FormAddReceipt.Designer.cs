namespace BillSplitter.UI.Forms
{
  partial class FormAddReceipt
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
      this.label1 = new System.Windows.Forms.Label();
      this.recipeNameTextBox = new System.Windows.Forms.TextBox();
      this.usersDataGridView = new System.Windows.Forms.DataGridView();
      this.acceptButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(73, 56);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Receipt name:";
      // 
      // recipeNameTextBox
      // 
      this.recipeNameTextBox.Location = new System.Drawing.Point(222, 53);
      this.recipeNameTextBox.Name = "recipeNameTextBox";
      this.recipeNameTextBox.Size = new System.Drawing.Size(206, 27);
      this.recipeNameTextBox.TabIndex = 1;
      // 
      // usersDataGridView
      // 
      this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.usersDataGridView.Location = new System.Drawing.Point(73, 125);
      this.usersDataGridView.Name = "usersDataGridView";
      this.usersDataGridView.RowHeadersWidth = 51;
      this.usersDataGridView.RowTemplate.Height = 29;
      this.usersDataGridView.Size = new System.Drawing.Size(355, 278);
      this.usersDataGridView.TabIndex = 2;
      // 
      // acceptButton
      // 
      this.acceptButton.Location = new System.Drawing.Point(183, 439);
      this.acceptButton.Name = "acceptButton";
      this.acceptButton.Size = new System.Drawing.Size(146, 39);
      this.acceptButton.TabIndex = 3;
      this.acceptButton.Text = "Accept";
      this.acceptButton.UseVisualStyleBackColor = true;
      this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
      // 
      // FormAddReceipt
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 490);
      this.Controls.Add(this.acceptButton);
      this.Controls.Add(this.usersDataGridView);
      this.Controls.Add(this.recipeNameTextBox);
      this.Controls.Add(this.label1);
      this.Name = "FormAddReceipt";
      this.Text = "Bill Splitter";
      ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox recipeNameTextBox;
    private DataGridView usersDataGridView;
    private Button acceptButton;
  }
}