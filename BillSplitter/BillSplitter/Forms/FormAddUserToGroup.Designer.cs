namespace BillSplitter.UI.Forms
{
  partial class FormAddUserToGroup
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
      this.usernameTextBox = new System.Windows.Forms.TextBox();
      this.addButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(28, 42);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(114, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Enter username:";
      // 
      // usernameTextBox
      // 
      this.usernameTextBox.Location = new System.Drawing.Point(148, 39);
      this.usernameTextBox.Name = "usernameTextBox";
      this.usernameTextBox.Size = new System.Drawing.Size(172, 27);
      this.usernameTextBox.TabIndex = 1;
      // 
      // addButton
      // 
      this.addButton.Location = new System.Drawing.Point(105, 96);
      this.addButton.Name = "addButton";
      this.addButton.Size = new System.Drawing.Size(150, 48);
      this.addButton.TabIndex = 2;
      this.addButton.Text = "Add";
      this.addButton.UseVisualStyleBackColor = true;
      this.addButton.Click += new System.EventHandler(this.addButton_Click);
      // 
      // FormAddUserToGroup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(368, 165);
      this.Controls.Add(this.addButton);
      this.Controls.Add(this.usernameTextBox);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "FormAddUserToGroup";
      this.Text = "Bill Splitter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox usernameTextBox;
    private Button addButton;
  }
}